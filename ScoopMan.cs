using BrightIdeasSoftware;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllYourFault
{
    public partial class ScoopMan : Form
    {
        public ScoopMan()
        {
            InitializeComponent();
        }

        public static List<Bucket> buckets;

        private void ScoopMan_Load(object sender, EventArgs e)
        {
            buckets = new List<Bucket>();
            string[] files = Directory.GetDirectories(AllYourFault.userprof + "\\scoop\\buckets\\");
            for (int i = 0; i < files.Length; i++)
            {
                Bucket bu = new Bucket(Path.GetFileName(files[i]));
                buckets.Add(bu);
            }
            
            ActionCol.AspectGetter = delegate
            {
                return "Delete";
            };
            objectListView1.UseCellFormatEvents = true;
            this.objectListView1.OwnerDraw = true;
            objectListView1.SetObjects(buckets);
        }

        private void objectListView1_ButtonClick(object sender, CellClickEventArgs e)
        {
            e.Item.Remove();
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.Arguments = "/c scoop bucket rm " + e.Item.Text;
            cmd.Start();
            cmd.WaitForExit();
            buckets = new List<Bucket>();
            string[] files = Directory.GetDirectories(AllYourFault.userprof + "\\scoop\\buckets\\");
            for (int i = 0; i < files.Length; i++)
            {
                Bucket bu = new Bucket(Path.GetFileName(files[i]));
                buckets.Add(bu);
            }
            AllYourFault.RerunObj();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            WaitForm w = new WaitForm();
            w.Show();
            if (cueTextBox2.Text != null || cueTextBox2.Text != "")
            {
                cmd.StandardInput.WriteLine("scoop bucket add " + cueTextBox1.Text + " " + cueTextBox2.Text);
            }
            cmd.StandardInput.WriteLine("scoop bucket add " + cueTextBox1.Text);
            cmd.StandardInput.Close();
            await ProcessExtensions.WaitForExitAsync(cmd);
            w.Hide();
            buckets = new List<Bucket>();
            string[] files = Directory.GetDirectories(AllYourFault.userprof + "\\scoop\\buckets\\");
            for (int i = 0; i < files.Length; i++)
            {
                Bucket bu = new Bucket(Path.GetFileName(files[i]));
                buckets.Add(bu);
            }
            objectListView1.SetObjects(buckets);
            AllYourFault.RerunObj();
        }
    }

    public class Bucket
    {
        public string bucketName;
        public Bucket(string name)
        {
            bucketName = name;
        }
    }
}
