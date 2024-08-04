using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class InAdvEditing : Form
    {
        public InAdvEditing()
        {
            InitializeComponent();
        }

        private void shipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shipmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNdataset);

        }

        private void Editing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNdataset.SUPPLIERS' table. You can move, or remove it, as needed.
            this.sUPPLIERSTableAdapter.Fill(this.iNdataset.SUPPLIERS);
            // TODO: This line of code loads data into the 'iNdataset.INBatch' table. You can move, or remove it, as needed.
            //this.iNBatchTableAdapter.Fill(this.iNdataset.INBatch);
            // TODO: This line of code loads data into the 'iNdataset.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.iNdataset.Shipment);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();
        }
    }
}
