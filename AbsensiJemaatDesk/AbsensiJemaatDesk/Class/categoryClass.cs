using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace AbsensiJemaatDesk
{
    class categoryClass
    {
        private MySqlConnection conn = null;
        MySqlTransaction trans = null;
        private MySqlCommand comm = new MySqlCommand();
        private MySqlDataAdapter sda;
        
        public categoryClass(){
           conn = new MySqlConnection(AbsensiJemaatDesk.Properties.Settings.Default.conStr);
        }
        
        public DataTable getCategories()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM M_CATEGORY ORDER BY CATEGORY_ID";
                comm.CommandTimeout = 10000;
                sda = new MySqlDataAdapter();
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

        public Boolean saveCategory(String id, String desc, String status) {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction(); 
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "INSERT INTO M_CATEGORY SET CATEGORY_ID='" + id +
                                        "', CATEGORY_DESC='" + desc +
                                        "', CATEGORY_OPEN_FLAG='" + status +
                                        "', CREATE_DATE=SYSDATE()" +
                                        ", CREATE_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userName +
                                        "', MOD_DATE=SYSDATE()" +
                                        ", MOD_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userName + "';";
                comm.CommandTimeout = 10000;
                comm.ExecuteNonQuery();

                trans.Commit();
                hasil = true;
            }
            catch (SystemException err) {
                trans.Rollback();
                iMessage.erBoxOk(err.Message);
                hasil = false;
            }
            finally {
                conn.Close();
            }

            return hasil;
        }

        public Boolean editCategory(String id, String desc) {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "UPDATE M_CATEGORY SET CATEGORY_DESC='" + desc +
                                    "', MOD_DATE=SYSDATE()" +
                                    ", MOD_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userId +
                                    "' WHERE CATEGORY_ID='" + id + "';";
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
            finally {
                conn.Close();
            }

            return hasil;
        }

        public Boolean deleteCategory(String id) {
            bool hasil = false;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                comm.Connection = conn;
                comm.Transaction = trans;

                comm.CommandText = "UPDATE M_CATEGORY SET CATEGORY_OPEN_FLAG='0'" +
                                    ", MOD_BY='" + AbsensiJemaatDesk.Properties.Settings.Default.userId + 
                                    "', MOD_DATE=SYSDATE() WHERE CATEGORY_ID='" + id + "';";
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
            finally {
                conn.Close();
            }

            return hasil;
        }
    }
}