using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Globalization;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.UI;
using System.Windows.Forms;

namespace AbsensiJemaatDesk
{
    public partial class xRptUmatGraph : DevExpress.XtraReports.UI.XtraReport
    {
        DataTable dt;
        pdClass pd;
        
        public xRptUmatGraph()
        {
            InitializeComponent();

            pd = new pdClass();
            dt = new DataTable();

            getData();

            DevExpress.XtraCharts.Native.Chart chart;
        }

        private void getData() {
            dt = pd.callRptGraph();

            if (dt.Rows.Count > 0) {
                DataRow dr;
                for (int a = 0; a < dt.Rows.Count - 1; a++) {
                    dr = dtGrafik.NewRow();
                    dr[0] = dt.Rows[a][0].ToString();
                    dr[1] = dt.Rows[a][1].ToString();
                    dtGrafik.Rows.Add(dr);
                }
            }
        }

        private void iniChart() {
            ChartControl chart = new ChartControl();

            Series series = new Series("Series1", ViewType.Bar);
            chart.Series.Add(series);

            series.DataSource = dtGrafik;

            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "umat_name";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "persen"});

            chart.Dock = DockStyle.Fill;
            //this.Contrl
        }
    }
}