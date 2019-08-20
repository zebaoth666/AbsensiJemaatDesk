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

        public xRptBirthday(String dateDari, String dateSampai, String monthDari, String monthSampai)
        {
            InitializeComponent();

            umat = new umatClass();
            dt = new DataTable();

            getData(dateDari, dateSampai, monthDari, monthSampai);
        }

        private void getData(String dateDari, String dateSampai, String monthDari, String monthSampai) {
            String fields = " UMAT_DATE_BIRTH, UMAT_COMP_NAME, DATEDIFF('yyyy', UMAT_DATE_BIRTH, NOW()) AS UMUR";
            String param = " MONTH(UMAT_DATE_BIRTH) BETWEEN " + monthDari + " AND " + monthSampai + 
                            " AND DAY(UMAT_DATE_BIRTH) BETWEEN " + dateDari + " AND " + dateSampai + "";
            //String param = " FORMAT(UMAT_DATE_BIRTH,'dd-MM') BETWEEN '" + dateDari + "-" + monthDari +
            //                "' AND '" + dateSampai + "-" + monthSampai + "'";

            dt.Clear();
            dt = umat.callRptUmat(fields, param);

            if (dt.Rows.Count > 0) {
                DataRow dr;
                for (int a = 0; a <= dt.Rows.Count - 1; a++) {
                    dr = dtUmat.NewRow();
                    dr[0] = dt.Rows[a][0].ToString();
                    dr[1] = dt.Rows[a][1].ToString();
                    dr[2] = dt.Rows[a][2].ToString();
                    dtUmat.Rows.Add(dr);
                }
            }
        }

        public void setBulan(String dateDari, String dateSampai, String monthDari, String monthSampai) {
            lblBulan.Text = "Periode " + dateDari + " " + convertDariDate(monthDari) + 
                            " s.d. " + dateSampai + " " + convertSmpDate(monthSampai);
        }

        private String convertDariDate(String dateDari) {
            String convDariDate = string.Empty;

            switch (dateDari) {
                case "01":
                    convDariDate = "Januari";
                    break;
                case "02":
                    convDariDate = "Februari";
                    break;
                case "03":
                    convDariDate = "Maret";
                    break;
                case "04":
                    convDariDate = "April";
                    break;
                case "05":
                    convDariDate = "Mei";
                    break;
                case "06":
                    convDariDate = "Juni";
                    break;
                case "07":
                    convDariDate = "Juli";
                    break;
                case "08":
                    convDariDate = "Agustus";
                    break;
                case "09":
                    convDariDate = "September";
                    break;
                case "10":
                    convDariDate = "Oktober";
                    break;
                case "11":
                    convDariDate = "November";
                    break;
                case "12":
                    convDariDate = "Desember";
                    break;
                default:
                    convDariDate = string.Empty;
                    break;
            }

            return convDariDate;
        }

        private String convertSmpDate(String dateSampai)
        {
            String convSmpDate = string.Empty;

            switch (dateSampai)
            {
                case "01":
                    convSmpDate = "Januari";
                    break;
                case "02":
                    convSmpDate = "Februari";
                    break;
                case "03":
                    convSmpDate = "Maret";
                    break;
                case "04":
                    convSmpDate = "April";
                    break;
                case "05":
                    convSmpDate = "Mei";
                    break;
                case "06":
                    convSmpDate = "Juni";
                    break;
                case "07":
                    convSmpDate = "Juli";
                    break;
                case "08":
                    convSmpDate = "Agustus";
                    break;
                case "09":
                    convSmpDate = "September";
                    break;
                case "10":
                    convSmpDate = "Oktober";
                    break;
                case "11":
                    convSmpDate = "November";
                    break;
                case "12":
                    convSmpDate = "Desember";
                    break;
                default:
                    convSmpDate = string.Empty;
                    break;
            }

            return convSmpDate;
        }
    }
}