using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OutWCard : Form
    {

        public OutWCard()
        {

            InitializeComponent();

        }

        DataQuery dq = new DataQuery();


        private void printW(int wcid)
        {
            try
            {
                Print_Wcard pw = new Print_Wcard(wcid, "out");

                pw.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            // dateTextBox.Text = System.DateTime.Now.ToString("MM/dd/yyyy   HH:mm:ss");
            loaddata();
        }

        private void OUTWCard_Load(object sender, EventArgs e)
        {

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000;
            loaddata();
            cardnumberTxtbx.Focus();
        }
        public void loaddata()
        {
            try
            {
                this.lcacrd1BindingSource.DataSource = dq.GetDataTable("SELECT Lading_Out.ladingID, Lading_Out.Qty, Lading_Out.Date, Lading_Out.LOusername, Lading_Out.Loading_Station, Lading_Out.F_weight, Lading_Out.S_weight, Lading_Out.Net_Weight, Commodity.Comm_NAME, "

        + " Lading_Out.Trans_type, Lading_Out.Representative, Lading_Out.Fill_Type, [Order].Order_Number, Contract.Contract_Number, Lading_Out.Bags_Count, Lading_Out.Stack_Bar, WcardID.WCardID, Lading_Out.F_Wdate, "
          + "               Lading_Out.S_Wdate, Contract.Contract_Type, Customers.Cust_NAME, Transport_Co.Company_Name, Truck.Truck_number, Truck.Truck_traffic, Truck.Trailer_number, Truck.Trailer_traffic, Truck.Owner, Drivers.Driver_Name, "
            + "             Drivers.Liscense_num, Lading_Out.ShipAddress, Drivers.N_Card, Lading_Out.LeaveDate, Lading_Out.Status, Lading_Out.Lading_Notes, Lading_Out.Ship_City"
        + " FROM Lading_Out INNER JOIN"
          + "               [Order] ON Lading_Out.Order_ID = [Order].Order_ID INNER JOIN"
          + "               Contract ON[Order].Contract_ID = Contract.Contract_ID INNER JOIN"
             + "            Commodity ON Contract.Comm_ID = Commodity.Comm_ID INNER JOIN"
                + "         WcardID ON Lading_Out.ladingID = WcardID.LADOUT_ID INNER JOIN"
                   + "      Customers ON[Order].Cust_ID = Customers.Cust_ID INNER JOIN"
                      + "   Transport_Co ON Lading_Out.TransC_ID = Transport_Co.Company_ID INNER JOIN"
                         + " Truck ON Lading_Out.Truck_ID = Truck.Truck_ID INNER JOIN"
                         + " Drivers ON Lading_Out.Driver_ID = Drivers.Driver_ID" +
                         " WHERE(Lading_Out.Status =N'اول' or Lading_Out.Status =N'ثان') ");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void OutWCard_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.Message + " erw13");
            }

            Cursor.Current = Cursors.Default;
        }


        private void ladingDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    //int lid = int.Parse(ladingIDComboBox.Text);
                    ////lading_OutTableAdapter.FillByStatsAndlid(this.oUTDataset.Lading_Out, lid);
                    //BridgeOut br = new BridgeOut(lid);
                    //br.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + string.Empty);
                }
            }

        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cardnumberTxtbx_Leave(object sender, EventArgs e)
        {
            //  ((TextBox)sender).Focus();
        }


        private void cardnumberTxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;

                textBox.SelectAll();
                sendvalue();
            }

        }

        private void sendvalue()
        {
            int wvalue;
            if (int.TryParse(cardnumberTxtbx.Text, out wvalue))
            {
                string sts = dq.GetStringValu("Select Status from Lading_out WHERE Lading_Out.ladingID =" + wvalue);
                if (sts == "اول" || sts == "ثان")
                {

                    BridgeOut bridgeOut = new BridgeOut(wvalue);

                    bridgeOut.ShowDialog();
                    loaddata();
                }
                else if (sts == "تم")
                {

                    MessageBox.Show("تم الوزن  ");
                }
                else if (sts == "ملغي")
                {

                    MessageBox.Show("الكارت ملغي");
                }
                else
                {

                    MessageBox.Show("غير موجود");
                }
            }

        }
        private void cardnumberTxtbx_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            textBox.SelectAll();

        }

        private void dateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != (char)Keys.Enter)
            {
                cardnumberTxtbx.Text = cardnumberTxtbx.Text + e.KeyChar;

            }
            else
            {
                cardnumberTxtbx.Focus();
                sendvalue();
                cardnumberTxtbx.SelectAll();
            }
        }

        private void OutWCard_Paint(object sender, PaintEventArgs e)
        {
            cardnumberTxtbx.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}

