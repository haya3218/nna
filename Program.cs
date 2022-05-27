using AllYourFault;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace VistaSelection
{
    static class Program
    {
        public static AllYourFault.AllYourFault mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Directory.Exists(Environment.GetEnvironmentVariable("HOMEDRIVE") + Environment.GetEnvironmentVariable("HOMEPATH") + "\\scoop"))
            {
                Console.WriteLine("Scoop is not installed.");
                System.Diagnostics.Process.Start("powershell.exe", " -NoExit -Command Set-ExecutionPolicy RemoteSigned -Scope CurrentUser");
                System.Diagnostics.Process.Start("powershell.exe", "-Command irm get.scoop.sh | iex");
                System.Diagnostics.Process.Start("powershell.exe", "-Command scoop bucket add main");
                Console.WriteLine("Scoop is now installed.");
            } else
            {
                Console.WriteLine("Scoop is installed.");
            }
            ScoopMan.buckets = new List<Bucket>();
            string[] files = Directory.GetDirectories(Environment.GetEnvironmentVariable("HOMEDRIVE") + Environment.GetEnvironmentVariable("HOMEPATH") + "\\scoop\\buckets\\");
            for (int i = 0; i < files.Length; i++)
            {
                Bucket bu = new Bucket(Path.GetFileName(files[i]));
                ScoopMan.buckets.Add(bu);
            }
            mainForm = new AllYourFault.AllYourFault();
            Application.Run(mainForm);
            
        }
    }
}