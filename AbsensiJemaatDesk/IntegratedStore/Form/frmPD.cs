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
        private Boolean headerSave = false;
        private Double pdTotal = 0;
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
            LblMenu.Text = "PERSEKUTUAN DOA";

            LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
            this.VisibleChanged += new EventHandler(this.frmKebaktian_VisibleChanged);
            this.dgvUmat.CurrentCellDirtyStateChanged += new EventHandler(this.dgvUmat_CurrentCellDirtyStateChanged);
            this.txtCari.TextChanged += new EventHandler(this.txtCari_TextChanged);
            this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectionIndexChanged);
            this.dtKebaktian.LostFocus += new EventHandler(this.dtKebaktian_LostFocus);

            initiateDT();
        }

        private void frmKebaktian_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                dtKebaktian.Value = DateTime.Now;
                txtPewarta.Text = string.Empty;
                txtTema.Text = string.Empty;
                dt.Clear();

                headerId = string.Empty;
                statusPD = string.Empty;
                editMode = false;
                headerSave = false;

                dtKebaktian.Enabled = true;
                dtKebaktian.Focus();
            }
        }

        private void tabControl1_SelectionIndexChanged(object sender, EventArgs e) {
            if (headerSave == false && tabControl1.SelectedIndex == 1) {
                tabControl1.SelectedIndex = 0;
            }
        }

        private void dtKebaktian_LostFocus(object sender, EventArgs e) {
            if (pd.checkService(dtKebaktian.Value.Year.ToString(), dtKebaktian.Value.Month.ToString(), dtKebaktian.Value.Day.ToString()) == "EDIT")
            {
                editMode = true;
                headerId = pd.getHeaderId();
                txtPewarta.Text = pd.getPewarta();
                txtTema.Text = pd.getTitle();

                getData();
            }
            else if (pd.checkService(dtKebaktian.Value.Year.ToString(), dtKebaktian.Value.Month.ToString(), dtKebaktian.Value.Day.ToString()) == "NEW")
            {
                editMode = false;
                txtPewarta.Text = string.Empty;
                txtTema.Text = string.Empty;
                dt.Clear();
                dgvUmat.DataSource = null;
                dgvUmat.Rows.Clear();
            }
            else
            {
                btnSimpan.Enabled = false;
                iMessage.erBoxOk("Terjadi kesalahan sistem. Silakan hubungi Administrator Anda");
            }
            dtKebaktian.Enabled = false;
        }

        private void dgvUmat_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (dgvUmat.Rows.Count > 0)
            {
                if (dgvUmat.IsCurrentCellDirty == false) {
                    if (dgvUmat.CurrentRow.Cells[9].Value.Equals(true))
                    {
                        hadir = "1";
                        pdTotal = pdTotal + 1;
                    }
                    else
                    {
                        hadir = "0";
                        pdTotal = pdTotal - 1;
                    }

                    lbltotal.Text = "Total Jemaat : " + Convert.ToString(pdTotal);
                    pd.editLines(dgvUmat.CurrentRow.Cells[0].Value.ToString(), hadir);
                }
            }
        }
        
        private void txtCari_TextChanged(object sender, EventArgs e) {
            refresh(txtCari.Text);
        }

        private void btnUmatBaru_Click(object sender, EventArgs e)
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPewarta.Text) || String.IsNullOrWhiteSpace(txtTema.Text))
            {
                iMessage.iBoxOk("Harap mengisi data pewarta dan tema");
            }
            else {
                DialogResult result = iMessage.quBoxCon("Simpan Data?");

                if (result == DialogResult.Yes) {
                    if (editMode == true)
                    {
                        if (pd.editHeader(dtKebaktian.Value.ToString("yyyyMMdd"), txtTema.Text.Trim(), txtPewarta.Text.Trim()) == true)
                        {
                            headerSave = true;
                            tabControl1.SelectedIndex = 1;
                        }
                        else
                        {
                            iMessage.iBoxOk("Data gagal diubah");
                        }
                    }
                    else {
                        if (pd.savePD(dtKebaktian.Value.ToString("yyyyMMdd"), dtKebaktian.Value.ToShortDateString(),
                                txtTema.Text.Trim(), txtPewarta.Text.Trim()) == true)
                        {
                            getData();
                            headerSave = true;
                            tabControl1.SelectedIndex = 1;
                        }
                        else {
                            iMessage.iBoxOk("Data gagal disimpan");
                        }
                    }

                    pdTotal = pd.getTotal();
                    lbltotal.Text = "Total Jemaat : " + Convert.ToString(pdTotal);
                }
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

            pd.getUmats(pd.getHeaderId(), dt);

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