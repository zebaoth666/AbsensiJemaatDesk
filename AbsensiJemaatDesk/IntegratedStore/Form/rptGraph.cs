using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace AbsensiJemaatDesk
{
    public partial class rptGraph : Form
    {
        DataTable dtGlobal;
        DataTable dtAlpha;
        DataView dvAlpha;
        pdClass pd;

        Microsoft.Office.Interop.Excel.Application excel;
        Microsoft.Office.Interop.Excel.Workbook excelWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet excelSheet;
        Microsoft.Office.Interop.Excel.Range excelCellRange;

        public rptGraph()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
            
            this.VisibleChanged += new EventHandler(this.rptPD_VisibleChanged);
            this.tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);

            pd = new pdClass();
            dtGlobal = new DataTable();
            dtAlpha = new DataTable();
            dvAlpha = new DataView();
            dtGlobal = pd.callPDGlobal();

            //initDgvAlpha();
        }

        private void rptPD_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                //dgvAlphaUmat.DataSource = dtGlobal;
                getAlphaUmat();
            }
        }

        private void tabControl1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            //Get Item from the collection
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            //Get the real bounds for the rectangle
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);
            //_tabBounds.Size = new Size(500,100);

            if (e.State == DrawItemState.Selected) {
                //Draw a different background color, and dont paint a focus rectangle
                _textBrush = new SolidBrush(Color.Black);
                e.DrawBackground();
            } else {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                g.FillRectangle(Brushes.WhiteSmoke, e.Bounds);
                
            }

            //Use our own font
            Font _tabFont = new Font("Arial", 11.25f, FontStyle.Regular);

            //Draw String . Center the text
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex == 3) {
                AbsensiJemaatDesk.Properties.Settings.Default.mdiParent = false;

                this.Parent = null;
                this.Visible = false;
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            AbsensiJemaatDesk.Properties.Settings.Default.mdiParent = false;

            this.Parent = null;
            this.Visible = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {  
        
        }


        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////                                          Function                                         //////////
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void initDgvAlpha() {
            dgvAlphaUmat.ColumnCount = 2;
            dgvAlphaUmat.Columns[2].Name = "Nama Lengkap";
            dgvAlphaUmat.Columns[3].Name = "Nama Panggilan";

            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            DataGridViewProgressColumn column = new DataGridViewProgressColumn();
            
            dgvAlphaUmat.Columns.Add(check);
            dgvAlphaUmat.Columns.Add(column);

            check.HeaderText = "Hapus";
            check.Name = "Persentase";
            dgvAlphaUmat.Columns[1].DisplayIndex = 3;
        }

        private void getAlphaUmat() {
            //linq total_PD
            var resTotal = (from test in dtGlobal.AsEnumerable()
                            group test by new
                            {
                                id = test.Field<string>("PD_UMAT_ID"),
                                nama = test.Field<string>("UMAT_COMP_NAME"),
                                alias = test.Field<string>("UMAT_ALIAS_NAME"),
                            } into abc
                            select new
                            {
                                abc.Key.id,
                                abc.Key.nama,
                                abc.Key.alias,
                                total = abc.Count()
                            }
                         )
                         .OrderBy(abc => abc.nama);

            //linq total_alpha
            var resAlpha = dtGlobal.AsEnumerable()
                .Where(p => p.Field<string>("PD_PRESENT_FLAG") == "0")
                .GroupBy(p => new {
                    id = p.Field<string>("PD_UMAT_ID"),
                    nama = p.Field<string>("UMAT_COMP_NAME"),
                    alias = p.Field<string>("UMAT_ALIAS_NAME")
                })
                .Select(item => new {
                    id = item.Key.id,
                    alpha = item.Count()
                });

            var result = (from rT in resTotal
                          from rAl in resAlpha
                          where (rT.id == rAl.id)
                          select new
                          {
                              rT.id, rT.nama, rT.alias, persen = ((float)rAl.alpha / (float)rT.total) * 100
                          }
                         )
                         .ToList();
            dtAlpha.Copy(result);

            for (int a = 0; a <= result.Count - 1; a++) {
                dgvAlphaUmat.Rows.Add();
                dgvAlphaUmat[3, a].Value = Convert.ToInt32(result[a].persen);
                dgvAlphaUmat[1, a].Value = (result[a].nama);
                dgvAlphaUmat[2, a].Value = (result[a].alias);
            }

            dgvAlphaUmat.SortOrder(dgvAlphaUmat.Columns)
        }

        private void exportToExcel() {
            ////Start excel and get application object
            //excel = new Microsoft.Office.Interop.Excel.Application();
            //excel.Visible = false;
            //excel.DisplayAlerts = false;
            ////create new workbook
            //excelWorkBook = excel.Workbooks.Add(Type.Missing);
            ////worksheet
            //excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkBook.ActiveSheet;

            //excel.Windows.Application.ActiveWindow.DisplayGridlines = false;
            //excelSheet.Columns[1].ColumnWidth = 0.1;
            //excelSheet.Columns[2].ColumnWidth = 14;
            //excelSheet.Columns[3].ColumnWidth = 35;
            //excelSheet.Columns[4].ColumnWidth = 20;
            //excelSheet.Columns[5].ColumnWidth = 15;
            //excelSheet.Columns[6].ColumnWidth = 30;
            //excelSheet.Columns[7].ColumnWidth = 20;
            //excelSheet.Columns[8].ColumnWidth = 20;


            //////////////////////////////////////////////    HEADER  ////////////////////////////////////////////
            ////WRITING
            //excelSheet.Cells[1, 1] = "ABSEN PERSEKUTUAN DOA ST. YAKOBUS";
            ////FORMATTING CELLS
            //excelCellRange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[1, 1]];
            ////STYLING CELLS
            //excelCellRange.Font.Size = 18;
            //excelCellRange.Font.Bold = true;


            //excelSheet.Cells[3, 1] = "Tanggal";
            //excelSheet.Range[excelSheet.Cells[3, 1], excelSheet.Cells[3, 2]].Merge();
            //excelSheet.Cells[3, 3] = ": " + dgvListPD.CurrentRow.Cells[1].Value.ToString();
            //excelSheet.Cells[4, 1] = "Tema";
            //excelSheet.Range[excelSheet.Cells[4, 1], excelSheet.Cells[4, 2]].Merge();
            //excelSheet.Cells[4, 3] = ": " + dgvListPD.CurrentRow.Cells[2].Value.ToString();
            //excelSheet.Cells[5, 1] = "Pewarta";
            //excelSheet.Range[excelSheet.Cells[5, 1], excelSheet.Cells[5, 2]].Merge();
            //excelSheet.Cells[5, 3] = ": " + dgvListPD.CurrentRow.Cells[3].Value.ToString();
            //excelSheet.Cells[6, 1] = "Jumlah Umat";
            //excelSheet.Range[excelSheet.Cells[6, 1], excelSheet.Cells[6, 2]].Merge();
            //excelSheet.Cells[6, 3] = ": " + dgvListPD.CurrentRow.Cells[4].Value.ToString();

            //excelCellRange = excelSheet.Range[excelSheet.Cells[3, 1], excelSheet.Cells[6, 3]];
            //excelCellRange.Font.Bold = true;

            //excelCellRange = excelSheet.Range[excelSheet.Cells[8, 2], excelSheet.Cells[8, 8]];
            //excelCellRange.Font.Bold = true;
            //excelCellRange.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //excelCellRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            //excelCellRange.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            //excelCellRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //string status = string.Empty;

            //excelSheet.Cells[8, 2] = "NAMA LENGKAP";
            //excelSheet.Range[excelSheet.Cells[8, 2], excelSheet.Cells[8, 3]].Merge();
            //excelSheet.Cells[8, 4] = "NAMA ALIAS";
            //excelSheet.Cells[8, 5] = "GENDER";
            //excelSheet.Cells[8, 6] = "TEMPAT TANGGAL LAHIR";
            //excelSheet.Cells[8, 7] = "NO HP";
            //excelSheet.Cells[8, 8] = "STATUS";
            //for (int a = 0; a <= dgvUmatPD.RowCount - 1; a++) {
            //    excelSheet.Cells[9 + a, 2] = dgvUmatPD[3, a].Value.ToString();
            //    excelSheet.Range[excelSheet.Cells[9 + a, 2], excelSheet.Cells[9 + a, 3]].Merge();
            //    excelSheet.Cells[9 + a, 4] = dgvUmatPD[4, a].Value.ToString();
            //    excelSheet.Cells[9 + a, 6] = dgvUmatPD[6, a].Value.ToString();
            //    excelSheet.Cells[9 + a, 7] = "'" + dgvUmatPD[5, a].Value.ToString();
            //    excelSheet.Cells[9 + a, 5] = dgvUmatPD[7, a].Value.ToString();

            //    if (!String.IsNullOrEmpty(dgvUmatPD[8, a].Value.ToString())) {
            //        if (Convert.ToDateTime(dgvUmatPD[8, a].Value.ToString()).ToString("MM") == Convert.ToDateTime(dgvListPD.CurrentRow.Cells[1].Value.ToString()).ToString("MM"))
            //        {
            //            status = "Ultah";
            //        }
            //        else { status = string.Empty; }
            //    }

            //    if (dgvUmatPD[9, a].Value.ToString() == "1") {
            //        if (!String.IsNullOrEmpty(status))
            //        {
            //            status = status + ", baru";
            //        }
            //        else { status = status + "Baru"; }
            //    }

            //    excelSheet.Cells[9 + a, 8] = status;
            //}

            //excelCellRange = excelSheet.Range[excelSheet.Cells[9, 2], excelSheet.Cells[9 + dgvUmatPD.RowCount-1, 8]];
            //excelCellRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            //excelCellRange.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            //excelCellRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            ////save
            //excel.Visible=true;
        }
    }
}