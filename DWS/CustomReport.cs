using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class CustomReport : Form
    {
        public CustomReport()
        {
            InitializeComponent();
        }

        private void CustomReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.INCardsReport' table. You can move, or remove it, as needed.
            //this.iNCardsReportTableAdapter.FillINCards(this.dLWSDataSet.INCardsReport);
            openFileDialog1.InitialDirectory = (Application.StartupPath + @"\reports\");
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                reportDocument1.Load(filename);

                // TODO: This line of code loads data into the 'wdbDataSet.RECEIPTCARD' table. You can move, or remove it, as needed.
                try
                {
                    this.iNCardsReportTableAdapter.FillINCards(this.dLWSDataSet.INCardsReport);

                }
                catch (System.Exception ex)
                {
                    // System.Windows.Forms.MessageBox.Show(ex.Message + " >>rcard error1");
                }



                reportDocument1.SetDataSource(this.dLWSDataSet);
                crystalReportViewer1.ReportSource = reportDocument1;
                reportDocument1.Refresh();
            }

        }
    }
}
