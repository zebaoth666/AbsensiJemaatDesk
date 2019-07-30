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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Parent = Parent;
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamaUser.Text))
            {
                iMessage.eBoxOk("Silakan isi user Anda.");
            }
            else if (string.IsNullOrEmpty(txtPassUser.Text))
            {
                iMessage.eBoxOk("Silakan isi password Anda.");
            }
            else
            {
                userClass user = new userClass("", txtNamaUser.Text, encryptClass.Encrypt2("S@lv4tion", txtPassUser.Text));

                switch (user.validateUser())
                {
                    case -1:
                        iMessage.iBoxOk("Terjadi kesalahan sistem." + Environment.NewLine + "Harap hubungi Adminstrator Anda.");
                        break;
                    case 0:
                        iMessage.iBoxOk("Nama user atau password Anda salah.");
                        break;
                    case 1:
                        this.Dispose();
                        break;
                    default:
                        break;
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panelHeader.BackColor = ColorTranslator.FromHtml("#58D3F7");
        }
    }
}
