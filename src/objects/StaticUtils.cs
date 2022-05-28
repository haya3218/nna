using BrightIdeasSoftware;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nna_net3.src.objects
{
    static class StaticUtils
    {
        public static string UserDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string ScoopDir = UserDir + "\\scoop";
        public static string AppDir = ScoopDir + "\\apps";
        public static string BucketDir = ScoopDir + "\\buckets";

        public static bool ReturnApp(string Name)
        {
            return Directory.Exists(ScoopDir + "\\apps\\" + Name);
        }

        public static List<Manifest> ListManifests(bool verbose = true)
        {
            string[] buckets = Directory.GetDirectories(BucketDir);
            List<Manifest> fManifests = new List<Manifest>();
            foreach (string bucket in buckets)
            {
                string[] manifests = Directory.GetFiles(BucketDir + "\\" + Path.GetFileNameWithoutExtension(bucket) + "\\bucket");
                foreach (string manifest in manifests)
                {
                    Manifest m = JsonConvert.DeserializeObject<Manifest>(File.ReadAllText(manifest));
                    m = new Manifest(Path.GetFileNameWithoutExtension(manifest), m.ManifestDesc, m.ManifestLicense);
                    if (verbose)
                        Console.WriteLine("Creating manifest with name " + Path.GetFileNameWithoutExtension(manifest));
                    fManifests.Add(m);
                }
            }
            
            return fManifests;
        }

        public static void GenerateListView(ObjectListView varListView, List<ColumnNameSize> nameSizeList)
        {
            List<OLVColumn> columnsList = new List<OLVColumn>();
            foreach (ColumnNameSize nameSize in nameSizeList)
            {
                OLVColumn columnHeader = new BrightIdeasSoftware.OLVColumn
                {
                    Width = nameSize.ColumnSize,
                    Text = nameSize.ColumnName,
                    AspectName = nameSize.Aspect,
                    FillsFreeSpace = nameSize.TakesUp,
                    IsButton = nameSize.ButtonCol,
                    ButtonSizing = OLVColumn.ButtonSizingMode.FixedBounds,
                    TextAlign = nameSize.Alignment,
                    ButtonSize = new System.Drawing.Size(nameSize.ButtonX, nameSize.ButtonY),
                    IsEditable = nameSize.Editable,
                    Searchable = nameSize.Searchable,
                    HeaderTextAlign = nameSize.Alignment,
                    UseInitialLetterForGroup = true
                };
                if (nameSize.Renderer != null)
                    columnHeader.Renderer = nameSize.Renderer;
                columnsList.Add(columnHeader);
                varListView.AllColumns.Add(columnHeader);
            }

            varListView.Columns.AddRange(columnsList.Cast<System.Windows.Forms.ColumnHeader>().ToArray());
            varListView.RebuildColumns();
        }

        /// <summary>
        /// Waits asynchronously for the process to exit.
        /// </summary>
        /// <param name="process">The process to wait for cancellation.</param>
        /// <param name="cancellationToken">A cancellation token. If invoked, the task will return 
        /// immediately as canceled.</param>
        /// <returns>A Task representing waiting for the process to end.</returns>
        public static Task WaitForExitAsync(this Process process,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            if (process.HasExited) return Task.CompletedTask;

            var tcs = new TaskCompletionSource<object>();
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(null);
            if (cancellationToken != default(CancellationToken))
                cancellationToken.Register(() => tcs.SetCanceled());

            return process.HasExited ? Task.CompletedTask : tcs.Task;
        }

        public async static void AsyncRun(string command, string shell = "cmd", string dir = "C:\\")
        {
            switch (shell)
            {
                case "cmd":
                    command = "/C " + command;
                    break;
                case "powershell":
                    command = "-Command " + command;
                    break;
                case "pwsh":
                    command = "-Command " + command;
                    break;
            }

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = shell,
                    Arguments = command
                }
            };

            proc.Start();
            await WaitForExitAsync(proc);
        }
    }
}
