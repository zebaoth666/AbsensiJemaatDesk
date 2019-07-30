using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace AbsensiJemaatDesk
{
    class dbClass
    {
        private string conString = "";
        private string server = "";
        private string port = "";
        private string user = "";
        private string password = "";
        private string db = "";

        public dbClass(String server, String port, String user, String password, String db) {
            this.server = server;
            this.port = port;
            this.user = user;
            this.password = password;
            this.db = db;
        }

        public virtual string ConStr(){
            conString = "Provider=microsoft.Jet.oledb.4.0; Password=S@lv4tion; DataSource=";

            return conString;
        }
    }

    class dbConn : dbClass{
        private MySqlConnection conn = null;
        private MySqlCommand comm = new MySqlCommand();
        private MySqlDataAdapter sda = new MySqlDataAdapter();
        private MySqlDataReader sdr=null;
        private MySqlTransaction txn ;//= new MySqlTransaction();

        public dbConn(String server, String port, String user, String password, String db) : base(server, port, user, password, db) {
            conn = new MySqlConnection(ConStr());
        }

        public Boolean testConn()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException err)
            {
                iMessage.iBoxOk(err.Message);
                iMessage.erBoxOk("Terjadi Kesalahan Sistem");
                return false;
            }
            finally {
                conn.Close();
            }
        }

        public List<string> dbList(){
            List<string> dbList = new List<string>();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "use information_schema; select schema_name as DAFTAR_DATABASE from schemata";
                comm.CommandTimeout = 10000;
                sdr = comm.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        dbList.Add(sdr.GetString(0));
                    }
                }
            }
            catch(MySqlException err) {
                iMessage.iBoxOk(err.Message);
                iMessage.erBoxOk("Terjadi Kesalahan Sistem");
            }
            finally {
                sdr.Close();
                conn.Close();
            }
            
            return dbList;
        }

        public void setConn(String db){
            string conString = base.ConStr() + " database=" + db + ";";
            this.conn.ConnectionString = conString;
        }

        public int getUser(String userName, String userPass) {
            int hasil = 0;

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "select user_id, user_name from m_user where user_name ='" + userName +
                                "' and user_password='" + userPass + "'";
                comm.CommandTimeout = 10000;
                sda.SelectCommand = comm;
                DataSet ds = new DataSet();
                sda.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0) {
                    AbsensiJemaatDesk.Properties.Settings.Default.userId = ds.Tables[0].Rows[0][0].ToString();
                    hasil = ds.Tables[0].Rows.Count;
                } else
                    hasil = ds.Tables[0].Rows.Count;
            }
            catch (MySqlException err)
            {
                iMessage.iBoxOk(err.Message);
                iMessage.erBoxOk("Terjadi Kesalahan Sistem");
            }
            finally { conn.Close(); }

            return hasil;
        }

        public DataTable getListUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "select * from m_user order by user_id";
                comm.CommandTimeout = 10000;
                sda.SelectCommand = comm;
                sda.Fill(dt);
            }
            catch (MySqlException err)
            {
                iMessage.iBoxOk(err.Message);
                iMessage.erBoxOk("Terjadi Kesalahan Sistem");
            }
            finally { conn.Close(); }

            return dt;
        }
    }
}