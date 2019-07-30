using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace AbsensiJemaatDesk
{
    public partial class frmKatBrg : Form
    {
        categoryClass kat;
        private Boolean editMode = false;
        private String currId = string.Empty;
        private DataTable dt;
        private DataView dv;
        private PrintPreviewDialog ppd = new PrintPreviewDialog();
        private PrintDocument pd = new PrintDocument();

        public frmKatBrg()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(this.frmKatBrg_FormClosing);
            this.KeyDown += new KeyEventHandler(this.frmKatBrg_KeyDown);
            this.dgvKat.SelectionChanged += new EventHandler(dgvKat_SelectionChanged);
            this.txtCari.TextChanged += new EventHandler(txtCari_TextChanged);
            this.pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            kat = new categoryClass();
        }

        private void frmCategory_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                disableControl();
                getData();
                dgvKat.Focus();
            }
        }
        
        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            enableControl();
            lblKodeKat.Text = "0";
            txtDescKat.Text = string.Empty;
            lblStatus.Text = "AKTIF";
            txtDescKat.Focus();

            lblBuatOleh.Text = "Dibuat oleh: -";
            lblBuatPada.Text = "Dibuat pada: -";
            lblUbahOleh.Text = "Diubah oleh: -";
            lblUbahPada.Text = "Diubah pada: -";
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvKat.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                enableControl();
                editMode = true;
                txtDescKat.Focus();
            }
            else
                iMessage.iBoxOk("Data sudah dinon-aktifkan");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKat.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                DialogResult result = iMessage.quBoxCon("Hapus Data?");

                if (result == DialogResult.Yes)
                {
                    if (kat.deleteCategory(lblKodeKat.Text) == true)
                    {
                        iMessage.iBoxOk("Data berhasil dihapus");
                    }
                    else
                    {
                        iMessage.iBoxOk("Data gagal dihapus");
                    };

                    disableControl();
                    getData();
                    dgvKat.Focus();

                    for (int a = 0; a <= dgvKat.Rows.Count - 1; a++)
                    {
                        if (dgvKat.Rows[a].Cells[0].Value.ToString() == currId)
                        {
                            dgvKat.CurrentCell = dgvKat.Rows[a].Cells[1];
                        }
                    }
                }
            }
            else
                iMessage.iBoxOk("Data sudah dinon-aktifkan");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescKat.Text)) {
                iMessage.iBoxOk("Harap isi deskripsi kategori");
            }else {
                DialogResult result = iMessage.quBoxCon("Simpan data?");
                if (result == DialogResult.Yes){
                    if (editMode == false)
                    {
                        currId = getMaxNo();
                        if (kat.saveCategory(getMaxNo(), txtDescKat.Text.Trim(), "1") == true)
                        {   
                            iMessage.iBoxOk("Data berhasil disimpan");
                        }
                        else
                            iMessage.iBoxOk("Data gagal disimpan");
                    }
                    else {
                        currId = lblKodeKat.Text;
                        if (kat.editCategory(lblKodeKat.Text, txtDescKat.Text.Trim()) == true)
                        {
                            editMode = false;
                            iMessage.iBoxOk("Data berhasil diperbarui");
                        }
                        else
                            iMessage.iBoxOk("Data gagal diperbarui");
                    }

                    disableControl();
                    getData();
                    dgvKat.Focus();

                    for (int a = 0; a <= dgvKat.Rows.Count - 1; a++)
                    {
                        if (dgvKat.Rows[a].Cells[0].Value.ToString() == currId) {
                            dgvKat.CurrentCell = dgvKat.Rows[a].Cells[1];
                            bindControls();
                        }
                    }
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            disableControl();
            bindControls();
            dgvKat.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ppd.Document = pd;
            ppd.ShowDialog();
            
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////                                          Event                                            //////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void frmKatBrg_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }

        private void dgvKat_SelectionChanged(object sender, EventArgs e) {
            if (dgvKat.RowCount > 0) {
                bindControls();
            }
        }

        private void frmKatBrg_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) { 
                case Keys.F1:
                    btnTambah.PerformClick();
                    break;
                case Keys.F2:
                    btnUbah.PerformClick();
                    break;
                case Keys.F3:
                    btnHapus.PerformClick();
                    break;
                case Keys.F4:
                    btnSimpan.PerformClick();
                    break;
                case Keys.F5:
                    btnBatal.PerformClick();
                    break;
                case Keys.Escape:
                    btnTutup.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e) {
            refresh(txtCari.Text);
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////                                          Function                                         //////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void disableControl()
        {
            btnTambah.Enabled = true;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
            btnTutup.Enabled = true;
            btnPrint.Enabled = true;

            pnlList.Enabled = true;
            pnlDetail.Enabled = false;
        }

        private void enableControl()
        {
            btnTambah.Enabled = false;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
            btnTutup.Enabled = false;
            btnPrint.Enabled = false;

            pnlList.Enabled = false;
            pnlDetail.Enabled = true;
        }

        private void refresh(String cari)
        {
            dv = dt.DefaultView;
            dv.RowFilter="CATEGORY_DESC LIKE '%" + cari + "%'";

            if (dgvKat != null)
                dgvKat.DataSource = null; dgvKat.Rows.Clear();
            
            dgvKat.DataSource = dv;

            for (int a = 0; a < dgvKat.Columns.Count; a++)
            {
                if (a != 1)
                {
                    dgvKat.Columns[a].Visible = false;
                }
                else
                    dgvKat.Columns[a].ReadOnly = true; dgvKat.Columns[a].HeaderText = "NAMA KATEGORI";
            }

            if (dgvKat.Rows.Count > 0)
                dgvKat.CurrentCell = dgvKat.Rows[0].Cells[1];
        }

        private void getData() {
            if (dt != null) 
                dt.Clear();

            dt = kat.getCategories();
            refresh(txtCari.Text);
        }

        private void bindControls() {
            if (dgvKat.Rows.Count > 0)
            {
                lblKodeKat.Text = dgvKat.CurrentRow.Cells[0].Value.ToString();
                txtDescKat.Text = dgvKat.CurrentRow.Cells[1].Value.ToString();
                if (dgvKat.CurrentRow.Cells[2].Value.ToString() == "1")
                {
                    lblStatus.Text = "AKTIF";
                }
                else
                    lblStatus.Text = "NON-AKTIF";

                lblBuatOleh.Text = "Dibuat oleh: " + dgvKat.CurrentRow.Cells[3].Value.ToString();
                lblBuatPada.Text = "Dibuat pada: " + dgvKat.CurrentRow.Cells[4].Value.ToString();
                lblUbahOleh.Text = "Diubah oleh: " + dgvKat.CurrentRow.Cells[5].Value.ToString();
                lblUbahPada.Text = "Diubah pada: " + dgvKat.CurrentRow.Cells[6].Value.ToString();
            }
            else {
                lblKodeKat.Text = "0";
                txtDescKat.Text = string.Empty;
                lblStatus.Text = string.Empty;

                lblBuatOleh.Text = "Dibuat oleh: -";
                lblBuatPada.Text = "Dibuat pada: -";
                lblUbahOleh.Text = "Diubah oleh: -";

                lblUbahPada.Text = "Diubah pada: -";
            }
        }

        private String getMaxNo() {
            string maxNo = "";

            if (dgvKat.Rows.Count > 0)
            {
                int lastVal = Convert.ToInt16(dgvKat.Rows[dgvKat.Rows.Count - 1].Cells[0].Value.ToString()) + 1;
                maxNo = Convert.ToString(lastVal);

                while(maxNo.Length != 3){
                    maxNo = "0" + maxNo;
                }
            }
            else
                maxNo = "001";

            return maxNo;
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////                                              Print Area                                   //////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void pd_PrintPage(object sender, PrintPageEventArgs e) {
            int x = 10;
            int y = 10;


        }
    }
}