using ClosedXML.Excel;
using DGVPrinterHelper;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OUTLadingView : Form
    {
        DataTable perm;
        public OUTLadingView(DataTable dataTable)
        {
            perm = dataTable;
            InitializeComponent();
        }


        private void LadingView_Load(object sender, EventArgs e)
        {
            if (perm.Rows[0]["__ladingoutview_cancelmenuBtn"].ToString() != "1")
            {
                cancelBtn.Enabled = false;
            }

            if (perm.Rows[0]["__ladingoutview_enablemenuBtn"].ToString() != "1")
            {
                enableBtn.Enabled = false;
            }

            if (perm.Rows[0]["__ladingoutview_rw1menuBtn"].ToString() != "1")
            {
                rw1Btn.Enabled = false;
            }

            if (perm.Rows[0]["__ladingoutview_rw2menuBtn"].ToString() != "1")
            {
                rw2Btn.Enabled = false;
            }

            if (perm.Rows[0]["__ladingoutview_shwblBtn"].ToString() != "1")
            {
                shwblBtn.Enabled = false;
            }

            searchBycomboBox1.SelectedIndex = 0;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (searchtextBox1.Text.Length > 0)
            {
                if (searchBycomboBox1.SelectedIndex == 0)
                {
                    try
                    {
                        this.lcacrd1TableAdapter.FillAllbyLID(this.oUTDataset.Lcacrd1, ((int)(System.Convert.ChangeType(searchtextBox1.Text, typeof(int)))));

                        this.lcacrd1DataGridView.DataSource = this.oUTDataset.Lcacrd1;
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                else if (searchBycomboBox1.SelectedIndex == 1)
                {
                    try
                    {

                        this.lcacrd1TableAdapter.FillLastNlading(this.oUTDataset.Lcacrd1, ((int)(System.Convert.ChangeType(searchtextBox1.Text, typeof(int)))));
                        this.lcacrd1DataGridView.DataSource = this.oUTDataset.Lcacrd1;
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                else if (searchBycomboBox1.SelectedIndex == 2)
                {
                    try
                    {
                        this.lcacrd1TableAdapter.FillByCnumber(this.oUTDataset.Lcacrd1, searchtextBox1.Text);
                        this.lcacrd1DataGridView.DataSource = this.oUTDataset.Lcacrd1;
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                else if (searchBycomboBox1.SelectedIndex == 3)
                {

                    try
                    {
                        this.lcacrd1TableAdapter.FillByOrdernumber(this.oUTDataset.Lcacrd1, searchtextBox1.Text);
                        this.lcacrd1DataGridView.DataSource = this.oUTDataset.Lcacrd1;
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {

            }

            // MessageBox.Show("search");
            // summarygrid();
        }
        public void summarygrid()
        {


            int netsum = 0;
            int finishedcount = 0;
            if (lcacrd1DataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in lcacrd1DataGridView.Rows)
                {

                    try
                    {
                        if (row.Cells["Status"].Value.ToString() == "ملغي")
                        {
                            row.DefaultCellStyle.ForeColor = Color.Red;

                        }
                        else
                        if (row.Cells["Status"].Value.ToString() == "ثان")
                        {
                            row.DefaultCellStyle.BackColor = Color.LightCyan;
                        }
                        else if (row.Cells["Status"].Value.ToString() == "اول")
                        {
                            row.DefaultCellStyle.BackColor = Color.SkyBlue;
                        }
                        else if (row.Cells["Status"].Value.ToString() == "تم")
                        {
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            try
                            {
                                netsum += Convert.ToInt32(row.Cells["Net_Weight"].Value);
                                finishedcount++;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + "  error in net sum");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            countlabel3.Text = lcacrd1DataGridView.Rows.Count + "";

            netsumlabel3.Text = Convert.ToDecimal(netsum) / 1000 + " طن ";
            countNetlabel3.Text = finishedcount + "";
            // MessageBox.Show(finishedcount + " w  h " + Convert.ToDecimal(netsum) / 1000);

        }

        //bo
        private void button4_Click(object sender, EventArgs e)
        {

            DGVPrinter printer = new DGVPrinter();

            printer.Title = "الشركة الدولية لاستخلاص الزيوت المتعدد \n قسم اللوجستيات";
            printer.SubTitle = searchBycomboBox1.Text + "  (" + searchtextBox1.Text + ")";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "اجمالي العدد:" + countlabel3.Text + " تم وزن عدد: " + countNetlabel3.Text + " اجمالي صافي الوزن: " + netsumlabel3.Text + "\n\n";



            printer.FooterSpacing = 15;
            printer.PageSettings.Landscape = true;
            System.Drawing.Font oldf = panel1.Font;
            panel1.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);
            System.Drawing.Font lcgrid = lcacrd1DataGridView.DefaultCellStyle.Font;
            lcacrd1DataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8, FontStyle.Regular);

            lcacrd1DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            lcacrd1DataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            lcacrd1DataGridView.ColumnHeadersHeight = 40;

            printer.PrintDataGridView(lcacrd1DataGridView);
            panel1.Font = oldf;

            lcacrd1DataGridView.DefaultCellStyle.Font = lcgrid;


        }

        private void lcacrd1DataGridView_Sorted(object sender, EventArgs e)
        {

            // summarygrid();
        }

        private void printWCbutton5_Click(object sender, EventArgs e)
        {

            try
            {
                if (lcacrd1DataGridView.Rows.Count > 0)
                {
                    int wcid = ((int)(System.Convert.ChangeType(lcacrd1DataGridView.SelectedRows[0].Cells[0].Value, typeof(int))));
                    Print_Wcard pw = new Print_Wcard(wcid, "out");
                    pw.Show();
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void loadingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.lcacrd1TableAdapter.FillByUnderLoading(oUTDataset.Lcacrd1, "ثان");
                //MessageBox.Show("unders");
                //  summarygrid();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void WaitingInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.lcacrd1TableAdapter.FillByUnderLoading(oUTDataset.Lcacrd1, "اول");

                // MessageBox.Show("outget");
                //    summarygrid();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cancelledBtn_Click(object sender, EventArgs e)
        {

            try
            {
                this.lcacrd1TableAdapter.FillByUnderLoading(oUTDataset.Lcacrd1, "ملغي");
                //MessageBox.Show("cancel");
                //   summarygrid();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void showByDateBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showBydate();
        }
        private void showBydate()
        {
            try
            {
                DateTime sdate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString() + " 08:00:00");
                DateTime edate = Convert.ToDateTime(dateTimePicker1.Value.AddDays(1).ToShortDateString() + " 08:00:00");
                if (tocheckBox1.CheckState == CheckState.Checked)
                {


                    edate = Convert.ToDateTime(todateTimePicker2.Value + " 08:00:00");

                }
                this.lcacrd1TableAdapter.FillByDateInBetween(this.oUTDataset.Lcacrd1, sdate + "", edate + "");

                // MessageBox.Show("bydate");
                //   summarygrid();
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void lcacrd1DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // MessageBox.Show("lis");
            summarygrid();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showBydate();
            }
        }

        private void tocheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
        }

        private void exportclick(object sender, EventArgs e)
        {

            string fileName;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.Title = "To Excel";
            saveFileDialog1.FileName = this.Text + " (" + DateTime.Now.ToString("yyyy-MM-dd") + ")";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add(this.Text);
                for (int i = 0; i < lcacrd1DataGridView.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = lcacrd1DataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < lcacrd1DataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < lcacrd1DataGridView.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = lcacrd1DataGridView.Rows[i].Cells[j].Value.ToString();

                        if (worksheet.Cell(i + 2, j + 1).Value.ToString().Length > 0)
                        {
                            XLAlignmentHorizontalValues align;

                            switch (lcacrd1DataGridView.Rows[i].Cells[j].Style.Alignment)
                            {
                                case DataGridViewContentAlignment.BottomRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.MiddleRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.TopRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;

                                case DataGridViewContentAlignment.BottomCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                case DataGridViewContentAlignment.MiddleCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                case DataGridViewContentAlignment.TopCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;

                                default:
                                    align = XLAlignmentHorizontalValues.Left;
                                    break;
                            }

                            worksheet.Cell(i + 2, j + 1).Style.Alignment.Horizontal = align;

                            XLColor xlColor = XLColor.FromColor(lcacrd1DataGridView.Rows[i].Cells[j].Style.SelectionBackColor);
                            worksheet.Cell(i + 2, j + 1).AddConditionalFormat().WhenLessThan(1).Fill.SetBackgroundColor(xlColor);

                            worksheet.Cell(i + 2, j + 1).Style.Font.FontName = lcacrd1DataGridView.Font.Name;
                            worksheet.Cell(i + 2, j + 1).Style.Font.FontSize = lcacrd1DataGridView.Font.Size;

                        }
                    }
                }
                try
                {
                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(fileName);
                }
                catch (Exception ex)
                {

                }
                //MessageBox.Show("Done");}
            }
        }

        private void lcacrd1DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {

                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //MessageBox.Show("here");
                    // Here you can do whatever you want with the cell
                    this.lcacrd1DataGridView.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = lcacrd1DataGridView.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.contextMenuStrip1.Show(lcacrd1DataGridView, relativeMousePosition);

                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.BringToFront();
        }


        private void cancekcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                int idb = ((int)(System.Convert.ChangeType(lcacrd1DataGridView.CurrentRow.Cells[0].Value, typeof(int))));
                //MessageBox.Show(lcacrd1DataGridView.CurrentRow.Cells[0].Value+"");
                string sts = lcacrd1DataGridView.CurrentRow.Cells["Status"].Value.ToString();
                if (sts == "تم")
                {
                    MessageBox.Show("لا يمكن الغاء الكارت بعد اتمام الوزن");
                }
                else
                {
                    this.lading_OutTableAdapter.cancelCard("ملغي", "" + "تم الغاءالكارت يوم " + DateTime.Now + "  المستخدم" + Properties.Settings.Default.logedUN, idb);
                    dq.RunNonQuery("insert into logs(username,tablename,uaction,cdata,code) values (N'" + Properties.Settings.Default.logedUN +
                                    "','ladingout','cancel',N' cancel card   '," + idb + ")");
                    MessageBox.Show("تم الالغاء");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error 1");
            }
        }
        DataQuery dq = new DataQuery();
        private void enablecardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                int idb = ((int)(System.Convert.ChangeType(lcacrd1DataGridView.CurrentRow.Cells[0].Value, typeof(int))));

                // string NetW = dq.GetStringValu("Select sum(Net_Weight) from [Lading_out] where Order_ID in (select Order_ID from Lading_Out where ladingID="+idb+")");

                string allQty = dq.GetStringValu("Select Allowed_qty from [Order] where Order_ID in (select Order_ID from Lading_Out where ladingID=" + idb + ")");

                DataTable qts = dq.GetDataTable("Select Qty,net_weight from lading_Out where ladingid=" + idb);

                //if (dq.GetStringValu("Select Status from [Lading_out] where ladingID=" + idb) == "تم")
                //{

                //}
                //else 
                if (dq.GetStringValu("Select F_Wdate from [Lading_out] where ladingID=" + idb) == "")
                {
                    if (decimal.Parse(allQty) * 1000 >= decimal.Parse(qts.Rows[0]["Qty"].ToString()))
                    {
                        this.lading_OutTableAdapter.cancelCard("اول", "" + "تم تفعيل الكارت يوم " + DateTime.Now + "  المستخدم" + Properties.Settings.Default.logedUN, idb);
                        dq.RunNonQuery("insert into logs(username,tablename,uaction,cdata,code) values (N'" + Properties.Settings.Default.logedUN +
                                "','ladingout','enable',N' enable first weight card   '," + idb + ")");
                        MessageBox.Show("تم التفعيل");
                    }
                    else
                    {
                        MessageBox.Show("الكمية المطلوبة اكير من المتاح علي امر التوريد");
                    }
                }
                else if (dq.GetStringValu("Select S_Wdate from [Lading_out] where ladingID=" + idb) == "")
                {

                    if (decimal.Parse(allQty) * 1000 >= decimal.Parse(qts.Rows[0]["Qty"].ToString()))
                    {
                        this.lading_OutTableAdapter.cancelCard("ثان", "" + "تم تفعيل الكارت يوم " + DateTime.Now + "  المستخدم" + Properties.Settings.Default.logedUN, idb);

                        dq.RunNonQuery("insert into logs(username,tablename,uaction,cdata,code) values (N'" + Properties.Settings.Default.logedUN +
                                                        "','ladingout','enable',' enable second weight card   '," + idb + ")");
                        MessageBox.Show("تم التفعيل");
                    }
                    else
                    {
                        MessageBox.Show("الكمية المطلوبة اكير من المتاح علي امر التوريد");
                    }
                }
                else
                {

                    if (decimal.Parse(allQty) * 1000 >= decimal.Parse(qts.Rows[0]["Net_Weight"].ToString()))
                    {
                        this.lading_OutTableAdapter.cancelCard("تم", "" + "تم تفعيل الكارت يوم " + DateTime.Now + "  المستخدم" + Properties.Settings.Default.logedUN, idb);
                        dq.RunNonQuery("insert into logs(username,tablename,uaction,cdata,code) values (N'" + Properties.Settings.Default.logedUN +
                                "','ladingout','enable',' enable completed weight card   '," + idb + ")");
                        MessageBox.Show("تم التفعيل");
                    }
                    else
                    {
                        MessageBox.Show("صافي الوزن اكير من المتاح علي امر التوريد");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error 1");
            }
        }

        private void reweight1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                int idb = ((int)(System.Convert.ChangeType(lcacrd1DataGridView.CurrentRow.Cells[0].Value, typeof(int))));

                this.lading_OutTableAdapter.UpdateStatus("اول", idb);
                dq.RunNonQuery("insert into logs(username,tablename,uaction,cdata,code) values (N'" + Properties.Settings.Default.logedUN +
                                 "','ladingout','reweight','  re weight first   '," + idb + ")");
                MessageBox.Show("تم التعديل");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error 1");
            }
        }

        private void reweight2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                int idb = ((int)(System.Convert.ChangeType(lcacrd1DataGridView.CurrentRow.Cells[0].Value, typeof(int))));

                this.lading_OutTableAdapter.UpdateStatus("ثان", idb);
                dq.RunNonQuery("insert into logs(username,tablename,uaction,cdata,code) values (N'" + Properties.Settings.Default.logedUN +
                                "','ladingout','reweight','  re weight second   '," + idb + ")");
                MessageBox.Show("تم التعديل");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error 1");
            }
        }

        private void shwcardBtn_Click(object sender, EventArgs e)
        {

            try
            {

                int idb = ((int)(System.Convert.ChangeType(lcacrd1DataGridView.CurrentRow.Cells[0].Value, typeof(int))));
                string counted = "";

                if (dq.GetStringValu("Select counted from commodity where Comm_Name=N'" + lcacrd1DataGridView.CurrentRow.Cells["commname"].Value.ToString() + "'") == "yes")
                {
                    counted = "pack";
                }

                OUTPrint_Loadingcard oUTPrint_ = new OUTPrint_Loadingcard(idb, "new", counted);
                oUTPrint_.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error 1");
            }
        }

        private void shwblBtn_Click(object sender, EventArgs e)
        {

            try
            {

                int idb = ((int)(System.Convert.ChangeType(lcacrd1DataGridView.CurrentRow.Cells[0].Value, typeof(int))));

                OutPrint_BLading outPrint_BLading = new OutPrint_BLading(idb, perm);
                outPrint_BLading.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error 1");
            }
        }

        private void showwcBtn_Click(object sender, EventArgs e)
        {

            try
            {

                int idb = ((int)(System.Convert.ChangeType(lcacrd1DataGridView.CurrentRow.Cells[0].Value, typeof(int))));

                Print_Wcard pw = new Print_Wcard(idb, "out");
                pw.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error 1");
            }
        }

        // DataQuery dq = new DataQuery();

        private void buttonoutwaiting_Click(object sender, EventArgs e)
        {
            //string query = "SELECT        Lading_Out.ladingID, Lading_Out.Qty, Lading_Out.Date, Lading_Out.LOusername, Lading_Out.Loading_Station, Lading_Out.F_weight, Lading_Out.S_weight, Lading_Out.Net_Weight, Commodity.Comm_NAME, "
            //           + "  Lading_Out.Trans_type, Lading_Out.Representative, Lading_Out.Fill_Type, [Order].Order_Number, Contract.Contract_Number, Lading_Out.Bags_Count, Lading_Out.Stack_Bar, WcardID.WCardID, Lading_Out.F_Wdate, "
            //           + "  Lading_Out.S_Wdate, Contract.Contract_Type, Customers.Cust_NAME, Transport_Co.Company_Name, Truck.Truck_number, Truck.Truck_traffic, Truck.Trailer_number, Truck.Trailer_traffic, Truck.Owner, Drivers.Driver_Name, "
            //          + "   Drivers.Liscense_num, Lading_Out.Status, Drivers.N_Card, Lading_Out.LeaveDate FROM  Lading_Out INNER JOIN"
            //          + "   [Order] ON Lading_Out.Order_ID = [Order].Order_ID INNER JOIN"
            //          + "   Contract ON[Order].Contract_ID = Contract.Contract_ID INNER JOIN"
            //         + "    Commodity ON Contract.Comm_ID = Commodity.Comm_ID INNER JOIN"
            //         + "     WcardID ON Lading_Out.ladingID = WcardID.LADOUT_ID INNER JOIN"
            //          + "   Customers ON[Order].Cust_ID = Customers.Cust_ID INNER JOIN"
            //          + "    Transport_Co ON Lading_Out.TransC_ID = Transport_Co.Company_ID INNER JOIN"
            //         + "    Truck ON Lading_Out.Truck_ID = Truck.Truck_ID INNER JOIN"
            //          + "   Drivers ON Lading_Out.Driver_ID = Drivers.Driver_ID " +
            //          "WHERE(Lading_Out.Status = N'تم' AND Lading_Out.OUTUSER IS NULL)";
            try
            {
                this.lcacrd1TableAdapter.FillByWOut(oUTDataset.Lcacrd1);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TrcukWhistory_Click(object sender, EventArgs e)
        {
            try
            {

                string tnum = lcacrd1DataGridView.CurrentRow.Cells["Truck_number"].Value.ToString();
                OutTruckhistory oh = new OutTruckhistory(tnum);
                oh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error 1");
            }
        }
    }
}
