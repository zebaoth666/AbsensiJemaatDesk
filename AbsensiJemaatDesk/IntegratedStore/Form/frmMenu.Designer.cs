namespace AbsensiJemaatDesk
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tutupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupPTTokoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gantiPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kebaktianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absenJemaatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absenKebaktianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikKehadiranJemaatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsServer,
            this.tsDB,
            this.tsUser,
            this.tsDate,
            this.toolStripStatusLabel5,
            this.tsProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1022, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 19);
            // 
            // tsServer
            // 
            this.tsServer.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsServer.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsServer.Name = "tsServer";
            this.tsServer.Size = new System.Drawing.Size(68, 19);
            this.tsServer.Text = "Server : - ";
            // 
            // tsDB
            // 
            this.tsDB.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsDB.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsDB.Name = "tsDB";
            this.tsDB.Size = new System.Drawing.Size(83, 19);
            this.tsDB.Text = "Database : -";
            // 
            // tsUser
            // 
            this.tsUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(55, 19);
            this.tsUser.Text = "User : -";
            // 
            // tsDate
            // 
            this.tsDate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsDate.Name = "tsDate";
            this.tsDate.Size = new System.Drawing.Size(4, 19);
            this.tsDate.ToolTipText = "123456";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(522, 19);
            this.toolStripStatusLabel5.Spring = true;
            this.toolStripStatusLabel5.Text = "                                                                                 " +
    "               ";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(267, 18);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutupToolStripMenuItem,
            this.dataMasterToolStripMenuItem,
            this.kebaktianToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(147, 489);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tutupToolStripMenuItem
            // 
            this.tutupToolStripMenuItem.AutoSize = false;
            this.tutupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupPTTokoToolStripMenuItem,
            this.userToolStripMenuItem,
            this.gantiPasswordToolStripMenuItem,
            this.tutupToolStripMenuItem1});
            this.tutupToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tutupToolStripMenuItem.Image")));
            this.tutupToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tutupToolStripMenuItem.Name = "tutupToolStripMenuItem";
            this.tutupToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.tutupToolStripMenuItem.Text = "&File";
            this.tutupToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // setupPTTokoToolStripMenuItem
            // 
            this.setupPTTokoToolStripMenuItem.AutoSize = false;
            this.setupPTTokoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setupPTTokoToolStripMenuItem.Image")));
            this.setupPTTokoToolStripMenuItem.Name = "setupPTTokoToolStripMenuItem";
            this.setupPTTokoToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.setupPTTokoToolStripMenuItem.Text = "&Setup PT / Toko";
            this.setupPTTokoToolStripMenuItem.Visible = false;
            this.setupPTTokoToolStripMenuItem.Click += new System.EventHandler(this.setupPTTokoToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.AutoSize = false;
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.userToolStripMenuItem.Text = "&User";
            this.userToolStripMenuItem.Visible = false;
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // gantiPasswordToolStripMenuItem
            // 
            this.gantiPasswordToolStripMenuItem.AutoSize = false;
            this.gantiPasswordToolStripMenuItem.Name = "gantiPasswordToolStripMenuItem";
            this.gantiPasswordToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.gantiPasswordToolStripMenuItem.Text = "U&bah Kata Kunci";
            this.gantiPasswordToolStripMenuItem.Click += new System.EventHandler(this.gantiPasswordToolStripMenuItem_Click);
            // 
            // tutupToolStripMenuItem1
            // 
            this.tutupToolStripMenuItem1.AutoSize = false;
            this.tutupToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("tutupToolStripMenuItem1.Image")));
            this.tutupToolStripMenuItem1.Name = "tutupToolStripMenuItem1";
            this.tutupToolStripMenuItem1.Size = new System.Drawing.Size(198, 30);
            this.tutupToolStripMenuItem1.Text = "&Tutup";
            this.tutupToolStripMenuItem1.Click += new System.EventHandler(this.tutupToolStripMenuItem1_Click);
            // 
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.AutoSize = false;
            this.dataMasterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dataMasterToolStripMenuItem.Image")));
            this.dataMasterToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.dataMasterToolStripMenuItem.Text = "&Umat";
            this.dataMasterToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataMasterToolStripMenuItem.Click += new System.EventHandler(this.dataMasterToolStripMenuItem_Click);
            // 
            // kebaktianToolStripMenuItem
            // 
            this.kebaktianToolStripMenuItem.AutoSize = false;
            this.kebaktianToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kebaktianToolStripMenuItem.Image")));
            this.kebaktianToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kebaktianToolStripMenuItem.Name = "kebaktianToolStripMenuItem";
            this.kebaktianToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.kebaktianToolStripMenuItem.Text = "&Kebaktian";
            this.kebaktianToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kebaktianToolStripMenuItem.Click += new System.EventHandler(this.kebaktianToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.AutoSize = false;
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absenJemaatToolStripMenuItem,
            this.absenKebaktianToolStripMenuItem,
            this.grafikKehadiranJemaatToolStripMenuItem});
            this.laporanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("laporanToolStripMenuItem.Image")));
            this.laporanToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.laporanToolStripMenuItem.Text = "&Laporan";
            // 
            // absenJemaatToolStripMenuItem
            // 
            this.absenJemaatToolStripMenuItem.AutoSize = false;
            this.absenJemaatToolStripMenuItem.Name = "absenJemaatToolStripMenuItem";
            this.absenJemaatToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.absenJemaatToolStripMenuItem.Text = "&Ulang Tahun Jemaat";
            this.absenJemaatToolStripMenuItem.Click += new System.EventHandler(this.absenJemaatToolStripMenuItem_Click);
            // 
            // absenKebaktianToolStripMenuItem
            // 
            this.absenKebaktianToolStripMenuItem.AutoSize = false;
            this.absenKebaktianToolStripMenuItem.Name = "absenKebaktianToolStripMenuItem";
            this.absenKebaktianToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.absenKebaktianToolStripMenuItem.Text = "&Absen Kebaktian";
            this.absenKebaktianToolStripMenuItem.Click += new System.EventHandler(this.absenKebaktianToolStripMenuItem_Click);
            // 
            // grafikKehadiranJemaatToolStripMenuItem
            // 
            this.grafikKehadiranJemaatToolStripMenuItem.AutoSize = false;
            this.grafikKehadiranJemaatToolStripMenuItem.Name = "grafikKehadiranJemaatToolStripMenuItem";
            this.grafikKehadiranJemaatToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.grafikKehadiranJemaatToolStripMenuItem.Text = "&Grafik Umat";
            this.grafikKehadiranJemaatToolStripMenuItem.Click += new System.EventHandler(this.grafikKehadiranJemaatToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelStatus
            // 
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.statusStrip1);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 491);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(4);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1024, 26);
            this.panelStatus.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(149, 491);
            this.panelMenu.TabIndex = 5;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1024, 517);
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelStatus);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tutupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsServer;
        private System.Windows.Forms.ToolStripStatusLabel tsDB;
        private System.Windows.Forms.ToolStripStatusLabel tsUser;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem setupPTTokoToolStripMenuItem;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.ToolStripMenuItem kebaktianToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absenJemaatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absenKebaktianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafikKehadiranJemaatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gantiPasswordToolStripMenuItem;
    }
}

