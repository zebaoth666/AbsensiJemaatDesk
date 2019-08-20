﻿using System;
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

            this.dtDari.LostFocus += new EventHandler(this.dtDari_LostFocus);

            dtDari.Value = DateTime.Now;
            dtSampai.Value = dtDari.Value.AddDays(7);
        }

        private void dtDari_LostFocus(object sender, EventArgs e) {
            dtSampai.Value = dtDari.Value.AddDays(7);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu menu = new frmMenu();
            menu.Focus();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            xRptBirthday rpt = new xRptBirthday(dtDari.Value.ToString("dd"), dtSampai.Value.ToString("dd"), 
                                                dtDari.Value.ToString("MM"), dtSampai.Value.ToString("MM"));
            rpt.setBulan(dtDari.Value.ToString("dd"), dtSampai.Value.ToString("dd"),
                                                dtDari.Value.ToString("MM"), dtSampai.Value.ToString("MM"));
            rpt.ShowPreviewDialog();
        }
    }
}