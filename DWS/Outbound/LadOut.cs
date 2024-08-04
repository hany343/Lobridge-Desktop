using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class LadOut : Form
    {
        public LadOut()
        {
            InitializeComponent();
        }

        private void LadOut_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // this.lading_OutDataGridView.DataSource = this.lading_OutBindingSource;
                // TODO: This line of code loads data into the 'generalDataSet.Transport_Co' table. You can move, or remove it, as needed.
                this.transport_CoTableAdapter.Fill(this.generalDataSet.Transport_Co);
                // TODO: This line of code loads data into the 'generalDataSet.Drivers' table. You can move, or remove it, as needed.
                this.driversTableAdapter.Fill(this.generalDataSet.Drivers);
                // TODO: This line of code loads data into the 'generalDataSet.Truck' table. You can move, or remove it, as needed.
                this.truckTableAdapter.Fill(this.generalDataSet.Truck);
                // TODO: This line of code loads data into the 'outDataSet.Order' table. You can move, or remove it, as needed.
                //this.orderTableAdapter.Fill(this.outDataSet.Order);
                // TODO: This line of code loads data into the 'outDataSet.Contract' table. You can move, or remove it, as needed.
                this.contractTableAdapter.Fill(this.outDataSet.Contract);
                // TODO: This line of code loads data into the 'outDataSet.Lading_Out' table. You can move, or remove it, as needed.
                // this.lading_OutTableAdapter.Fill(this.outDataSet.Lading_Out);
                // TODO: This line of code loads data into the 'outDataSet.Lading_Out' table. You can move, or remove it, as needed.
                // this.lading_OutTableAdapter.Fill(this.outDataSet.Lading_Out);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  4 حدثت مشكلة في تحميل البيانات", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log error()
            }

            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void contract_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    // fill by order id
        //    if (orderIDtextBox1.Text.Length > 0)
        //    {
        //        Cursor.Current = Cursors.WaitCursor;
        //        try
        //        {
        //            if (contract_IDTextBox.Text.Length > 0)
        //            {
        //                // TODO: This line of code loads data into the 'outDataSet.Order' table. You can move, or remove it, as needed.
        //                this.lading_OutTableAdapter.FillByOid(this.outDataSet.Lading_Out, int.Parse(orderIDtextBox1.Text.Trim()));
        //                //saving = false;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message + "  4 حدثت مشكلة في تحميل البيانات", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            //log error()
        //        }

        //        Cursor.Current = Cursors.Default;
        //        this.Refresh();
        //    }
        //}

        private void lading_OutDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //fill default values

            e.Row.Cells["usernameColumn"].Value = Properties.Settings.Default.logedUN;
            e.Row.Cells["StatusColumn"].Value = "اول";
            // e.Row.Cells["Order_IDColumn"].Value = orderIDtextBox1.Text;
            e.Row.Cells["DateColumn"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void add_Button3_Click(object sender, EventArgs e)
        {
            //disable contract combo
            //this.lading_OutDataGridView.Rows.Clear();
            //this.lading_OutDataGridView.Refresh();
            add_Button3.Enabled = false;
            TransPanel.Visible = true;
            //lading_OutDataGridView.AllowUserToAddRows = true;
            LadGrid.Rows.Add();
            addingnew = true;
        }

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{
        //    if (textBox4.Text != "مفتوح")
        //    {
        //        add_Button3.Enabled = false;
        //    }
        //    else
        //    {
        //        add_Button3.Enabled = true;
        //    }
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SaveItem_Click(object sender, EventArgs e)
        {
            // fill by order id
            if (validaterows())
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    this.Validate();
                    this.lading_OutBindingSource.EndEdit();
                    this.lading_OutTableAdapter.Update(this.outDataSet);
                    addingnew = false;
                    unsaved = false;
                    ContractGrid.ReadOnly = false;
                    MessageBox.Show("save");
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
        private bool validaterows()
        {
            return true;
        }
        bool deleting = false;
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("delete clicked");
            deleting = true;
        }
        private void lading_OutDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }
        bool addingnew = false;
        /*
          Order_IDColumn
QtyColumn
Truck_IDColumn
Driver_IDColumn
Trans_typeBoxColumn
TransC_IDColumn
*/
        private bool validate_row(int rindex)
        {
            // MessageBox.Show(rindex+" rindex");
            //  if(lading_OutDataGridView.Rows[rindex].Cells[0].)
            if (addingnew)
            {
                try
                {
                    if (string.IsNullOrEmpty(ContractGrid.Rows[rindex].Cells["Order_IDColumn"].Value.ToString()))
                    {
                        return false;
                    }
                    else
                    if (string.IsNullOrEmpty(ContractGrid.Rows[rindex].Cells["QtyColumn"].Value.ToString()))
                    {
                        return false;
                    }
                    else
                     if (string.IsNullOrEmpty(ContractGrid.Rows[rindex].Cells["Truck_IDColumn"].Value.ToString()))
                    {
                        return false;
                    }
                    else
                    if (string.IsNullOrEmpty(ContractGrid.Rows[rindex].Cells["Driver_IDColumn"].Value.ToString()))
                    {
                        return false;
                    }
                    else
                    if (string.IsNullOrEmpty(ContractGrid.Rows[rindex].Cells["Trans_typeBoxColumn"].Value.ToString()))
                    {
                        return false;
                    }
                    else
                    if (string.IsNullOrEmpty(ContractGrid.Rows[rindex].Cells["TransC_IDColumn"].Value.ToString()))
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

        private void flowLayoutPanel2_Enter(object sender, EventArgs e)
        {
            // flowLayoutPanel2.BackColor = Color.LightBlue;
            //flowLayoutPanel1.BackColor = Color.White;
        }

        private void lading_OutDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LadOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  MessageBox.Show("closing");
        }

        private void lading_OutDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show("end edit");
        }

        private void lading_OutDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("cell lave edit");
            // lading_OutDataGridView.Rows[e.RowIndex].Cells.
        }

        private void lading_OutDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // MessageBox.Show("cell val edit");
            //if (lading_OutDataGridView.Rows[e.RowIndex].IsNewRow)
            //{
            //    lading_OutDataGridView.EndEdit();
            //    e.Cancel = true;
            //}
            //else
            //{
            //}
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rindex = 0;

            if (addingnew && ContractGrid.Rows[ContractGrid.CurrentRow.Index].IsNewRow)
            {
                ContractGrid.Rows[ContractGrid.CurrentRow.Index].Cells["TransC_IDColumn"].Value = company_IDTextBox.Text;
                ContractGrid.Rows[ContractGrid.CurrentRow.Index].Cells["Driver_IDColumn"].Value = driverCodetextBox6.Text;
                ContractGrid.Rows[ContractGrid.CurrentRow.Index].Cells["Truck_IDColumn"].Value = truck_IDTextBox.Text;
            }
        }

        bool beginedit = false;
        private void lading_OutDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

            beginedit = true;
        }

        private static DialogResult discardchanges()
        {
            return MessageBox.Show("هل تريد الغاء التعديلات؟", "لم يتم حفظ التعديلات",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
        }
        bool unsaved = false;
        private void lading_OutDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (beginedit)
            {
                unsaved = true;
            }
        }

        private void refreshButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(lading_OutDataGridView.Rows[lading_OutDataGridView.CurrentRow.Index ].s+ "");
        }

        private void lading_OutDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    // TODO: This line of code loads data into the 'outDataSet.Order' table. You can move, or remove it, as needed.
                    this.orderTableAdapter.FillByCIDandonum(this.outDataSet.Order, int.Parse(ContractGrid.Rows[e.RowIndex].Cells["ContractIDColumn"].Value.ToString().Trim()), "%%");
                    //saving = false;

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

        private void OrderGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    LadGrid.Rows.Clear();
                    // TODO: This line of code loads data into the 'outDataSet.Order' table. You can move, or remove it, as needed.
                    this.lading_OutTableAdapter.FillByOid(this.outDataSet.Lading_Out, int.Parse(OrderGrid.Rows[e.RowIndex].Cells["OrderIDColumn"].Value.ToString().Trim()));
                    //saving = false;
                    if (outDataSet.Lading_Out.Rows.Count > 0)
                    {
                        for (int i = 0; i < outDataSet.Lading_Out.Rows.Count; i++)
                        {
                            LadGrid.Rows.Add();
                            LadGrid.Rows[i].Cells[0].Value = outDataSet.Lading_Out.Rows[i][0];
                            LadGrid.Rows[i].Cells[1].Value = outDataSet.Lading_Out.Rows[i][2];
                            LadGrid.Rows[i].Cells[2].Value = outDataSet.Lading_Out.Rows[i][17];
                            LadGrid.Rows[i].Cells[3].Value = outDataSet.Lading_Out.Rows[i][23];
                            LadGrid.Rows[i].Cells[4].Value = outDataSet.Lading_Out.Rows[i][24];
                            LadGrid.Rows[i].Cells[5].Value = outDataSet.Lading_Out.Rows[i][25];
                            LadGrid.Rows[i].Cells[6].Value = outDataSet.Lading_Out.Rows[i][26];
                            LadGrid.Rows[i].Cells[7].Value = outDataSet.Lading_Out.Rows[i][6];
                            // LadGrid.Rows[i].Cells[8].Value = outDataSet.Lading_Out.Rows[i][7];
                        }
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
    }
}