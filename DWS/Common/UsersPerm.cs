using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoBridge.Common
{
    public partial class UsersPerm : Form
    {
        public UsersPerm()
        {
            InitializeComponent();
        }

        private void user_PermBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_PermBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dLWSDataSet);

        }

        private void UsersPerm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.User_Perm' table. You can move, or remove it, as needed.
            this.user_PermTableAdapter.Fill(this.dLWSDataSet.User_Perm);

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
