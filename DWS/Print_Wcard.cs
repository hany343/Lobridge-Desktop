using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class Print_Wcard : Form
    {
        int wcardid = 1;
        string wt = "in";
        public Print_Wcard(int wcid, string wtype)
        {
            wt = wtype;
            wcardid = wcid;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeCombobox.SelectedIndex = 0;

            load(Properties.Settings.Default.wcardsize);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (LadidBox.Text.Length > 0)
            {
                if (typeCombobox.Text.Length > 0)
                {
                    try
                    {
                        int cnumber = int.Parse(LadidBox.Text);
                        if (typeCombobox.SelectedIndex == 0)
                        {

                            wt = "out";

                            wcardid = cnumber;
                            load(Properties.Settings.Default.wcardsize);
                        }
                        else
                        {
                            wt = "in";

                            wcardid = cnumber;
                            load(Properties.Settings.Default.wcardsize);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("اختر نوع الكارت");
                }

            }
            else
            {
                MessageBox.Show("ادخل رقم الكارت");
            }
        }
        DataQuery dq = new DataQuery();
        public void load(string psize)
        {


            try
            {
                if (wt == "in")
                {
                    if (wcardid != 0)

                    {
                        this.wCard1TableAdapter.FillBYLID(this.inDataSet.WCard1, wcardid);
                        // MessageBox.Show(wcardid + "ss");


                        // try
                        // {
                        //     DataTable dt = dq.GetDataTable("SELECT  Lading.ladingID, Lading.BatchID, Lading.Lading_Notes, Lading.Loading_Station, Lading.Bags_Count, Lading.Date, Lading.Driver_ID, Lading.F_Wdate, Lading.F_wbridge, Lading.F_weigherName, Lading.F_weight, "
                        //+ "    Lading.Fill_Type, Lading.Net_Weight, Lading.S_Wdate, Lading.S_wbridge, Lading.S_weigherName, Lading.S_weight, Lading.Shrink, Lading.Stack_Bar, Lading.Truck_ID, Lading.Representative, Lading.Weight_Notes,"
                        //  + "  Lading.Qty, Lading.Lusername, Lading.Status, Lading.BLading, Commodity.Comm_NAME, Shipment.Shipping, SUPPLIERS.SUP_NAME, Drivers.Driver_Name, WcardID.WCardID, INBatch.Serial, Truck.Truck_number,"
                        //    + " Truck.Trailer_number,Transport_Co.Company_Name FROM            Shipment INNER JOIN"
                        //   + " Commodity ON Shipment.Comm_ID = Commodity.Comm_ID INNER JOIN"
                        //   + " SUPPLIERS ON Shipment.Supp_ID = SUPPLIERS.SUP_ID INNER JOIN"
                        //   + " INBatch ON Shipment.Ship_ID = INBatch.Ship_ID INNER JOIN"
                        //   + " Lading INNER JOIN  Drivers ON Lading.Driver_ID = Drivers.Driver_ID INNER JOIN"
                        //  + "  WcardID ON Lading.ladingID = WcardID.LAD_ID ON INBatch.Batch_ID = Lading.BatchID INNER JOIN"
                        //  + "  Truck ON Lading.Truck_ID = Truck.Truck_ID "
                        //  + " INNER JOIN Transport_Co ON Shipment.Trans_Co = Transport_Co.Company_ID"
                        //   + " WHERE(ladingID=" + wcardid +") ");
                        //     this.wCard1BindingSource.DataSource = dt;
                        // }
                        // catch (System.Exception ex)
                        // {
                        //     System.Windows.Forms.MessageBox.Show(ex.Message);
                        // }
                    }

                    reportDocument1.Load(Application.StartupPath + @"\reports\WCard1" + psize + ".rpt");
                    reportDocument1.SetDataSource(this.inDataSet);

                    crystalReportViewer2.ReportSource = reportDocument1;
                    reportDocument1.Refresh();

                }
                else if (wt == "g")
                {
                    //
                    //
                }
                else if (wt == "out")
                {

                    if (wcardid != 0)
                    {

                        reportDocument1.Load(Application.StartupPath + @"\reports\OutWCard1" + psize + ".rpt");
                        reportDocument1.SetDataSource(this.outdataset);

                        //MessageBox.Show("bef");
                        this.outWcard1TableAdapter.FillWcard(this.outdataset.OutWcard1, wcardid);
                        // MessageBox.Show("aft");
                        // MessageBox.Show("out");

                        //        this.outWcard1BindingSource.DataSource = dq.GetDataTable("SELECT Lading_Out.ladingID, Lading_Out.Qty, Lading_Out.Date, Lading_Out.LOusername, Lading_Out.Loading_Station, Lading_Out.F_weight, Lading_Out.S_weight, Lading_Out.Net_Weight, Commodity.Comm_NAME, "

                        //+ " Lading_Out.Trans_type, Lading_Out.Representative, Lading_Out.Fill_Type, [Order].Order_Number, Contract.Contract_Number, Lading_Out.Bags_Count, Lading_Out.Stack_Bar, WcardID.WCardID, Lading_Out.F_Wdate, "
                        //  + "               Lading_Out.S_Wdate, Contract.Contract_Type, Customers.Cust_NAME, Transport_Co.Company_Name, Truck.Truck_number, Truck.Truck_traffic, Truck.Trailer_number, Truck.Trailer_traffic, Truck.Owner, Drivers.Driver_Name, "
                        //    + "             Drivers.Liscense_num, Lading_Out.ShipAddress, Drivers.N_Card, Lading_Out.LeaveDate, Lading_Out.Status, Lading_Out.Lading_Notes, Lading_Out.Ship_City"
                        //+ " FROM Lading_Out INNER JOIN"
                        //  + "               [Order] ON Lading_Out.Order_ID = [Order].Order_ID INNER JOIN"
                        //  + "               Contract ON[Order].Contract_ID = Contract.Contract_ID INNER JOIN"
                        //     + "            Commodity ON Contract.Comm_ID = Commodity.Comm_ID INNER JOIN"
                        //        + "         WcardID ON Lading_Out.ladingID = WcardID.LADOUT_ID INNER JOIN"
                        //           + "      Customers ON[Order].Cust_ID = Customers.Cust_ID INNER JOIN"
                        //              + "   Transport_Co ON Lading_Out.TransC_ID = Transport_Co.Company_ID INNER JOIN"
                        //                 + " Truck ON Lading_Out.Truck_ID = Truck.Truck_ID INNER JOIN"
                        //                 + " Drivers ON Lading_Out.Driver_ID = Drivers.Driver_ID" +
                        //                 " WHERE(Lading_Out.ladingID =" + wcardid + ")  ");

                    }

                    crystalReportViewer2.ReportSource = reportDocument1;
                    reportDocument1.Refresh();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "er");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Print_Wcard_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportDocument1.Close();
        }

        private void A5paperBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.wcardsize = "A5";
            Properties.Settings.Default.Save();
            load("A5");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.wcardsize = "";
            Properties.Settings.Default.Save();
            load("");
        }
    }
}
