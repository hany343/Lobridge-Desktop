using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class comListComm : Form
    {
        DataTable perm;
        public comListComm(DataTable permdt)
        {
            perm = permdt;

            InitializeComponent();

        }

        private void commodityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.commodityBindingSource.EndEdit();
                this.commodityTableAdapter.Update(this.dLWSDataSet.Commodity);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListComm_Load(object sender, EventArgs e)
        {
            loadcom();
        }
        public void loadcom()
        {

            if (perm.Rows[0]["__commnav"].ToString() == "1")
            {
                commnav.Enabled = true;
            }

            try
            {

                commnav.Enabled = false;
                // TODO: This line of code loads data into the 'dLWSDataSet.Commodity' table. You can move, or remove it, as needed.
                this.commodityTableAdapter.Fill(this.dLWSDataSet.Commodity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                int idb = ((int)(System.Convert.ChangeType(commodityDataGridView.CurrentRow.Cells[0].Value, typeof(int))));

                commodityTableAdapter.UpdateStatus("مغلق", idb, idb);
                // TODO: This line of code loads data into the 'dLWSDataSet.Commodity' table. You can move, or remove it, as needed.
                this.commodityTableAdapter.Fill(this.dLWSDataSet.Commodity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void تفعيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {

                    int idb = ((int)(System.Convert.ChangeType(commodityDataGridView.CurrentRow.Cells[0].Value, typeof(int))));

                    commodityTableAdapter.UpdateStatus("مفتوح", idb, idb);
                    // TODO: This line of code loads data into the 'dLWSDataSet.Commodity' table. You can move, or remove it, as needed.
                    this.commodityTableAdapter.Fill(this.dLWSDataSet.Commodity);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void commodityDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            // Ignore if a column or row header is clicked
            try
            {
                if (perm.Rows[0]["__commenu"].ToString() == "1")
                {
                    if (e.RowIndex != -1 && e.ColumnIndex != -1)
                    {
                        if (e.Button == MouseButtons.Right)
                        {

                            DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                            //MessageBox.Show("here");
                            // Here you can do whatever you want with the cell
                            this.commodityDataGridView.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                            // Get mouse position relative to the vehicles grid
                            var relativeMousePosition = commodityDataGridView.PointToClient(Cursor.Position);
                            // Show the context menu
                            this.contextMenuStrip1.Show(commodityDataGridView, relativeMousePosition);

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.BringToFront();
        }
    }
}
