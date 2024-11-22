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
    public partial class Lading_Ports : Form
    {
        public Lading_Ports()
        {
            InitializeComponent();
        }

        private void lading_PortsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lading_PortsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dLWSDataSet);

        }

        private void Lading_Ports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.Lading_Ports' table. You can move, or remove it, as needed.
            this.lading_PortsTableAdapter.Fill(this.dLWSDataSet.Lading_Ports);
            // TODO: This line of code loads data into the 'dLWSDataSet.Lading_Ports' table. You can move, or remove it, as needed.
            this.lading_PortsTableAdapter.Fill(this.dLWSDataSet.Lading_Ports);

        }

        private void lading_PortsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lading_PortsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dLWSDataSet);

        }
    }
}
