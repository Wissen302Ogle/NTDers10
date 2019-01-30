namespace FileExplorer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbSuruculer = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopyalaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSuruculer
            // 
            this.cmbSuruculer.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbSuruculer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuruculer.FormattingEnabled = true;
            this.cmbSuruculer.Location = new System.Drawing.Point(0, 0);
            this.cmbSuruculer.Name = "cmbSuruculer";
            this.cmbSuruculer.Size = new System.Drawing.Size(176, 21);
            this.cmbSuruculer.TabIndex = 1;
            this.cmbSuruculer.SelectedIndexChanged += new System.EventHandler(this.cmbSuruculer_SelectedIndexChanged);
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.ımageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 27);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Size = new System.Drawing.Size(173, 353);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(306, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(490, 308);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Location = new System.Drawing.Point(179, 341);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltre.TabIndex = 3;
            // 
            // btnFiltre
            // 
            this.btnFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltre.Location = new System.Drawing.Point(325, 341);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(75, 23);
            this.btnFiltre.TabIndex = 4;
            this.btnFiltre.Text = "Filtrele";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kapali.jpg");
            this.ımageList1.Images.SetKeyName(1, "acik.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dosya Adı";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Boyut";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oluşturulma Tarihi";
            this.columnHeader3.Width = 183;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopyalaStripMenuItem,
            this.yapistirStripMenuItem,
            this.kesStripMenuItem,
            this.silStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 92);
            // 
            // kopyalaStripMenuItem
            // 
            this.kopyalaStripMenuItem.Name = "kopyalaStripMenuItem";
            this.kopyalaStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kopyalaStripMenuItem.Text = "Kopyala";
            // 
            // yapistirStripMenuItem
            // 
            this.yapistirStripMenuItem.Name = "yapistirStripMenuItem";
            this.yapistirStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapistirStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yapistirStripMenuItem.Text = "Yapistir";
            // 
            // kesStripMenuItem
            // 
            this.kesStripMenuItem.Name = "kesStripMenuItem";
            this.kesStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kesStripMenuItem.Text = "Kes";
            // 
            // silStripMenuItem
            // 
            this.silStripMenuItem.Name = "silStripMenuItem";
            this.silStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.silStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.silStripMenuItem.Text = "Sil";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(176, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(517, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 405);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbSuruculer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSuruculer;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

