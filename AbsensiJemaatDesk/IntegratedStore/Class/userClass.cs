using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace AbsensiJemaatDesk
{
    class userClass
    {
        private String userId = string.Empty;
        private String userName = string.Empty;
        private String userPass = string.Empty;
        OleDbTransaction trans = null;
        private OleDbConnection conn = null;
        private OleDbCommand comm = new OleDbCommand();
        private OleDbDataAdapter sda;
        
        public userClass(String userId, String userName, String userPass){
            this.userId = userId;
            this.userName = userName;
            this.userPass = userPass;

            conn = new OleDbConnection(AbsensiJemaatDesk.Properties.Settings.Default.conStr);
        }
        
        public int validateUser(){
            //note: -1 -> error; 0 -> null; 1 -> result
            int hasil = 0;

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT USER_ID, USER_NAME, USER_PASSWORD FROM M_USER WHERE USER_NAME='" + userName +
                                    "' AND USER_PASSWORD='" + userPass + "' AND USER_OPEN_FLAG='1';";
                comm.CommandTimeout = 10000;
                sda = new OleDbDataAdapter();
                sda.SelectCommand = comm;
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    AbsensiJemaatDesk.Properties.Settings.Default.userId = dt.Rows[0][0].ToString();
                    AbsensiJemaatDesk.Properties.Settings.Default.userName = dt.Rows[0][1].ToString();
                    AbsensiJemaatDesk.Properties.Settings.Default.userPass = dt.Rows[0][2].ToString();
                    hasil = 1;
                }
                else
                    hasil = 0;
            }
            catch (SystemException err)
            {
                iMessage.erBoxOk(err.Message);
                hasil = -1;
            }
            finally {
                conn.Close(); 
            }               

            return hasil;
        }

        public DataTable getUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM M_USER ORDER BY USER_ID";
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

        public Boolean saveUser(String id, String nama)
        {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "INSERT INTO M_USER(USER_ID, USER_NAME, USER_PASSWORD, USER_OPEN_FLAG," +
                                                    " CREATE_DATE, CREATE_BY, MOD_DATE, MOD_BY) VALUES(" +
                                                    "'" + id + "','" + nama + "','" +
                                                     encryptClass.Encrypt2("S@lv4tion", "welcome") +
                                                    "','1',NOW(),'" +
                                                    AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                                    "', NOW(), '" + AbsensiJemaatDesk.Properties.Settings.Default.userName + "')";
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

        public Boolean editUser(String currId, String nama)
        {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "UPDATE M_USER SET USER_NAME='" + nama +
                                    "', MOD_DATE=NOW()" +
                                    ", MOD_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                    "' WHERE USER_ID='" + currId + "';";
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

        public Boolean deleteUser(String id)
        {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "UPDATE M_USER SET USER_OPEN_FLAG='0'" +
                                    ", MOD_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userId +
                                    "', MOD_DATE=NOW() WHERE USER_ID='" + id + "';";
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

        public Boolean changePass(String currId, String password)
        {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "UPDATE M_USER SET USER_PASSWORD='" + password +
                                    "', MOD_DATE=NOW()" +
                                    ", MOD_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                    "' WHERE USER_ID='" + currId + "';";
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
    }
}