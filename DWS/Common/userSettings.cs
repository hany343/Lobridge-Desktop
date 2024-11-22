using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class userSettings : Form
    {
        public userSettings()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.usersTableAdapter.Update(this.dLWSDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void userSettings_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dLWSDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.dLWSDataSet.Users);
            try
            {
                this.usersTableAdapter.FillByLoginName(this.dLWSDataSet.Users, Properties.Settings.Default.logedUN);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByLoginNameToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
