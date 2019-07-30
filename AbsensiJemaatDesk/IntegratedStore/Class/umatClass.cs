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
    class umatClass
    {
        private String umatId = string.Empty;
        private String umatName = string.Empty;
        private String umatAlias = string.Empty;
        private String umatPlace = string.Empty;
        private String umatDate = string.Empty;
        private String umatAddress = string.Empty;
        private String umatHomePhone = string.Empty;        //
        private String umatPhone = string.Empty;
        private String umatSex = string.Empty;
        private String umatStatus = string.Empty;           //
        private String umatReligy = string.Empty;           //
        private String umatActivity = string.Empty;         //
        private String umatComm = string.Empty;             //
        private String umatParoki = string.Empty;   
        private String umatEnvironment = string.Empty;
        private String umatSocMed = string.Empty;           //
        private String umatSocMedUsername = string.Empty;   //
        OleDbTransaction trans = null;
        private OleDbConnection conn = null;
        private OleDbCommand comm = new OleDbCommand();
        private OleDbDataAdapter sda;
        private OleDbDataReader sdr = null;

        public umatClass(){
            conn = new OleDbConnection(AbsensiJemaatDesk.Properties.Settings.Default.conStr);
        }
        
        public DataTable getUmats()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM M_UMAT ORDER BY UMAT_ID";
                comm.CommandTimeout = 10000;
                sda = new OleDbDataAdapter();
                sda.SelectCommand = comm;
                sda.Fill(dt);
            }
            catch (SystemException err)
            {
                iMessage.erBoxOk(err.Message);
                iMessage.iBoxOk("Terjadi kesalahan sistem." + Environment.NewLine + "Harap hubungi Adminstrator Anda.");
            }
            finally { conn.Close(); }

            return dt;
        }

        public Boolean saveUmat(String id, String nama, String alias, String alamat, String hp, 
                                String tempat, String tanggal, String gender, String paroki, String lingkungan, 
                                String home_phone, String status, String religius, String aktivitas,
                                String commu, String socmed, String socmed_username)
        {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "INSERT INTO M_UMAT(UMAT_ID, UMAT_COMP_NAME, UMAT_ALIAS_NAME, UMAT_SEX," + 
                                                    " UMAT_PLACE_BIRTH, UMAT_DATE_BIRTH, UMAT_ADDRESS, UMAT_PHONE," + 
                                                    " UMAT_PAROKI, UMAT_ENVIRONMENT, UMAT_OPEN_FLAG," +
                                                    " CREATE_DATE, CREATE_BY, MOD_DATE, MOD_BY, UMAT_HOME_PHONE," + 
                                                    " UMAT_STATUS, UMAT_RELIGIUS, UMAT_ACTIVITY, UMAT_COMMUNITY," +
                                                    " UMAT_SOCMED, UMAT_SOCMED_USERNAME) VALUES('" +
                                                    id + "','" + nama + "','" + alias + "','" + gender + "','" + 
                                                    tempat + "','" + tanggal + "','" + alamat + "','" + hp + "','" +
                                                    paroki + "','" + lingkungan + "','1',NOW(),'" +
                                                    AbsensiJemaatDesk.Properties.Settings.Default.userName + "', NOW(),'" + 
                                                    AbsensiJemaatDesk.Properties.Settings.Default.userName + "','" + 
                                                    home_phone + "','" + status + "','" + religius + "','" +
                                                    aktivitas + "','" + commu + "','" + socmed + "','" + socmed_username + "');";
                comm.CommandTimeout = 10000;
                comm.ExecuteNonQuery();

                trans.Commit();
                hasil = true;
            }
            catch (SystemException err)
            {
                trans.Rollback();
                iMessage.erBoxOk(err.Message);
                hasil = false;
            }
            finally
            {
                conn.Close();
            }

            return hasil;
        }

        public Boolean editUmat(String currId, String nama, String alias, String alamat, String hp,
                                String tempat, String tanggal, String gender, String paroki, String lingkungan,
                                String home_phone, String status, String religius, String aktivitas,
                                String commu, String socmed, String socmed_username)
        {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "UPDATE M_UMAT SET UMAT_COMP_NAME='" + nama +
                                                    "', UMAT_ALIAS_NAME='" + alias +
                                                    "', UMAT_SEX='" + gender +
                                                    "', UMAT_PLACE_BIRTH='" + tempat +
                                                    "', UMAT_DATE_BIRTH='" + tanggal +
                                                    "', UMAT_ADDRESS='" + alamat +
                                                    "', UMAT_PHONE='" + hp +
                                                    "', UMAT_PAROKI='" + paroki +
                                                    "', UMAT_ENVIRONMENT='" + lingkungan + 
                                                    "', MOD_DATE=NOW()" +
                                                    ", MOD_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                                    "', UMAT_HOME_PHONE='" + home_phone +
                                                    "', UMAT_STATUS='" + status +
                                                    "', UMAT_RELIGIUS='" + religius +
                                                    "', UMAT_ACTIVITY='" + aktivitas +
                                                    "', UMAT_COMMUNITY='" + commu +
                                                    "', UMAT_SOCMED='" + socmed +
                                                    "', UMAT_SOCMED_USERNAME='" + socmed_username +
                                                    "' WHERE UMAT_ID='" + currId + "';";
                comm.CommandTimeout = 10000;
                comm.ExecuteNonQuery();

                trans.Commit();
                hasil = true;
            }
            catch (SystemException err)
            {
                trans.Rollback();
                iMessage.erBoxOk(err.Message);
                hasil = false;
            }
            finally
            {
                conn.Close();
            }

            return hasil;
        }

        public Boolean deleteUmat(String id)
        {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                //  Command diupdate menjadi delete krn user spt nya ga mau keep umat yg ga aktif
                //comm.CommandText = "UPDATE M_UMAT SET UMAT_OPEN_FLAG='0'" +
                //                    ", MOD_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userId +
                //                    "', MOD_DATE=NOW() WHERE UMAT_ID='" + id + "';";
                comm.CommandText = "DELETE FROM M_UMAT WHERE UMAT_ID='" + id + "';";
                comm.CommandTimeout = 10000;
                comm.ExecuteNonQuery();

                trans.Commit();
                hasil = true;
            }
            catch (SystemException err)
            {
                trans.Rollback();
                iMessage.erBoxOk(err.Message);
                hasil = false;
            }
            finally
            {
                conn.Close();
            }

            return hasil;
        }

        public String nextId()
        {
            String next = "";
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT MAX(UMAT_ID) FROM M_UMAT";
                comm.CommandTimeout = 10000;
                sdr = comm.ExecuteReader();
                sdr.Read();
                if (sdr.IsDBNull(0))
                {
                    next = "U000";
                    sdr.Close();
                }
                else
                {
                    //next = sdr.GetInt16(0);
                    next = sdr.GetString(0);
                    sdr.Close();
                }
            }
            catch (SystemException err)
            {
                next = "U000";
                iMessage.erBoxOk(err.Message);
            }
            finally
            {
                conn.Close();
            }

            return next;
        }

        public DataTable callRptUmat(String fields, String param)
        {
            DataTable dt = new DataTable();

            if (String.IsNullOrEmpty(fields)) { fields = "*"; }
            if (!String.IsNullOrEmpty(param)) { param = " WHERE " + param; }

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT " + fields + " FROM M_UMAT " + 
                                    param + " ORDER BY UMAT_DATE_BIRTH, UMAT_COMP_NAME";
                comm.CommandTimeout = 10000;
                sda = new OleDbDataAdapter();
                sda.SelectCommand = comm;
                sda.Fill(dt);
            }
            catch (SystemException err)
            {
                iMessage.erBoxOk(err.Message);
                iMessage.iBoxOk("Terjadi kesalahan sistem." + Environment.NewLine + "Harap hubungi Adminstrator Anda.");
            }
            finally { conn.Close(); }

            return dt;
        }
    }
}