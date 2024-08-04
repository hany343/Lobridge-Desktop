using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class INWCard : Form
    {


        public INWCard()
        {

            InitializeComponent();

        }

        private void WCard_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        private void ladingBindingNavigator_RefreshItems(object sender, EventArgs e)
        { }
        private void timer1_Tick(object sender, EventArgs e)
        {

            dateTextBox.Text = System.DateTime.Now.ToString("MM/dd/yyyy   HH:mm:ss");
        }
        private void INWCard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNdataset.Lading' table. You can move, or remove it, as needed.
            this.ladingTableAdapter.Fill(this.iNdataset.Lading);

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();


            // timer1.Tick += new EventHandler(timer1_Tick);
            loaddata();
            cardnumberTxtbx.Focus();
            cardnumberTxtbx.SelectAll();
        }
        DataQuery dq = new DataQuery();
        public void loaddata()
        {
            try
            {
                this.ladinginDataGridView.DataSource = dq.GetDataTable("SELECT  Lading.ladingID, Lading.BatchID, Lading.Lading_Notes, Lading.Loading_Station, Lading.Bags_Count, Lading.Date, Lading.Driver_ID, Lading.F_Wdate, Lading.F_wbridge, Lading.F_weigherName, Lading.F_weight, "
                     + "    Lading.Fill_Type, Lading.Net_Weight, Lading.S_Wdate, Lading.S_wbridge, Lading.S_weigherName, Lading.S_weight, Lading.Shrink, Lading.Stack_Bar, Lading.Truck_ID, Lading.Representative, Lading.Weight_Notes,"
                       + "  Lading.Qty, Lading.Lusername, Lading.Status, Lading.BLading, Commodity.Comm_NAME, Shipment.Shipping, SUPPLIERS.SUP_NAME, Drivers.Driver_Name, WcardID.WCardID, INBatch.Serial, Truck.Truck_number,"
                         + " Truck.Trailer_number FROM  Shipment INNER JOIN"
                        + " Commodity ON Shipment.Comm_ID = Commodity.Comm_ID INNER JOIN"
                        + " SUPPLIERS ON Shipment.Supp_ID = SUPPLIERS.SUP_ID INNER JOIN"
                        + " INBatch ON Shipment.Ship_ID = INBatch.Ship_ID INNER JOIN"
                        + " Lading INNER JOIN  Drivers ON Lading.Driver_ID = Drivers.Driver_ID INNER JOIN"
                       + "  WcardID ON Lading.ladingID = WcardID.LAD_ID ON INBatch.Batch_ID = Lading.BatchID INNER JOIN"
                       + "  Truck ON Lading.Truck_ID = Truck.Truck_ID "
                        + " WHERE(Lading.Status =N'اول' or Lading.Status =N'ثان') ");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            loaddata();
            Cursor.Current = Cursors.Default;
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        WPreviewCamera pr;

        private void INWCard_Shown_1(object sender, EventArgs e)
        {
            //    Cursor.Current = Cursors.WaitCursor;

            //    Cursor.Current = Cursors.Default;
        }

        private void INWCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        private void cardnumberTxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;

                textBox.SelectAll();
                sendValu();
            }
        }
        private void sendValu()
        {

            int wvalue;
            if (int.TryParse(cardnumberTxtbx.Text, out wvalue))
            {
                string sts = dq.GetStringValu("Select Status from Lading WHERE Lading.ladingID =" + wvalue);
                if (sts == "اول" || sts == "ثان")
                {

                    BridgeIN bridgeOut = new BridgeIN(wvalue);

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

        private void ladinginDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != (char)Keys.Enter)
            {
                cardnumberTxtbx.Text = cardnumberTxtbx.Text + e.KeyChar;

            }
            else
            {
                cardnumberTxtbx.Focus();
                sendValu();
                cardnumberTxtbx.SelectAll();
            }
        }

        private void INWCard_Paint(object sender, PaintEventArgs e)
        {
            cardnumberTxtbx.Focus();
        }
    }
}

