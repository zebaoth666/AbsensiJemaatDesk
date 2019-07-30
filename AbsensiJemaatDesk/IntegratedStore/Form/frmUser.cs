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
    public partial class frmUser : Form
    {
        userClass user;
        private Boolean editMode = false;
        private String currId = string.Empty;
        private DataTable dt;
        private DataView dv;

        public frmUser()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////                                          Event                                            //////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void frmUser_Load(object sender, EventArgs e)
        {
            user = new userClass(AbsensiJemaatDesk.Properties.Settings.Default.userId,
                                        AbsensiJemaatDesk.Properties.Settings.Default.userName,
                                        null);

            this.VisibleChanged += new EventHandler(this.frmUser_VisibleChanged);
            this.KeyDown += new KeyEventHandler(this.frmUser_KeyDown);
            this.dgvUsers.SelectionChanged += new EventHandler(dgvUsers_SelectionChanged);
            this.txtCari.TextChanged += new EventHandler(txtCari_TextChanged);

            LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
            getData();
        }

        private void frmUser_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                disableControl();
                txtCari.Text = string.Empty;
            }
        }

        private void frmUser_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F1) {
            }

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
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.RowCount > 0)
            {
                bindControls();
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            AbsensiJemaatDesk.Properties.Settings.Default.mdiParent = false;

            this.Parent = null;
            this.Visible=false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            enableControl();
            lblIdUser.Text = "0";
            txtNamaUser.Text = string.Empty;
            txtNamaUser.Focus();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvUsers.RowCount > 0)
            {
                enableControl();
                editMode = true;
                txtNamaUser.Focus();
            }
            else iMessage.iBoxOk("Tidak ada data untuk diubah");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaUser.Text))
            {
                iMessage.iBoxOk("Harap isi nama user");
            }
            else
            {
                DialogResult result = iMessage.quBoxCon("Simpan data?");
                if (result == DialogResult.Yes)
                {
                    if (editMode == false)
                    {
                        currId = getMaxNo();
                        if (user.saveUser(getMaxNo(), txtNamaUser.Text.Trim()) == true)
                        {
                            iMessage.iBoxOk("Data berhasil disimpan");
                        }
                        else
                            iMessage.iBoxOk("Data gagal disimpan");
                    }
                    else
                    {
                        currId = lblIdUser.Text;
                        if (user.editUser(lblIdUser.Text, txtNamaUser.Text.Trim()) == true)
                        {
                            editMode = false;
                            iMessage.iBoxOk("Data berhasil diperbarui");
                        }
                        else
                            iMessage.iBoxOk("Data gagal diperbarui");
                    }

                    disableControl();
                    getData();
                    dgvUsers.Focus();

                    for (int a = 0; a <= dgvUsers.Rows.Count - 1; a++)
                    {
                        if (dgvUsers.Rows[a].Cells[1].Value.ToString() == currId)
                        {
                            dgvUsers.CurrentCell = dgvUsers.Rows[a].Cells[2];
                            bindControls();
                        }
                    }
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvUsers.RowCount > 0) {
                if (dgvUsers.CurrentRow.Cells[4].Value.ToString() == "1")
                {
                    DialogResult result = iMessage.quBoxCon("Hapus Data?");

                    if (result == DialogResult.Yes)
                    {
                        if (user.deleteUser(lblIdUser.Text) == true)
                        {
                            iMessage.iBoxOk("Data berhasil dihapus");
                        }
                        else
                        {
                            iMessage.iBoxOk("Data gagal dihapus");
                        };

                        disableControl();
                        getData();
                        dgvUsers.Focus();
                    }
                }
                else
                    iMessage.iBoxOk("Data sudah dihapus");
            }else iMessage.iBoxOk("Tidak ada data untuk dihapus");
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            refresh(txtCari.Text);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            disableControl();
            bindControls();
            dgvUsers.Focus();
            editMode = false;
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

            if (dgvUsers.Rows.Count > 0)
            {
                int lastVal = dt.Rows.Count + 1;
                maxNo = Convert.ToString(lastVal);

                while (maxNo.Length != 3)
                {
                    maxNo = "0" + maxNo;
                }
            }
            else
                maxNo = "001";

            return maxNo;
        }

        private void refresh(String cari)
        {
            dv = dt.DefaultView;
            dv.RowFilter = "USER_NAME LIKE '%" + cari + "%' AND USER_OPEN_FLAG='1'";

            if (dgvUsers != null)
                dgvUsers.DataSource = null; dgvUsers.Rows.Clear();

            dgvUsers.DataSource = dv;

            for (int a = 0; a < dgvUsers.Columns.Count; a++)
            {
                if (a != 2)
                {
                    dgvUsers.Columns[a].Visible = false;
                }
                else
                dgvUsers.Columns[a].ReadOnly = true; dgvUsers.Columns[a].HeaderText = "NAMA USER";
            }

            if (dgvUsers.Rows.Count > 0)
                dgvUsers.CurrentCell = dgvUsers.Rows[0].Cells[2];
        }

        private void getData()
        {
            if (dt != null)
                dt.Clear();

            dt = user.getUsers();
            refresh(txtCari.Text);
        }

        private void bindControls()
        {
            if (dgvUsers.Rows.Count > 0)
            {
                lblIdUser.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
                txtNamaUser.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();

            }
            else
            {
                lblIdUser.Text = "0";
                txtNamaUser.Text = string.Empty;
            }
        }       
    }
}