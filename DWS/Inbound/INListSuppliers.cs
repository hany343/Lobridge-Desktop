using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class INListSuppliers : Form
    {
        DataTable perm;
        INSupplier insp;
        public INListSuppliers(DataTable dtp, INSupplier ins)
        {
            insp = ins;
            perm = dtp;
            InitializeComponent();
        }

        private void sUPPLIERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (perm.Rows[0]["__supplier_saveBtn"].ToString() == "1")
            {
                saveBtn.Visible = true;
            }

            try
            {
                this.Validate();
                this.sUPPLIERSBindingSource.EndEdit();
                this.sUPPLIERSTableAdapter.Update(this.iNdataset);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " لا يمكن الحفظ");
            }
        }
        public void refill()
        {
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.SUPPLIERS' table. You can move, or remove it, as needed.
                this.sUPPLIERSTableAdapter.Fill(this.iNdataset.SUPPLIERS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ListSuppliers_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.SUPPLIERS' table. You can move, or remove it, as needed.
                this.sUPPLIERSTableAdapter.Fill(this.iNdataset.SUPPLIERS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillBySNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sUPPLIERSTableAdapter.FillBySName(this.iNdataset.SUPPLIERS, "%" + snameToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void snameToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.sUPPLIERSTableAdapter.FillBySName(this.iNdataset.SUPPLIERS, "%" + snameToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillBySNameToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void shwcardBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int idb = ((int)(System.Convert.ChangeType(sUPPLIERSDataGridView.CurrentRow.Cells[0].Value, typeof(int))));
                //MessageBox.Show(lcacrd1DataGridView.CurrentRow.Cells[0].Value+"");
                insp.fillforedit(idb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error 1");
            }

        }

        private void sUPPLIERSDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {


                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //MessageBox.Show("here");
                    // Here you can do whatever you want with the cell
                    this.sUPPLIERSDataGridView.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = sUPPLIERSDataGridView.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.contextMenuStrip1.Show(sUPPLIERSDataGridView, relativeMousePosition);


                }
            }
        }
    }
}
