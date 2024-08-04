using System;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        bool saving = false;
        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (check_Qty())
            {
                try
                {
                    this.Validate();
                    this.orderBindingSource.EndEdit();
                    this.orderTableAdapter.Update(this.outDataSet);
                    orderDataGridView.AllowUserToAddRows = false;
                    addingnew = false;
                    string cpos = contract_NumberComboBox.Text;
                    //saving = true;
                    //contractTableAdapter.FillByCnum(this.outDataSet.Contract, cpos);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " حدثت مشكلة في حفظ البيانات", "مشكلة في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //log error()
                }

                Cursor.Current = Cursors.Default;
                //this.Refresh();
            }
        }

        bool loading = true;
        private void Orders_Load(object sender, EventArgs e)
        {

            load_Data();
            loading = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            load_Data();
        }
        bool addingnew = false;
        private void load_Data()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                addingnew = false;
                contract_NumberComboBox.Enabled = true;
                orderDataGridView.AllowUserToAddRows = false;

                // TODO: This line of code loads data into the 'outDataSet.Customers' table. You can move, or remove it, as needed.
                this.customersTableAdapter.Fill(this.outDataSet.Customers);
                // TODO: This line of code loads data into the 'outDataSet.Contract' table. You can move, or remove it, as needed.
                this.contractTableAdapter.Fill(this.outDataSet.Contract);
                if (contract_IDTextBox.Text.Length > 0)
                {
                    // TODO: This line of code loads data into the 'outDataSet.Order' table. You can move, or remove it, as needed.
                    this.orderTableAdapter.FillByCIDandonum(this.outDataSet.Order, int.Parse(contract_IDTextBox.Text.Trim()), "%" + toolStripTextBox1.Text.Trim() + "%");
                    // this.contractTableAdapter.Fill(this.outDataSet.Contract);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  1 حدثت مشكلة في تحميل البيانات", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log error()
            }

            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void find_OTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                find_Order(toolStripTextBox1.Text.Trim());
            }
        }

        private void find_OButton1_Click(object sender, EventArgs e)
        {
            find_Order(toolStripTextBox1.Text.Trim());
        }
        private void find_Order(string onum)
        {
            Cursor.Current = Cursors.WaitCursor;
            orderDataGridView.AllowUserToAddRows = false;
            try
            {
                // TODO: This line of code loads data into the 'outDataSet.Customers' table. You can move, or remove it, as needed.
                this.contractTableAdapter.FillByOnum(this.outDataSet.Contract, "%" + onum + "%");

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("enable"))
                {

                }
                else
                {
                    MessageBox.Show(ex.Message + " حدثت مشكلة في تحميل البيانات 2 ", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //log error()
                }
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void add_Button3_Click(object sender, EventArgs e)
        {
            addingnew = true;
            orderDataGridView.AllowUserToAddRows = true;
            // contract_NumberComboBox.Enabled = false;
        }

        private void orderDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

            e.Row.Cells["Contract_IDColumn"].Value = contract_IDTextBox.Text.Trim();
            e.Row.Cells["Remain_QtyColumn"].Value = 0;
            e.Row.Cells["QtyColumn"].Value = 0;
            e.Row.Cells["Allowed_qtyColumn"].Value = 0;
            e.Row.Cells["OusernameColumn"].Value = Properties.Settings.Default.logedUN;
            e.Row.Cells["StatusColumn"].Value = "مفتوح";
            e.Row.Cells["DateColumn"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void orderDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

            if (!orderDataGridView.Rows[e.RowIndex].IsNewRow)
            {
                if (!deleting)
                {
                    if (!validate_row(e.RowIndex))
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    // MessageBox.Show("validate dele")
                    ;
                }
            }
        }

        private bool validate_row(int rowindex)
        {
            if (addingnew)
            {
                try
                {
                    if (string.IsNullOrEmpty(orderDataGridView.Rows[rowindex].Cells["Order_NumberColumn"].Value.ToString()))
                    {
                        return false;
                    }
                    else
                    if (string.IsNullOrEmpty(orderDataGridView.Rows[rowindex].Cells["Contract_IDColumn"].Value.ToString()))
                    {
                        return false;
                    }
                    else
                     if (string.IsNullOrEmpty(orderDataGridView.Rows[rowindex].Cells[2].Value.ToString()))
                    {
                        return false;
                    }
                    else
                    if (string.IsNullOrEmpty(orderDataGridView.Rows[rowindex].Cells[3].Value.ToString()))
                    {
                        return false;
                    }
                    else
                    if (string.IsNullOrEmpty(orderDataGridView.Rows[rowindex].Cells["QtyColumn"].Value.ToString()))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            else
            {
                return true;
            }
        }
        private bool check_Qty()
        {
            // MessageBox.Show("check");
            bool accQty = false;
            try
            {

                decimal rq = decimal.Parse(qtyTextBox.Text);
                //MessageBox.Show(orderDataGridView.Rows.Count+" rc");
                decimal nqty = 0;
                for (int i = 0; i < orderDataGridView.Rows.Count - 1; i++)
                {
                    try
                    {

                        nqty += decimal.Parse("0" + orderDataGridView.Rows[i].Cells["QtyColumn"].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (rq <= nqty)
                {
                    MessageBox.Show("الكمية المتاحة لا تكفي ");
                    accQty = false;
                }
                else
                {
                    accQty = true;
                }
                // orderDataGridView.Rows.Add(dataRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 3 حدثت مشكلة في تحميل البيانات", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log error()
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();
            return accQty;
        }


        private void orderDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //// MessageBox.Show(e.RowIndex+ "%"+ toolStripTextBox1.Text.Trim() + "%");
        }

        private void orderDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (orderDataGridView.Rows[e.RowIndex].IsNewRow)
            {
                orderDataGridView.Rows[e.RowIndex].Selected = true;
                //  MessageBox.Show("leave new row");
            }
        }

        private void orderDataGridView_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //MessageBox.Show(e.Row.Index+"%"+ toolStripTextBox1.Text.Trim() + "%");

        }

        private void orderDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            //- MessageBox.Show(e.RowIndex + "%"+ toolStripTextBox1.Text.Trim() + "%");
        }

        private void Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            contract_NumberComboBox.DataBindings.Clear();// = None;
        }

        private void contract_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            //contract_NumberComboBox.Enabled = false;
            if (!loading)
            {
                if (!saving)
                {

                    try
                    {
                        if (!addingnew)
                        {
                            orderDataGridView.AllowUserToAddRows = false;
                        }
                        if (contract_IDTextBox.Text.Length > 0)
                        {
                            // TODO: This line of code loads data into the 'outDataSet.Order' table. You can move, or remove it, as needed.
                            this.orderTableAdapter.FillByCIDandonum(this.outDataSet.Order, int.Parse(contract_IDTextBox.Text.Trim()), "%" + toolStripTextBox1.Text.Trim() + "%");
                            saving = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "  4 حدثت مشكلة في تحميل البيانات", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //log error()
                    }

                    Cursor.Current = Cursors.Default;
                    this.Refresh();
                }
            }

            // contract_NumberComboBox.Enabled = true;
        }
        bool deleting = false;
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("delete clicked");
            deleting = true;
        }

        private void orderDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("data error");
        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

            if (statusTextBox.Text != "مفتوح")
            {
                add_Button3.Enabled = false;
            }
            else
            {
                add_Button3.Enabled = true;
            }
        }

        private void contract_NumberComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    // TODO: This line of code loads data into the 'outDataSet.Contract' table. You can move, or remove it, as needed.
                    this.contractTableAdapter.Fill(this.outDataSet.Contract);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " 5 حدثت مشكلة في تحميل البيانات", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //log error()
                }
                Cursor.Current = Cursors.Default;
                this.Refresh();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
