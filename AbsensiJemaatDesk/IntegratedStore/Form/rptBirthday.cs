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
    public partial class rptBirthday : Form
    {
        DataTable dt;
        
        public rptBirthday()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panelHeader.BackColor = ColorTranslator.FromHtml("#58D3F7");

            dt = new DataTable();
            dt.Columns.Add("mNum");
            dt.Columns.Add("Bulan");
            dt.Rows.Add("1", "Januari");
            dt.Rows.Add("2", "Februari");
            dt.Rows.Add("3", "Maret");
            dt.Rows.Add("4", "April");
            dt.Rows.Add("5", "Mei");
            dt.Rows.Add("6", "Juni");
            dt.Rows.Add("7", "Juli");
            dt.Rows.Add("8", "Agustus");
            dt.Rows.Add("9", "September");
            dt.Rows.Add("10", "Oktober");
            dt.Rows.Add("11", "November");
            dt.Rows.Add("12", "Desember");

            cmbBulan.Properties.DataSource = dt;
            cmbBulan.Properties.PopulateColumns();
            cmbBulan.Properties.DisplayMember = "Bulan";
            cmbBulan.Properties.Columns["mNum"].Visible = false;
            cmbBulan.Properties.ValueMember = "mNum";
            cmbBulan.Properties.NullText = "-- Pilih Bulan --";
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu menu = new frmMenu();
            menu.Focus();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbBulan.EditValue != null)
            {
                xRptBirthday rpt = new xRptBirthday(cmbBulan.EditValue.ToString());
                rpt.setBulan(cmbBulan.Text);
                rpt.ShowPreviewDialog();
            }
            else {
                iMessage.iBoxOk("Silakan memilih bulan lahir");
            }
        }
    }
}