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
    public partial class INladAdvEdit : Form
    {
        public INladAdvEdit()
        {
            InitializeComponent();
        }

        private void ladingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ladingBindingSource.EndEdit();
            this.ladingTableAdapter.Update(this.iNdataset.Lading);
            //this.tableAdapterManager.Update(this.iNdataset);

        }

        private void INladAdvEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNdataset.Lading' table. You can move, or remove it, as needed.
           // this.ladingTableAdapter.Fill(this.iNdataset.Lading);
            // TODO: This line of code loads data into the 'iNdataset.Lading' table. You can move, or remove it, as needed.
            //this.ladingTableAdapter.Fill(this.iNdataset.Lading);

        }

        private void fillRCardToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ladingTableAdapter.FillByLadingid(this.iNdataset.Lading, ((int)(System.Convert.ChangeType(lidToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
