using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoBridge.Common
{
    public partial class TruckTypes : Form
    {
        public TruckTypes()
        {
            InitializeComponent();
        }

        private void truck_TypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.truck_TypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dLWSDataSet);

        }

        private void TruckTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.Truck_Types' table. You can move, or remove it, as needed.
            this.truck_TypesTableAdapter.Fill(this.dLWSDataSet.Truck_Types);

        }
    }
}
