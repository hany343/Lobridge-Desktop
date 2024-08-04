using ClosedXML.Excel;
using DGVPrinterHelper;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class ListInCards : Form
    {
        DataTable perm;
        public ListInCards(DataTable pdt)
        {
            perm = pdt;
            InitializeComponent();
        }

        private void fillBYLIDToolStripButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (searchCBox.SelectedIndex == 0)
                {
                    this.wCard1TableAdapter.FillBYLID(this.iNdataset.WCard1, ((int)(System.Convert.ChangeType(SearchStripTextBox.Text, typeof(int)))));
                }
                else if (searchCBox.SelectedIndex == 1)
                {

                    this.wCard1TableAdapter.FilLastN(this.iNdataset.WCard1, ((int)(System.Convert.ChangeType(SearchStripTextBox.Text, typeof(int)))));

                }
                else if (searchCBox.SelectedIndex == 2)
                {
                    this.wCard1TableAdapter.FillByBatchNumber(this.iNdataset.WCard1, SearchStripTextBox.Text.Trim());
                }
                else if (searchCBox.SelectedIndex == 3)
                {
                    int cid = 0;
                    try
                    {
                        cid = (int)(System.Convert.ChangeType(SearchStripTextBox.Text, typeof(int)));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    this.wCard1TableAdapter.FillBySHipnameID(this.iNdataset.WCard1, "%" + SearchStripTextBox.Text.Trim() + "%", cid);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            summarygrid();

            Cursor.Current = Cursors.Default;
        }
        public void summarygrid()
        {
            int netsum = 0;
            int finishedcount = 0;
            if (incardsDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in incardsDataGridView.Rows)
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
            countlabel.Text = incardsDataGridView.Rows.Count + "";

            netsumlabel.Text = Convert.ToDecimal(netsum) / 1000 + " طن ";
            countFlabel.Text = finishedcount + "";
            //MessageBox.Show(lcacrd1DataGridView.Width + " w  h " + lcacrd1DataGridView.Height);

        }

        private void ListInCards_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'iNdataset.Lading' table. You can move, or remove it, as needed.
            //this.ladingTableAdapter.Fill(this.iNdataset.Lading);
            Cursor.Current = Cursors.WaitCursor;
            if (perm.Rows[0]["__ladingin_cancelBtn"].ToString() == "1")
            {
                cancelBtn.Enabled = true;
            }

            if (perm.Rows[0]["__ladingin_enableBtn"].ToString() == "1")
            {
                enableBtn.Enabled = true;
            }

            if (perm.Rows[0]["__ladingin_rw1Btn"].ToString() == "1")
            {
                rw1Btn.Enabled = true;
            }

            if (perm.Rows[0]["__ladingin_rw2Btn"].ToString() == "1")
            {
                rw2Btn.Enabled = true;
            }

            searchCBox.SelectedIndex = 0;


            try
            {
                this.wCard1TableAdapter.FilLastN(this.iNdataset.WCard1, 5);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            //summarygrid();
            Cursor.Current = Cursors.Default;
        }

        private void printCardbuttn_Click(object sender, EventArgs e)
        {

            try
            {

                int idb = ((int)(System.Convert.ChangeType(incardsDataGridView.CurrentRow.Cells[0].Value, typeof(int))));
                Print_Wcard pw = new Print_Wcard(idb, "in");
                pw.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void unLoadingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.wCard1TableAdapter.FillByunloading(this.iNdataset.WCard1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void outwaitingBtn_Click(object sender, EventArgs e)
        {

            try
            {
                this.wCard1TableAdapter.FillByStatus(this.iNdataset.WCard1, "اول");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CancelInCard_Click(object sender, EventArgs e)
        {
            try
            {
                string sts = incardsDataGridView.CurrentRow.Cells["Status"].Value.ToString();
                if (sts == "تم")
                {
                    MessageBox.Show("لا يمكن الغاء الكارت بعد اتمام الوزن");
                }
                else
                {
                    int idb = ((int)(System.Convert.ChangeType(incardsDataGridView.CurrentRow.Cells[0].Value, typeof(int))));
                    this.ladingTableAdapter.UpdateStatus("ملغي", idb, idb);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataQuery dq = new DataQuery();
        private void enablecardBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int idb = ((int)(System.Convert.ChangeType(incardsDataGridView.CurrentRow.Cells[0].Value, typeof(int))));
                // this.ladingTableAdapter.UpdateStatus("اول", idb, idb);



                // string NetW = dq.GetStringValu("Select sum(Net_Weight) from [Lading_out] where Order_ID in (select Order_ID from Lading_Out where ladingID="+idb+")");

                string allQty = dq.GetStringValu("Select AllowedQ from [Inbatch] where batch_ID in (select batchid from Lading where ladingID=" + idb + ")");

                DataTable qts = dq.GetDataTable("Select Qty,net_weight from lading where ladingid=" + idb);
               

                if (qts != null)
                {
                    if (dq.GetStringValu("Select F_Wdate from [Lading] where ladingID=" + idb) == "")
                    {
                        if (decimal.Parse(allQty) >= decimal.Parse(qts.Rows[0]["Qty"].ToString()))
                        {
                            this.ladingTableAdapter.UpdateStatus("اول", idb, idb);
                        }
                        else
                        {
                            MessageBox.Show("الكمية المحددة اكير من المتبقي");
                        }
                    }
                    else if (dq.GetStringValu("Select S_Wdate from [Lading] where ladingID=" + idb) == "")
                    {

                        if (decimal.Parse(allQty) >= decimal.Parse(qts.Rows[0]["Qty"].ToString()))
                        {
                            this.ladingTableAdapter.UpdateStatus("ثان", idb, idb);
                        }
                        else
                        {
                            MessageBox.Show("الكمية المحددة اكير من المتبقي");
                        }

                    }
                    else
                    {
                        if (decimal.Parse(allQty) >= decimal.Parse(qts.Rows[0]["Net_Weight"].ToString()))
                        {
                            this.ladingTableAdapter.UpdateStatus("تم", idb, idb);
                        }
                        else
                        {
                            MessageBox.Show("صافي الوزن اكير من المتبقي");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ReWseconed_Click(object sender, EventArgs e)
        {

            try
            {

                int idb = ((int)(System.Convert.ChangeType(incardsDataGridView.CurrentRow.Cells[0].Value, typeof(int))));
                this.ladingTableAdapter.UpdateStatus("ثان", idb, idb);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wCard1DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            summarygrid();
        }

        private void exportXLSBtn_Click(object sender, EventArgs e)
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
                for (int i = 0; i < incardsDataGridView.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = incardsDataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < incardsDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < incardsDataGridView.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = incardsDataGridView.Rows[i].Cells[j].Value.ToString();

                        if (worksheet.Cell(i + 2, j + 1).Value.ToString().Length > 0)
                        {
                            XLAlignmentHorizontalValues align;

                            switch (incardsDataGridView.Rows[i].Cells[j].Style.Alignment)
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

                            XLColor xlColor = XLColor.FromColor(incardsDataGridView.Rows[i].Cells[j].Style.SelectionBackColor);
                            worksheet.Cell(i + 2, j + 1).AddConditionalFormat().WhenLessThan(1).Fill.SetBackgroundColor(xlColor);

                            worksheet.Cell(i + 2, j + 1).Style.Font.FontName = incardsDataGridView.Font.Name;
                            worksheet.Cell(i + 2, j + 1).Style.Font.FontSize = incardsDataGridView.Font.Size;

                        }
                    }
                }
                try
                {
                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(fileName);
                }

                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                //MessageBox.Show("Done");}
            }
        }

        private void cancelledBtn_Click(object sender, EventArgs e)
        {

            try
            {
                this.wCard1TableAdapter.FillByStatus(this.iNdataset.WCard1, "ملغي");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void wCard1DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {

                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //MessageBox.Show("here");
                    // Here you can do whatever you want with the cell
                    this.incardsDataGridView.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = incardsDataGridView.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.contextMenuStrip1.Show(incardsDataGridView, relativeMousePosition);

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DGVPrinter printer = new DGVPrinter();

            printer.Title = "الشركة الدولية لاستخلاص الزيوت المتعدد \n قسم اللوجستيات";
            printer.SubTitle = searchCBox.Text + "  (" + SearchStripTextBox.Text + ")";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "اجمالي العدد:" + countlabel.Text + " تم وزن عدد: " + countFlabel.Text + " اجمالي صافي الوزن: " + netsumlabel.Text + "\n\n";



            printer.FooterSpacing = 15;
            printer.PageSettings.Landscape = true;
            System.Drawing.Font oldf = panel1.Font;
            panel1.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);
            System.Drawing.Font lcgrid = incardsDataGridView.DefaultCellStyle.Font;
            incardsDataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8, FontStyle.Regular);

            incardsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            incardsDataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            incardsDataGridView.ColumnHeadersHeight = 40;

            printer.PrintDataGridView(incardsDataGridView);
            panel1.Font = oldf;

            incardsDataGridView.DefaultCellStyle.Font = lcgrid;


        }

        private void searchbyDate_Click(object sender, EventArgs e)
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
                    //dateTimePicker1.Format = DateTimePickerFormat.Long;

                    //sdate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString() + " 08:00:00");
                    edate = Convert.ToDateTime(todateTimePicker2.Value);

                }
                this.wCard1TableAdapter.FillByDateInBetween(this.iNdataset.WCard1, sdate, edate);

                // MessageBox.Show("bydate");
                //   summarygrid();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void shwcardBtn_Click(object sender, EventArgs e)
        {

            try
            {

                int idb = ((int)(System.Convert.ChangeType(incardsDataGridView.CurrentRow.Cells[0].Value, typeof(int))));

                INPrint_RCard iNPrint_ = new INPrint_RCard(idb);
                iNPrint_.Show();

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

                int idb = ((int)(System.Convert.ChangeType(incardsDataGridView.CurrentRow.Cells[0].Value, typeof(int))));

                Print_Wcard pw = new Print_Wcard(idb, "in");
                pw.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error 1");
            }
        }

        private void rw1Btn_Click(object sender, EventArgs e)
        {

            try
            {

                int idb = ((int)(System.Convert.ChangeType(incardsDataGridView.CurrentRow.Cells[0].Value, typeof(int))));
                this.ladingTableAdapter.UpdateStatus("اول", idb, idb);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}


