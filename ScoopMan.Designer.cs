
namespace AllYourFault
{
    partial class ScoopMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoopMan));
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.BucketCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ActionCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cueTextBox2 = new CueTextBox();
            this.cueTextBox1 = new CueTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.BucketCol);
            this.objectListView1.AllColumns.Add(this.ActionCol);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BucketCol,
            this.ActionCol});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(12, 140);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.RowHeight = 25;
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(458, 208);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.objectListView1_ButtonClick);
            // 
            // BucketCol
            // 
            this.BucketCol.AspectName = "bucketName";
            this.BucketCol.FillsFreeSpace = true;
            this.BucketCol.Text = "Bucket";
            // 
            // ActionCol
            // 
            this.ActionCol.AspectName = "DUMMY";
            this.ActionCol.ButtonSize = new System.Drawing.Size(50, 20);
            this.ActionCol.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.FixedBounds;
            this.ActionCol.IsButton = true;
            this.ActionCol.Text = "Action";
            this.ActionCol.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cueTextBox2
            // 
            this.cueTextBox2.Cue = "Gitlink";
            this.cueTextBox2.Location = new System.Drawing.Point(257, 53);
            this.cueTextBox2.Name = "cueTextBox2";
            this.cueTextBox2.Size = new System.Drawing.Size(183, 20);
            this.cueTextBox2.TabIndex = 3;
            // 
            // cueTextBox1
            // 
            this.cueTextBox1.Cue = "Name of bucket";
            this.cueTextBox1.Location = new System.Drawing.Point(257, 27);
            this.cueTextBox1.Name = "cueTextBox1";
            this.cueTextBox1.Size = new System.Drawing.Size(183, 20);
            this.cueTextBox1.TabIndex = 2;
            // 
            // ScoopMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cueTextBox2);
            this.Controls.Add(this.cueTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectListView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScoopMan";
            this.Text = "Manage buckets";
            this.Load += new System.EventHandler(this.ScoopMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn BucketCol;
        private BrightIdeasSoftware.OLVColumn ActionCol;
        private System.Windows.Forms.Label label1;
        private CueTextBox cueTextBox1;
        private CueTextBox cueTextBox2;
        private System.Windows.Forms.Button button1;
    }
}