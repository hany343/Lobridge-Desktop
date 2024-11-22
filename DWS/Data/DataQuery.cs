using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoBridge
{
    class DataQuery
    {

        string connStr = "";
        public DataQuery()
        {
            bool devmode = Properties.Settings.Default.devmode;
            if(devmode) { 
                connStr = Properties.Settings.Default.DevString;
            }
            else
            {
                connStr = Properties.Settings.Default.wdbConnectionString;
            }

        }
        public DataTable GetDataTable(string query)
        {

            DataTable dt = new DataTable();

            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                dt.Load(cmd.ExecuteReader());
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "  خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return dt;
        }

        public void Log_Action(string act, string cdata, string tablename, string code)
        {
            //
            string logquery = " insert into Logs(uaction, cdata, tablename, code, username) values('" + act + "', '" + cdata + "', '" + tablename + "'," + code + " '" + Properties.Settings.Default.logedUN + "');";
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(logquery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "  خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public string GetStringValu(string query)
        {
            string SValue;
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SValue = cmd.ExecuteScalar() + "";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "  خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
            return SValue;
        }

        public bool RunNonQuery(string query)
        {
            bool success;
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "  خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return success;
        }


    }
}
