using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace AbsensiJemaatDesk
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tutupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            connClass conn = new connClass();

            if (conn.testConn())
            {

                instanceClass.log.ShowDialog();
            }
            else {
                iMessage.iBoxOk("Terjadi kesalahan sistem." + Environment.NewLine + "Harap hubungi Adminstrator Anda.");
                Application.Exit();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AbsensiJemaatDesk.Properties.Settings.Default.mdiParent == false) {
                instanceClass.user.MdiParent = this;
                instanceClass.user.Dock = DockStyle.Fill;
                instanceClass.user.Visible = true;

                AbsensiJemaatDesk.Properties.Settings.Default.mdiParent = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsDate.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
            tsUser.Text = "User: " + AbsensiJemaatDesk.Properties.Settings.Default.userName;
        }

        private void setupPTTokoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanceClass.setup.ShowDialog();
        }

        private void dataMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AbsensiJemaatDesk.Properties.Settings.Default.mdiParent == false) {
                instanceClass.jem.MdiParent = this;
                instanceClass.jem.Dock = DockStyle.Fill;
                instanceClass.jem.Visible = true;

                AbsensiJemaatDesk.Properties.Settings.Default.mdiParent = true;
            }
        }

        private void kebaktianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AbsensiJemaatDesk.Properties.Settings.Default.mdiParent == false){
                instanceClass.bakti.MdiParent = this;
                instanceClass.bakti.Dock = DockStyle.Fill;
                instanceClass.bakti.Visible = true;

                AbsensiJemaatDesk.Properties.Settings.Default.mdiParent = true;
            }
        }

        private void gantiPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AbsensiJemaatDesk.Properties.Settings.Default.mdiParent == false) {
                instanceClass.pass.ShowDialog();
            }
        }

        private void absenJemaatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AbsensiJemaatDesk.Properties.Settings.Default.mdiParent == false)
            {
                rptBirthday birth = new rptBirthday();
                birth.ShowDialog();
            }
        }

        private void absenKebaktianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AbsensiJemaatDesk.Properties.Settings.Default.mdiParent == false)
            {
                rptPD pd = new rptPD();
                pd.ShowDialog();
            }
        }

        private void grafikKehadiranJemaatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rptUmatGraph graph = new rptUmatGraph();
            //xRptUmatGraph graph = new xRptUmatGraph();
            //graph.ShowDialog();
            iMessage.iBoxOk("Sedang dalam pengembangan");
        }
    }
}