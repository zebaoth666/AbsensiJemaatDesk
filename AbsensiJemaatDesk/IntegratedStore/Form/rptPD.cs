using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AbsensiJemaatDesk
{
    public partial class rptPD : Form
    {
        pdClass pd;
        DataTable dtList;
        DataTable dtUmat;
        DataView dvList;
        DataView dvUmat;
        Microsoft.Office.Interop.Excel.Application excel;
        Microsoft.Office.Interop.Excel.Workbook excelWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet excelSheet;
        Microsoft.Office.Interop.Excel.Range excelCellRange;

        public rptPD()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
            dtList = new DataTable();
            dtUmat = new DataTable();
            dvList = new DataView();
            dvUmat = new DataView();
            pd = new pdClass();

            this.VisibleChanged += new EventHandler(this.rptPD_VisibleChanged);
            this.dtDariPD.TextChanged += new EventHandler(this.dtDariPD_TextChanged);
            this.dtSampaiPD.TextChanged += new EventHandler(this.dtSampaiPD_TextChanged);
            this.txtPewarta.TextChanged += new EventHandler(this.txtPewarta_TextChanged);
            this.txtTema.TextChanged += new EventHandler(this.txtTema_TextChanged);
            this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectionIndexChanged);
        }

        private void rptPD_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                listPD();
                listUmat();
                dtDariPD.Value = new DateTime(2019, 01, 01);
                dtSampaiPD.Value = DateTime.Now;
            }
        }

        private void tabControl1_SelectionIndexChanged(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex == 1) {
                refreshUmat(dgvListPD.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void dtDariPD_TextChanged(object sender, EventArgs e) {
            refreshList();
        }

        private void dtSampaiPD_TextChanged(object sender, EventArgs e) {
            refreshList();
        }

        private void txtPewarta_TextChanged(object sender, EventArgs e) {
            refreshList();
        }

        private void txtTema_TextChanged(object sender, EventArgs e) {
            refreshList();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            AbsensiJemaatDesk.Properties.Settings.Default.mdiParent = false;

            this.Parent = null;
            this.Visible = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //xRptPD rpt = new xRptPD(dtPD.Value.Year.ToString(), dtPD.Value.Month.ToString(), dtPD.Value.Day.ToString());
            //rpt.ShowPreviewDialog();

            if (dgvListPD.Rows.Count > 0) {
                refreshUmat(dgvListPD.CurrentRow.Cells[0].Value.ToString());
                exportToExcel();
            }
        }


        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////                                          Function                                         //////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void listPD() {
            if (dtList != null) {
                dtList.Clear();
            }

            pd.getListPD(dtList);
            refreshList();
        }

        private void refreshList() {
            String query = string.Empty;
            dvList = dtList.DefaultView;

            if (!String.IsNullOrEmpty(txtTema.Text)) {
                query = " AND PD_TITLE LIKE '%" + txtTema.Text.Trim() + "%'";
            }

            if (!String.IsNullOrEmpty(txtPewarta.Text))
            {
                query = " AND PD_SPEAKER LIKE '%" + txtPewarta.Text.Trim() + "%'";
            }

            dvList.RowFilter = " (PD_DATE>='" + dtDariPD.Value.ToString("dd/MM/yyyy") +
                                "' AND PD_DATE<='" + dtSampaiPD.Value.ToString("dd/MM/yyyy") + "')" + query;

            if (dgvListPD != null)
                dgvListPD.DataSource = null; dgvListPD.Rows.Clear();

            dgvListPD.DataSource = dvList;

            dgvListPD.Columns[0].Visible = false;
            dgvListPD.Columns[1].HeaderText = "TANGGAL";
            dgvListPD.Columns[2].HeaderText = "TEMA";
            dgvListPD.Columns[3].HeaderText = "PEWARTA";
            dgvListPD.Columns[4].HeaderText = "JUMLAH UMAT";

            if (dgvListPD.Rows.Count > 0)
                dgvListPD.CurrentCell = dgvListPD.Rows[0].Cells[2];
        }

        private void listUmat()
        {
            if (dtUmat != null)
            {
                dtUmat.Clear();
            }

            pd.getListUmats(dtUmat);
            refreshList();
        }

        private void refreshUmat(String pdHeaderId)
        {
            try
            {
                String query = string.Empty;
                dvUmat = dtUmat.DefaultView;

                dvUmat.RowFilter = " PD_HEADER_ID='" + pdHeaderId + "'";

                if (dgvUmatPD != null)
                    dgvUmatPD.DataSource = null; dgvUmatPD.Rows.Clear();

                dgvUmatPD.DataSource = dvUmat;

                dgvUmatPD.Columns[0].Visible = false;
                dgvUmatPD.Columns[1].Visible = false;
                dgvUmatPD.Columns[2].Visible = false;
                dgvUmatPD.Columns[3].HeaderText = "NAMA LENGKAP";
                dgvUmatPD.Columns[4].HeaderText = "NAMA PANGGILAN";
                dgvUmatPD.Columns[5].HeaderText = "NO HANDPHONE";
                dgvUmatPD.Columns[5].DisplayIndex = 7;
                dgvUmatPD.Columns[6].HeaderText = "TEMPAT TANGGAL LAHIR";
                dgvUmatPD.Columns[7].HeaderText = "JENIS KELAMIN";
                dgvUmatPD.Columns[7].DisplayIndex = 5;
                dgvUmatPD.Columns[8].Visible = false;
                dgvUmatPD.Columns[9].Visible = false;   //first_flag
            }
            catch (SystemException err) { iMessage.erBoxOk(err.Message); }
        }

        private void exportToExcel() {
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
            excelSheet.Columns[2].ColumnWidth = 14;
            excelSheet.Columns[3].ColumnWidth = 35;
            excelSheet.Columns[4].ColumnWidth = 20;
            excelSheet.Columns[5].ColumnWidth = 15;
            excelSheet.Columns[6].ColumnWidth = 30;
            excelSheet.Columns[7].ColumnWidth = 20;
            excelSheet.Columns[8].ColumnWidth = 20;


            ////////////////////////////////////////////    HEADER  ////////////////////////////////////////////
            //WRITING
            excelSheet.Cells[1, 1] = "ABSEN PERSEKUTUAN DOA ST. YAKOBUS";
            //FORMATTING CELLS
            excelCellRange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[1, 1]];
            //STYLING CELLS
            excelCellRange.Font.Size = 18;
            excelCellRange.Font.Bold = true;


            excelSheet.Cells[3, 1] = "Tanggal";
            excelSheet.Range[excelSheet.Cells[3, 1], excelSheet.Cells[3, 2]].Merge();
            excelSheet.Cells[3, 3] = ": " + dgvListPD.CurrentRow.Cells[1].Value.ToString();
            excelSheet.Cells[4, 1] = "Tema";
            excelSheet.Range[excelSheet.Cells[4, 1], excelSheet.Cells[4, 2]].Merge();
            excelSheet.Cells[4, 3] = ": " + dgvListPD.CurrentRow.Cells[2].Value.ToString();
            excelSheet.Cells[5, 1] = "Pewarta";
            excelSheet.Range[excelSheet.Cells[5, 1], excelSheet.Cells[5, 2]].Merge();
            excelSheet.Cells[5, 3] = ": " + dgvListPD.CurrentRow.Cells[3].Value.ToString();
            excelSheet.Cells[6, 1] = "Jumlah Umat";
            excelSheet.Range[excelSheet.Cells[6, 1], excelSheet.Cells[6, 2]].Merge();
            excelSheet.Cells[6, 3] = ": " + dgvListPD.CurrentRow.Cells[4].Value.ToString();

            excelCellRange = excelSheet.Range[excelSheet.Cells[3, 1], excelSheet.Cells[6, 3]];
            excelCellRange.Font.Bold = true;

            excelCellRange = excelSheet.Range[excelSheet.Cells[8, 2], excelSheet.Cells[8, 8]];
            excelCellRange.Font.Bold = true;
            excelCellRange.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            excelCellRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            excelCellRange.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            excelCellRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            string status = string.Empty;

            excelSheet.Cells[8, 2] = "NAMA LENGKAP";
            excelSheet.Range[excelSheet.Cells[8, 2], excelSheet.Cells[8, 3]].Merge();
            excelSheet.Cells[8, 4] = "NAMA ALIAS";
            excelSheet.Cells[8, 5] = "GENDER";
            excelSheet.Cells[8, 6] = "TEMPAT TANGGAL LAHIR";
            excelSheet.Cells[8, 7] = "NO HP";
            excelSheet.Cells[8, 8] = "STATUS";
            for (int a = 0; a <= dgvUmatPD.RowCount - 1; a++) {
                excelSheet.Cells[9 + a, 2] = dgvUmatPD[3, a].Value.ToString();
                excelSheet.Range[excelSheet.Cells[9 + a, 2], excelSheet.Cells[9 + a, 3]].Merge();
                excelSheet.Cells[9 + a, 4] = dgvUmatPD[4, a].Value.ToString();
                excelSheet.Cells[9 + a, 6] = dgvUmatPD[6, a].Value.ToString();
                excelSheet.Cells[9 + a, 7] = "'" + dgvUmatPD[5, a].Value.ToString();
                excelSheet.Cells[9 + a, 5] = dgvUmatPD[7, a].Value.ToString();

                if (!String.IsNullOrEmpty(dgvUmatPD[8, a].Value.ToString())) {
                    if (Convert.ToDateTime(dgvUmatPD[8, a].Value.ToString()).ToString("MM") == Convert.ToDateTime(dgvListPD.CurrentRow.Cells[1].Value.ToString()).ToString("MM"))
                    {
                        status = "Ultah";
                    }
                    else { status = string.Empty; }
                }

                if (dgvUmatPD[9, a].Value.ToString() == "1") {
                    if (!String.IsNullOrEmpty(status))
                    {
                        status = status + ", baru";
                    }
                    else { status = status + "Baru"; }
                }

                excelSheet.Cells[9 + a, 8] = status;
            }

            excelCellRange = excelSheet.Range[excelSheet.Cells[9, 2], excelSheet.Cells[9 + dgvUmatPD.RowCount-1, 8]];
            excelCellRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            excelCellRange.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            excelCellRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //save
            excel.Visible=true;
        }
    }
}