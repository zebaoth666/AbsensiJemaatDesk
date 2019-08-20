using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace AbsensiJemaatDesk
{
    class pdClass
    {
        private String pdHeaderId = string.Empty;
        private String pdPewarta = string.Empty;
        private String pdTema = string.Empty;
        private Int16 pdNextNo = 0;
        private Double pdTotal = 0;

        OleDbTransaction trans = null;
        private OleDbConnection conn = null;
        private OleDbCommand comm = new OleDbCommand();
        private OleDbDataAdapter sda;
        private OleDbDataReader sdr = null;
        
        public pdClass(){
            conn = new OleDbConnection(AbsensiJemaatDesk.Properties.Settings.Default.conStr);
        }

        public String getHeaderId()
        {
            return this.pdHeaderId;
        }

        public String getTitle()
        {
            return this.pdTema;
        }

        public String getPewarta()
        {
            return this.pdPewarta;
        }

        public Double getTotal() {
            return this.pdTotal;
        }
        
        public String checkService(String tahun, String bulan, String tanggal)
        {
            string status = string.Empty;

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT PD_HEADER_ID, PD_TITLE, PD_SPEAKER, PD_NEXT_NO FROM T_PD_HEADERS" +
                                    " WHERE YEAR(PD_DATE)='" + tahun + 
                                    "' AND MONTH(PD_DATE)='" + bulan + 
                                    "' AND DAY(PD_DATE)='" + tanggal + "'";
                comm.CommandTimeout = 10000;
                sdr = comm.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    this.pdHeaderId = sdr.GetString(0);
                    this.pdTema = sdr.GetString(1);
                    this.pdPewarta = sdr.GetString(2);

                    sdr.Close();
                    conn.Close();

                    status = "EDIT";
                }
                else
                {
                    sdr.Close();
                    conn.Close();

                    status = "NEW";
                }
            }
            catch (SystemException err)
            {
                sdr.Close();
                conn.Close();
                status = "ERR";
                iMessage.erBoxOk(err.Message);
            }

            return status;
        }

        // not used since 25 July 2019
        private void nextNo()
        {
            Int16 next = 0;
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT MAX(PD_NEXT_NO) FROM T_PD_HEADERS";
                comm.CommandTimeout = 10000;
                sdr = comm.ExecuteReader();
                sdr.Read();
                if (sdr.IsDBNull(0))
                {
                    next = 1;
                    sdr.Close();
                }
                else {
                    next = sdr.GetInt16(0);
                    sdr.Close();
                }
            }
            catch (SystemException err)
            {
                next = 0;
                iMessage.erBoxOk(err.Message);
            }
            finally
            {
                conn.Close();
            }

            this.pdNextNo=next;
        }

        public Boolean savePD(String header_id, String tgl, String tema, String pewarta) {
            bool hasil = false;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "INSERT INTO T_PD_HEADERS(PD_HEADER_ID, PD_DATE, PD_TYPE, PD_TITLE, PD_SPEAKER," + 
                                                    " PD_NEXT_NO, CREATE_DATE, CREATE_BY, MOD_DATE, MOD_BY) VALUES(" +
                                                    "'" + header_id + "','" + tgl + "','YOUTH SATURDAY SERVICE','" + tema +
                                                    "','" + pewarta + "','0',NOW(),'" +
                                                    AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                                    "', NOW(), '" + AbsensiJemaatDesk.Properties.Settings.Default.userName + "')";
                comm.CommandTimeout = 10000;
                comm.ExecuteNonQuery();

                comm.CommandText = "INSERT INTO T_PD_LINES(PD_HEADER_ID, PD_UMAT_ID, PD_UMAT_COMP_NAME," + 
                                    " PD_UMAT_ALIAS_NAME, PD_UMAT_BORN_PLACE, PD_UMAT_BORN_DATE," + 
                                    " PD_UMAT_PHONE, PD_UMAT_SEX, PD_PRESENT_FLAG," +
                                    " CREATE_DATE, CREATE_BY, MOD_DATE, MOD_BY) SELECT " +
                                    "'" + header_id + "', UMAT_ID, UMAT_COMP_NAME, UMAT_ALIAS_NAME," +
                                    " UMAT_PLACE_BIRTH, UMAT_DATE_BIRTH, UMAT_PHONE, UMAT_SEX, '0', NOW(),'" +
                                    AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                    "', NOW(), '" + AbsensiJemaatDesk.Properties.Settings.Default.userName + 
                                    "' FROM M_UMAT WHERE UMAT_OPEN_FLAG='1'";
                comm.CommandTimeout = 10000;
                comm.ExecuteNonQuery();

                trans.Commit();
                this.pdHeaderId = header_id;
                hasil = true;
            }
            catch (SystemException err)
            {
                trans.Rollback();
                hasil = false;
                iMessage.erBoxOk(err.Message);
            }
            finally { conn.Close(); }

            return hasil;
        }

        public Boolean editHeader(String headerId, String tema, String pewarta) {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "UPDATE T_PD_HEADERS SET PD_TITLE='" + pewarta + 
                                                    "', PD_SPEAKER='" + tema +
                                                    "', MOD_DATE=NOW(), MOD_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                                    "' WHERE PD_HEADER_ID='" + headerId + "'";
                comm.CommandTimeout = 10000;
                comm.ExecuteNonQuery();

                trans.Commit();
                hasil = true;
            }
            catch (SystemException err)
            {
                hasil = false;
                trans.Rollback();
                iMessage.erBoxOk(err.Message);
            }
            finally { conn.Close(); }

            return hasil;
        }

        public void editLines(String lineId, String hadir)
        {
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "UPDATE T_PD_LINES SET PD_PRESENT_FLAG='" + hadir +
                                                    "', MOD_DATE=NOW(), MOD_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                                    "' WHERE PD_LINE_ID=" + lineId;
                comm.CommandTimeout = 10000;
                comm.ExecuteNonQuery();

                trans.Commit();
            }
            catch (SystemException err)
            {
                trans.Rollback();
                iMessage.erBoxOk(err.Message);
                iMessage.erBoxOk("Terjadi kesalahan sistem. Silakan hubungi Administrator Anda");
            }
            finally { conn.Close(); }
        }

        public Boolean insertLine(string headerId, string umatId, string compName, string aliasName, string place, string date,
                                  string phone, string sex) {
            bool hasil = false;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "INSERT INTO T_PD_LINES(PD_HEADER_ID, PD_UMAT_ID, PD_UMAT_COMP_NAME," +
                                    " PD_UMAT_ALIAS_NAME, PD_UMAT_BORN_PLACE, PD_UMAT_BORN_DATE," +
                                    " PD_UMAT_PHONE, PD_UMAT_SEX, PD_PRESENT_FLAG," +
                                    " CREATE_DATE, CREATE_BY, MOD_DATE, MOD_BY) VALUES('" + 
                                    headerId + "','" + umatId + "','" + compName + "','" + 
                                    aliasName + "','" + place + "','" + date + "','" + 
                                    phone + "','" + sex + "','1', NOW(),'" +
                                    AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                    "', NOW(), '" + AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                    "')";
                comm.CommandTimeout = 10000;
                comm.ExecuteNonQuery();

                trans.Commit();
                hasil = true;
            }
            catch (SystemException err)
            {
                trans.Rollback();
                hasil = false;
                iMessage.erBoxOk(err.Message);
            }
            finally { conn.Close(); }

            return hasil;
        }

        public void getUmats(string headerId, DataTable dt1)
        {
            DataTable dt = new DataTable();
            DataRow dr;

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT PD_LINE_ID, PD_HEADER_ID, PD_UMAT_ID, PD_UMAT_COMP_NAME, PD_UMAT_ALIAS_NAME, PD_UMAT_PHONE," + 
                                    " PD_UMAT_BORN_PLACE, PD_UMAT_BORN_DATE, PD_UMAT_SEX, PD_PRESENT_FLAG" +
                                    " FROM T_PD_LINES WHERE PD_HEADER_ID='" + headerId + 
                                    "' ORDER BY PD_UMAT_COMP_NAME";
                comm.CommandTimeout = 10000;
                sda = new OleDbDataAdapter();
                sda.SelectCommand = comm;
                sda.Fill(dt);

                if (dt.Rows.Count > 0) {
                    for (int a = 0; a <= dt.Rows.Count - 1; a++) {
                        dr = dt1.NewRow();
                        dr[0] = dt.Rows[a][0].ToString();
                        dr[1] = dt.Rows[a][1].ToString();
                        dr[2] = dt.Rows[a][2].ToString();
                        dr[3] = dt.Rows[a][3].ToString();
                        dr[4] = dt.Rows[a][4].ToString();
                        dr[5] = dt.Rows[a][5].ToString();
                        dr[6] = dt.Rows[a][6].ToString();
                        dr[7] = dt.Rows[a][7].ToString();
                        dr[8] = dt.Rows[a][8].ToString();

                        if (dt.Rows[a][9].ToString() == "1")
                        {
                            dr[9] = true;
                            pdTotal = pdTotal + 1;
                        }
                        else {
                            dr[9] = false;
                        }

                        dt1.Rows.Add(dr);
                    }
                }
            }
            catch (SystemException err)
            {
                iMessage.erBoxOk(err.Message);
            }
            finally { conn.Close(); }

            
        }

        // not use since 25 July 2019
        private String getMaxNo()
        {
            string maxNo = string.Empty;
            int value = this.pdNextNo + 1;

            if (value == 0)
            {
                maxNo = "S" + DateTime.Now.ToString("yy") + "001";
            }
            else
            {
                string str = Convert.ToString(value);

                while (str.Length != 3)
                {
                    str = "0" + str;
                }

                maxNo = "S" + DateTime.Now.ToString("yy") + str;
            }

            return maxNo;
        }

        public DataTable callRptPD(string fields, String param, String order) {
            DataTable dt = new DataTable();

            String dParam = " WHERE PD_PRESENT_FLAG='1' ";
            if (String.IsNullOrEmpty(fields)) { fields = "*"; }
            if (!String.IsNullOrEmpty(param)) { param = dParam + " AND " + param; }
            if (!String.IsNullOrEmpty(order)) { order = " ORDER BY " + order; }

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT " + fields + " FROM T_PD_HEADERS H, T_PD_LINES L " + 
                                param + order;
                comm.CommandTimeout = 10000;
                sda = new OleDbDataAdapter();
                sda.SelectCommand = comm;
                sda.Fill(dt);
            }
            catch (SystemException err)
            {
                iMessage.erBoxOk(err.Message);
            }
            finally { conn.Close(); }

            return dt;
        }

        public DataTable callRptGraph()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                comm.Connection = conn;
                //comm.CommandText = "SELECT TOTAL.PD_UMAT_ID, TOTAL.PD_UMAT_COMP_NAME, TOTAL.JML AS TOTAL," +     
                //                    " HADIR.JML AS HADIR, ABSEN.JML AS ABSEN" +
                //                    " FROM (SELECT PD_UMAT_ID, PD_UMAT_COMP_NAME, COUNT(PD_UMAT_ID) AS JML" +
                //                    " FROM T_PD_LINES GROUP BY PD_UMAT_ID, PD_UMAT_COMP_NAME) AS TOTAL," +
                //                    " (SELECT PD_UMAT_ID, COUNT(PD_UMAT_ID)AS JML FROM T_PD_LINES" +
                //                    " WHERE PD_PRESENT_FLAG = '1' GROUP BY PD_UMAT_ID) AS HADIR," +
                //                    " (SELECT PD_UMAT_ID, COUNT(PD_UMAT_ID)AS JML FROM T_PD_LINES" +
                //                    " WHERE PD_PRESENT_FLAG = '0' GROUP BY PD_UMAT_ID) AS ABSEN" +
                //                    " WHERE TOTAL.PD_UMAT_ID = HADIR.PD_UMAT_ID AND TOTAL.PD_UMAT_ID = ABSEN.PD_UMAT_ID" +
                //                    " ORDER BY HADIR.JML DESC";
                comm.CommandText = "SELECT TOTAL.PD_UMAT_COMP_NAME AS NAMA, ((HADIR.JML / TOTAL.JML) * 100) AS PERSEN" +
                                    " FROM (SELECT PD_UMAT_ID, PD_UMAT_COMP_NAME, COUNT(PD_UMAT_ID) AS JML" +
                                        " FROM T_PD_LINES GROUP BY PD_UMAT_ID, PD_UMAT_COMP_NAME) AS TOTAL," +
                                    " (SELECT PD_UMAT_ID, COUNT(PD_UMAT_ID) AS JML FROM T_PD_LINES" +
                                    " WHERE PD_PRESENT_FLAG = '1' GROUP BY PD_UMAT_ID) AS HADIR" +
                                    " WHERE TOTAL.PD_UMAT_ID = HADIR.PD_UMAT_ID ORDER BY HADIR.JML DESC";
                comm.CommandTimeout = 10000;
                sda = new OleDbDataAdapter();
                sda.SelectCommand = comm;
                sda.Fill(dt);
            }
            catch (SystemException err)
            {
                iMessage.erBoxOk(err.Message);
            }
            finally { conn.Close(); }

            return dt;
        }
    }
}