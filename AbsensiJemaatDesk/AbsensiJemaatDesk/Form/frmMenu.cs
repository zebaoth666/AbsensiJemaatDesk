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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void tutupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //panelHeader.BackColor = ColorTranslator.FromHtml("#58D3F7");

            if (xmlClass.detectXml())
            {
                xmlClass.readXml();

                tsServer.Text = "Server: " + AbsensiJemaatDesk.Properties.Settings.Default.server;
                tsDB.Text = "Database: " + AbsensiJemaatDesk.Properties.Settings.Default.db;

                instanceClass.log.ShowDialog();
            }
            else
            {
                //frmKoneksi konek = new frmKoneksi(true);
                instanceClass.konek.ShowDialog();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instanceClass.user.MdiParent = this;
            instanceClass.user.Dock = DockStyle.Fill;
            instanceClass.user.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsDate.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
            tsUser.Text = "User: " + AbsensiJemaatDesk.Properties.Settings.Default.userName;
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kategoriBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void setupPTTokoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instanceClass.setup.ShowDialog();
        }

        private void dataMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instanceClass.jem.MdiParent = this;
            instanceClass.jem.Dock = DockStyle.Fill;
            instanceClass.jem.Visible = true;
        }

        private void kebaktianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instanceClass.bakti.MdiParent = this;
            instanceClass.bakti.Dock = DockStyle.Fill;
            instanceClass.bakti.Visible = true;
        }
    }
}