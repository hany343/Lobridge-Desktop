using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }


        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.User_Perm' table. You can move, or remove it, as needed.
            this.user_PermTableAdapter.Fill(this.dLWSDataSet.User_Perm);
            // TODO: This line of code loads data into the 'dLWSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.FillByNotadmin(this.dLWSDataSet.Users);

        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        //private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (newu == true)
        //        {
        //            decimal mnum = 0;
        //            try
        //            {
        //                mnum = Convert.ToDecimal(mobileTextBox.Text);
        //            }
        //            catch (Exception exx)
        //            {
        //                MessageBox.Show("error in mobile number");
        //            }
        //            int rol = 5;
        //            try
        //            {
        //                rol = Convert.ToInt32(roleComboBox.SelectedValue.ToString());
        //            }
        //            catch (Exception exx)
        //            {
        //                MessageBox.Show("error in role value");
        //            }

        //            this.usersTableAdapter.InsertUser(uNameTextBox.Text, uLoginTextBox.Text, uPassTextBox.Text, emailTextBox.Text
        //                , jobTextBox.Text, mnum, "", rol);

        //            MessageBox.Show("save success");


        //    }else if (newu == false)
        //    {
        //            this.Validate();
        //            this.usersBindingSource.EndEdit();
        //            this.usersTableAdapter.Update(this.dLWSDataSet);
        //    }
        //}
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool newu = false;
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            newu = true;
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dLWSDataSet);

        }
    }
}
