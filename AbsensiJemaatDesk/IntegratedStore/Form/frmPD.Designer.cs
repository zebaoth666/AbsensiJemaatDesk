namespace AbsensiJemaatDesk
{
    partial class frmPD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblMenu = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHeader = new System.Windows.Forms.TabPage();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtKebaktian = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPewarta = new System.Windows.Forms.TextBox();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvUmat = new System.Windows.Forms.DataGridView();
            this.pnlCari = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnUmatBaru = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHeader.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmat)).BeginInit();
            this.pnlCari.SuspendLayout();
            this.SuspendLayout();
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
            this.LblMenu.Size = new System.Drawing.Size(924, 42);
            this.LblMenu.TabIndex = 0;
            this.LblMenu.Text = "JADWAL PERSEKUTUAN DOA";
            this.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabControl1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 42);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(924, 475);
            this.pnlMain.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHeader);
            this.tabControl1.Controls.Add(this.tabDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 475);
            this.tabControl1.TabIndex = 2;
            // 
            // tabHeader
            // 
            this.tabHeader.Controls.Add(this.pnlHeader);
            this.tabHeader.Location = new System.Drawing.Point(4, 27);
            this.tabHeader.Name = "tabHeader";
            this.tabHeader.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeader.Size = new System.Drawing.Size(916, 444);
            this.tabHeader.TabIndex = 0;
            this.tabHeader.Text = "Header";
            this.tabHeader.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnSimpan);
            this.pnlHeader.Controls.Add(this.btnTutup);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.dtKebaktian);
            this.pnlHeader.Controls.Add(this.label9);
            this.pnlHeader.Controls.Add(this.txtPewarta);
            this.pnlHeader.Controls.Add(this.txtTema);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(910, 438);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Control;
            this.btnSimpan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Image")));
            this.btnSimpan.Location = new System.Drawing.Point(273, 110);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(109, 43);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Image = ((System.Drawing.Image)(resources.GetObject("btnTutup.Image")));
            this.btnTutup.Location = new System.Drawing.Point(389, 109);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(109, 43);
            this.btnTutup.TabIndex = 4;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pewarta";
            // 
            // dtKebaktian
            // 
            this.dtKebaktian.CustomFormat = "dd MMM yyyy";
            this.dtKebaktian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtKebaktian.Location = new System.Drawing.Point(91, 9);
            this.dtKebaktian.Name = "dtKebaktian";
            this.dtKebaktian.Size = new System.Drawing.Size(146, 26);
            this.dtKebaktian.TabIndex = 0;
            this.dtKebaktian.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tema";
            // 
            // txtPewarta
            // 
            this.txtPewarta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPewarta.Location = new System.Drawing.Point(91, 76);
            this.txtPewarta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPewarta.Name = "txtPewarta";
            this.txtPewarta.Size = new System.Drawing.Size(407, 26);
            this.txtPewarta.TabIndex = 2;
            // 
            // txtTema
            // 
            this.txtTema.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.Location = new System.Drawing.Point(91, 42);
            this.txtTema.Margin = new System.Windows.Forms.Padding(4);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(407, 26);
            this.txtTema.TabIndex = 1;
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.pnlBody);
            this.tabDetail.Location = new System.Drawing.Point(4, 27);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(916, 444);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "Detail";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // pnlBody
            // 
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Controls.Add(this.pnlGrid);
            this.pnlBody.Controls.Add(this.pnlCari);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(3, 3);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(910, 438);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvUmat);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 42);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(908, 394);
            this.pnlGrid.TabIndex = 3;
            // 
            // dgvUmat
            // 
            this.dgvUmat.AllowUserToAddRows = false;
            this.dgvUmat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvUmat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUmat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUmat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUmat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUmat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUmat.ColumnHeadersHeight = 30;
            this.dgvUmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUmat.Location = new System.Drawing.Point(0, 0);
            this.dgvUmat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUmat.MultiSelect = false;
            this.dgvUmat.Name = "dgvUmat";
            this.dgvUmat.Size = new System.Drawing.Size(908, 394);
            this.dgvUmat.TabIndex = 0;
            // 
            // pnlCari
            // 
            this.pnlCari.Controls.Add(this.lbltotal);
            this.pnlCari.Controls.Add(this.btnUmatBaru);
            this.pnlCari.Controls.Add(this.txtCari);
            this.pnlCari.Controls.Add(this.label2);
            this.pnlCari.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCari.Location = new System.Drawing.Point(0, 0);
            this.pnlCari.Name = "pnlCari";
            this.pnlCari.Size = new System.Drawing.Size(908, 42);
            this.pnlCari.TabIndex = 2;
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(753, 9);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(151, 19);
            this.lbltotal.TabIndex = 12;
            this.lbltotal.Text = "Total Jemaat : ";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUmatBaru
            // 
            this.btnUmatBaru.BackColor = System.Drawing.SystemColors.Control;
            this.btnUmatBaru.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUmatBaru.Location = new System.Drawing.Point(595, 6);
            this.btnUmatBaru.Margin = new System.Windows.Forms.Padding(4);
            this.btnUmatBaru.Name = "btnUmatBaru";
            this.btnUmatBaru.Size = new System.Drawing.Size(139, 26);
            this.btnUmatBaru.TabIndex = 1;
            this.btnUmatBaru.Text = "Umat Baru";
            this.btnUmatBaru.UseVisualStyleBackColor = false;
            this.btnUmatBaru.Click += new System.EventHandler(this.btnUmatBaru_Click);
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(179, 6);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(408, 26);
            this.txtCari.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cari Nama Lengkap";
            // 
            // frmPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(924, 517);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.LblMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKebaktian_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabHeader.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabDetail.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmat)).EndInit();
            this.pnlCari.ResumeLayout(false);
            this.pnlCari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtPewarta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.DataGridView dgvUmat;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtKebaktian;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHeader;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUmatBaru;
        private System.Windows.Forms.Label lbltotal;
    }
}