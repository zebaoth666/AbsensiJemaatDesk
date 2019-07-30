using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Globalization;

namespace AbsensiJemaatDesk
{
    public partial class xRptPD : DevExpress.XtraReports.UI.XtraReport
    {
        DataTable dt;
        pdClass pd;
        String tahun = null, bulan = null, hari = null;

        public xRptPD(String tahun, String bulan, String hari)
        {
            InitializeComponent();

            pd = new pdClass();
            dt = new DataTable();

            this.tahun = tahun;
            this.bulan = bulan;
            this.hari = hari;

            getData(null);
        }

        private void getData(String bulan) {
            String fields = "H.PD_DATE, H.PD_TITLE, H.PD_SPEAKER, L.PD_UMAT_COMP_NAME, L.PD_UMAT_ALIAS_NAME," +
                            " L.PD_UMAT_BORN_PLACE, L.PD_UMAT_BORN_DATE, L.PD_UMAT_PHONE, L.PD_UMAT_SEX, L.PD_PRESENT_FLAG";
            String param = "H.PD_HEADER_ID=L.PD_HEADER_ID AND (YEAR(H.PD_DATE)='" + this.tahun +
                            "' AND MONTH(H.PD_DATE)='" + this.bulan + 
                            "' AND DAY(H.PD_DATE)='" + this.hari + "')";
            string order = " L.PD_UMAT_COMP_NAME ";
            dt = pd.callRptPD(fields, param, order);

            if (dt.Rows.Count > 0) {
                DataRow dr;
                for (int a = 0; a < dt.Rows.Count - 1; a++) {
                    dr = dtPD.NewRow();
                    dr[0] = dt.Rows[a][0].ToString();
                    dr[1] = dt.Rows[a][1].ToString();
                    dr[2] = dt.Rows[a][2].ToString();
                    dr[3] = dt.Rows[a][3].ToString();
                    dr[4] = dt.Rows[a][4].ToString();
                    dr[6] = dt.Rows[a][6].ToString();
                    dr[5] = dt.Rows[a][5].ToString() + ", " + String.Format("{0:d/M/yyyy}", dr[6]);
                    dr[7] = dt.Rows[a][7].ToString();

                    if (dt.Rows[a][8].ToString() == "P")
                    {
                        dr[8] = "Pria";
                    }
                    else { dr[8] = "Wanita"; }

                    if (dt.Rows[a][9].ToString() == "1") {
                        dr[9] = "Ya";
                    }else { dr[9] = "Tidak"; }
                    
                    dtPD.Rows.Add(dr);
                }
            }
        }
    }
}
