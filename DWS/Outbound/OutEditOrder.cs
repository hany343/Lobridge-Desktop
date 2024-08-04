using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OutEditOrder : Form
    {
        int orderid = 0;
        public OutEditOrder(int oid)
        {
            orderid = oid;
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (validatorder())
            {

                if (checkReamainQuanty())
                {

                    try
                    {
                        this.orderTableAdapter.UpdateOrder(int.Parse(contract_IDTextBox.Text), notesTextBox.Text, statusTextBox.Text
                            , Convert.ToDecimal(qtyTextBox.Text), order_NumberTextBox.Text, int.Parse(cust_IDTextBox.Text), int.Parse(order_IDTextBox.Text.Trim()), int.Parse(order_IDTextBox.Text));
                        dq.RunNonQuery("insert into logs(actiondate,username,tablename,uaction,cdata,code) values ('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "',N'" + Properties.Settings.Default.logedUN +
                                 "','Order','edit',N'q=" + qtyTextBox.Text + "  onum=" + order_NumberTextBox.Text + " contID =" + contract_IDTextBox.Text + "  custid=" + cust_IDTextBox.Text + "'," + order_IDTextBox.Text.Trim() + ")");
                        MessageBox.Show("Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                        this.orderTableAdapter.FillByOID(this.outdataset.Order, int.Parse(order_IDTextBox.Text));
                        qtyTextBox.Enabled = true;
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
        }

        private bool validatorder()
        {
            //order_IDTextBox.Text = dt.Rows[0]["Order_ID"].ToString();
            if (order_NumberTextBox.Text.Length < 1)
            {
                MessageBox.Show("ادخل رقم امر التوريد");
                return false;
            }
            else if (order_NumberTextBox.Text != dt.Rows[0]["Order_Number"].ToString())
            {
                string onum = dq.GetStringValu("Select Order_Number from [Order] where Order_Number=N'" + order_NumberTextBox.Text + "'");
                if (onum == "error")
                {
                    MessageBox.Show("!حدث خطأ في الاتصال");
                    return false;

                }
                else if (onum != "")
                {
                    MessageBox.Show("امر التوريد مكرر");
                    return false;
                }
            }
            else
            {

            }

            //qtyTextBox.Text = dt.Rows[0]["Qty"].ToString();
            //remain_QtyTextBox.Text = dt.Rows[0]["Remain_Qty"].ToString();

            //Contract_numComboBox.Text = dq.GetStringValu("Select Contract_Number from Contract where Contract_ID=" + dt.Rows[0]["Contract_ID"].ToString());
            //cust_IDTextBox.Text = dt.Rows[0]["cust_ID"].ToString();
            //Cust_Nametxtbox.Text = dq.GetStringValu("Select Cust_NAME from Customers where Cust_ID=" + dt.Rows[0]["cust_ID"].ToString());
            //notesTextBox.Text = dt.Rows[0]["Notes"].ToString();
            //dateTextBox.Text = dt.Rows[0]["Date"].ToString();
            //statusTextBox.Text = dt.Rows[0]["Status"].ToString();

            return true;
        }
        private void DEOrder_Load(object sender, EventArgs e)
        {

            loadorder();
            if (Properties.Settings.Default.Urole < 3)
            {
                //bindingNavigatorDeleteItem.Visible = true;
            }
            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadorder()
        {
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.

                string vquery = "SELECT  COUNT(*) AS Expr1 FROM  Lading_Out INNER JOIN  [Order] ON Lading_Out.Order_ID = [Order].Order_ID " +
                                "WHERE([Order].Order_ID = " + orderid + " ) AND((Lading_Out.F_weight > 0) AND (Lading_Out.[Status] !=N'ملغي'))";

                if (dq.GetStringValu(vquery) != "0")
                {
                    checkBox1.Visible = false;
                    cust_IDTextBox.Enabled = false;
                    Cust_Nametxtbox.Enabled = false;
                    Contract_numComboBox.Enabled = false;
                    contract_IDTextBox.Enabled = false;
                }

                dt = dq.GetDataTable("Select * from [Order] where Order_ID=" + orderid);
                if (dt.Rows.Count > 0)
                {
                    order_IDTextBox.Text = dt.Rows[0]["Order_ID"].ToString();
                    order_NumberTextBox.Text = dt.Rows[0]["Order_Number"].ToString();
                    qtyTextBox.Text = dt.Rows[0]["Qty"].ToString();
                    remain_QtyTextBox.Text = dt.Rows[0]["Remain_Qty"].ToString();
                    contract_IDTextBox.Text = dt.Rows[0]["Contract_ID"].ToString();
                    Contract_numComboBox.Text = dq.GetStringValu("Select Contract_Number from Contract where Contract_ID=" + dt.Rows[0]["Contract_ID"].ToString());
                    cust_IDTextBox.Text = dt.Rows[0]["cust_ID"].ToString();
                    Cust_Nametxtbox.Text = dq.GetStringValu("Select Cust_NAME from Customers where Cust_ID=" + dt.Rows[0]["cust_ID"].ToString());
                    notesTextBox.Text = dt.Rows[0]["Notes"].ToString();
                    dateTextBox.Text = dt.Rows[0]["Date"].ToString();
                    statusTextBox.Text = dt.Rows[0]["Status"].ToString();
                    if (dt.Rows[0]["Status"].ToString() == "مفتوح")
                    {
                        metroToggle1.Checked = true;
                    }
                    else
                    {
                        metroToggle1.Checked = false;
                    }
                    checkBox1.Enabled = true;
                    orderBindingNavigatorSaveItem.Enabled = true;

                }
                else
                {
                    MessageBox.Show("! غير موجود");
                }
                qtyTextBox.Enabled = true;


                //MessageBox.Show("<"+ order_NumberTextBox.Text.ToString()+">");
            }
            catch (Exception ex)
            {

            }

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                this.orderTableAdapter.FillByOnum(this.outdataset.Order, order_NumberTextBox.Text);
                qtyTextBox.Enabled = true;


            }
            catch (Exception ex)
            {

            }


        }

        private void orderBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void qtyTextBox_TextChanged(object sender, EventArgs e)
        {
            // checkReamainQuanty();
        }
        public Boolean checkReamainQuanty()
        {

            //if (qtyTextBox.Text.Length > 0)
            //{
            //    int Cid = 0;
            //    if (contract_IDTextBox.Text.Length > 0)
            //    {
            //        Cid = int.Parse(contract_IDTextBox.Text.ToString());

            //    }
            //    int oid = int.Parse(order_IDTextBox.Text.ToString());

            //    decimal OrderQ = decimal.Parse(qtyTextBox.Text.ToString());
            //    decimal OrderQnow = decimal.Parse(this.orderTableAdapter.GetQty(oid) + "");
            //    decimal ContQ = decimal.Parse(this.contractTableAdapter.GetQty(Cid) + "");
            //    decimal sumORdeq = decimal.Parse(this.orderTableAdapter.sumOfQtybyCid(Cid).ToString());
            //    //MessageBox.Show(sumORdeq + " " + OrderQ + " " + ContQ);
            //    if ((sumORdeq + OrderQ) > ContQ + OrderQnow)
            //    {

            //        MessageBox.Show("خطأ في الكمية او كمية غير متوفرة");
            //        // orderBindingNavigatorSaveItem.Enabled = false;
            //        qtyTextBox.ForeColor = System.Drawing.Color.Red;
            //        return false;
            //    }
            //    else
            //    {

            //        //orderBindingNavigatorSaveItem.Enabled = true;
            //        qtyTextBox.ForeColor = System.Drawing.Color.Black;

            //    }

            //}
            return true;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataQuery dq = new DataQuery();
        DataTable dt = new DataTable();
        private void order_NumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // MessageBox.Show("<" + order_NumberTextBox.Text.ToString() + ">");
                    // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                    //this.orderTableAdapter.FillByOnum(this.outdataset.Order,  );
                    dt = dq.GetDataTable("Select * from [Order] where Order_Number=N'" + order_NumberTextBox.Text.Trim().ToString() + "'");
                    if (dt.Rows.Count > 0)
                    {
                        order_IDTextBox.Text = dt.Rows[0]["Order_ID"].ToString();
                        order_NumberTextBox.Text = dt.Rows[0]["Order_Number"].ToString();
                        qtyTextBox.Text = dt.Rows[0]["Qty"].ToString();
                        remain_QtyTextBox.Text = dt.Rows[0]["Remain_Qty"].ToString();
                        contract_IDTextBox.Text = dt.Rows[0]["Contract_ID"].ToString();
                        Contract_numComboBox.Text = dq.GetStringValu("Select Contract_Number from Contract where Contract_ID=" + dt.Rows[0]["Contract_ID"].ToString());
                        cust_IDTextBox.Text = dt.Rows[0]["cust_ID"].ToString();
                        Cust_Nametxtbox.Text = dq.GetStringValu("Select Cust_NAME from Customers where Cust_ID=" + dt.Rows[0]["cust_ID"].ToString());
                        notesTextBox.Text = dt.Rows[0]["Notes"].ToString();
                        dateTextBox.Text = dt.Rows[0]["Date"].ToString();
                        statusTextBox.Text = dt.Rows[0]["Status"].ToString();
                        if (dt.Rows[0]["Status"].ToString() == "مفتوح")
                        {
                            metroToggle1.Checked = true;
                        }
                        else
                        {
                            metroToggle1.Checked = false;
                        }
                        checkBox1.Enabled = true;
                        orderBindingNavigatorSaveItem.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("! غير موجود");
                    }
                    qtyTextBox.Enabled = true;


                    //MessageBox.Show("<"+ order_NumberTextBox.Text.ToString()+">");
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "مغلق";
        }

        private void enableOrderBtn_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "مفتوح";
        }

        private void order_IDTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // TODO: This line of code loads data into the 'dLWSDataSet.Contract' table. You can move, or remove it, as needed.
                    this.orderTableAdapter.FillByOID(this.outdataset.Order, int.Parse(order_IDTextBox.Text));
                    qtyTextBox.Enabled = true;
                }
                catch (Exception ex)
                {

                }
            }
        }
        bool del = false;
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            del = true;
        }

        private void metroToggle1_CheckStateChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked == true)
            {
                statusTextBox.Text = "مفتوح";
            }
            else
            {
                statusTextBox.Text = "مغلق";
            }
        }

        string cnumtext = "";
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cnumtext = Contract_numComboBox.Text;
                DataTable cnumbers = dq.GetDataTable("Select Contract_Number,Contract_ID from Contract where (Status=N'مفتوح' and Qty>0)");
                if (cnumbers.Rows.Count < 1)
                {
                    MessageBox.Show("لا يوجد عقود متاحة");
                }
                else
                {
                    Contract_numComboBox.DataSource = cnumbers;
                    Contract_numComboBox.DisplayMember = "Contract_Number";
                    Contract_numComboBox.ValueMember = "Contract_ID";
                    contract_IDTextBox.DataBindings.Clear();
                    contract_IDTextBox.DataBindings.Add("Text", cnumbers, "Contract_ID");
                    if (dt.Rows.Count > 0)
                    {
                        contract_IDTextBox.Text = dt.Rows[0]["Contract_ID"].ToString();
                        Contract_numComboBox.Text = cnumtext;
                    }
                }
            }
            else
            {

                if (dt.Rows.Count > 0)
                {
                    Contract_numComboBox.Text = cnumtext;
                    contract_IDTextBox.Text = dt.Rows[0]["Contract_ID"].ToString();
                }
                //Contract_numComboBox.Enabled = false;
            }
        }

        private void SearchOrderNumber(object sender, EventArgs e)
        {

        }
    }
}
