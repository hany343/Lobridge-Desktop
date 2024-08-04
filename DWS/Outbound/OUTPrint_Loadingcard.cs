using System;
using System.Windows.Forms;


namespace LoBridge
{
    public partial class OUTPrint_Loadingcard : Form
    {
        int lcard = 1;
        string typ = "a";
        string counted = "";
        public OUTPrint_Loadingcard(int lCard, string type, string cnt)
        {
            counted = cnt;
            lcard = lCard;
            typ = type;
            InitializeComponent();
        }

        private void Print_Lcard_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dLWSDataSet.Lcacrd1' table. You can move, or remove it, as needed.
            //this.lcacrd1TableAdapter.FillForLadout(this.dLWSDataSet.Lcacrd1);
            if (typ == "new")
            {
                loadRpt();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (LadidBox.Text.Length > 0)
            {
                try
                {
                    lcard = int.Parse(LadidBox.Text);

                    loadRpt();
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                MessageBox.Show("ادخل رقم الكارت");
            }

        }
        public void loadRpt()
        {

            // TODO: This line of code loads data into the 'wdbDataSet.RECEIPTCARD' table. You can move, or remove it, as needed.
            try
            {
                this.lcacrd1TableAdapter.FillBy(this.oUTDataset.Lcacrd1, lcard);
                // MessageBox.Show(lcard+"");
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message + " >>rcard error1");
            }

            reportDocument1.Load(Application.StartupPath + @"\reports\LCard" + counted + ".rpt");
            reportDocument1.SetDataSource(this.oUTDataset);

            crystalReportViewer1.ReportSource = reportDocument1;
            reportDocument1.Refresh();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Print_Lcard_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportDocument1.Close();
        }

        private void LadidBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (LadidBox.Text.Length > 0)
                {

                    loadRpt();

                    // loadcard();
                }
                else
                {
                    MessageBox.Show("ادخل رقم كارت التحميل");
                }
            }
        }
    }
}