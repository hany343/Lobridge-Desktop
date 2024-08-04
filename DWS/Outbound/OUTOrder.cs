using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OUTOrder : Form
    {

        public OUTOrder()
        {

            InitializeComponent();
        }
        bool suc = false;
        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (order_NumberTextBox.Text.Length < 1)
            {
                MessageBox.Show("Enter Order Number");
                return;
            }
            else if (orderExist(order_NumberTextBox.Text.Trim()))
            {
                MessageBox.Show("!رقم امر التوريد موجود من قبل");
                return;
            }
            else if (cust_NAMEComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("!لم يتم اختيار العميل ");
                return;
            }
            else
            {
                int cid = int.Parse(Contract_numComboBox.SelectedValue.ToString());
                savecase = true;
                // dateDateTimePicker.Text = DateTime.Now.ToShortDateString();
                if (checkReamainQuanty())
                {

                    try
                    {
                        DateTime sdate = start_DateDateTimePicker.Value;
                        DateTime edate = end_DateDateTimePicker.Value;

                        string inquery = "INSERT INTO [Order] (Contract_ID,   Date, Start_Date, End_Date, Notes, Status, Qty, Remain_Qty, Ousername, Order_Number, Cust_ID, Allowed_qty)" +
                        "VALUES(" + cid + ",  CURRENT_TIMESTAMP, " + sdate.ToShortDateString() + ", " + edate.ToShortDateString() + ", N'" + notesTextBox.Text + "', N'مفتوح', " + OrderqtyTextBox.Text + ", " + OrderqtyTextBox.Text
                        + ", N'" + Properties.Settings.Default.logedUN + "', '" + order_NumberTextBox.Text + "', " + cust_NAMEComboBox.SelectedValue + "," + OrderqtyTextBox.Text + ")";


                        if (dq.RunNonQuery(inquery))
                        {
                            orderBindingNavigatorSaveItem.Enabled = false;
                            bindingNavigatorAddNewItem.Enabled = true;
                            groupBox2.Enabled = false;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "er2");
                        return;
                    }


                }
            }
        }

        private bool orderExist(string onum)
        {
            try
            {
                DataTable dt = dq.GetDataTable("Select * from [Order] where Order_Number=N'" + onum + "'");
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "er21");
                return true;
            }
            //return false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            //dateTextBox.Text = System.DateTime.Now.ToString();

        }

        DataQuery dq = new DataQuery();
        private void OrderOut_Load(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //try
            //{

            //    // TODO: This line of code loads data into the 'outdataset.Customers' table. You can move, or remove it, as needed.
            //   // this.customersTableAdapter.Fill(this.outdataset.Customers);
            //    //    // TODO: This line of code loads data into the 'outdataset.Order' table. You can move, or remove it, as needed.


            //}
            //catch (Exception ex)
            //{

            //}
            //Cursor.Current = Cursors.Default;
        }

        private void comm_NAMEComboBox_TextChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    if (Contract_numComboBox.SelectedIndex > -1)
            //    {
            //        contract_IDTextBox.Text = Contract_numComboBox.SelectedValue.ToString();
            //    }
            //}
            //catch (Exception ex)
            //{

            //}

        }
        DataTable Cdt = new DataTable();
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Enabled = true;
                savecase = false;
                bindingNavigatorAddNewItem.Enabled = false;
                orderBindingNavigatorSaveItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;

                order_NumberTextBox.Text = "";
                OrderqtyTextBox.Text = "";
                if (cust_NAMEComboBox.SelectedIndex > 0)
                {
                    cust_NAMEComboBox.SelectedIndex = 0;
                }
                notesTextBox.Text = "";
                start_DateDateTimePicker.Text = DateTime.Now.ToString();

                string sCont = "SELECT   Contract.Contract_ID, Contract.Contract_Number, Contract.Qty, Contract.Remain_QTY, Commodity.Comm_NAME " +
                    "FROM Contract INNER JOIN  Commodity ON Contract.Comm_ID = Commodity.Comm_ID WHERE(Contract.Status = N'مفتوح')";
                Cdt = dq.GetDataTable(sCont);
                if (Cdt.Rows.Count < 1)
                {
                    MessageBox.Show("! لا يوجد عقود مفتوحة");
                }
                else
                {
                    ContractqtyTextBox.DataBindings.Clear();
                    comm_NAMETextBox.DataBindings.Clear();
                    remain_ContractQTYTextBox1.DataBindings.Clear();
                    Contract_numComboBox.DataSource = Cdt;
                    Contract_numComboBox.DisplayMember = "Contract_Number";
                    Contract_numComboBox.ValueMember = "Contract_ID";
                    ContractqtyTextBox.DataBindings.Add("Text", Cdt, "Qty");
                    comm_NAMETextBox.DataBindings.Add("Text", Cdt, "Comm_NAME");
                    remain_ContractQTYTextBox1.DataBindings.Add("Text", Cdt, "Remain_QTY");

                    string Get_cust = "select * from Customers where Status=N'مفعل'";


                    DataTable cdt = dq.GetDataTable(Get_cust);

                    cust_NAMEComboBox.DataSource = cdt;
                    cust_NAMEComboBox.DisplayMember = "Cust_Name";
                    cust_NAMEComboBox.ValueMember = "Cust_ID";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        public Boolean checkReamainQuanty()
        {
            Cursor.Current = Cursors.WaitCursor;


            try
            {
                decimal OrderQ = decimal.Parse(OrderqtyTextBox.Text.ToString());
                decimal rqty = decimal.Parse(remain_ContractQTYTextBox1.Text.ToString());
                if (OrderQ > rqty)
                {
                    MessageBox.Show("خطأ في الكمية او كمية غير متوفرة");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            //    decimal ContQ = decimal.Parse(ContractqtyTextBox.Text.ToString());
            //    decimal sumORdeq = decimal.Parse(this.orderTableAdapter.sumOfQtybyCid(Cid).ToString());
            //    //MessageBox.Show(sumORdeq + " " + OrderQ + " " + ContQ);
            //    if ((sumORdeq + OrderQ) > ContQ)
            //    {

            //        remain_ContractQTYTextBox1.Text = (ContQ - sumORdeq) + "";
            //        MessageBox.Show("خطأ في الكمية او كمية غير متوفرة");
            //        orderBindingNavigatorSaveItem.Enabled = false;
            //        OrderqtyTextBox.ForeColor = System.Drawing.Color.Red;
            //        return false;
            //    }
            //    else
            //    {

            //        orderBindingNavigatorSaveItem.Enabled = true;
            //        OrderqtyTextBox.ForeColor = System.Drawing.Color.Black;

            //    }

            //}
            //if (order_NumberTextBox.Text.Trim().Length < 1)
            //{
            //    MessageBox.Show("أدخل رقم امر التوريد !");
            //    return false;
            //}
            // return true;
            //Cursor.Current = Cursors.Default;
            //}
            //private void qtyTextBox_TextChanged(object sender, EventArgs e)
            //{

            //    checkReamainQuanty();

        }



        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //    Cursor.Current = Cursors.WaitCursor;
            //    try
            //    {
            //        // TODO: This line of code loads data into the 'dLWSDataSet.ContractForOrder' table. You can move, or remove it, as needed.
            //        this.contractForOrderTableAdapter.FillForOrder(this.outdataset.ContractForOrder, 0, "no");
            //        groupBox2.Enabled = false;
            //        bindingNavigatorDeleteItem.Enabled = false;
            //        bindingNavigatorAddNewItem.Enabled = true;
            //        orderBindingNavigatorSaveItem.Enabled = false;
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //    Cursor.Current = Cursors.Default;


        }
        bool savecase = false;


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void order_NumberTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {

            order_NumberTextBox.Text = order_NumberTextBox.Text.Replace(" ", "");

        }

        private void order_NumberTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void order_NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void OUTOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            cust_NAMEComboBox.DataBindings.Clear();
        }

        private void remain_ContractQTYTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal remainQty = decimal.Parse(remain_ContractQTYTextBox1.Text);
                if (remainQty <= 0)
                {
                    remain_ContractQTYTextBox1.ForeColor = Color.Red;
                    groupBox2.Enabled = false;
                    orderBindingNavigatorSaveItem.Enabled = false;
                }
                else
                {
                    remain_ContractQTYTextBox1.ForeColor = Color.Black;
                    groupBox2.Enabled = true;
                    orderBindingNavigatorSaveItem.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cust_NAMEComboBox_Click(object sender, EventArgs e)
        {


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
