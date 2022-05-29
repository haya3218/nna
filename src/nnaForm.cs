using BrightIdeasSoftware;
using nna_net3.src.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nna_net3
{
    public partial class nnaForm : Form
    {
        public nnaForm()
        {
            InitializeComponent();
        }

        private void FormLoad(object s, EventArgs e)
        {
            List<Manifest> manifests = StaticUtils.ListManifests();
            List<ColumnNameSize> cols = new List<ColumnNameSize>();
            DescribedTaskRenderer rend = new DescribedTaskRenderer
            {
                TitleFont = new Font(new FontFamily("Microsoft Sans Serif"), 12.0f, FontStyle.Bold),
                DescriptionAspectName = "ManifestDesc"
            };
            cols.Add(new ColumnNameSize(120, "Application", "ManifestName", true, true, true, HorizontalAlignment.Left, rend));
            cols.Add(new ColumnNameSize(120, "License", "ManifestLicense", false, HorizontalAlignment.Center));
            cols.Add(new ColumnNameSize(120, "Action", "Status1", false, true, new Point(80, 30), false, true, HorizontalAlignment.Center));
            StaticUtils.GenerateListView(olvMain, cols);
            olvMain.SetObjects(manifests);
            olvMain.RowHeight = 68;
        }

        private void ViewButtons(object sender, CellClickEventArgs e)
        {
            if (Directory.Exists(StaticUtils.AppDir + "\\" + e.Item.Text))
                StaticUtils.AsyncRun("scoop update " + e.Item.Text);
            else
                StaticUtils.AsyncRun("scoop install " + e.Item.Text);
            List<Manifest> manifests = StaticUtils.ListManifests(false);
            olvMain.SetObjects(manifests);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            olvMain.ModelFilter = TextMatchFilter.Contains(olvMain, SearchBox.Text);
        }
    }
}
