using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class TransList : Form
    {
        DataTable perm;
        public TransList(DataTable permdt)
        {
            perm = permdt;
            InitializeComponent();
        }

        private void transport_CoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.Validate();
                this.transport_CoBindingSource.EndEdit();
                this.transport_CoTableAdapter.Update(this.dLWSDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // 01288727493
            Cursor.Current = Cursors.Default;
        }

        private void TransList_Load(object sender, EventArgs e)
        {

            loadt();
        }
        public void loadt()
        {
            if (perm.Rows[0]["__transnav"].ToString() == "1")
            {
                transnav.Enabled = true;
            }
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Transport_Co' table. You can move, or remove it, as needed.
                this.transport_CoTableAdapter.Fill(this.dLWSDataSet.Transport_Co);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
