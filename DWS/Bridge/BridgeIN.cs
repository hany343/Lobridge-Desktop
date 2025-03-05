using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class BridgeIN : Form
    {
        int ladnum;
        public BridgeIN(int lnum)
        {
            ladnum = lnum;
            InitializeComponent();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private int tolerance = 20;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            base.WndProc(ref m);
        //            var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
        //            if (sizeGripRectangle.Contains(hitPoint))
        //                m.Result = new IntPtr(HTBOTTOMRIGHT);
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);

            //Graphics g = this.CreateGraphics();
            //double fw = this.Width; // form width
            //double tw = g.MeasureString(this.Text.Trim(), this.Font).Width; // text width
            //double rp = (fw - tw) / 2;
            //int tt = Convert.ToInt32(rp);
            //string st = " ";
            //st = st.PadRight(tt / 3);
            //this.Text = st + this.Text.Trim();

        }
        DataQuery dq = new DataQuery();
        private void txtbxLadnum_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            Cursor.Current = Cursors.Default;

        }
        WPreviewCamera pr;
        WScreen wScreen;
        private void BridgeOut_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            wScreen = new WScreen();
            wScreen.TopLevel = false;
            wScreen.Dock = DockStyle.Fill;
            panel3wscreen.Controls.Add(wScreen);
            wScreen.Show();




            try
            {
                DataTable dt = dq.GetDataTable("SELECT Lading.Truck_Type, Lading.ladingID, Lading.BatchID, Lading.Lading_Notes, Lading.Loading_Station, Lading.Bags_Count, Lading.Date, Lading.Driver_ID, Lading.F_Wdate, Lading.F_wbridge, Lading.F_weigherName, Lading.F_weight, "
                     + "    Lading.Fill_Type, Lading.Net_Weight, Lading.S_Wdate, Lading.S_wbridge, Lading.S_weigherName, Lading.S_weight, Lading.Shrink, Lading.Stack_Bar, Lading.Truck_ID, Lading.Representative, Lading.Weight_Notes,"
                       + "  Lading.Qty, Lading.Lusername, Lading.Status, Lading.BLading, Commodity.Comm_NAME, Shipment.Shipping, SUPPLIERS.SUP_NAME, Drivers.Driver_Name, WcardID.WCardID, INBatch.Serial, Truck.Truck_number,"
                         + " Truck.Trailer_number,Transport_Co.Company_Name FROM            Shipment INNER JOIN"
                        + " Commodity ON Shipment.Comm_ID = Commodity.Comm_ID INNER JOIN"
                        + " SUPPLIERS ON Shipment.Supp_ID = SUPPLIERS.SUP_ID INNER JOIN"
                        + " INBatch ON Shipment.Ship_ID = INBatch.Ship_ID INNER JOIN"
                        + " Lading INNER JOIN  Drivers ON Lading.Driver_ID = Drivers.Driver_ID INNER JOIN"
                       + "  WcardID ON Lading.ladingID = WcardID.LAD_ID ON INBatch.Batch_ID = Lading.BatchID INNER JOIN"
                       + "  Truck ON Lading.Truck_ID = Truck.Truck_ID "
                       + " INNER JOIN Transport_Co ON Shipment.Trans_Co = Transport_Co.Company_ID"
                        + " WHERE(ladingID=" + ladnum + " and (Lading.Status =N'اول' or Lading.Status =N'ثان')) ");
                this.wCard1BindingSource.DataSource = dt;

                ladingIDLabel1.Text = "*" + ladingIDLabel1.Text + "*";
                //  this.lcacrd1TableAdapter.FillForLadout(this.outdataset.Lcacrd1, ladnum);// ((int)(System.Convert.ChangeType(lcardToolStripTextBox.Text, typeof(int)))));



                DataTable ttypes = dq.GetDataTable("Select * from Truck_Types");
                if (ttypes.Rows.Count > 0)
                {
                    foreach (DataRow row in ttypes.Rows)
                    {
                        truck_TypeComboBox.Items.Add(row[0].ToString()); // Access column 0 value

                    }

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            try
            {
                int Incam = int.Parse(Properties.Settings.Default.inwcam);
                // TODO: This line of code loads data into the 'dLWSDataSet.Camera' table. You can move, or remove it, as needed.
                // this.cameraTableAdapter.FillBy(this.dLWSDataSet.Camera, outintcam);
                DataTable cams = dq.GetDataTable("Select * from Camera where Cam_id=" + Incam);
                if (cams.Rows.Count < 1)
                {
                    MessageBox.Show("لم يتم تسجيل كاميرات");
                }
                else
                {
                    try
                    {
                        pr = new WPreviewCamera(cams.Rows[0][2].ToString().Trim(),
                            cams.Rows[0][3].ToString().Trim()
                                , cams.Rows[0][4].ToString().Trim());

                        pr.TopLevel = false;
                        pr.Dock = DockStyle.Fill;

                        panel6Cam.Controls.Add(pr);
                        pr.Show();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " lc");
            }
            Cursor.Current = Cursors.Default;
        }


        //private void txtbxLadnum_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Return)

        //    {
        //        try
        //        {
        //            this.wca.DataSource = dq.GetDataTable("SELECT Lading_Out.ladingID, Lading_Out.Qty, Lading_Out.Date, Lading_Out.LOusername, Lading_Out.Loading_Station, Lading_Out.F_weight, Lading_Out.S_weight, Lading_Out.Net_Weight, Commodity.Comm_NAME, "

        //    + " Lading_Out.Trans_type, Lading_Out.Representative, Lading_Out.Fill_Type, [Order].Order_Number, Contract.Contract_Number, Lading_Out.Bags_Count, Lading_Out.Stack_Bar, WcardID.WCardID, Lading_Out.F_Wdate, "
        //      + "               Lading_Out.S_Wdate, Contract.Contract_Type, Customers.Cust_NAME, Transport_Co.Company_Name, Truck.Truck_number, Truck.Truck_traffic, Truck.Trailer_number, Truck.Trailer_traffic, Truck.Owner, Drivers.Driver_Name, "
        //        + "             Drivers.Liscense_num, Lading_Out.ShipAddress, Drivers.N_Card, Lading_Out.LeaveDate, Lading_Out.Status, Lading_Out.Lading_Notes, Lading_Out.Ship_City"
        //    + " FROM Lading_Out INNER JOIN"
        //      + "               [Order] ON Lading_Out.Order_ID = [Order].Order_ID INNER JOIN"
        //      + "               Contract ON[Order].Contract_ID = Contract.Contract_ID INNER JOIN"
        //         + "            Commodity ON Contract.Comm_ID = Commodity.Comm_ID INNER JOIN"
        //            + "         WcardID ON Lading_Out.ladingID = WcardID.LADOUT_ID INNER JOIN"
        //               + "      Customers ON[Order].Cust_ID = Customers.Cust_ID INNER JOIN"
        //                  + "   Transport_Co ON Lading_Out.TransC_ID = Transport_Co.Company_ID INNER JOIN"
        //                     + " Truck ON Lading_Out.Truck_ID = Truck.Truck_ID INNER JOIN"
        //                     + " Drivers ON Lading_Out.Driver_ID = Drivers.Driver_ID" +
        //                     " WHERE(Lading_Out.ladingID =" + ladnum + ")  ");

        //            //  this.lcacrd1TableAdapter.FillForLadout(this.outdataset.Lcacrd1, ladnum);// ((int)(System.Convert.ChangeType(lcardToolStripTextBox.Text, typeof(int)))));
        //            ladingIDLabel1.Text = "*" + ladingIDLabel1.Text + "*";
        //        }
        //        catch (System.Exception ex)
        //        {
        //            System.Windows.Forms.MessageBox.Show(ex.Message);
        //        }

        //    }
        //}

        private void panel6Cam_SizeChanged(object sender, EventArgs e)
        {

            try
            {

                panel6Cam.Controls.RemoveAt(0);
                panel6Cam.Controls.Add(pr);
            }
            catch (Exception ex)
            {

            }
        }

        private void f_weightLabel1_DoubleClick(object sender, EventArgs e)
        {

            int wvalue;
            if (int.TryParse(wScreen.Screen1.Text, out wvalue))
            {
                if (wvalue > 0)
                {
                    f_weightLabel1.Text = wScreen.Screen1.Text;
                    button1saveFW.Visible = true;

                    f_WdateLabel1.Text = DateTime.Now.ToString();
                    pr.CaptureW("INW", "" + ladnum, "F");
                }
            }

        }

        private void s_weightLabel1_DoubleClick(object sender, EventArgs e)
        {
            DateTime sdate = DateTime.Now;
            DateTime fdate = Convert.ToDateTime(f_WdateLabel1.Text.Trim().ToString());
            TimeSpan ts = sdate - fdate;

            if (ts.TotalMinutes < 5 && Properties.Settings.Default.Urole > 2)
            {
                MessageBox.Show("الوقت بين الوزن الاول و الثاني يجب الا يقل عن 5 دقائق !");
            }
            else
            {
                int wvalue;
                if (int.TryParse(wScreen.Screen1.Text, out wvalue))
                {
                    if (wvalue > 0)
                    {
                        s_weightLabel1.Text = wScreen.Screen1.Text;
                        s_WdateLabel1.Text = DateTime.Now.ToString();
                        button2saveSW.Visible = true;
                        net_WeightLabel1.Text = Math.Abs(int.Parse(s_weightLabel1.Text) - int.Parse(f_weightLabel1.Text)) + "";
                        // MessageBox.Show(Math.Abs(int.Parse(s_weightLabel1.Text) - wvalue)+"");

                        int shrink = (int)(int.Parse(net_WeightLabel1.Text) - decimal.Parse(qtyLabel1.Text) * 1000);
                        shrinktxtbx.Text = shrink + "";
                        pr.CaptureW("INW", "" + ladnum, "S");
                    }
                }
            }
        }
        private void printW(int wcid)
        {
            try
            {
                Print_Wcard pw = new Print_Wcard(wcid, "in");

                pw.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void wCardIDLabel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusLabel1_TextChanged(object sender, EventArgs e)
        {
            if (statusLabel1.Text == "اول")
            {
                f_weightLabel1.Enabled = true;
                s_weightLabel1.Enabled = false;
                f_weightLabel1.BackColor = Color.LightBlue;

            }
            else if (statusLabel1.Text == "ثان")
            {
                f_weightLabel1.Enabled = false;
                s_weightLabel1.Enabled = true;
                s_weightLabel1.BackColor = Color.LightBlue;
            }
            else
            {
                f_weightLabel1.Enabled = false;
                s_weightLabel1.Enabled = false;
            }

        }

        private void button1saveFW_Click(object sender, EventArgs e)
        {
            try
            {
                string upquery = "Update lading set Truck_Type=N'"+truck_TypeComboBox.Text.Trim().ToString()+"', F_weight=" + f_weightLabel1.Text + ", F_Wdate=CURRENT_TIMESTAMP, Status=N'ثان'" +
                    ", F_weigherName=N'" + Properties.Settings.Default.logedUN + "',F_wbridge=N'" + Properties.Settings.Default.WBridge + "', " +
                    " Weight_Notes=N'" + weight_NotesTextBox.Text + "' where ladingid=" + ladnum;
                dq.RunNonQuery(upquery);

                if (dq.GetStringValu("Select Status from lading where ladingid=" + ladnum) == "ثان")
                {
                    MessageBox.Show("تم الحفظ");
                    this.wScreen.Close();
                    this.pr.Close();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void button2saveSW_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                try
                {
                    string upquery = "Update lading set Truck_Type=N'"+truck_TypeComboBox.Text.Trim().ToString()+"', S_weight=" + s_weightLabel1.Text + ", S_Wdate=CURRENT_TIMESTAMP, Status=N'تم'" +
                        ", S_weigherName=N'" + Properties.Settings.Default.logedUN + "',S_wbridge=N'" + Properties.Settings.Default.WBridge + "' ," +
                        " Weight_Notes=N'" + weight_NotesTextBox.Text + "' where ladingid=" + ladnum;
                    dq.RunNonQuery(upquery);

                    if (dq.GetStringValu("Select Status from lading where ladingid=" + ladnum) == "تم")
                    {
                        printW(ladnum);
                        this.wScreen.Close();
                        this.pr.Close();
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
            }
        }

        private bool Valid()
        {
            if (!checkOrderQty())
            {
                return false;
            }
            if(truck_TypeComboBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("اختر نوع الشاحنة");
                return false;
            }
            return true;
        }
        private bool checkOrderQty()
        {
            //try
            //{
            //    string ordrID = dq.GetStringValu("Select Order_ID from Lading_out where ladingID=" + ladnum);
            //    string querey = "select sum(net_weight) from lading_out where order_id=" + ordrID;
            //    string orderQty = dq.GetStringValu("Select Qty from [Order] where order_id=" + ordrID);
            //    //MessageBox.Show(orderQty);
            //    if ((int.Parse(net_WeightLabel1.Text) + int.Parse(dq.GetStringValu(querey)) > decimal.Parse(orderQty) * 1000))
            //    {
            //        MessageBox.Show("الكمية تتخطي المسموح");
            //        return false;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return false;
            //}

            return true;
        }

        private void BridgeIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            wScreen.Close();
            pr.Close();
        }
    }
}
