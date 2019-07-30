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

        OleDbTransaction trans = null;
        private OleDbConnection conn = null;
        private OleDbCommand comm = new OleDbCommand();
        private OleDbDataAdapter sda;
        private OleDbDataReader sdr = null;

        public pdClass()
        {
            conn = new OleDbConnection(AbsensiJemaatDesk.Properties.Settings.Default.conStr);
        }

        public Boolean savePD()
        {
            return true;
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

        public void setNextNo()
        {
            this.pdNextNo = nextNo();
        }

        //public DataTable

        public String checkService()
        {
            string status = string.Empty;

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT PD_HEADER_ID, PD_TITLE, PD_SPEAKER, PD_NEXT_NO FROM T_PD_HEADERS" +
                                    " WHERE PD_DATE>=#" + DateTime.Now.ToString("dd-MM-yyyy") + "#";
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
                }
                else
                {
                    sdr.Close();
                    conn.Close();

                    nextNo();
                    this.pdHeaderId = getMaxNo();
                    savePD(this.pdHeaderId);
                }

                status = "GOOD";
            }
            catch (SystemException err)
            {
                status = "ERR";
                iMessage.erBoxOk(err.Message);
            }

            return status;
        }

        private void nextNo()
        {
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.CommandText = "SELECT MAX(PD_NEXT_NO) FROM T_PD_HEADERS";
                comm.CommandTimeout = 10000;
                sdr = comm.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    this.pdNextNo = sdr.GetInt16(3);

                    sdr.Close();
                }
                else
                {
                    this.pdNextNo = 1;
                    sdr.Close();
                }
            }
            catch (SystemException err)
            {
                iMessage.erBoxOk(err.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void savePD(String maxNo)
        {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "INSERT INTO T_PD_HEADERS(PD_HEADER_ID, PD_DATE, PD_TYPE, PD_TITLE, PD_SPEAKER," +
                                                    " PD_NEXT_NO, CREATE_DATE, CREATE_BY, MOD_DATE, MOD_BY) VALUES(" +
                                                    "'" + maxNo + "',NOW(),'YOUTH SATURDAY SERVICE','','','" +
                                                    (pdNextNo + 1) + "',NOW(),'" +
                                                    AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                                    "', NOW(), '" + AbsensiJemaatDesk.Properties.Settings.Default.userName + "')";
                comm.CommandTimeout = 10000;
                comm.ExecuteNonQuery();

                comm.CommandText = "INSERT INTO T_PD_LINES(PD_HEADER_ID, PD_UMAT_ID, PD_UMAT_COMP_NAME," +
                                    " PD_UMAT_ALIAS_NAME, PD_UMAT_BORN_PLACE, PD_UMAT_BORN_DATE," +
                                    " PD_UMAT_PHONE, PD_UMAT_SEX, PD_PRESENT_FLAG," +
                                    " CREATE_DATE, CREATE_BY, MOD_DATE, MOD_BY) SELECT (" +
                                    "'" + maxNo + "', UMAT_ID, UMAT_COMP_NAME, UMAT_ALIAS_NAME, UMAT_ADDRESS," +
                                    " UMAT_PLACE_BIRTH, UMAT_DATE_BIRTH, UMAT_PHONE, UMAT_SEX, '0', NOW()," +
                                    AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                    "', NOW(), '" + AbsensiJemaatDesk.Properties.Settings.Default.userName + "')";
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

        public Boolean editHeader(String headerId, String tema, String pewarta)
        {
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

        public void getUmats(string headerId, DataTable dt)
        {
            //DataTable dt = new DataTable();

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
                //sda.Fill(dt);

                if (sda.rows.count > 0)
                {
                    for (int a = 0; a <= sda.row.count - 1; a++)
                    {

                    }
                }
            }
            catch (SystemException err)
            {
                iMessage.erBoxOk(err.Message);
            }
            finally { conn.Close(); }

            return dt;
        }

        private String getMaxNo()
        {
            string maxNo = string.Empty;
            int value = this.pdNextNo;

            if (value == 0)
            {
                maxNo = "S" + DateTime.Now.ToString("yy") + "001";
            }
            else
            {
                string str = Convert.ToString(this.pdNextNo);

                while (str.Length != 3)
                {
                    str = "0" + str;
                }

                maxNo = "S" + DateTime.Now.ToString("yy") + str;
            }

            return maxNo;
        }
    }
}