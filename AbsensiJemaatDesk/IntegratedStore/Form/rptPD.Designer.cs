namespace AbsensiJemaatDesk
{
    partial class rptPD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptPD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUmatPD = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDariPD = new System.Windows.Forms.DateTimePicker();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPewarta = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlList = new System.Windows.Forms.Panel();
            this.dgvListPD = new System.Windows.Forms.DataGridView();
            this.pnlCari = new System.Windows.Forms.Panel();
            this.gbCari = new System.Windows.Forms.GroupBox();
            this.dtSampaiPD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.tabHeader = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.LblMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmatPD)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPD)).BeginInit();
            this.pnlCari.SuspendLayout();
            this.gbCari.SuspendLayout();
            this.tabHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUmatPD
            // 
            this.dgvUmatPD.AllowUserToAddRows = false;
            this.dgvUmatPD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvUmatPD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUmatPD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUmatPD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUmatPD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUmatPD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUmatPD.ColumnHeadersHeight = 30;
            this.dgvUmatPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUmatPD.Location = new System.Drawing.Point(0, 0);
            this.dgvUmatPD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUmatPD.MultiSelect = false;
            this.dgvUmatPD.Name = "dgvUmatPD";
            this.dgvUmatPD.ReadOnly = true;
            this.dgvUmatPD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUmatPD.Size = new System.Drawing.Size(898, 407);
            this.dgvUmatPD.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(10, 227);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(172, 63);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Image = ((System.Drawing.Image)(resources.GetObject("btnTutup.Image")));
            this.btnTutup.Location = new System.Drawing.Point(10, 297);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(172, 63);
            this.btnTutup.TabIndex = 5;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "dari tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pewarta";
            // 
            // dtDariPD
            // 
            this.dtDariPD.CustomFormat = "dd MMM yyyy";
            this.dtDariPD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDariPD.Location = new System.Drawing.Point(27, 42);
            this.dtDariPD.Name = "dtDariPD";
            this.dtDariPD.Size = new System.Drawing.Size(155, 25);
            this.dtDariPD.TabIndex = 0;
            this.dtDariPD.TabStop = false;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvUmatPD);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(898, 407);
            this.pnlGrid.TabIndex = 3;
            // 
            // pnlBody
            // 
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Controls.Add(this.pnlGrid);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(3, 3);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(900, 409);
            this.pnlBody.TabIndex = 1;
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.pnlBody);
            this.tabDetail.Location = new System.Drawing.Point(4, 26);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(906, 415);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "Detail";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tema";
            // 
            // txtPewarta
            // 
            this.txtPewarta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPewarta.Location = new System.Drawing.Point(27, 193);
            this.txtPewarta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPewarta.Name = "txtPewarta";
            this.txtPewarta.Size = new System.Drawing.Size(155, 26);
            this.txtPewarta.TabIndex = 3;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pnlList);
            this.pnlHeader.Controls.Add(this.pnlCari);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 409);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlList
            // 
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Controls.Add(this.dgvListPD);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(201, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(699, 409);
            this.pnlList.TabIndex = 1;
            // 
            // dgvListPD
            // 
            this.dgvListPD.AllowUserToAddRows = false;
            this.dgvListPD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvListPD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListPD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListPD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListPD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListPD.ColumnHeadersHeight = 30;
            this.dgvListPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListPD.Location = new System.Drawing.Point(0, 0);
            this.dgvListPD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListPD.MultiSelect = false;
            this.dgvListPD.Name = "dgvListPD";
            this.dgvListPD.ReadOnly = true;
            this.dgvListPD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListPD.Size = new System.Drawing.Size(697, 407);
            this.dgvListPD.TabIndex = 1;
            // 
            // pnlCari
            // 
            this.pnlCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCari.Controls.Add(this.gbCari);
            this.pnlCari.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCari.Location = new System.Drawing.Point(0, 0);
            this.pnlCari.Name = "pnlCari";
            this.pnlCari.Size = new System.Drawing.Size(201, 409);
            this.pnlCari.TabIndex = 0;
            // 
            // gbCari
            // 
            this.gbCari.Controls.Add(this.btnTutup);
            this.gbCari.Controls.Add(this.btnExport);
            this.gbCari.Controls.Add(this.dtSampaiPD);
            this.gbCari.Controls.Add(this.label2);
            this.gbCari.Controls.Add(this.label4);
            this.gbCari.Controls.Add(this.label9);
            this.gbCari.Controls.Add(this.label1);
            this.gbCari.Controls.Add(this.dtDariPD);
            this.gbCari.Controls.Add(this.txtPewarta);
            this.gbCari.Controls.Add(this.txtTema);
            this.gbCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCari.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCari.Location = new System.Drawing.Point(0, 0);
            this.gbCari.Name = "gbCari";
            this.gbCari.Size = new System.Drawing.Size(199, 407);
            this.gbCari.TabIndex = 0;
            this.gbCari.TabStop = false;
            this.gbCari.Text = "Pencarian";
            // 
            // dtSampaiPD
            // 
            this.dtSampaiPD.CustomFormat = "dd MMM yyyy";
            this.dtSampaiPD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSampaiPD.Location = new System.Drawing.Point(27, 91);
            this.dtSampaiPD.Name = "dtSampaiPD";
            this.dtSampaiPD.Size = new System.Drawing.Size(155, 25);
            this.dtSampaiPD.TabIndex = 1;
            this.dtSampaiPD.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "sampai tanggal";
            // 
            // txtTema
            // 
            this.txtTema.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.Location = new System.Drawing.Point(27, 141);
            this.txtTema.Margin = new System.Windows.Forms.Padding(4);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(155, 26);
            this.txtTema.TabIndex = 2;
            // 
            // tabHeader
            // 
            this.tabHeader.Controls.Add(this.pnlHeader);
            this.tabHeader.Location = new System.Drawing.Point(4, 26);
            this.tabHeader.Name = "tabHeader";
            this.tabHeader.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeader.Size = new System.Drawing.Size(906, 415);
            this.tabHeader.TabIndex = 0;
            this.tabHeader.Text = "Header";
            this.tabHeader.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHeader);
            this.tabControl1.Controls.Add(this.tabDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 445);
            this.tabControl1.TabIndex = 2;
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
            this.LblMenu.Text = "DAFTAR PERSEKUTUAN DOA";
            this.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rptPD
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
            this.Name = "rptPD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmatPD)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPD)).EndInit();
            this.pnlCari.ResumeLayout(false);
            this.gbCari.ResumeLayout(false);
            this.gbCari.PerformLayout();
            this.tabHeader.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUmatPD;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDariPD;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPewarta;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.TabPage tabHeader;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Panel pnlCari;
        private System.Windows.Forms.GroupBox gbCari;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DateTimePicker dtSampaiPD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListPD;
    }
}