
using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OutPrint_BLading : Form
    {
        int lcard = 1;
        DataTable perm;
        public OutPrint_BLading(int lCard, DataTable pdt)
        {
            perm = pdt;
            lcard = lCard;
            InitializeComponent();
        }

        private void Print_Lcard_Load(object sender, EventArgs e)
        {
            if (perm.Rows[0]["__billlading_edit"].ToString() == "1")
            {
                outcardBtn.Enabled = true;
                saverepBtn.Enabled = true;
                addrsBtn.Enabled = true;
            }
            // TODO: This line of code loads data into the 'dLWSDataSet.Lading_Out' table. You can move, or remove it, as needed.
            // this.lading_OutTableAdapter.Fill(this.dLWSDataSet.Lading_Out);
            // TODO: This line of code loads data into the 'dLWSDataSet.Lading_Out' table. You can move, or remove it, as needed.
            //this.lading_OutTableAdapter.Fill(this.dLWSDataSet.Lading_Out);
            if (lcard > 0)
            {
                loadcard();
            }
            //  
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (LadidBox.Text.Length > 0)
            {

                lcard = int.Parse(LadidBox.Text);

                loadcard();
            }
            else
            {
                MessageBox.Show("ادخل رقم كارت التحميل");
            }

        }
        DataQuery dq = new DataQuery();
        public void loadcard()
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.Lcacrd1' table. You can move, or remove it, as needed.
            //this.lcacrd1TableAdapter.FillForLadout(this.dLWSDataSet.Lcacrd1);

            if (lcard != 0)
            {



                // TODO: This line of code loads data into the 'wdbDataSet.RECEIPTCARD' table. You can move, or remove it, as needed.
                try
                {
                    this.lcacrd1TableAdapter.FillBLading(this.oUTDataset.Lcacrd1, lcard);
                    string counted = "";
                    if (this.oUTDataset.Lcacrd1.Rows.Count > 0)
                    {
                        if (dq.GetStringValu("Select counted from commodity where Comm_Name=N'" + this.oUTDataset.Lcacrd1.Rows[0]["Comm_Name"].ToString() + "'") == "yes")
                        {
                            counted = "-pack";
                        }

                        if (decimal.Parse(this.oUTDataset.Lcacrd1.Rows[0]["Net_Weight"].ToString()) == 0)
                        {
                            counted = "-packnw";
                        }

                    }
                    string contname = this.oUTDataset.Lcacrd1.Rows[0]["Contract_Number"].ToString();

                    if (contname.Contains("GOV") || contname.Contains("gov"))
                    {
                        counted = "-gov" + counted;

                    }

                    reportDocument1.Load(Application.StartupPath + @"\reports\BLading1" + counted + ".rpt");

                    if (this.oUTDataset.Lcacrd1.Rows.Count > 0)
                    {
                        addrsBtn.Visible = true;
                    }
                    else
                    {
                        addrsBtn.Visible = false;
                    }
                }
                catch (System.Exception ex)
                {
                    // System.Windows.Forms.MessageBox.Show(ex.Message + " >>rcard error1");
                }

            }
            if (this.oUTDataset.Lcacrd1.Rows.Count > 0)
            {
                reportDocument1.SetDataSource(this.oUTDataset);
                crystalReportViewer1.ReportSource = reportDocument1;

                reportDocument1.Refresh();
                //reportDocument1.SetParameterValue(0, "hany");
                if (toolStripTextBox1.Text.Length < 1)
                {
                    toolStripTextBox1.ReadOnly = false;
                    saverepBtn.Visible = true;
                    crystalReportViewer1.ShowPrintButton = false;
                }
                else if (leaveDateTextBox.Text.Length < 10)
                {
                    outcardBtn.Visible = true;
                    crystalReportViewer1.ShowPrintButton = false;

                }
                else
                {
                    outcardBtn.Visible = false;
                    leaveDateTextBox.ReadOnly = true;
                    toolStripTextBox1.ReadOnly = true;
                    saverepBtn.Visible = false;
                    crystalReportViewer1.ShowPrintButton = true;
                }

            }
            else
            {
                MessageBox.Show("غير موجود ", "خطأ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lading_OutTableAdapter.UpdateRepr(toolStripTextBox1.Text, int.Parse(LadidBox.Text), int.Parse(LadidBox.Text));
                loadcard();
            }
            catch (Exception ex)
            {

            }
        }

        private void Print_Ladingcard_FormClosing(object sender, FormClosingEventArgs e)
        {


            reportDocument1.Close();
            // Dispose();


        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_Click_1(object sender, EventArgs e)
        {
            if (LadidBox.Text.Length > 0)
            {
                try
                {

                    ShipAddress shipAddress = new ShipAddress(int.Parse(LadidBox.Text));
                    shipAddress.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            lading_OutTableAdapter.UpdatelEAVEDATE(Properties.Settings.Default.logedUN, int.Parse(LadidBox.Text), int.Parse(LadidBox.Text));
            loadcard();
        }

        private void LadidBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (LadidBox.Text.Length > 0)
                {

                    lcard = int.Parse(LadidBox.Text);

                    loadcard();
                }
                else
                {
                    MessageBox.Show("ادخل رقم كارت التحميل");
                }
            }
        }
    }
}

