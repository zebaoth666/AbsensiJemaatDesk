using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiJemaatDesk
{
    public partial class frmUmat : Form
    {
        umatClass umat;
        private Boolean editMode = false;
        private String currId = string.Empty;
        private DataTable dt;
        private DataView dv;

        public frmUmat()
        {
            InitializeComponent();
        }

        private void frmUmat_Load(object sender, EventArgs e)
        {
            umat = new umatClass();
            
            this.VisibleChanged += new EventHandler(this.frmUmat_VisibleChanged);
            this.KeyDown += new KeyEventHandler(this.frmUmat_KeyDown);
            this.dgvUmat.SelectionChanged += new EventHandler(dgvUmat_SelectionChanged);
            this.txtCari.TextChanged += new EventHandler(txtCari_TextChanged);

            LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
        }

        private void frmUmat_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                disableControl();
                txtCari.Text = string.Empty;
                getData();
            }
        }

        private void frmUmat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
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
            }
        }

        private void dgvUmat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUmat.RowCount > 0)
            {
                bindControls();
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            AbsensiJemaatDesk.Properties.Settings.Default.mdiParent = false;

            this.Parent = null;
            this.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            enableControl();
            lblId.Text = "0";
            txtNama.Focus();

            lblId.Text = "0";
            txtNama.Text = string.Empty;
            txtAlias.Text = string.Empty;
            txtAlamat.Text = string.Empty;
            txtHp.Text = string.Empty;
            txTempat.Text = string.Empty;
            dtLahirJemaat.Value = DateTime.Now;
            txtParoki.Text = string.Empty;
            txtLingkungan.Text = string.Empty;
            rdPria.Checked = true;
            txtTlpRmh.Text = string.Empty;
            cmbAgama.Text = string.Empty;
            txtSibuk.Text = string.Empty;
            txtKomunitas.Text = string.Empty;
            rdSingle.Checked = true;
            txtSosMed.Text = string.Empty;
            cmbSosMed.Text = string.Empty;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvUmat.RowCount > 0)
            {
                enableControl();
                editMode = true;
                txtNama.Focus();
            }
            else iMessage.iBoxOk("Tidak ada data untuk diubah");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                iMessage.iBoxOk("Harap isi nama umat");
            }
            else
            {
                DialogResult result = iMessage.quBoxCon("Simpan data?");
                if (result == DialogResult.Yes)
                {
                    String sex = String.Empty;
                    String status = String.Empty;
                    if (rdPria.Checked)
                    {
                        sex = "P";
                    }
                    else sex = "W";

                    if (rdSingle.Checked) {
                        status = "Single";
                    } else status = "Married";

                    if (editMode == false)
                    {
                        currId = getMaxNo();
                        if (umat.saveUmat(getMaxNo(), txtNama.Text.Trim(), txtAlias.Text.Trim(), txtAlamat.Text.Trim(),
                                            txtHp.Text.Trim(), txTempat.Text.Trim(), dtLahirJemaat.Value.ToShortDateString(),
                                            sex, txtParoki.Text.Trim(), txtLingkungan.Text.Trim(), txtTlpRmh.Text.Trim(), 
                                            status, cmbAgama.Text, txtSibuk.Text.Trim(), txtKomunitas.Text.Trim(), 
                                            cmbSosMed.Text, txtSosMed.Text.Trim()) == true)
                        {
                            iMessage.iBoxOk("Data berhasil disimpan");
                        }
                        else
                            iMessage.iBoxOk("Data gagal disimpan");
                    }
                    else
                    {
                        currId = lblId.Text;
                        if (umat.editUmat(currId, txtNama.Text.Trim(), txtAlias.Text.Trim(), txtAlamat.Text.Trim(),
                                            txtHp.Text.Trim(), txTempat.Text.Trim(), dtLahirJemaat.Value.ToShortDateString(),
                                            sex, txtParoki.Text.Trim(), txtLingkungan.Text.Trim(), txtTlpRmh.Text.Trim(),
                                            status, cmbAgama.Text, txtSibuk.Text.Trim(), txtKomunitas.Text.Trim(),
                                            cmbSosMed.Text, txtSosMed.Text.Trim()) == true)
                        {
                            editMode = false;
                            iMessage.iBoxOk("Data berhasil diperbarui");
                        }
                        else
                            iMessage.iBoxOk("Data gagal diperbarui");
                    }

                    disableControl();
                    getData();
                    dgvUmat.Focus();

                    for (int a = 0; a <= dgvUmat.Rows.Count - 1; a++)
                    {
                        if (dgvUmat.Rows[a].Cells[1].Value.ToString() == currId)
                        {
                            dgvUmat.CurrentCell = dgvUmat.Rows[a].Cells[2];
                            bindControls();
                        }
                    }
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvUmat.RowCount > 0) {
                if (dgvUmat.CurrentRow.Cells[18].Value.ToString() == "1")
                {
                    DialogResult result = iMessage.quBoxCon("Hapus Data?");

                    if (result == DialogResult.Yes)
                    {
                        if (umat.deleteUmat(lblId.Text) == true)
                        {
                            iMessage.iBoxOk("Data berhasil dihapus");
                        }
                        else
                        {
                            iMessage.iBoxOk("Data gagal dihapus");
                        };

                        disableControl();
                        getData();
                        dgvUmat.Focus();
                    }
                }
                else
                    iMessage.iBoxOk("Data sudah dihapus");
            }else iMessage.iBoxOk("Tidak ada data untuk dihapus");
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            disableControl();
            bindControls();
            dgvUmat.Focus();
            editMode = false;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
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

            pnlList.Enabled = false;
            pnlDetail.Enabled = true;
        }

        private String getMaxNo()
        {
            string maxNo = "";

            if (dgvUmat.Rows.Count > 0)
            {
                int lastVal = Convert.ToInt16(umat.nextId().Substring(2)) + 1;
                maxNo = Convert.ToString(lastVal);

                while (maxNo.Length != 4)
                {
                    maxNo = "0" + maxNo;
                }

                maxNo = "U" + maxNo;
            }
            else
                maxNo = "U0001";

            return maxNo;
        }

        private void refresh(String cari)
        {
            dv = dt.DefaultView;
            dv.RowFilter = "(UMAT_COMP_NAME LIKE '%" + cari + "%' OR UMAT_ALIAS_NAME LIKE '%" + cari + "%') AND" + 
                            " UMAT_OPEN_FLAG='1'";

            if (dgvUmat != null)
                dgvUmat.DataSource = null; dgvUmat.Rows.Clear();

            dgvUmat.DataSource = dv;

            for (int a = 0; a < dgvUmat.Columns.Count; a++)
            {
                if (a != 2)
                {
                    dgvUmat.Columns[a].Visible = false;
                }
                else
                    dgvUmat.Columns[a].ReadOnly = true; dgvUmat.Columns[a].HeaderText = "NAMA UMAT";
            }

            if (dgvUmat.Rows.Count > 0)
                dgvUmat.CurrentCell = dgvUmat.Rows[0].Cells[2];
        }

        private void getData()
        {
            if (dt != null)
                dt.Clear();

            dt = umat.getUmats();
            refresh(txtCari.Text);
        }

        private void bindControls()
        {
            if (dgvUmat.Rows.Count > 0)
            {
                lblId.Text = dgvUmat.CurrentRow.Cells[1].Value.ToString();
                txtNama.Text = dgvUmat.CurrentRow.Cells[2].Value.ToString();
                txtAlias.Text = dgvUmat.CurrentRow.Cells[3].Value.ToString();
                txtAlamat.Text = dgvUmat.CurrentRow.Cells[4].Value.ToString();
                txtTlpRmh.Text = dgvUmat.CurrentRow.Cells[5].Value.ToString();
                txtHp.Text = dgvUmat.CurrentRow.Cells[6].Value.ToString();
                txTempat.Text = dgvUmat.CurrentRow.Cells[7].Value.ToString();
                dtLahirJemaat.Value = DateTime.Parse(dgvUmat.CurrentRow.Cells[8].Value.ToString());
                cmbAgama.Text = dgvUmat.CurrentRow.Cells[11].Value.ToString();
                txtSibuk.Text = dgvUmat.CurrentRow.Cells[12].Value.ToString();
                txtKomunitas.Text = dgvUmat.CurrentRow.Cells[13].Value.ToString();
                txtParoki.Text = dgvUmat.CurrentRow.Cells[14].Value.ToString();
                txtLingkungan.Text = dgvUmat.CurrentRow.Cells[15].Value.ToString();
                cmbSosMed.Text = dgvUmat.CurrentRow.Cells[16].Value.ToString();
                txtSosMed.Text = dgvUmat.CurrentRow.Cells[17].Value.ToString();

                if (dgvUmat.CurrentRow.Cells[9].Value.ToString() == "P")
                {
                    rdPria.Checked=true;
                }
                else rdWanita.Checked=true;

                if (dgvUmat.CurrentRow.Cells[10].Value.ToString() == "Single")
                {
                    rdSingle.Checked = true;
                }
                else rdNikah.Checked = true;
            }
            else
            {
                lblId.Text = "0";
                txtNama.Text = string.Empty;
                txtAlias.Text = string.Empty;
                txtAlamat.Text = string.Empty;
                txtHp.Text = string.Empty;
                txTempat.Text = string.Empty;
                dtLahirJemaat.Value = DateTime.Now;
                txtParoki.Text = string.Empty;
                txtLingkungan.Text = string.Empty;
                rdPria.Checked = true;
            }
        }
    }
}