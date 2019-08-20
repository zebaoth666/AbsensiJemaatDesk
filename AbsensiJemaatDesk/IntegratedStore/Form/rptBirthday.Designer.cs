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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBirthday));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnTutup = new System.Windows.Forms.Button();
            this.gbLahir = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDari = new System.Windows.Forms.DateTimePicker();
            this.dtSampai = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmbBulan = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.gbLahir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBulan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panelBody);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 153);
            this.panel1.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBody.Controls.Add(this.btnTutup);
            this.panelBody.Controls.Add(this.gbLahir);
            this.panelBody.Controls.Add(this.dgv);
            this.panelBody.Controls.Add(this.cmbBulan);
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Controls.Add(this.btnMasuk);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBody.Location = new System.Drawing.Point(0, 46);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(576, 103);
            this.panelBody.TabIndex = 5;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.SystemColors.Control;
            this.btnTutup.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Image = ((System.Drawing.Image)(resources.GetObject("btnTutup.Image")));
            this.btnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTutup.Location = new System.Drawing.Point(429, 24);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(4);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(135, 56);
            this.btnTutup.TabIndex = 2;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // gbLahir
            // 
            this.gbLahir.Controls.Add(this.label3);
            this.gbLahir.Controls.Add(this.label2);
            this.gbLahir.Controls.Add(this.dtDari);
            this.gbLahir.Controls.Add(this.dtSampai);
            this.gbLahir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLahir.Location = new System.Drawing.Point(9, 1);
            this.gbLahir.Name = "gbLahir";
            this.gbLahir.Size = new System.Drawing.Size(268, 91);
            this.gbLahir.TabIndex = 0;
            this.gbLahir.TabStop = false;
            this.gbLahir.Text = "Kelahiran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "sampai tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "dari tanggal";
            // 
            // dtDari
            // 
            this.dtDari.CustomFormat = "dd MMMM";
            this.dtDari.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDari.Location = new System.Drawing.Point(123, 23);
            this.dtDari.Name = "dtDari";
            this.dtDari.Size = new System.Drawing.Size(136, 25);
            this.dtDari.TabIndex = 0;
            // 
            // dtSampai
            // 
            this.dtSampai.CustomFormat = "dd MMMM";
            this.dtSampai.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSampai.Location = new System.Drawing.Point(123, 54);
            this.dtSampai.Name = "dtSampai";
            this.dtSampai.Size = new System.Drawing.Size(136, 25);
            this.dtSampai.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(241, 140);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(612, 150);
            this.dgv.TabIndex = 5;
            // 
            // cmbBulan
            // 
            this.cmbBulan.Location = new System.Drawing.Point(86, 137);
            this.cmbBulan.Name = "cmbBulan";
            this.cmbBulan.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBulan.Properties.Appearance.Options.UseFont = true;
            this.cmbBulan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBulan.Size = new System.Drawing.Size(129, 24);
            this.cmbBulan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-7, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulan Lahir";
            // 
            // btnMasuk
            // 
            this.btnMasuk.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasuk.Image = ((System.Drawing.Image)(resources.GetObject("btnMasuk.Image")));
            this.btnMasuk.Location = new System.Drawing.Point(285, 24);
            this.btnMasuk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(135, 56);
            this.btnMasuk.TabIndex = 1;
            this.btnMasuk.Text = "Generate";
            this.btnMasuk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasuk.UseVisualStyleBackColor = true;
            this.btnMasuk.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(576, 46);
            this.panelHeader.TabIndex = 4;
            // 
            // rptBirthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 153);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "rptBirthday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.gbLahir.ResumeLayout(false);
            this.gbLahir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBulan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView dgv;
        private DevExpress.XtraEditors.LookUpEdit cmbBulan;
        private System.Windows.Forms.DateTimePicker dtDari;
        private System.Windows.Forms.DateTimePicker dtSampai;
        private System.Windows.Forms.GroupBox gbLahir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTutup;
    }
}