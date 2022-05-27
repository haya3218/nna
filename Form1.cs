using BrightIdeasSoftware;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllYourFault
{
    public partial class AllYourFault : Form
    {
        public AllYourFault()
        {
            InitializeComponent();
        }

        public static string userprof = Environment.GetEnvironmentVariable("HOMEDRIVE") + Environment.GetEnvironmentVariable("HOMEPATH");

        List<Manifest> manifests;

        public void Form1_Load(object sender, EventArgs e)
        {
            manifests = new List<Manifest>();
            for (int b = 0; b < ScoopMan.buckets.Count; b++)
            {
                Console.WriteLine("Reading "+ ScoopMan.buckets[b].bucketName + " bucket...");
                string[] files = Directory.GetFiles(userprof + "\\scoop\\buckets\\"+ ScoopMan.buckets[b].bucketName+ "\\bucket\\");
                for (int i = 0; i < files.Length; i++)
                {
                    //Console.WriteLine(files[i]);
                    ScoopManifest m = JsonConvert.DeserializeObject<ScoopManifest>(File.ReadAllText(files[i]));
                    string namef = Path.GetFileNameWithoutExtension(files[i]);
                    Manifest rm = m.ReturnValidManifest(namef, "main");

                    manifests.Add(rm);

                }
            }
            
            this.objectListView1.RowHeight = 58;
            this.objectListView1.UseCellFormatEvents = true;
            this.objectListView1.SetObjects(manifests);
            this.objectListView1.OwnerDraw = true;
        }

        public static void RerunObj()
        {
            VistaSelection.Program.mainForm.Form1_Load(null, null);
        }

        private void cueTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(cueTextBox1.Text);
            if (objectListView1.GetItemCount() > 5000)
            {
                Console.WriteLine("Too many items! Abort!");
                cueTextBox1.Text = "Too many items. Can't search.";
                cueTextBox1.Cue = "Too many items. Can't search.";
                cueTextBox1.Enabled = false;
                return;
            }
            objectListView1.ModelFilter = TextMatchFilter.Contains(objectListView1, cueTextBox1.Text);
            objectListView1.DefaultRenderer = null;
        }

        private void manageBucketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoopMan man = new ScoopMan();
            man.Show();
        }

        private async void objectListView1_ButtonClick(object sender, CellClickEventArgs e)
        {
            Process cmd = new Process();
            WaitForm w = new WaitForm();
            w.Show();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;
            if (Directory.Exists(userprof + "\\scoop\\apps\\" + e.Item.Text))
                cmd.StartInfo.Arguments = "/c scoop update " + e.Item.Text;
            else
                cmd.StartInfo.Arguments = "/c scoop install " + e.Item.Text;
            cmd.Start();

            await ProcessExtensions.WaitForExitAsync(cmd);
            w.Hide();
            RerunObj();
        }
    }
}
