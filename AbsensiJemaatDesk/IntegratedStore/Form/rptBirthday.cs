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
    public partial class rptBirthday : Form
    {
        umatClass umat;
        DataTable dt;
        DataView dv;
        Microsoft.Office.Interop.Excel.Application excel;
        Microsoft.Office.Interop.Excel.Workbook excelWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet excelSheet;
        Microsoft.Office.Interop.Excel.Range excelCellRange;
        String bulan = string.Empty;
        String query = string.Empty;

        public rptBirthday()
        {
            InitializeComponent();
        }

        private void rptBirthday_Load(object sender, EventArgs e)
        {
            pnlHeader.BackColor = ColorTranslator.FromHtml("#58D3F7");

            umat = new umatClass();
            dt = new DataTable();
            dv = new DataView();

            this.VisibleChanged += new EventHandler(this.rptBirthday_VisibleChanged);
            this.cmbBln.SelectedValueChanged += new EventHandler(this.cmbBln_SelectionValueChanged);
            this.cmbTglAwal.SelectedValueChanged += new EventHandler(this.cmbTglAwal_SelectionValueChanged);
            this.cmbTglAkhir.SelectedValueChanged += new EventHandler(this.cmbTglAkhir_SelectionValueChanged);
        }

        private void rptBirthday_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                listUmat();

                dtDari.Value = DateTime.Now;
                dtSampai.Value = dtDari.Value.AddDays(7);

                cmbBln.SelectedIndex = 0;
                cmbTglAwal.SelectedIndex = 0;
            }
        }

        private void cmbBln_SelectionValueChanged(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(cmbBln.Text)) {
                switch (cmbBln.Text) {
                    case "Januari":
                        bulan = "1";
                        break;
                    case "Februari":
                        bulan = "2";
                        break;
                    case "Maret":
                        bulan = "3";
                        break;
                    case "April":
                        bulan = "4";
                        break;
                    case "Mei":
                        bulan = "5";
                        break;
                    case "Juni":
                        bulan = "6";
                        break;
                    case "Juli":
                        bulan = "7";
                        break;
                    case "Agustus":
                        bulan = "8";
                        break;
                    case "September":
                        bulan = "9";
                        break;
                    case "Oktober":
                        bulan = "10";
                        break;
                    case "November":
                        bulan = "11";
                        break;
                    case "Desember":
                        bulan = "12";
                        break;       
                    default:
                        bulan = string.Empty;
                        break;
                }

                cmbTglAwal.Enabled = true;
                cmbTglAkhir.Enabled = true;

                refreshList();
            }
            else
            {
                cmbTglAwal.Enabled = false;
                cmbTglAkhir.Enabled = false;
            }
        }

        private void cmbTglAwal_SelectionValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbTglAwal.Text)) {
                if (cmbTglAwal.SelectedIndex + 7 > cmbTglAkhir.Items.Count - 1)
                {
                    cmbTglAkhir.SelectedIndex = cmbTglAwal.SelectedIndex + ((cmbTglAkhir.Items.Count-1)- cmbTglAwal.SelectedIndex);
                }
                else {
                    cmbTglAkhir.SelectedIndex = cmbTglAwal.SelectedIndex + 7;
                }
                
            }
        }

        private void cmbTglAkhir_SelectionValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbTglAkhir.Text)) {
                refreshList();
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            AbsensiJemaatDesk.Properties.Settings.Default.mdiParent = false;

            this.Parent = null;
            this.Visible = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            exportToExcel();
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////                                          Function                                         //////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void listUmat()
        {
            if (dt != null)
            {
                dt.Clear();
            }

            dt = umat.callRptUmat();
            refreshList();
        }

        private void refreshList()
        {
            dv = dt.DefaultView;

            dtDari.Value = new DateTime(1900, 01, 01);

            if (!String.IsNullOrWhiteSpace(cmbBln.Text)) {
                query = " KBLN='" + bulan + "'";
            }

            if (!String.IsNullOrWhiteSpace(cmbTglAwal.Text) && !String.IsNullOrWhiteSpace(cmbTglAkhir.Text)){
                if (!String.IsNullOrWhiteSpace(query))
                {
                    query = query + " AND (KTGL>='" + Convert.ToDouble(cmbTglAwal.Text) + "' AND KTGL<='" + Convert.ToDouble(cmbTglAkhir.Text) + "')";
                }
                else {
                    query = " (KTGL>='" + Convert.ToDouble(cmbTglAwal.Text) + "' AND KTGL<='" + Convert.ToDouble(cmbTglAkhir.Text) + "')";
                }
            }

            dv.RowFilter = query;

            if (dgvUmat != null)
                dgvUmat.DataSource = null; dgvUmat.Rows.Clear();

            dgvUmat.DataSource = dv;

            dgvUmat.Columns[0].HeaderText = "TANGGAL LAHIR";
            dgvUmat.Columns[1].HeaderText = "NAMA LENGKAP";
            dgvUmat.Columns[2].HeaderText = "UMUR";
            dgvUmat.Columns[3].Visible = false;
            dgvUmat.Columns[4].Visible = false;
        }

        private void exportToExcel()
        {
            //Start excel and get application object
            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = false;
            excel.DisplayAlerts = false;
            //create new workbook
            excelWorkBook = excel.Workbooks.Add(Type.Missing);
            //worksheet
            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkBook.ActiveSheet;

            excel.Windows.Application.ActiveWindow.DisplayGridlines = false;
            excelSheet.Columns[1].ColumnWidth = 0.1;
            excelSheet.Columns[2].ColumnWidth = 15;
            excelSheet.Columns[3].ColumnWidth = 45;
            excelSheet.Columns[4].ColumnWidth = 10;


            ////////////////////////////////////////////    HEADER  ////////////////////////////////////////////
            //WRITING
            excelSheet.Cells[1, 1] = "DATA ULANG TAHUN UMAT PD ST. YAKOBUS";
            //FORMATTING CELLS
            excelCellRange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[1, 1]];
            //STYLING CELLS
            excelCellRange.Font.Size = 18;
            excelCellRange.Font.Bold = true;


            excelSheet.Cells[3, 1] = "Bulan " + cmbBln.Text;
            excelSheet.Range[excelSheet.Cells[3, 1], excelSheet.Cells[3, 2]].Merge();

            excelCellRange = excelSheet.Range[excelSheet.Cells[3, 1], excelSheet.Cells[3, 2]];
            excelCellRange.Font.Bold = true;

            excelCellRange = excelSheet.Range[excelSheet.Cells[4, 2], excelSheet.Cells[4, 4]];
            excelCellRange.Font.Bold = true;
            excelCellRange.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            excelCellRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            excelCellRange.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            excelCellRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            string status = string.Empty;

            excelSheet.Cells[4, 2] = "TANGGAL LAHIR";
            excelSheet.Cells[4, 3] = "NAMA";
            excelSheet.Cells[4, 4] = "USIA";
            for (int a = 0; a <= dgvUmat.RowCount - 1; a++)
            {
                excelSheet.Cells[5 + a, 2] = dgvUmat[0, a].Value.ToString();
                excelSheet.Cells[5 + a, 3] = dgvUmat[1, a].Value.ToString();
                excelSheet.Cells[5 + a, 4] = dgvUmat[2, a].Value.ToString();
            }

            excelCellRange = excelSheet.Range[excelSheet.Cells[5, 2], excelSheet.Cells[5 + dgvUmat.RowCount - 1, 4]];
            excelCellRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            excelCellRange.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            excelCellRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //save
            excel.Visible = true;
        }
    }
}