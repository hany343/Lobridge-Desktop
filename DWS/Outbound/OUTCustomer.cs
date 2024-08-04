using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace LoBridge
{
    public partial class OUTCustomer : Form
    {
        DataTable perm;
        public OUTCustomer(DataTable dtp)
        {
            perm = dtp;
            InitializeComponent();
        }

        bool editing = false;
        int editID = 0;
        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            if (perm.Rows[0]["__customers_addBtn"].ToString() == "1")
            {
                AddNewItemBtn.Enabled = true;
            }

            List_Customers();
        }

        private void Clearfields()
        {
            //sUP_IDTextBox.Text = "";
            cust_NAMETextBox.Text = "";
            pHONETextBox.Text = "";
            mOBILETextBox.Text = "";
            cITYTextBox.Text = "";
            aDDRESSTextBox.Text = "";
            nOTESTextBox.Text = "";
        }
        private void canceledit()
        {
            Clearfields();
            SaveItemBtn.Enabled = false;
            AddNewItemBtn.Enabled = true;

            panel1.Enabled = false;
            editing = false;

        }
        DataQuery dq = new DataQuery();
        private void SaveItem_Click(object sender, EventArgs e)
        {
            if (cust_NAMETextBox.Text.Trim() == "")
            {
                MessageBox.Show("ادخل اسم العميل ", "خطأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (!editing)
                    {

                        DataTable dt = dq.GetDataTable("SELECT * FROM Customers WHERE (Cust_NAME = N'" + cust_NAMETextBox.Text + "')");
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("هذا العميل موجود بالفعل !!");
                            cust_NAMETextBox.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            string inquery = "INSERT INTO[Customers] ([ADDRESS], [NOTES], [Status], [CUusername], [CITY], [Cust_NAME], [MOBILE], [PHONE], [create_date]) VALUES" +
                                "(N'" + aDDRESSTextBox.Text + "', N'" + nOTESTextBox.Text + "',N'مفعل' " + ",N'" + Properties.Settings.Default.logedUN
                                + "','" + cITYTextBox.Text + "',N'" + cust_NAMETextBox.Text + "',N'" + mOBILETextBox.Text + "', '" + pHONETextBox.Text + "', current_timestamp);";
                            dq.RunNonQuery(inquery);
                            dt = dq.GetDataTable("SELECT * FROM Customers WHERE (Cust_NAME = N'" + cust_NAMETextBox.Text + "')");
                            if (dt.Rows.Count > 0)
                            {
                                SaveItemBtn.Enabled = false;
                                AddNewItemBtn.Enabled = true;

                                panel1.Enabled = false;
                                MessageBox.Show("تم الحفظ");
                            }
                            else
                            {
                                MessageBox.Show("خطأ اثناء الحفظ, يرجي المحاولة مرة اخري.");
                            }
                        }
                    }
                    else
                    {
                        DataTable dt = dq.GetDataTable("SELECT * FROM Customers WHERE (Cust_NAME = N'" + cust_NAMETextBox.Text + "')");
                        if (dt.Rows.Count > 0)
                        {
                            int tempID = ((int)(System.Convert.ChangeType(dt.Rows[0]["Cust_ID"].ToString(), typeof(int))));
                            if (editID != tempID)
                            {
                                MessageBox.Show("هذا العميل موجود بالفعل !!");
                                cust_NAMETextBox.ForeColor = System.Drawing.Color.Red;
                            }
                            else
                            {
                                string inquery = "update [Customers] set [ADDRESS]=N'" + aDDRESSTextBox.Text + "', [NOTES]=N'" + nOTESTextBox.Text + "', [Status]=N'" + statuscombox.Text +
                                    "',  [CITY]=N'" + cITYTextBox.Text + "', [Cust_NAME]=N'" + cust_NAMETextBox.Text +
                                    "', [MOBILE]=N'" + mOBILETextBox.Text + "', [PHONE]=N'" + pHONETextBox.Text + "' where Cust_ID= " + editID;
                                dq.RunNonQuery(inquery);
                                //save
                                editing = false;

                            }

                        }
                        else
                        {
                            string inquery = "update [Customers] set [ADDRESS]=N'" + aDDRESSTextBox.Text + "', [NOTES]=N'" + nOTESTextBox.Text + "', [Status]=N'" + statuscombox.Text +
                                       "',  [CITY]=N'" + cITYTextBox.Text + "', [Cust_NAME]=N'" + cust_NAMETextBox.Text +
                                       "', [MOBILE]=N'" + mOBILETextBox.Text + "', [PHONE]=N'" + pHONETextBox.Text + "' where Cust_ID= " + editID;
                            dq.RunNonQuery(inquery);
                            editing = false;
                        }
                    }

                    FormCollection fc = Application.OpenForms;
                    OutListCustomers lc = new OutListCustomers(perm);
                    foreach (Form frm in fc)
                    {
                        if (frm.Text == lc.Text)
                        {
                            lc = (LoBridge.OutListCustomers)frm;
                        }
                    }
                    SaveItemBtn.Enabled = false;
                    AddNewItemBtn.Enabled = true;

                    panel1.Enabled = false;
                    lc.reload();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void AddNewItem_Click(object sender, EventArgs e)
        {
            SaveItemBtn.Enabled = true;
            AddNewItemBtn.Enabled = false;
            panel1.Enabled = true;
            statuscombox.SelectedIndex = 0;
            statuscombox.Enabled = false;
            Clearfields();
        }

        public void Editcustomer(int cid)
        {
            AddNewItemBtn.Enabled = false;
            editing = true;
            statuscombox.Enabled = true;
            editID = cid;
            DataTable dt = dq.GetDataTable("SELECT * FROM Customers WHERE (Cust_ID = " + cid + ")");
            if (dt.Rows.Count > 0)
            {

                SaveItemBtn.Enabled = true;
                AddNewItemBtn.Enabled = false;
                panel1.Enabled = true;
                Clearfields();

                cust_NAMETextBox.Text = dt.Rows[0]["Cust_NAME"].ToString();
                pHONETextBox.Text = dt.Rows[0]["PHONE"].ToString();
                mOBILETextBox.Text = dt.Rows[0]["MOBILE"].ToString();
                cITYTextBox.Text = dt.Rows[0]["CITY"].ToString();
                aDDRESSTextBox.Text = dt.Rows[0]["ADDRESS"].ToString();
                nOTESTextBox.Text = dt.Rows[0]["NOTES"].ToString();
                statuscombox.Text = dt.Rows[0]["Status"].ToString();

            }
            else
            {
                MessageBox.Show("خطأ في تحميل البيانات !");
            }
        }
        private void List_Customers()
        {
            OutListCustomers listC = new OutListCustomers(perm);
            listC.TopLevel = false;
            panel3.Controls.Add(listC);
            listC.Dock = DockStyle.Fill;
            listC.FormBorderStyle = FormBorderStyle.None;
            listC.Show();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cust_name_TextChanged(object sender, EventArgs e)
        {

            //if (cust_NAMETextBox.FindStringExact(cust_NAMETextBox.Text.Trim()) != -1)
            //{
            //    // MessageBox.Show("موجود");
            //    sUPPLIERSBindingNavigatorSaveItem.Enabled = false;
            //    cust_NAMEComboBox.ForeColor = System.Drawing.Color.Red;
            //}
            //else
            //{
            cust_NAMETextBox.ForeColor = System.Drawing.Color.Black;

            SaveItemBtn.Enabled = true;
            //}

        }

        private void OUTCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {

            //  cust_NAMEComboBox.DataBindings.Clear();

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            canceledit();
        }
    }
}
