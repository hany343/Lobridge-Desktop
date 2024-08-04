using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class Commodity : Form
    {
        DataTable perm;
        public Commodity(DataTable permdt)
        {
            perm = permdt;
            InitializeComponent();
        }

        private void commodityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (comm_NAMETextBox.Text.Length > 0)
            {
                try
                {
                    string counted = "no";
                    if (checkBox1.CheckState == CheckState.Checked)
                    {
                        counted = "yes";
                    }
                    this.commodityTableAdapter.InsertComm(comm_NAMETextBox.Text + "", comm_TYPETextBox.Text + "", notesTextBox.Text + "", descriptionTextBox.Text + "", Properties.Settings.Default.logedUN, counted);

                    bindingNavigatorAddNewItem.Enabled = true;
                    commodityBindingNavigatorSaveItem.Enabled = false;
                    bindingNavigatorDeleteItem.Enabled = false;
                    panel3.Enabled = false;
                    listComm.loadcom();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " <Comm Error 1>");
                }
            }
            else
            {
                MessageBox.Show("ادخل اسم البضاعة");
            }
        }

        private void Commodity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.Commodity' table. You can move, or remove it, as needed.

        }
        public void clearf()
        {
            comm_NAMETextBox.Text = "";
            comm_TYPETextBox.Text = "";
            notesTextBox.Text = "";
            descriptionTextBox.Text = "";

        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            commodityBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            panel3.Enabled = true;
            clearf();

            int comID = 1;
            try
            {
                string maxID = commodityTableAdapter.GetLastID().ToString();
                comID = int.Parse(maxID) + 1;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + "err10");
            }
            CommIDTextBox.Text = comID + "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            commodityBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            panel3.Enabled = false;
            // TODO: This line of code loads data into the 'dLWSDataSet.Commodity' table. You can move, or remove it, as needed.
            try
            {
                this.commodityTableAdapter.FillByCID(this.dLWSDataSet.Commodity, -1);
                CommIDTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        comListComm listComm;
        private void Commodity_Shown(object sender, EventArgs e)
        {
            listComm = new comListComm(perm);
            listComm.FormBorderStyle = FormBorderStyle.None;
            listComm.Dock = DockStyle.Fill;
            listComm.TopLevel = false;
            listcommPanel.Controls.Add(listComm);
            listComm.Show();
        }

        private void Commodity_Load_1(object sender, EventArgs e)
        {

        }
    }
}
