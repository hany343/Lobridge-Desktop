using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class ListTrucks : Form
    {
        public ListTrucks()
        {
            InitializeComponent();
        }

        private void truckBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.truckBindingSource.EndEdit();
            this.truckTableAdapter.Update(this.dLWSDataSet.Truck);

        }

        private void ListTrucks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
            this.truckTableAdapter.Fill(this.dLWSDataSet.Truck);

        }

        private void truckDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByTNumberToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.truckTableAdapter.FillByTNumber(this.dLWSDataSet.Truck, "%" + tnumToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tnumToolStripTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                this.truckTableAdapter.FillByTNumber(this.dLWSDataSet.Truck, "%" + tnumToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
