using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OUTContractView : Form
    {
        DataTable perm;
        public OUTContractView(DataTable dtp)
        {
            perm = dtp;
            InitializeComponent();
        }

        private void ContractView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'outdataset.Lading_Out' table. You can move, or remove it, as needed.
            //this.lading_OutTableAdapter.Fill(this.outdataset.Lading_Out);
            Cursor.Current = Cursors.WaitCursor;
            if (perm.Rows[0]["__order_cancelmenuBtn"].ToString() != "1")
            {
                cancelBtn.Enabled = false;
            }
            if (perm.Rows[0]["__order_enablemenuBtn"].ToString() != "1")
            {
                enableBtn.Enabled = false;
            }
            if (perm.Rows[0]["__order_editmenuBtn"].ToString() != "1")
            {
                editBtn.Enabled = false;
            }
            if (perm.Rows[0]["__order_reportmenuBtn"].ToString() != "1")
            {
                reportBtn.Enabled = false;
            }


            if (perm.Rows[0]["__contract_cancelmenuBtn"].ToString() != "1")
            {
                cancelContBtn.Enabled = false;
            }

            if (perm.Rows[0]["__contract_enablemenuBtn"].ToString() != "1")
            {
                enableContBtn.Enabled = false;
            }
            if (perm.Rows[0]["__contract_editmenuBtn"].ToString() != "1")
            {
                editcontBtn.Enabled = false;
            }
            if (perm.Rows[0]["__contract_reportmenuBtn"].ToString() != "1")
            {
                contreportBtn.Enabled = false;
            }
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                this.contractTableAdapter.FillForlist(this.outdataset.Contract, "");
                contractCount.Text = contractDataGridView.Rows.Count + "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void contractDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("re");
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (e.RowIndex > -1)
                {

                    // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
                    this.orderTableAdapter.FillByCIDandonum(this.outdataset.Order, ((int)(System.Convert.ChangeType(contractDataGridView.Rows[e.RowIndex].Cells[0].Value, typeof(int)))), "%%");
                    //MessageBox.Show(this.outdataset.Order.Rows.Count+" "+ ((int)(System.Convert.ChangeType(contractDataGridView.Rows[e.RowIndex].Cells[0].Value, typeof(int)))));
                    selectedContractlabel4.Text = contractDataGridView.Rows[e.RowIndex].Cells["Cnum"].Value + "";
                    contQty.Text = contractDataGridView.Rows[e.RowIndex].Cells["CQty"].Value + " طن";

                    decimal outq = Convert.ToDecimal(this.lading_OutTableAdapter.getOutQty((int)(System.Convert.ChangeType(contractDataGridView.Rows[e.RowIndex].Cells[0].Value, typeof(int)))) / 1000);
                    outQtylabel5.Text = outq + "  طن";
                    decimal re = 0;
                    try
                    {
                        re = Convert.ToDecimal(contractDataGridView.Rows[e.RowIndex].Cells["CQty"].Value) - outq;
                        remQtylabel2.Text = re + " طن";
                    }
                    catch (Exception exx)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
                this.orderTableAdapter.FillByCIDandonum(this.outdataset.Order, 0, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                this.contractTableAdapter.FillForlist(this.outdataset.Contract, "مفتوح");
                contractCount.Text = contractDataGridView.Rows.Count + "";

            }
            catch (Exception ex)
            {

            }

            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
                this.orderTableAdapter.FillByCIDandonum(this.outdataset.Order, 0, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                this.contractTableAdapter.FillForlist(this.outdataset.Contract, "مغلق");
                contractCount.Text = contractDataGridView.Rows.Count + "";

            }
            catch (Exception ex)
            {

            }

            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
                this.orderTableAdapter.FillByCIDandonum(this.outdataset.Order, 0, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                this.contractTableAdapter.FillForlist(this.outdataset.Contract, "%%");
                contractCount.Text = contractDataGridView.Rows.Count + "";

            }
            catch (Exception ex)
            {

            }

            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
                this.orderTableAdapter.FillByCIDandonum(this.outdataset.Order, 0, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                this.contractTableAdapter.FillBysearchCNum(this.outdataset.Contract, "%" + searchCNumtbox.Text + "%");
                contractCount.Text = contractDataGridView.Rows.Count + "";

            }
            catch (Exception ex)
            {

            }

            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void orderDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (Properties.Settings.Default.Urole < 5)
                    {
                        if (Properties.Settings.Default.Urole > 3)
                        {
                            //contextMenuStrip1.Items.Remove(اعادةوزنثانToolStripMenuItem);
                            // reweight2ToolStripMenuItem.Enabled = false;
                        }
                        DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                        //MessageBox.Show("here");
                        // Here you can do whatever you want with the cell
                        this.orderDataGridView.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                        // Get mouse position relative to the vehicles grid
                        var relativeMousePosition = orderDataGridView.PointToClient(Cursor.Position);

                        // Show the context menu
                        this.contextMenuStrip1.Show(orderDataGridView, relativeMousePosition);

                    }
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.BringToFront();
        }

        private void OUTContractView_FormClosing(object sender, FormClosingEventArgs e)
        {
            orderDataGridView.DataSource = null;
            contractDataGridView.DataSource = null;

        }

        private void cancekcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string squery = " SELECT COUNT(*) AS Expr1 FROM Lading_Out WHERE(Order_ID = " + orderDataGridView.CurrentRow.Cells[0].Value + ") AND(outUser IS NULL) and (Status!=N'ملغي')";
            DataQuery dq = new DataQuery();
            string stat = dq.GetStringValu(squery);
            if (stat == "0")
            {
                string uquery = "update [order] set Status=N'مغلق' where order_id=" + orderDataGridView.CurrentRow.Cells[0].Value;
                dq.RunNonQuery(uquery);


                // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
                this.orderTableAdapter.FillByCIDandonum(this.outdataset.Order, ((int)(System.Convert.ChangeType(contractDataGridView.CurrentRow.Cells[0].Value, typeof(int)))), "%%");

            }
            else
            {
                MessageBox.Show(" لا يمكن اغلاق الامر , يوجد  " + stat + " حمولة لم يتم تسجيل خروجها ", "خطأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void enablecardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataQuery dq = new DataQuery();

            string uquery = "update [order] set Status=N'مفتوح' where order_id=" + orderDataGridView.CurrentRow.Cells[0].Value;
            dq.RunNonQuery(uquery);

            MessageBox.Show("success");
            // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.FillByCIDandonum(this.outdataset.Order, ((int)(System.Convert.ChangeType(contractDataGridView.CurrentRow.Cells[0].Value, typeof(int)))), "%%");

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutEditOrder outEdit = new OutEditOrder(int.Parse(orderDataGridView.CurrentRow.Cells[0].Value + ""));
            outEdit.ShowDialog();

            // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.FillByCIDandonum(this.outdataset.Order, ((int)(System.Convert.ChangeType(contractDataGridView.CurrentRow.Cells[0].Value, typeof(int)))), "%%");

        }

        private void contractDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {

                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //MessageBox.Show("here");
                    // Here you can do whatever you want with the cell
                    this.contractDataGridView.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = contractDataGridView.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.contextMenuStrip2.Show(contractDataGridView, relativeMousePosition);

                }
            }
        }
        DataQuery dq = new DataQuery();
        private void cancelContBtn_Click(object sender, EventArgs e)
        {
            string squery = " SELECT COUNT(*) AS Expr1 FROM [Order] WHERE(Contract_id = " + contractDataGridView.CurrentRow.Cells[0].Value + ")  and (Status!=N'مغلق')";

            string stat = dq.GetStringValu(squery);
            if (stat == "0")
            {
                string uquery = "update [Contract] set Status=N'مغلق' where Contract_id=" + contractDataGridView.CurrentRow.Cells[0].Value;
                dq.RunNonQuery(uquery);


                // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                this.contractTableAdapter.FillForlist(this.outdataset.Contract, "مفتوح");
                contractCount.Text = contractDataGridView.Rows.Count + "";

            }
            else
            {
                MessageBox.Show(" يجب اغلاق اوامر التوريد المفتوحة اولا ", "خطأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void enableContBtn_Click(object sender, EventArgs e)
        {

            string uquery = "update [Contract] set Status=N'مفتوح' where Contract_id=" + contractDataGridView.CurrentRow.Cells[0].Value;
            dq.RunNonQuery(uquery);
            this.contractTableAdapter.FillForlist(this.outdataset.Contract, "مغلق");
            contractCount.Text = contractDataGridView.Rows.Count + "";
        }

        private void editcontBtn_Click(object sender, EventArgs e)
        {
            int ccid = int.Parse(contractDataGridView.CurrentRow.Cells[0].Value + "");
            OUTContract outc = new OUTContract(ccid, perm); ;
            outc.ShowDialog();
            this.contractTableAdapter.FillByCID(this.outdataset.Contract, ccid);
            contractCount.Text = contractDataGridView.Rows.Count + "";

        }
    }
}
