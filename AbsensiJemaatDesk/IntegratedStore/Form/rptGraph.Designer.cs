namespace AbsensiJemaatDesk
{
    partial class rptGraph
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptGraph));
            this.tabAlpha = new System.Windows.Forms.TabPage();
            this.pnlAlphaMain = new System.Windows.Forms.Panel();
            this.pnlAlphaData = new System.Windows.Forms.Panel();
            this.dgvAlphaUmat = new System.Windows.Forms.DataGridView();
            this.pnlAlpahMenu = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHadir = new System.Windows.Forms.TabPage();
            this.tabBuku = new System.Windows.Forms.TabPage();
            this.tabClose = new System.Windows.Forms.TabPage();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.LblMenu = new System.Windows.Forms.Label();
            this.dataGridViewProgressColumn1 = new AbsensiJemaatDesk.DataGridViewProgressColumn();
            this.hapus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.namaLengkap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persen = new AbsensiJemaatDesk.DataGridViewProgressColumn();
            this.tabAlpha.SuspendLayout();
            this.pnlAlphaMain.SuspendLayout();
            this.pnlAlphaData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlphaUmat)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAlpha
            // 
            this.tabAlpha.Controls.Add(this.pnlAlphaMain);
            this.tabAlpha.Location = new System.Drawing.Point(154, 4);
            this.tabAlpha.Name = "tabAlpha";
            this.tabAlpha.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlpha.Size = new System.Drawing.Size(756, 437);
            this.tabAlpha.TabIndex = 1;
            this.tabAlpha.Text = "Kealphaan Umat";
            this.tabAlpha.UseVisualStyleBackColor = true;
            // 
            // pnlAlphaMain
            // 
            this.pnlAlphaMain.Controls.Add(this.pnlAlphaData);
            this.pnlAlphaMain.Controls.Add(this.pnlAlpahMenu);
            this.pnlAlphaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlphaMain.Location = new System.Drawing.Point(3, 3);
            this.pnlAlphaMain.Name = "pnlAlphaMain";
            this.pnlAlphaMain.Size = new System.Drawing.Size(750, 431);
            this.pnlAlphaMain.TabIndex = 2;
            // 
            // pnlAlphaData
            // 
            this.pnlAlphaData.Controls.Add(this.dgvAlphaUmat);
            this.pnlAlphaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlphaData.Location = new System.Drawing.Point(175, 0);
            this.pnlAlphaData.Name = "pnlAlphaData";
            this.pnlAlphaData.Size = new System.Drawing.Size(575, 431);
            this.pnlAlphaData.TabIndex = 3;
            // 
            // dgvAlphaUmat
            // 
            this.dgvAlphaUmat.AllowUserToAddRows = false;
            this.dgvAlphaUmat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvAlphaUmat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlphaUmat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlphaUmat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAlphaUmat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlphaUmat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlphaUmat.ColumnHeadersHeight = 30;
            this.dgvAlphaUmat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hapus,
            this.namaLengkap,
            this.namaAlias,
            this.persen});
            this.dgvAlphaUmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlphaUmat.Location = new System.Drawing.Point(0, 0);
            this.dgvAlphaUmat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlphaUmat.MultiSelect = false;
            this.dgvAlphaUmat.Name = "dgvAlphaUmat";
            this.dgvAlphaUmat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlphaUmat.Size = new System.Drawing.Size(575, 431);
            this.dgvAlphaUmat.TabIndex = 1;
            // 
            // pnlAlpahMenu
            // 
            this.pnlAlpahMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAlpahMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlAlpahMenu.Name = "pnlAlpahMenu";
            this.pnlAlpahMenu.Size = new System.Drawing.Size(175, 431);
            this.pnlAlpahMenu.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabAlpha);
            this.tabControl1.Controls.Add(this.tabHadir);
            this.tabControl1.Controls.Add(this.tabBuku);
            this.tabControl1.Controls.Add(this.tabClose);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(35, 150);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 445);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabHadir
            // 
            this.tabHadir.Location = new System.Drawing.Point(154, 4);
            this.tabHadir.Name = "tabHadir";
            this.tabHadir.Padding = new System.Windows.Forms.Padding(3);
            this.tabHadir.Size = new System.Drawing.Size(756, 437);
            this.tabHadir.TabIndex = 0;
            this.tabHadir.Text = "Kehadiran Umat";
            this.tabHadir.UseVisualStyleBackColor = true;
            // 
            // tabBuku
            // 
            this.tabBuku.Location = new System.Drawing.Point(154, 4);
            this.tabBuku.Name = "tabBuku";
            this.tabBuku.Size = new System.Drawing.Size(756, 437);
            this.tabBuku.TabIndex = 2;
            this.tabBuku.Text = "Buku Absen Umat";
            this.tabBuku.UseVisualStyleBackColor = true;
            // 
            // tabClose
            // 
            this.tabClose.Location = new System.Drawing.Point(154, 4);
            this.tabClose.Name = "tabClose";
            this.tabClose.Size = new System.Drawing.Size(756, 437);
            this.tabClose.TabIndex = 3;
            this.tabClose.Text = "Tutup";
            this.tabClose.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabControl1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 42);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(914, 445);
            this.pnlMain.TabIndex = 3;
            // 
            // LblMenu
            // 
            this.LblMenu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.LblMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblMenu.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.LblMenu.Location = new System.Drawing.Point(0, 0);
            this.LblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(914, 42);
            this.LblMenu.TabIndex = 2;
            this.LblMenu.Text = "GRAFIK PD ST. YAKOBUS";
            this.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewProgressColumn1
            // 
            this.dataGridViewProgressColumn1.HeaderText = "Presentase";
            this.dataGridViewProgressColumn1.Name = "dataGridViewProgressColumn1";
            this.dataGridViewProgressColumn1.ReadOnly = true;
            this.dataGridViewProgressColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProgressColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewProgressColumn1.Width = 133;
            // 
            // hapus
            // 
            this.hapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hapus.HeaderText = "Hapus";
            this.hapus.Name = "hapus";
            this.hapus.Width = 56;
            // 
            // namaLengkap
            // 
            this.namaLengkap.HeaderText = "NamaLengkap";
            this.namaLengkap.Name = "namaLengkap";
            this.namaLengkap.ReadOnly = true;
            this.namaLengkap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.namaLengkap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // namaAlias
            // 
            this.namaAlias.HeaderText = "Nama Alias";
            this.namaAlias.Name = "namaAlias";
            this.namaAlias.ReadOnly = true;
            // 
            // persen
            // 
            this.persen.HeaderText = "Presentase";
            this.persen.Name = "persen";
            this.persen.ReadOnly = true;
            this.persen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.persen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rptGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 487);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.LblMenu);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "rptGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tabAlpha.ResumeLayout(false);
            this.pnlAlphaMain.ResumeLayout(false);
            this.pnlAlphaData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlphaUmat)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabAlpha;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.TabPage tabBuku;
        private System.Windows.Forms.TabPage tabHadir;
        private System.Windows.Forms.DataGridView dgvAlphaUmat;
        private System.Windows.Forms.Panel pnlAlphaMain;
        private System.Windows.Forms.Panel pnlAlphaData;
        private System.Windows.Forms.Panel pnlAlpahMenu;
        private System.Windows.Forms.TabPage tabClose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaLengkap;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaAlias;
        private DataGridViewProgressColumn persen;
        private DataGridViewProgressColumn dataGridViewProgressColumn1;
    }
}