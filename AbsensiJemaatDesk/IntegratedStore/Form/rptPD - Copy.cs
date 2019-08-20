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
    public partial class rptPD : Form
    {
        pdClass pd;
        DataTable dt;

        public rptPD()
        {
            InitializeComponent();

            dt = new DataTable();
            pd = new pdClass();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panelHeader.BackColor = ColorTranslator.FromHtml("#58D3F7");
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu menu = new frmMenu();
            menu.Focus();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            xRptPD rpt = new xRptPD(dtPD.Value.Year.ToString(), dtPD.Value.Month.ToString(), dtPD.Value.Day.ToString());
            rpt.ShowPreviewDialog();
        }
    }
}