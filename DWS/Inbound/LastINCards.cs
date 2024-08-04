using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class LastINCards : Form
    {
        public LastINCards()
        {
            InitializeComponent();
        }

        private void LastINCards_Load(object sender, EventArgs e)
        {
            reload();
        }


        public void reload()
        {
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Lading' table. You can move, or remove it, as needed.
                this.ladingTableAdapter.FillBylastFive(this.iNdataset.Lading);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
