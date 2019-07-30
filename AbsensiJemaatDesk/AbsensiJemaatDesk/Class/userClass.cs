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
    class userClass
    {
        private String userId = "";
        private String userName = "";
        private String userPass = "";
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
                                    "' AND USER_PASSWORD='" + userPass + "';";
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
    }
}