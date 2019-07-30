using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraCharts;

namespace AbsensiJemaatDesk
{
    public partial class rptUmatGraph : Form
    {
        DataTable dt;
        pdClass pd;

        public rptUmatGraph()
        {
            InitializeComponent();
        }

        private void rptUmatGraph_Load(object sender, EventArgs e)
        {
            panelHeader.BackColor = ColorTranslator.FromHtml("#58D3F7");

            dt = new DataTable();
            pd = new pdClass();
            dt = pd.callRptGraph();
            
            chartDev();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chartDev()
        {
            if (dt.Rows.Count > 0)
            {
                DataRow dr;
                for (int a = 0; a < dt.Rows.Count - 1; a++)
                {
                    dr = dtGrafik.NewRow();
                    dr[0] = dt.Rows[a][0].ToString();
                    dr[1] = dt.Rows[a][1].ToString();
                    dtGrafik.Rows.Add(dr);
                }

                try
                {
                    // Create a new Chart control and add it to the form. 
                    ChartControl chart = new ChartControl();
                    chart.Dock = DockStyle.Fill;
                    this.panelBody.Controls.AddRange(new Control[] { chart });

                    // Create a Bar series and add points to it. 
                    Series series1 = new Series("Bar", ViewType.Bar);
                    series1.DataSource = dtGrafik.DefaultView;
                    series1.ArgumentScaleType = ScaleType.Auto;
                    series1.ArgumentDataMember = "nama";
                    series1.ValueScaleType = ScaleType.Numerical;
                    series1.ValueDataMembers.AddRange(new String[] { "persen" });

                    // Add the series to the chart. 
                    chart.Series.Add(series1);

                    ((XYDiagram)chart.Diagram).Rotated = true;
                    ////((XYDiagram)chart.Diagram).Panes[0].EnableAxisYScrolling = DefaultBoolean.True;
                    //((XYDiagram)chart.Diagram).DefaultPane.ScrollBarOptions.XAxisScrollBarAlignment = DevExpress.XtraCharts.ScrollBarAlignment.Far;
                    //((XYDiagram)chart.Diagram).EnableAxisXZooming = true;
                    //((XYDiagram)chart.Diagram).EnableAxisXScrolling = true;
                    //((XYDiagram)chart.Diagram).ScrollingOptions.UseScrollBars = true;

                    // Cast the chart's diagram to the XYDiagram type, to access its axes. 
                    //XYDiagram diagram = (XYDiagram)chart.Diagram;

                    // Add a new additional pane to the diagram. 
                    //diagram.Panes.Add(new XYDiagramPane("My Pane"));

                    // Define the whole range for the axes. 
                    ((XYDiagram)chart.Diagram).AxisX.WholeRange.Auto = false;
                    ((XYDiagram)chart.Diagram).AxisX.WholeRange.SetMinMaxValues("A", "Z");
                    ((XYDiagram)chart.Diagram).AxisY.WholeRange.Auto = false;
                    ((XYDiagram)chart.Diagram).AxisY.WholeRange.SetMinMaxValues(0, 100);

                    // Specify the axes scrolling at the diagram's level. 
                    ((XYDiagram)chart.Diagram).EnableAxisXScrolling = true;
                    ((XYDiagram)chart.Diagram).EnableAxisYScrolling = false;

                    //// Individually specify the axes scrolling for the panes. 
                    //((XYDiagram)chart.Diagram).DefaultPane.EnableAxisXScrolling = DefaultBoolean.Default;
                    //((XYDiagram)chart.Diagram).Panes[0].EnableAxisXScrolling = DefaultBoolean.False;
                    //((XYDiagram)chart.Diagram).Panes[0].EnableAxisYScrolling = DefaultBoolean.True;

                    // Adjust how the scrolling can be performed. 
                    ((XYDiagram)chart.Diagram).ScrollingOptions.UseKeyboard = false;
                    ((XYDiagram)chart.Diagram).ScrollingOptions.UseMouse = false;
                    ((XYDiagram)chart.Diagram).ScrollingOptions.UseScrollBars = true;
                }
                catch (SystemException err){ iMessage.erBoxOk(err.Message); }
            }
        }
    }
}