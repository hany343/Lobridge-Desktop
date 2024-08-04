using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class ListDrivers : Form
    {
        public ListDrivers()
        {
            InitializeComponent();
        }

        private void driversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversBindingSource.EndEdit();
            this.driversTableAdapter.Update(this.dLWSDataSet);

        }

        private void ListDrivers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.dLWSDataSet.Drivers);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            decimal nc;
            try
            {
                if (ncardToolStripTextBox.Text.Length > 0)
                {
                    nc = ((decimal)(System.Convert.ChangeType(ncardToolStripTextBox.Text, typeof(decimal))));
                    this.driversTableAdapter.FillBy1(this.dLWSDataSet.Drivers, "%" + dnameToolStripTextBox.Text + "%", nc);
                }
                else
                {
                    // nc = ((decimal)(System.Convert.ChangeType(ncardToolStripTextBox.Text, typeof(decimal))));
                    this.driversTableAdapter.FillBy2NameOnly(this.dLWSDataSet.Drivers, "%" + dnameToolStripTextBox.Text + "%");
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dnameToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal nc;
            try
            {
                if (ncardToolStripTextBox.Text.Length > 0)
                {
                    nc = ((decimal)(System.Convert.ChangeType(ncardToolStripTextBox.Text, typeof(decimal))));
                    this.driversTableAdapter.FillBy1(this.dLWSDataSet.Drivers, "%" + dnameToolStripTextBox.Text + "%", nc);
                }
                else
                {
                    // nc = ((decimal)(System.Convert.ChangeType(ncardToolStripTextBox.Text, typeof(decimal))));
                    this.driversTableAdapter.FillBy2NameOnly(this.dLWSDataSet.Drivers, "%" + dnameToolStripTextBox.Text + "%");
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
