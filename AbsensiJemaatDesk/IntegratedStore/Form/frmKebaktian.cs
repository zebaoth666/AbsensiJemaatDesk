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
    public partial class frmKebaktian : Form
    {
        kebaktianClass pd;
        umatClass umat;
        private String headerId = string.Empty;
        private String statusPD = string.Empty;
        private Boolean editMode = false;
        private DataTable dt;
        private DataView dv;
        private DataRow dr;
        private DataGridViewCheckBoxCell cb;

        public frmKebaktian()
        {
            InitializeComponent();
        }

        private void frmKebaktian_Load(object sender, EventArgs e)
        {
            pd = new kebaktianClass();
            umat = new umatClass();
            dv = new DataView();

            LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
            this.VisibleChanged += new EventHandler(this.frmKebaktian_VisibleChanged);
            this.dgvUmat.CellEndEdit += new DataGridViewCellEventHandler(this.dgvUmat_CellEndEdit);
            this.txtCari.TextChanged += new EventHandler(this.txtCari_TextChanged);

            getData();
        }

        private void frmKebaktian_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                LblMenu.Text = "PERSEKUTUAN DOA " + DateTime.Now.ToString("dd-MM-yyyy");

                statusPD = pd.checkService();
                switch (statusPD) {
                    case "NEW":
                        pd.getMaxNo();
                        break;
                    case "EDIT":
                        headerId = pd.getHeaderId();
                        txtPewarta.Text = pd.getPewarta();
                        txtTema.Text = pd.getTitle();
                        break;
                    case "ERR":
                        pnlTitle.Enabled = false;
                        pnlBody.Enabled = false;
                        btnUbah.Enabled = false;
                        btnBaru.Enabled = false;
                        iMessage.erBoxOk("Terjadi kesalahan sistem. Silakan hubungi Administrator Anda");
                        break;
                }
            }
        }

        private void dgvUmat_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (dgvUmat.Rows.Count > 0)
            {
                cb = (DataGridViewCheckBoxCell)dgvUmat.CurrentRow.Cells[0];
                if (cb != null && (bool)cb.Value == true) { iMessage.iBoxOk(dgvUmat.CurrentRow.Cells[0].Value.ToString()); }

                if (dgvUmat.CurrentRow.Cells[0].Value.Equals(true) && (String)dgvUmat.CurrentRow.Cells[0].Value == null)
                {

                }

            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e) {
          //  refresh(txtCari.Text);
            DataRow drow = dgvUmat.Select();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
     
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

                btnUbah.Text = "Batal";
                editMode = true;
            }
            else {
                pnlTitle.Enabled = false;
                pnlBody.Enabled = true;

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
                    if (statusPD == "NEW")
                    {
                        
                        if (pd.saveHeader(getMaxNo(), txtPewarta.Text.Trim(), txtTema.Text.Trim()) == true)
                        {
                            statusPD = "EDIT";
                            iMessage.iBoxOk("Data berhasil disimpan");
                        }
                        else
                        {
                            iMessage.iBoxOk("Data gagal disimpan");
                        }
                    }
                    else
                    {
                        if (pd.editHeader(headerId, txtTema.Text.Trim(), txtPewarta.Text.Trim()) == true){
                            iMessage.iBoxOk("Data berhasil diubah");
                        }
                        else
                        {
                            iMessage.iBoxOk("Data gagal diubah");
                        }
                    }
                }

                pnlTitle.Enabled = false;
                pnlBody.Enabled = true;

                btnUbah.Text = "Ubah";
                editMode = false;
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////                                          Function                                         //////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private String getMaxNo() {
            string maxNo = string.Empty;
            int value = pd.getNextNo();

            if (value==0)
            {
                maxNo = "S" + DateTime.Now.ToString("yy") + "001";
            }
            else {
                string str =Convert.ToString(pd.getNextNo());

                while (str.Length != 3)
                {
                    str = "0" + str;
                }

                maxNo ="S" + DateTime.Now.ToString("yy") + str;
            }

            return maxNo;
        }

        private void refresh(String cari)
        {
            dv = dt.DefaultView;
            dv.RowFilter = "UMAT_COMP_NAME LIKE '%" + cari + "%'";
            dv.Sort = "UMAT_COMP_NAME";

            if (dgvUmat != null)
                dgvUmat.DataSource = null; dgvUmat.Rows.Clear();

            dgvUmat.DataSource = dv;
            dgvUmat.Columns["colHadir"].DisplayIndex = dt.Columns.Count;

            //dgvUmat.Columns[0].Visible = false;
            dgvUmat.Columns[1].Visible = false;
            dgvUmat.Columns[2].HeaderText = "Nama Lengkap";
            dgvUmat.Columns[3].HeaderText = "Nama Panggilan";
            dgvUmat.Columns[4].Visible = false;
            dgvUmat.Columns[5].HeaderText = "No Hp";
            dgvUmat.Columns[6].HeaderText = "Tempat Lahir";
            dgvUmat.Columns[7].HeaderText = "Tanggal Lahir";
            dgvUmat.Columns[8].HeaderText = "Jenis Kelamin";
            dgvUmat.Columns[9].Visible = false;
            dgvUmat.Columns[10].Visible = false;
            dgvUmat.Columns[11].Visible = false;
            dgvUmat.Columns[12].Visible = false;
            dgvUmat.Columns[13].Visible = false;
            dgvUmat.Columns[14].Visible = false;
            dgvUmat.Columns[15].Visible = false;
            dgvUmat.Columns[16].Visible = false;

            for (int a = 1; a < dgvUmat.Columns.Count-1; a++) {
                dgvUmat.Columns[a].ReadOnly = true;
            }
        }

        private void getData()
        {
            if (dt != null)
                dt.Clear();

            dt = umat.getUmats();
            dt.Columns.Add("dtHadir", typeof(System.String));
            refresh(txtCari.Text);
        }
    }
}