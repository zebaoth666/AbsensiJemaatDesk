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
    public partial class frmPD : Form
    {
        pdClass pd;
        private String headerId = string.Empty;
        private String statusPD = string.Empty;
        private Boolean editMode = false;
        private DataTable dt;
        private DataView dv;
        private DataRow dr;
        private DataGridViewCheckBoxCell cb;
        private String hadir = "0";

        public frmPD()
        {
            InitializeComponent();
        }

        private void frmKebaktian_Load(object sender, EventArgs e)
        {
            pd = new pdClass();
            dt = new DataTable();
            dv = new DataView();

            LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
            this.VisibleChanged += new EventHandler(this.frmKebaktian_VisibleChanged);
            this.dgvUmat.CurrentCellDirtyStateChanged += new EventHandler(this.dgvUmat_CurrentCellDirtyStateChanged);
            this.txtCari.TextChanged += new EventHandler(this.txtCari_TextChanged);

            initiateDT();
        }

        private void frmKebaktian_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                LblMenu.Text = "PERSEKUTUAN DOA " + DateTime.Now.ToString("dd-MM-yyyy");

                if (pd.checkService() == "GOOD")
                {
                    headerId = pd.getHeaderId();
                    txtPewarta.Text = pd.getPewarta();
                    txtTema.Text = pd.getTitle();

                    getData();
                }
                else {
                    pnlTitle.Enabled = false;
                    pnlBody.Enabled = false;
                    btnUbah.Enabled = false;
                    btnBaru.Enabled = false;
                    iMessage.erBoxOk("Terjadi kesalahan sistem. Silakan hubungi Administrator Anda");
                }
            }
        }

        private void dgvUmat_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (dgvUmat.Rows.Count > 0)
            {
                if (dgvUmat.CurrentRow.Cells[9].Value.Equals(true))
                {
                    hadir = "1";
                }
                else
                {
                    hadir = "0";
                }

                pd.editLines(dgvUmat.CurrentRow.Cells[0].Value.ToString(), hadir);
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e) {
            refresh(txtCari.Text);
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            frmNewUmat newUmat = new frmNewUmat(headerId, dt.Rows[dt.Rows.Count - 1][2].ToString());
            newUmat.ShowDialog();

            getData();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            AbsensiJemaatDesk.Properties.Settings.Default.mdiParent = false;

            this.Parent = null;
            this.Visible = false;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (editMode == false)
            {
                pnlTitle.Enabled = true;
                pnlBody.Enabled = false;
                btnBaru.Enabled = false;
                btnTutup.Enabled = false;

                btnUbah.Text = "Batal";
                editMode = true;
            }
            else {
                pnlTitle.Enabled = false;
                pnlBody.Enabled = true;
                btnBaru.Enabled = true;
                btnTutup.Enabled = true;

                btnUbah.Text = "Ubah";
                editMode = false;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPewarta.Text) || String.IsNullOrWhiteSpace(txtTema.Text))
            {
                iMessage.iBoxOk("Harap mengisi data pewarta dan tema");
            }
            else {
                DialogResult result = iMessage.quBoxCon("Simpan Data?");

                if (result == DialogResult.Yes) {
                    if (pd.editHeader(headerId, txtTema.Text.Trim(), txtPewarta.Text.Trim()) == true)
                    {
                        iMessage.iBoxOk("Data berhasil diubah");
                    }
                    else
                    {
                        iMessage.iBoxOk("Data gagal diubah");
                    }   
                }

                pnlTitle.Enabled = false;
                pnlBody.Enabled = true;
                btnBaru.Enabled = true;
                btnTutup.Enabled = true;

                btnUbah.Text = "Ubah";
                editMode = false;
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////                                          Function                                         //////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void refresh(String cari)
        {
            dv = dt.DefaultView;
            dv.RowFilter = "PD_UMAT_COMP_NAME LIKE '%" + cari + "%'";
            dv.Sort = "PD_UMAT_COMP_NAME";

            if (dgvUmat != null)
                dgvUmat.DataSource = null; dgvUmat.Rows.Clear();

            dgvUmat.DataSource = dv;

            dgvUmat.Columns[0].Visible = false;
            dgvUmat.Columns[1].Visible = false;
            dgvUmat.Columns[2].Visible = false;
            dgvUmat.Columns[3].HeaderText = "Nama Lengkap";
            dgvUmat.Columns[4].HeaderText = "Nama Panggilan";
            dgvUmat.Columns[5].HeaderText = "No Hp";
            dgvUmat.Columns[6].HeaderText = "Tempat Lahir";
            dgvUmat.Columns[7].HeaderText = "Tanggal Lahir";
            dgvUmat.Columns[8].HeaderText = "Jenis Kelamin";
            dgvUmat.Columns[9].HeaderText = "Hadir";

            for (int a = 1; a < dgvUmat.Columns.Count-1; a++) {
                dgvUmat.Columns[a].ReadOnly = true;
            }
        }

        private void getData()
        {
            if (dt != null)
                dt.Clear();

            pd.getUmats(headerId, dt);

            refresh(txtCari.Text);
        }

        public void initiateDT()
        {
            dt.Columns.Add("pd_line_id", typeof(string));
            dt.Columns.Add("pd_header_id", typeof(string));
            dt.Columns.Add("pd_umat_id", typeof(string));
            dt.Columns.Add("pd_umat_comp_name", typeof(string));
            dt.Columns.Add("pd_umat_alias_name", typeof(string));
            dt.Columns.Add("pd_umat_phone", typeof(string));
            dt.Columns.Add("pd_umat_born_place", typeof(string));
            dt.Columns.Add("pd_umat_born_date", typeof(DateTime));
            dt.Columns.Add("pd_umat_sex", typeof(string));
            dt.Columns.Add("pd_present_flag", typeof(bool));      //9
        }
    }
}