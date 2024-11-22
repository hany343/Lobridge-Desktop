using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoBridge
{
    class SQLConnector
    {
        private string ServerName = ".\\SQLEXPRESS";
        private string DBInstance = "WDB";
        private string UName = "hany";
        private string UPass = "dareen";
        SqlConnection conn = new SqlConnection();


        public SqlConnection GetConnection()
        {
            conn.ConnectionString =
                "Data Source=" + ServerName +
                ";Initial Catalog=" + DBInstance +
                "; User id=" + UName +
                "; Password=" + UPass + ";";
            //Data Source = OILEX - LOG - PC6\WDB; Initial Catalog = wdb; Persist Security Info = True; User ID = hany; Password = D@reen117
            try
            {
                conn.Open();
                //MessageBox.Show("connection success", "");
            }
            catch
            {
                MessageBox.Show("connection Failed", "");
            }
            return conn;
        }

        public bool firstweight(string receiptCard_ID, string truck_number, string trailer_number, string date, string Time_IN,
                                string Comm_type, int first_weight, int pack_Count, string stack_Bar, string Notes)
        {

            string qurey = @" INSERT INTO[dbo].[first_Weight]  ( receiptCard_ID,truck_number,trailer_number,date,Time_IN,Comm_type,
                            first_weight , pack_Count, stack_Bar, Notes)
                            VALUES (" + receiptCard_ID + ",'" + truck_number + "','" + trailer_number + "','" + date + "','" + Time_IN + "','" +
                           Comm_type + "'," + first_weight + "," + pack_Count + ",'" + stack_Bar + "','" + Notes + "')";

            SqlCommand command = new SqlCommand(qurey, conn);
            GetConnection();
            command.ExecuteNonQuery();
            conn.Close();

            return true;
        }

        public bool addSupplier(string SUP_NAME, string PHONE, string MOBILE, string CITY, string ADDRESS)
        {

            string qurey = @" INSERT INTO[dbo].[Suppliers]  ( SUP_NAME,PHONE,MOBILE,CITY,ADDRESS)
                            VALUES (" + SUP_NAME + "','" + PHONE + "','" + MOBILE + "','" + CITY + "','" + ADDRESS + "')";
            SqlCommand command = new SqlCommand(qurey, conn);
            GetConnection();
            //conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            return true;
        }

    }
}
