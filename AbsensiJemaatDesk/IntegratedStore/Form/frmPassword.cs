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
    public partial class frmPassword : Form
    {
        userClass user;
        private string decpass;

        public frmPassword()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////                                          Event                                            //////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void frmPassword_Load(object sender, EventArgs e)
        {
            user = new userClass(AbsensiJemaatDesk.Properties.Settings.Default.userId,
                                        AbsensiJemaatDesk.Properties.Settings.Default.userName,
                                        null);

            this.KeyDown += new KeyEventHandler(this.frmPassword_KeyDown);
            this.txtNewPass.TextChanged += new EventHandler(txtNewPass_TextChanged);

            LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
        }

        private void frmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4:
                    btnSimpan.PerformClick();
                    break;
                case Keys.Escape:
                    btnTutup.PerformClick();
                    break;
            }
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Length < 4)
            {
                lblStatus.Text = "Lemah";
                lblStatus.ForeColor = Color.Red;
            }
            else if (txtNewPass.Text.Length > 4 || txtNewPass.Text.Length < 8)
            {
                lblStatus.Text = "Cukup";
                lblStatus.ForeColor = Color.Yellow;
            }
            else if (txtNewPass.Text.Length > 8)
            {
                lblStatus.Text = "Kuat";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            decpass = encryptClass.Decrypt2("S@lv4tion", AbsensiJemaatDesk.Properties.Settings.Default.userPass);

            if (string.IsNullOrWhiteSpace(txtOldPass.Text))
            {
                iMessage.iBoxOk("Harap isi kata kunci lama");
            }
            else if (string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                iMessage.iBoxOk("Harap isi kata kunci baru beserta konfirmasinya");
            }
            else if (txtNewPass.Text.Trim() != txtConfirm.Text.Trim())
            {
                iMessage.iBoxOk("Kata kunci baru tidak sama dengan konfirmasi");
            }
            else if (txtOldPass.Text != decpass)
            {
                iMessage.iBoxOk("Kata kunci lama tidak sama");
            }
            else {
                DialogResult result = iMessage.quBoxCon("Simpan data?");
                if (result == DialogResult.Yes)
                {   
                    string newPass = encryptClass.Encrypt2("S@lv4tion", txtNewPass.Text);
                    if (user.changePass(AbsensiJemaatDesk.Properties.Settings.Default.userId, newPass) == true)
                    {
                        iMessage.iBoxOk("kata kunci berhasil diubah");
                        Application.Restart();
                    }
                    else {
                        iMessage.iBoxOk("kata kunci gagal diubah");
                    };
                }
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}