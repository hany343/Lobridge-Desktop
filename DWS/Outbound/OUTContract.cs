using System;

using System.Data;

using System.Windows.Forms;

namespace LoBridge
{
    public partial class OUTContract : Form
    {
        int coid = 0;
        DataTable perm;
        public OUTContract(int co_id, DataTable permdt)
        {
            coid = co_id;
            perm = permdt;
            InitializeComponent();
        }

        private void OUTContract_Load(object sender, EventArgs e)
        {
            if (perm.Rows[0]["__edit_contract"].ToString() == "1")
            {
                editButton1.Enabled = true;
            }
            if (coid > 0)
            {
                editing = true;
                this.panel2.Enabled = true;
                this.SaveItemBtn.Enabled = true;
                DeleteItemBtn.Enabled = true;
                AddNewItemBtn.Enabled = false;
                refreshButton1.Enabled = true;
                editButton1.Enabled = false;
                clearFields();
                load_Contract("id");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            this.panel2.Enabled = true;
            this.SaveItemBtn.Enabled = true;
            DeleteItemBtn.Enabled = true;
            AddNewItemBtn.Enabled = false;
            refreshButton1.Enabled = true;
            editButton1.Enabled = false;
            clearFields();
        }

        private void clearFields()
        {
            contract_NumberTextBox.Text = "";
            contract_TypeTextBox.Text = "";
            qtyTextBox.Text = "";
            notesTextBox.Text = "";
        }


        DataQuery dq = new DataQuery();
        private void contractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (contract_NumberTextBox.Text.Length < 1)
            {
                MessageBox.Show("ادخل رقم العقد");
                return;
            }

            if (qtyTextBox.Text.Length < 1)
            {
                MessageBox.Show("ادخل كمية العقد");
                return;
            }
            else
            {
                try
                {
                    decimal.Parse(qtyTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("الكمية غير صحيحة");
                }
            }

            if (editing)
            {
                if (decimal.Parse(dq.GetStringValu("SELECT  ISNULL ((SELECT  SUM(Qty) AS Expr1  FROM[Order] WHERE(Contract_ID = " + cid + ")), 0) AS Expr1")) > decimal.Parse(qtyTextBox.Text))
                {

                    MessageBox.Show("! كمية العقد اقل من المحجوز");
                    return;
                }
               
            }
            try
            {
                string findCNum = "select Contract_Number from Contract where Contract_Number='" + contract_NumberTextBox.Text + "'";
                DataTable foundNum = dq.GetDataTable(findCNum);


                try
                {

                    string inQuery = "";
                    if (!editing)
                    {
                        if (foundNum.Rows.Count < 1)
                        {
                            inQuery = "INSERT INTO Contract (Comm_ID, Contract_Number, CONusername, Contract_Type,  Notes, Qty, Remain_QTY,  Status,date)" +
                          "VALUES(" + int.Parse(comm_IDComboBox.SelectedValue.ToString()) + ",N'" + contract_NumberTextBox.Text + "',N'" + Properties.Settings.Default.logedUN + "',N'" + contract_TypeTextBox.Text +
                          "', N'" + notesTextBox.Text + "'," + decimal.Parse(qtyTextBox.Text) + "," + decimal.Parse(qtyTextBox.Text) + ", N'مفتوح',current_timestamp);";


                        }
                        else
                        {
                            MessageBox.Show("رقم عقد مكرر");
                            return;
                        }
                    }
                    else
                    {
                        inQuery = "update Contract set Comm_ID=" + int.Parse(comm_IDComboBox.SelectedValue.ToString()) + ", Contract_Number = N'" + contract_NumberTextBox.Text + "', CONusername = N'" + Properties.Settings.Default.logedUN +
                           "', Contract_Type = N'" + contract_TypeTextBox.Text + "', Notes =  N'" + notesTextBox.Text + "', Qty=" + decimal.Parse(qtyTextBox.Text) + " where Contract_ID =" + cid;
                        //   MessageBox.Show(inQuery);
                    }
                    if (dq.RunNonQuery(inQuery))
                    {
                        string getCNum = "select Contract_Number,qty from Contract where Contract_Number='" + contract_NumberTextBox.Text + "'";
                        DataTable contNum = dq.GetDataTable(getCNum);
                        // && qtyTextBox.Text == contNum.Rows[0]["Qty"].ToString()
                        if (contNum.Rows.Count > 0)
                        {
                            SaveItemBtn.Enabled = false;
                            DeleteItemBtn.Enabled = false;
                            this.panel2.Enabled = false;
                            AddNewItemBtn.Enabled = true;
                            refreshButton1.Enabled = false;

                            editButton1.Enabled = true;
                            comm_IDComboBox.Enabled = true;

                            
                            dq.RunNonQuery("insert into logs(actiondate,username,tablename,uaction,cdata,code) values ('"+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+"',N'" + Properties.Settings.Default.logedUN +
                                   "','Contract','edit',N'" + qtyTextBox.Text + "  " + contract_NumberTextBox.Text + "',0)");


                            MessageBox.Show("تم الحفظ");
                        }
                        else
                        {
                            MessageBox.Show("خطأ في الحفظ يرجي اعادة المحاولة !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("خطأ في الحفظ يرجي اعادة المحاولة !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }

        }

        private void comm_IDComboBox_Click(object sender, EventArgs e)
        {


            try
            {
                string commQuery = "select Comm_ID,Comm_Name from Commodity where Status=N'مفتوح'";
                DataTable dt = dq.GetDataTable(commQuery);
                comm_IDComboBox.DataSource = dt;
                comm_IDComboBox.DisplayMember = "Comm_Name";
                comm_IDComboBox.ValueMember = "Comm_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            Fill_Comm();
        }

        private void Fill_Comm()
        {

            // TODO: This line of code loads data into the 'dLWSDataSet.Commodity' table. You can move, or remove it, as needed.
            string vquerey = "SELECT COUNT(*) AS Expr1 FROM Lading_Out INNER JOIN   [Order] ON Lading_Out.Order_ID = [Order].Order_ID INNER JOIN" +
                       " Contract ON[Order].Contract_ID = Contract.Contract_ID WHERE(Contract.Contract_Number = N'" + contract_NumberTextBox.Text.Trim() + "') AND(Lading_Out.F_weight > 0)";
            if (dq.GetStringValu(vquerey) != "0")
            {
                comm_IDComboBox.Enabled = false;
            }
            else
            {
                try
                {
                    comm_IDComboBox.Enabled = true;
                    string commQuery = "select Comm_ID,Comm_Name from Commodity";
                    DataTable dt = dq.GetDataTable(commQuery);
                    comm_IDComboBox.DataSource = dt;
                    comm_IDComboBox.DisplayMember = "Comm_Name";
                    comm_IDComboBox.ValueMember = "Comm_ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            clearFields();
            SaveItemBtn.Enabled = false;
            DeleteItemBtn.Enabled = false;
            this.panel2.Enabled = false;
            AddNewItemBtn.Enabled = true;
            refreshButton1.Enabled = false;
            editButton1.Enabled = true;
        }

        bool editing = false;

        private void editButton1_Click(object sender, EventArgs e)
        {
            this.panel2.Enabled = true;
            this.SaveItemBtn.Enabled = true;
            DeleteItemBtn.Enabled = true;
            AddNewItemBtn.Enabled = false;
            refreshButton1.Enabled = true;
            editButton1.Enabled = false;
            editing = true;

            clearFields();
        }
        int cid = 0;
        private void contract_NumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && editing == true)
            {
                load_Contract("cname");
            }
        }
        private void load_Contract(string ltype)
        {

            try
            {
                string findCNum = "";
                if (ltype == "cname")
                {
                    findCNum = "select * from Contract where Contract_Number=N'" + contract_NumberTextBox.Text + "'";
                }
                else
                {
                    findCNum = "select * from Contract where Contract_ID=" + coid;

                }

                DataTable dt = dq.GetDataTable(findCNum);
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("!غير موجود");
                    if (coid > 0)
                    {
                        this.Close();
                    }
                }
                else if (dt.Rows[0]["Status"].ToString() == "مغلق")
                {
                    MessageBox.Show("! هذا العقد مغلق");
                    if (coid > 0)
                    {
                        this.Close();
                    }
                }
                else
                {
                    contract_NumberTextBox.Text = dt.Rows[0]["Contract_Number"].ToString();

                    Fill_Comm();
                    cid = int.Parse(dt.Rows[0]["Contract_ID"].ToString());
                    contract_TypeTextBox.Text = dt.Rows[0]["Contract_Type"].ToString();

                    comm_IDComboBox.Text = dq.GetStringValu("select Comm_Name from Commodity where Comm_ID=" + int.Parse(dt.Rows[0]["Comm_ID"].ToString()));
                    qtyTextBox.Text = dt.Rows[0]["Qty"].ToString();
                    notesTextBox.Text = dt.Rows[0]["Notes"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
