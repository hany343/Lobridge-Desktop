using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoBridge.Inbound
{
    public partial class Local_Suppliers : Form
    {
        public Local_Suppliers()
        {
            InitializeComponent();
        }

        private void local_SuppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.local_SuppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNdataset);

        }

        private void Local_Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNdataset.Local_Suppliers' table. You can move, or remove it, as needed.
            this.local_SuppliersTableAdapter.Fill(this.iNdataset.Local_Suppliers);
            // TODO: This line of code loads data into the 'iNdataset.Local_Suppliers' table. You can move, or remove it, as needed.
            this.local_SuppliersTableAdapter.Fill(this.iNdataset.Local_Suppliers);

        }

        private void local_SuppliersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.local_SuppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNdataset);

        }
    }
}
