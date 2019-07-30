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
        //userClass user;

        public frmKebaktian()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            //user = new userClass(AbsensiJemaatDesk.Properties.Settings.Default.userId,
            //                            AbsensiJemaatDesk.Properties.Settings.Default.userName,
            //                            null);


            //LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
            ////refresh();

            //dgvUsers.Rows.Add();
            //dgvUsers[0, 0].Value = "ADMINISTRATOR";
            LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
        }

        //private void btnTutup_Click(object sender, EventArgs e)
        //{
        //    this.FormClosing += new FormClosingEventHandler(this.frmUser_FormClosing);
        //    this.Close();
        //}

        ////Event
        //private void frmUser_FormClosing(object sender, FormClosingEventArgs e) {
        //    e.Cancel = true;
        //    this.Hide();
        //    this.Parent = null;
        //}

        ////function
        //private void disableControl()
        //{
        //    btnTambah.Enabled = true;
        //    btnUbah.Enabled = true;
        //    btnHapus.Enabled = true;
        //    btnSimpan.Enabled = false;
        //    btnBatal.Enabled = false;
        //    btnTutup.Enabled = true;

        //    pnlList.Enabled = true;
        //    pnlDetail.Enabled = false;
        //}

        //private void enableControl()
        //{
        //    btnTambah.Enabled = false;
        //    btnUbah.Enabled = false;
        //    btnHapus.Enabled = false;
        //    btnSimpan.Enabled = true;
        //    btnBatal.Enabled = true;
        //    btnTutup.Enabled = false;

        //    pnlList.Enabled = false;
        //    pnlDetail.Enabled = true;
        //}

        //private void refresh()
        //{
        //    disableControl();

        //    dgvUsers.Rows.Clear();
        //    dgvUsers.DataSource = user.getUsers();
        //    for (int a = 0; a < dgvUsers.Columns.Count; a++)
        //    {
        //        if (a != 1)
        //        {
        //            dgvUsers.Columns[a].Visible = false;
        //        }
        //        else
        //            dgvUsers.Columns[a].ReadOnly = true; dgvUsers.Columns[a].HeaderText = "NAMA USER";
        //    }
        //}

        //private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
