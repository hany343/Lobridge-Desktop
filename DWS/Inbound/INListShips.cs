using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class INListShips : Form
    {
        DataTable perm;
        public INListShips(DataTable pdt)
        {
            perm = pdt;
            InitializeComponent();
        }

        private void shipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Validate();
            //    this.shipmentBindingSource.EndEdit();
            //    this.tableAdapterManager.UpdateAll(this.iNdataset);
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message + " لم يتم الحفظ برجاء المحاولة مرة اخري");
            //}
        }

        private void Ships_Load(object sender, EventArgs e)
        {
            if (perm.Rows[0]["__ship_cancellBtn"].ToString() == "1")
            {
                closeToolStripMenuItem.Enabled = true;
            }

            if (perm.Rows[0]["__ship_enableBtn"].ToString() == "1")
            {
                openToolStripMenuItem.Enabled = true;
            }

            string qur = @"SELECT Shipment.Ship_ID, Shipment.Contract, Shipment.Comm_ID, Shipment.Supp_ID, Shipment.Qty, Shipment.Shipping, Shipment.ArrialDate, Shipment.Notes, Shipment.Status, Shipment.Date, Shipment.Ship_RQty, Shipment.Lading_Port, 
                  Shipment.Trans_Co, Commodity.Comm_NAME
FROM     Shipment INNER JOIN
                  Commodity ON Shipment.Comm_ID = Commodity.Comm_ID";
            // TODO: This line of code loads data into the 'iNdataset.INBatch' table. You can move, or remove it, as needed.
            //this.iNBatchTableAdapter.Fill(this.iNdataset.INBatch);
            // TODO: This line of code loads data into the 'dLWSDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.FillByJoinComm(this.iNdataset.Shipment);

        }

        private void Ships_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.shipmentBindingSource.EndEdit();
                this.shipmentTableAdapter.Update(this.iNdataset.Shipment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " لم يتم الحفظ برجاء المحاولة مرة اخري");
            }
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shipmentDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowEnter(e.RowIndex);
        }
        private void rowEnter(int rind)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (rind > -1)
                {

                    // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
                    this.iNBatchTableAdapter.FillBySID(this.iNdataset.INBatch, ((int)(System.Convert.ChangeType(shipmentDataGridView.Rows[rind].Cells[0].Value, typeof(int)))));

                    // selectedContractlabel4.Text = contractDataGridView.Rows[e.RowIndex].Cells["Cnum"].Value + "";
                    // contQty.Text = contractDataGridView.Rows[e.RowIndex].Cells["CQty"].Value + " طن";

                    //decimal outq = Convert.ToDecimal(this.lading_OutTableAdapter.getOutQty((int)(System.Convert.ChangeType(contractDataGridView.Rows[e.RowIndex].Cells[0].Value, typeof(int)))) / 1000);
                    //outQtylabel5.Text = outq + "  طن";
                    //decimal re = 0;
                    //try
                    //{
                    //    re = Convert.ToDecimal(contractDataGridView.Rows[e.RowIndex].Cells["CQty"].Value) - outq;
                    //    remQtylabel2.Text = re + " طن";
                    //}
                    //catch (Exception exx)
                    //{

                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            searshChip();
        }

        private void searshChip()
        {
            //searchTextBox1
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                // TODO: This line of code loads data into the 'dLWSDataSet.Order' table. You can move, or remove it, as needed.
                this.shipmentTableAdapter.FillBySname(this.iNdataset.Shipment, "%" + searchTextBox1.Text + "%");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();
        }
        private void iNBatchDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //MessageBox.Show("here");
                    // Here you can do whatever you want with the cell
                    this.iNBatchDataGridView.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = iNBatchDataGridView.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.contextMenuStrip1.Show(iNBatchDataGridView, relativeMousePosition);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.BringToFront();// = true;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int rid = int.Parse(iNBatchDataGridView.CurrentRow.Cells[0].Value.ToString());

                iNBatchTableAdapter.UpdateBatchStatus("مغلق", rid);

                rowEnter(shipmentDataGridView.CurrentRow.Index);
            }
            catch (Exception ex)
            {

            }
        }

        private void searchTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searshChip();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int rid = int.Parse(iNBatchDataGridView.CurrentRow.Cells[0].Value.ToString());

                iNBatchTableAdapter.UpdateBatchStatus("مفتوح", rid);
                rowEnter(shipmentDataGridView.CurrentRow.Index);
            }
            catch (Exception ex)
            {

            }
        }

        private void تعديلالكميةToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                int rid = int.Parse(iNBatchDataGridView.CurrentRow.Cells[0].Value.ToString());


                iNBatchTableAdapter.UpdateBatchStatus("مفتوح", rid);
                rowEnter(shipmentDataGridView.CurrentRow.Index);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
