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
    public partial class frmKoneksi : Form
    {
        connClass conn;
        private bool init;

        public frmKoneksi(bool init)
        {
            InitializeComponent();
            this.init = init;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            if (init == true)
            {
                Application.Exit();
            }
            else 
                this.Dispose();        
        }

        private void btnTes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServer.Text))
            {
                iMessage.eBoxOk("Silakan isi data server");
                txtServer.Focus();
            }
            else if (string.IsNullOrEmpty(txtPort.Text))
            {
                iMessage.eBoxOk("Silakan isi data port");
                txtPort.Focus();
            }
            else if (string.IsNullOrEmpty(txtUser.Text))
            {
                iMessage.eBoxOk("Silakan isi data user");
                txtUser.Focus();
            }
            else {
                if (string.IsNullOrEmpty(txtPassword.Text)) { txtPassword.Text = ""; };
                
                conn = new connClass();
                if (conn.testConn())
                {
                    BindingSource bs = new BindingSource();
                  //  bs.DataSource = conn.dbList();
                  //  cmbDatabase.DataSource = bs;

                    cmbDatabase.Enabled = true;
                    disableControl();
                }
                else {
                    iMessage.eBoxOk("Konfigurasi database salah");
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            
        }

        private void frmKoneksi_Load(object sender, EventArgs e)
        {

        }

        //------------------------------------function-----------------------------------------

        private void disableControl() { 
            this.txtServer.Enabled=false;
            this.txtPort.Enabled = false;
            this.txtUser.Enabled = false;
            this.txtPassword.Enabled = false;
            this.btnSimpan.Enabled = true;
        }
    }
}