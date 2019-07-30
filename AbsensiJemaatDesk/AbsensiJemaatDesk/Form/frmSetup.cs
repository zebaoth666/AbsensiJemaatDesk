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
    public partial class frmSetup : Form
    {
        connClass conn;

        public frmSetup()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
          
        }

        private void frmKoneksi_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image = new Bitmap(ofd.FileName);
                picLogo.SizeMode = PictureBoxSizeMode.Zoom;
                ofd.Dispose();
            }
            else {
                ofd.Dispose();
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////                                           Function                                        //////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void disableControl() { 
            this.txtNama.Enabled=false;
            this.txtTelp1.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtLogo.Enabled = false;
            this.btnSimpan.Enabled = true;
        }
    }
}