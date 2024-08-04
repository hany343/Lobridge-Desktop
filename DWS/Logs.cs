using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void logsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.logsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dLWSDataSet);

        }

        private void Logs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.Logs' table. You can move, or remove it, as needed.
            this.logsTableAdapter.Fill(this.dLWSDataSet.Logs);

        }
    }
}
