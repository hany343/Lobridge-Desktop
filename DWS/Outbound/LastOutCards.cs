using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class LastOutCards : Form
    {
        public LastOutCards()
        {
            InitializeComponent();
        }

        private void fillForLadoutToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.lcacrd1TableAdapter.FillForLadout(this.dLWSDataSet.Lcacrd1, ((int)(System.Convert.ChangeType(lcardToolStripTextBox.Text, typeof(int)))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void LastOutCards_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.LastLadingout' table. You can move, or remove it, as needed.
                this.lastLadingoutTableAdapter.Fill(this.oUTDataset.LastLadingout);
            }
            catch (Exception ex)
            {

            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
