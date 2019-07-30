using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace AbsensiJemaatDesk
{
    class connClass
    {
        private OleDbConnection conn = null;
        private OleDbCommand comm = new OleDbCommand();
        private OleDbDataReader sdr;
        private String constr= "Provider=microsoft.Jet.oledb.4.0; DataSource=";
        
        public void setDb (){
            conn.ConnectionString = AbsensiJemaatDesk.Properties.Settings.Default.conStr +"; database=" + db + ";";
            
        }

        public Boolean testConn()
        {
            try
            {   conn = new OleDbConnection(constr + AppDomain.CurrentDomain.BaseDirectory + "dbAbsen");
                conn.Open();
                return true;
            }
            catch (SystemException err)
            {
                iMessage.erBoxOk(err.Message);
                iMessage.iBoxOk("Terjadi kesalahan sistem." + Environment.NewLine + "Harap hubungi Adminstrator Anda.");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> dbList()
        {
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
            catch (MySqlException err)
            {
                iMessage.erBoxOk(err.Message);
                iMessage.iBoxOk("Terjadi kesalahan sistem." + Environment.NewLine + "Harap hubungi Adminstrator Anda.");
            }
            finally
            {
                sdr.Close();
                conn.Close();
            }

            return dbList;
        }
    }
}
