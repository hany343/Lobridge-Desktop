using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class INPrint_RCard : Form
    {
        int rcardid = 0;
        public INPrint_RCard(int rid)
        {
            rcardid = rid;
            InitializeComponent();
        }

        private void Print_RCard_Load(object sender, EventArgs e)
        {
            load(rcardid);

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Print_RCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportDocument1.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int rid = Convert.ToInt32(LadidBox.Text);
                load(rid);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " >>rcard error0");
            }
        }
        public void load(int rid)
        {

            // TODO: This line of code loads data into the 'wdbDataSet.RECEIPTCARD' table. You can move, or remove it, as needed.
            try
            {
                this.rcard1TableAdapter.FillRCard(this.iNdataset.Rcard1, rid);
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message+" >>rcard error1");
            }

            reportDocument1.Load(Application.StartupPath + @"\reports\RCardds.rpt");
            reportDocument1.SetDataSource(this.iNdataset);
            crystalReportViewer1.ReportSource = reportDocument1;
            reportDocument1.Refresh();
        }

        private void LadidBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int rid = Convert.ToInt32(LadidBox.Text);
                    load(rid);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message + " >>rcard error0");
                }
            }
        }
    }
}
