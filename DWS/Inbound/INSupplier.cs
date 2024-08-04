using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class INSupplier : Form
    {
        DataTable perm;
        public INSupplier(DataTable dataTable)
        {
            perm = dataTable;
            InitializeComponent();
        }

        INListSuppliers listSuppliers; //= new INListSuppliers(perm);

        private void CreateSupplier_Load(object sender, EventArgs e)
        {
            if (perm.Rows[0]["__supplier_addBtn"].ToString() == "1")
            {
                addBtn.Enabled = true;
            }


            listSuppliers = new INListSuppliers(perm, this);
            listSuppliers.TopLevel = false;
            listSuppliers.Dock = DockStyle.Fill;
            ListSupplierspanel1.Controls.Add(listSuppliers);
            listSuppliers.Show();
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'iNdataset.SUPPLIERS' table. You can move, or remove it, as needed.
                this.sUPPLIERSTableAdapter.Fill(this.iNdataset.SUPPLIERS);

            }
            catch (Exception ex)
            {

            }

            this.sUP_IDTextBox.Text = "";

            addBtn.Enabled = false;
            sUPPLIERSBindingNavigatorSaveItem.Enabled = true;


            bindingNavigatorDeleteItem.Enabled = true;
            //EditBtn.Enabled = false;
            panel3.Enabled = true;
        }
        bool editing = false;
        private void sUPPLIERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (suppNametextBox.Text.Trim() == "")
            {
                MessageBox.Show("ادخل اسم المورد");
            }
            else
            {
                try
                {


                    if (!editing)
                    {
                        string compID = dq.GetStringValu("SELECT  ISNULL ((SELECT  COUNT(*) AS Expr1 FROM  SUPPLIERS" +
                                " WHERE(SUP_NAME = N'" + suppNametextBox.Text.Trim() + "' )), 0) AS Expr1 ");

                        if (compID != "0")
                        {
                            MessageBox.Show("اسم المورد موجود بالفعل");
                        }
                        else
                        {
                            int ident = int.Parse(this.sUPPLIERSTableAdapter.InsertSupplier(suppNametextBox.Text, pHONETextBox.Text, mOBILETextBox.Text, cITYComboBox.Text
                                     , aDDRESSTextBox.Text, nOTESTextBox.Text, "", Properties.Settings.Default.logedUN).ToString());

                            sUP_IDTextBox.Text = ident + "";
                            sUPPLIERSBindingNavigatorSaveItem.Enabled = false;
                            addBtn.Enabled = true;
                            bindingNavigatorDeleteItem.Enabled = false;
                            // EditBtn.Enabled = true;
                            panel3.Enabled = false;
                            listSuppliers.refill();

                        }

                    }
                    else
                    {

                        bool val = true;

                        DataTable dtid = dq.GetDataTable("Select SUP_ID from Suppliers where SUP_NAME=N'" + suppNametextBox.Text.Trim() + "'");
                        if (dtid != null)
                        {
                            if (dtid.Rows.Count > 0)
                            {
                                if (dtid.Rows[0][0].ToString() != sUP_IDTextBox.Text)
                                {
                                    val = false;

                                    MessageBox.Show("اسم المورد موجود بالفعل");
                                }

                            }

                            if (val)
                            {
                                string upquery = "UPDATE [SUPPLIERS] SET [SUP_NAME] = N'" + suppNametextBox.Text + "', [PHONE] = N'" + pHONETextBox.Text + "', [MOBILE] = N'" + mOBILETextBox.Text +
                                    "', [CITY] = N'" + cITYComboBox.Text + "', " + "[ADDRESS] = N'" + aDDRESSTextBox.Text + "', [NOTES] = N'" + nOTESTextBox.Text + "'  WHERE [SUP_ID] = " + sUP_IDTextBox.Text.Trim() + "";
                                if (dq.RunNonQuery(upquery))
                                {
                                    sUPPLIERSBindingNavigatorSaveItem.Enabled = false;
                                    addBtn.Enabled = true;
                                    bindingNavigatorDeleteItem.Enabled = false;
                                    // EditBtn.Enabled = true;
                                    panel3.Enabled = false;
                                    listSuppliers.refill();
                                    editing = false;
                                }
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        DataQuery dq = new DataQuery();
        public void fillforedit(int sid)
        {
            try
            {

                // this.sUP_IDTextBox.Text = "";

                addBtn.Enabled = false;
                sUPPLIERSBindingNavigatorSaveItem.Enabled = true;


                bindingNavigatorDeleteItem.Enabled = true;
                // EditBtn.Enabled = false;
                panel3.Enabled = true;
                this.sUPPLIERSTableAdapter.FillBySid(this.iNdataset.SUPPLIERS, sid);
                // MessageBox.Show(sid + ""+ this.iNdataset.SUPPLIERS.Rows.Count + ""+ this.iNdataset.SUPPLIERS.Rows[0][1].ToString());


                suppNametextBox.Text = this.iNdataset.SUPPLIERS.Rows[0]["SUP_NAME"].ToString();
                sUP_IDTextBox.Text = this.iNdataset.SUPPLIERS.Rows[0][0].ToString();
                aDDRESSTextBox.Text = this.iNdataset.SUPPLIERS.Rows[0]["ADDRESS"].ToString();
                pHONETextBox.Text = this.iNdataset.SUPPLIERS.Rows[0]["PHONE"].ToString();
                cITYComboBox.Text = this.iNdataset.SUPPLIERS.Rows[0]["CITY"].ToString();
                mOBILETextBox.Text = this.iNdataset.SUPPLIERS.Rows[0]["MOBILE"].ToString();
                nOTESTextBox.Text = this.iNdataset.SUPPLIERS.Rows[0]["NOTES"].ToString();

                editing = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
