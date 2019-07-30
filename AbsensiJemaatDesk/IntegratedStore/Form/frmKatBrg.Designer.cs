namespace AbsensiJemaatDesk
{
    partial class frmKatBrg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKatBrg));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUbahPada = new System.Windows.Forms.Label();
            this.lblUbahOleh = new System.Windows.Forms.Label();
            this.lblBuatPada = new System.Windows.Forms.Label();
            this.lblBuatOleh = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKodeKat = new System.Windows.Forms.Label();
            this.txtDescKat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.pnlList2 = new System.Windows.Forms.Panel();
            this.dgvKat = new System.Windows.Forms.DataGridView();
            this.pnlList1 = new System.Windows.Forms.Panel();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.pnlParent.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlList2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKat)).BeginInit();
            this.pnlList1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(881, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAFTAR KATEGORI BARANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlParent
            // 
            this.pnlParent.Controls.Add(this.pnlDetail);
            this.pnlParent.Controls.Add(this.pnlList);
            this.pnlParent.Controls.Add(this.pnlMenu);
            this.pnlParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParent.Location = new System.Drawing.Point(0, 42);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(881, 419);
            this.pnlParent.TabIndex = 0;
            // 
            // pnlDetail
            // 
            this.pnlDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetail.Controls.Add(this.panel1);
            this.pnlDetail.Controls.Add(this.lblStatus);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.lblKodeKat);
            this.pnlDetail.Controls.Add(this.txtDescKat);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(215, 41);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(666, 378);
            this.pnlDetail.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.lblUbahPada);
            this.panel1.Controls.Add(this.lblUbahOleh);
            this.panel1.Controls.Add(this.lblBuatPada);
            this.panel1.Controls.Add(this.lblBuatOleh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 62);
            this.panel1.TabIndex = 5;
            // 
            // lblUbahPada
            // 
            this.lblUbahPada.AutoSize = true;
            this.lblUbahPada.Location = new System.Drawing.Point(295, 35);
            this.lblUbahPada.Name = "lblUbahPada";
            this.lblUbahPada.Size = new System.Drawing.Size(77, 13);
            this.lblUbahPada.TabIndex = 3;
            this.lblUbahPada.Text = "Diubah pada :-";
            // 
            // lblUbahOleh
            // 
            this.lblUbahOleh.AutoSize = true;
            this.lblUbahOleh.Location = new System.Drawing.Point(295, 12);
            this.lblUbahOleh.Name = "lblUbahOleh";
            this.lblUbahOleh.Size = new System.Drawing.Size(73, 13);
            this.lblUbahOleh.TabIndex = 2;
            this.lblUbahOleh.Text = "Diubah oleh :-";
            // 
            // lblBuatPada
            // 
            this.lblBuatPada.AutoSize = true;
            this.lblBuatPada.Location = new System.Drawing.Point(15, 35);
            this.lblBuatPada.Name = "lblBuatPada";
            this.lblBuatPada.Size = new System.Drawing.Size(74, 13);
            this.lblBuatPada.TabIndex = 1;
            this.lblBuatPada.Text = "Dibuat pada :-";
            // 
            // lblBuatOleh
            // 
            this.lblBuatOleh.AutoSize = true;
            this.lblBuatOleh.Location = new System.Drawing.Point(15, 12);
            this.lblBuatOleh.Name = "lblBuatOleh";
            this.lblBuatOleh.Size = new System.Drawing.Size(70, 13);
            this.lblBuatOleh.TabIndex = 0;
            this.lblBuatOleh.Text = "Dibuat oleh :-";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(109, 54);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Deskripsi Kategori";
            // 
            // lblKodeKat
            // 
            this.lblKodeKat.AutoSize = true;
            this.lblKodeKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeKat.Location = new System.Drawing.Point(109, 12);
            this.lblKodeKat.Name = "lblKodeKat";
            this.lblKodeKat.Size = new System.Drawing.Size(14, 13);
            this.lblKodeKat.TabIndex = 2;
            this.lblKodeKat.Text = "0";
            // 
            // txtDescKat
            // 
            this.txtDescKat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescKat.Location = new System.Drawing.Point(112, 31);
            this.txtDescKat.Name = "txtDescKat";
            this.txtDescKat.Size = new System.Drawing.Size(131, 20);
            this.txtDescKat.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kode Kategori";
            // 
            // pnlList
            // 
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Controls.Add(this.pnlList2);
            this.pnlList.Controls.Add(this.pnlList1);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlList.Location = new System.Drawing.Point(0, 41);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(215, 378);
            this.pnlList.TabIndex = 1;
            // 
            // pnlList2
            // 
            this.pnlList2.Controls.Add(this.dgvKat);
            this.pnlList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList2.Location = new System.Drawing.Point(0, 31);
            this.pnlList2.Name = "pnlList2";
            this.pnlList2.Size = new System.Drawing.Size(213, 345);
            this.pnlList2.TabIndex = 1;
            // 
            // dgvKat
            // 
            this.dgvKat.AllowUserToAddRows = false;
            this.dgvKat.AllowUserToDeleteRows = false;
            this.dgvKat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKat.Location = new System.Drawing.Point(0, 0);
            this.dgvKat.MultiSelect = false;
            this.dgvKat.Name = "dgvKat";
            this.dgvKat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKat.Size = new System.Drawing.Size(213, 345);
            this.dgvKat.TabIndex = 0;
            // 
            // pnlList1
            // 
            this.pnlList1.Controls.Add(this.txtCari);
            this.pnlList1.Controls.Add(this.label2);
            this.pnlList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlList1.Location = new System.Drawing.Point(0, 0);
            this.pnlList1.Name = "pnlList1";
            this.pnlList1.Size = new System.Drawing.Size(213, 31);
            this.pnlList1.TabIndex = 0;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(76, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(131, 20);
            this.txtCari.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Kategori";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnPrint);
            this.pnlMenu.Controls.Add(this.btnTutup);
            this.pnlMenu.Controls.Add(this.btnBatal);
            this.pnlMenu.Controls.Add(this.btnSimpan);
            this.pnlMenu.Controls.Add(this.btnHapus);
            this.pnlMenu.Controls.Add(this.btnUbah);
            this.pnlMenu.Controls.Add(this.btnTambah);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(881, 41);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.TabStop = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(665, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 39);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print (F10)";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTutup.Image = ((System.Drawing.Image)(resources.GetObject("btnTutup.Image")));
            this.btnTutup.Location = new System.Drawing.Point(772, 0);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(107, 39);
            this.btnTutup.TabIndex = 6;
            this.btnTutup.Text = "Keluar (Esc)";
            this.btnTutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBatal.Image = ((System.Drawing.Image)(resources.GetObject("btnBatal.Image")));
            this.btnBatal.Location = new System.Drawing.Point(428, 0);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(107, 39);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal (F5)";
            this.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Image")));
            this.btnSimpan.Location = new System.Drawing.Point(321, 0);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(107, 39);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan (F4)";
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.Location = new System.Drawing.Point(214, 0);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(107, 39);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus (F3)";
            this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUbah.Image = ((System.Drawing.Image)(resources.GetObject("btnUbah.Image")));
            this.btnUbah.Location = new System.Drawing.Point(107, 0);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(107, 39);
            this.btnUbah.TabIndex = 1;
            this.btnUbah.Text = "Ubah (F2)";
            this.btnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.Location = new System.Drawing.Point(0, 0);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(107, 39);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Tambah (F1)";
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // frmKatBrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(881, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmKatBrg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.VisibleChanged += new System.EventHandler(this.frmCategory_VisibleChanged);
            this.pnlParent.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlList2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKat)).EndInit();
            this.pnlList1.ResumeLayout(false);
            this.pnlList1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlParent;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.DataGridView dgvKat;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlList2;
        private System.Windows.Forms.Panel pnlList1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKodeKat;
        private System.Windows.Forms.TextBox txtDescKat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUbahPada;
        private System.Windows.Forms.Label lblUbahOleh;
        private System.Windows.Forms.Label lblBuatPada;
        private System.Windows.Forms.Label lblBuatOleh;
        private System.Windows.Forms.Button btnPrint;
    }
}