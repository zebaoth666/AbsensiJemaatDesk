using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Globalization;

namespace AbsensiJemaatDesk
{
    public partial class xRptBirthday : DevExpress.XtraReports.UI.XtraReport
    {
        DataTable dt;
        umatClass umat;

        public xRptBirthday(String bulan)
        {
            InitializeComponent();

            umat = new umatClass();
            dt = new DataTable();

            getData(bulan);
        }

        private void getData(String bulan) {
            String fields = " UMAT_DATE_BIRTH, UMAT_COMP_NAME, DATEDIFF('yyyy', UMAT_DATE_BIRTH, NOW()) AS UMUR";
            String param = " MONTH(UMAT_DATE_BIRTH)='" + bulan + "'";

            dt.Clear();
            dt = umat.callRptUmat(fields, param);

            if (dt.Rows.Count > 0) {
                DataRow dr;
                for (int a = 0; a < dt.Rows.Count - 1; a++) {
                    dr = dtUmat.NewRow();
                    dr[0] = dt.Rows[a][0].ToString();
                    dr[1] = dt.Rows[a][1].ToString();
                    dr[2] = dt.Rows[a][2].ToString();
                    dtUmat.Rows.Add(dr);
                }
            }
        }

        public void setBulan(String bulan) {
            lblBulan.Text = "Bulan " + bulan;
        }
    }
}
