using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OutEditContract : Form
    {
        public OutEditContract()
        {
            InitializeComponent();
        }

        private void contractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (checkReamainQuanty())
            {
                try
                {

                    int Cid = 0;
                    if (contract_IDTextBox.Text.Length > 0)
                    {
                        Cid = int.Parse(contract_IDTextBox.Text.ToString());

                    }
                    this.Validate();
                    this.contractBindingSource.EndEdit();
                    this.contractTableAdapter.Update(this.oUTDataset.Contract);
                    //this.contractTableAdapter.UpdateQuery(int.Parse(comm_IDTextBox.Text),contract_NumberTextBox.Text
                    //    ,notesTextBox.Text,decimal.Parse(qtyTextBox.Text),decimal.Parse(remain_QTYTextBox.Text)
                    //    ,statusTextBox.Text,Cid, Cid);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public Boolean checkReamainQuanty()
        {

            if (qtyTextBox.Text.Length > 0)
            {
                int Cid = 0;
                if (contract_IDTextBox.Text.Length > 0)
                {
                    Cid = int.Parse(contract_IDTextBox.Text.ToString());

                }

                decimal newQty = decimal.Parse(qtyTextBox.Text.ToString());
                //decimal rqty = decimal.Parse(remain_QTYTextBox.Text );
                //decimal ContQ = decimal.Parse(this.contractTableAdapter.GetQty(Cid) + "");

                decimal sumORdeq = decimal.Parse(this.orderTableAdapter.sumOfQtybyCid(Cid).ToString());

                if (sumORdeq > newQty)
                {
                    MessageBox.Show("الكمية اقل من المحجوز");
                    qtyTextBox.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                else
                {
                    decimal newRQ = newQty - sumORdeq;

                    remain_QTYTextBox.Text = newRQ + "";
                    // qtyTextBox.ReadOnly = true;
                }


            }
            return true;
        }
        private void DEContract_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Urole < 4)
            {
                closeorderBtn.Enabled = true;
                enableOrderBtn.Enabled = true;
                comm_IDTextBox.ReadOnly = false;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                this.contractTableAdapter.Fill(this.oUTDataset.Contract);
                qtyTextBox.Enabled = true;
            }
            catch (Exception ex)
            {

            }

        }

        private void qtyTextBox_TextChanged(object sender, EventArgs e)
        {
            qtyTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contract_NumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                    this.contractTableAdapter.FillByCnum(this.oUTDataset.Contract, "%" + contract_NumberTextBox.Text + "%");
                    qtyTextBox.Enabled = true;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void enableOrderBtn_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "مفتوح";
        }

        private void closeorderBtn_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "مغلق";
        }
    }
}
