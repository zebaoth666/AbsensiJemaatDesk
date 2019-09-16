namespace AbsensiJemaatDesk
{
    partial class rptBirthday
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBirthday));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlList = new System.Windows.Forms.Panel();
            this.dgvUmat = new System.Windows.Forms.DataGridView();
            this.pnlCari = new System.Windows.Forms.Panel();
            this.gbCari = new System.Windows.Forms.GroupBox();
            this.cmbTglAkhir = new System.Windows.Forms.ComboBox();
            this.cmbTglAwal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBln = new System.Windows.Forms.ComboBox();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dtSampai = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDari = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmat)).BeginInit();
            this.pnlCari.SuspendLayout();
            this.gbCari.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnlMain);
            this.panel1.Controls.Add(this.pnlHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 529);
            this.panel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlList);
            this.pnlMain.Controls.Add(this.pnlCari);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 46);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(876, 479);
            this.pnlMain.TabIndex = 5;
            // 
            // pnlList
            // 
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Controls.Add(this.dgvUmat);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(201, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(675, 479);
            this.pnlList.TabIndex = 1;
            // 
            // dgvUmat
            // 
            this.dgvUmat.AllowUserToAddRows = false;
            this.dgvUmat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvUmat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUmat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUmat.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUmat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUmat.ColumnHeadersHeight = 30;
            this.dgvUmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUmat.Location = new System.Drawing.Point(0, 0);
            this.dgvUmat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUmat.MultiSelect = false;
            this.dgvUmat.Name = "dgvUmat";
            this.dgvUmat.ReadOnly = true;
            this.dgvUmat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUmat.Size = new System.Drawing.Size(673, 477);
            this.dgvUmat.TabIndex = 1;
            // 
            // pnlCari
            // 
            this.pnlCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCari.Controls.Add(this.gbCari);
            this.pnlCari.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCari.Location = new System.Drawing.Point(0, 0);
            this.pnlCari.Name = "pnlCari";
            this.pnlCari.Size = new System.Drawing.Size(201, 479);
            this.pnlCari.TabIndex = 0;
            // 
            // gbCari
            // 
            this.gbCari.Controls.Add(this.cmbTglAkhir);
            this.gbCari.Controls.Add(this.cmbTglAwal);
            this.gbCari.Controls.Add(this.label1);
            this.gbCari.Controls.Add(this.cmbBln);
            this.gbCari.Controls.Add(this.btnTutup);
            this.gbCari.Controls.Add(this.btnExport);
            this.gbCari.Controls.Add(this.dtSampai);
            this.gbCari.Controls.Add(this.label2);
            this.gbCari.Controls.Add(this.label4);
            this.gbCari.Controls.Add(this.dtDari);
            this.gbCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCari.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCari.Location = new System.Drawing.Point(0, 0);
            this.gbCari.Name = "gbCari";
            this.gbCari.Size = new System.Drawing.Size(199, 477);
            this.gbCari.TabIndex = 0;
            this.gbCari.TabStop = false;
            this.gbCari.Text = "Pencarian";
            // 
            // cmbTglAkhir
            // 
            this.cmbTglAkhir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTglAkhir.Enabled = false;
            this.cmbTglAkhir.FormattingEnabled = true;
            this.cmbTglAkhir.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbTglAkhir.Location = new System.Drawing.Point(129, 104);
            this.cmbTglAkhir.Name = "cmbTglAkhir";
            this.cmbTglAkhir.Size = new System.Drawing.Size(53, 25);
            this.cmbTglAkhir.TabIndex = 2;
            // 
            // cmbTglAwal
            // 
            this.cmbTglAwal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTglAwal.Enabled = false;
            this.cmbTglAwal.FormattingEnabled = true;
            this.cmbTglAwal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbTglAwal.Location = new System.Drawing.Point(129, 73);
            this.cmbTglAwal.Name = "cmbTglAwal";
            this.cmbTglAwal.Size = new System.Drawing.Size(53, 25);
            this.cmbTglAwal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bulan";
            // 
            // cmbBln
            // 
            this.cmbBln.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBln.FormattingEnabled = true;
            this.cmbBln.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cmbBln.Location = new System.Drawing.Point(10, 42);
            this.cmbBln.Name = "cmbBln";
            this.cmbBln.Size = new System.Drawing.Size(172, 25);
            this.cmbBln.TabIndex = 0;
            // 
            // btnTutup
            // 
            this.btnTutup.Image = ((System.Drawing.Image)(resources.GetObject("btnTutup.Image")));
            this.btnTutup.Location = new System.Drawing.Point(10, 206);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(172, 63);
            this.btnTutup.TabIndex = 4;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(10, 136);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(172, 63);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dtSampai
            // 
            this.dtSampai.CustomFormat = "dd MMM yyyy";
            this.dtSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSampai.Location = new System.Drawing.Point(222, 186);
            this.dtSampai.Name = "dtSampai";
            this.dtSampai.Size = new System.Drawing.Size(155, 25);
            this.dtSampai.TabIndex = 1;
            this.dtSampai.TabStop = false;
            this.dtSampai.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "sampai tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "dari tanggal";
            // 
            // dtDari
            // 
            this.dtDari.CustomFormat = "dd MMM yyyy";
            this.dtDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDari.Location = new System.Drawing.Point(222, 137);
            this.dtDari.Name = "dtDari";
            this.dtDari.Size = new System.Drawing.Size(155, 25);
            this.dtDari.TabIndex = 0;
            this.dtDari.TabStop = false;
            this.dtDari.Visible = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(876, 46);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(874, 44);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "DAFTAR ULANG TAHUN UMAT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rptBirthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 529);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "rptBirthday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptBirthday_Load);
            this.panel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmat)).EndInit();
            this.pnlCari.ResumeLayout(false);
            this.gbCari.ResumeLayout(false);
            this.gbCari.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView dgvUmat;
        private System.Windows.Forms.Panel pnlCari;
        private System.Windows.Forms.GroupBox gbCari;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dtSampai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDari;
        private System.Windows.Forms.Label lblTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBln;
        private System.Windows.Forms.ComboBox cmbTglAkhir;
        private System.Windows.Forms.ComboBox cmbTglAwal;
    }
}