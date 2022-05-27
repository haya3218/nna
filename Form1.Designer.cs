
namespace AllYourFault
{
    partial class AllYourFault
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllYourFault));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cueTextBox1 = new CueTextBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.AppCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.describedTaskRenderer1 = new BrightIdeasSoftware.DescribedTaskRenderer();
            this.LicenseCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ActionCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBucketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cueTextBox1);
            this.tabPage1.Controls.Add(this.objectListView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scoop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cueTextBox1
            // 
            this.cueTextBox1.Cue = "Type here to search!";
            this.cueTextBox1.Location = new System.Drawing.Point(6, 391);
            this.cueTextBox1.Name = "cueTextBox1";
            this.cueTextBox1.Size = new System.Drawing.Size(268, 20);
            this.cueTextBox1.TabIndex = 1;
            this.cueTextBox1.TextChanged += new System.EventHandler(this.cueTextBox1_TextChanged);
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.AppCol);
            this.objectListView1.AllColumns.Add(this.LicenseCol);
            this.objectListView1.AllColumns.Add(this.ActionCol);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AppCol,
            this.LicenseCol,
            this.ActionCol});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.EmptyListMsg = "Empty list :(";
            this.objectListView1.EmptyListMsgFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(4, 6);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(772, 381);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.TileSize = new System.Drawing.Size(1, 1);
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseFiltering = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.objectListView1_ButtonClick);
            // 
            // AppCol
            // 
            this.AppCol.AspectName = "AppName";
            this.AppCol.FillsFreeSpace = true;
            this.AppCol.Renderer = this.describedTaskRenderer1;
            this.AppCol.Text = "Application";
            // 
            // describedTaskRenderer1
            // 
            this.describedTaskRenderer1.DescriptionAspectName = "Description";
            this.describedTaskRenderer1.TitleDescriptionSpace = 4;
            this.describedTaskRenderer1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LicenseCol
            // 
            this.LicenseCol.AspectName = "License";
            this.LicenseCol.MaximumWidth = 120;
            this.LicenseCol.MinimumWidth = 120;
            this.LicenseCol.Searchable = false;
            this.LicenseCol.Text = "License";
            this.LicenseCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LicenseCol.Width = 120;
            // 
            // ActionCol
            // 
            this.ActionCol.AspectName = "status";
            this.ActionCol.ButtonSize = new System.Drawing.Size(75, 30);
            this.ActionCol.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.FixedBounds;
            this.ActionCol.IsButton = true;
            this.ActionCol.IsEditable = false;
            this.ActionCol.Searchable = false;
            this.ActionCol.Text = "Action";
            this.ActionCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ActionCol.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tweaker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeModeToolStripMenuItem,
            this.manageBucketsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // removeModeToolStripMenuItem
            // 
            this.removeModeToolStripMenuItem.CheckOnClick = true;
            this.removeModeToolStripMenuItem.Name = "removeModeToolStripMenuItem";
            this.removeModeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeModeToolStripMenuItem.Text = "Remove Mode";
            // 
            // manageBucketsToolStripMenuItem
            // 
            this.manageBucketsToolStripMenuItem.Name = "manageBucketsToolStripMenuItem";
            this.manageBucketsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.manageBucketsToolStripMenuItem.Text = "Manage buckets";
            this.manageBucketsToolStripMenuItem.Click += new System.EventHandler(this.manageBucketsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // AllYourFault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllYourFault";
            this.Text = "AllYourFault";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn AppCol;
        private BrightIdeasSoftware.OLVColumn LicenseCol;
        private BrightIdeasSoftware.OLVColumn ActionCol;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private CueTextBox cueTextBox1;
        private BrightIdeasSoftware.DescribedTaskRenderer describedTaskRenderer1;
        private System.Windows.Forms.ToolStripMenuItem removeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBucketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}