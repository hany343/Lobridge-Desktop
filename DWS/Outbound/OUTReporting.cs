using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OutDailyreport : Form
    {
        public OutDailyreport()
        {
            InitializeComponent();
        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.Commodity' table. You can move, or remove it, as needed.

            try
            {
                this.commodityTableAdapter.Fill(this.dLWSDataSet.Commodity);
                comm_NAMEComboBox.Visible = false;
                string cname = lcardToolStripTextBox.Text;

                lcacrd1TableAdapter.FillByCnumber(outdataset.Lcacrd1, cname);


                reportDocument1.Load(Application.StartupPath + @"\reports\DailyOut.rpt");


                reportDocument1.SetDataSource(this.outdataset);

                crystalReportViewer1.ReportSource = reportDocument1;
                reportDocument1.Refresh();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBYLIDToolStripButton_Click(object sender, EventArgs e)
        {

            string cname = lcardToolStripTextBox.Text;
            try
            {
                lcacrd1TableAdapter.FillByCnumber(outdataset.Lcacrd1, cname);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            crystalReportViewer1.ReportSource = reportDocument1;
            reportDocument1.Refresh();


        }

        private void Reporting_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportDocument1.Close();
        }

        private void fillForLadoutToolStripButton_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        this.lcacrd1TableAdapter.FillForLadout(this.outdataset.Lcacrd1, ((int)(System.Convert.ChangeType(lcardToolStripTextBox.Text, typeof(int)))));
            //    }
            //    catch (System.Exception ex)
            //    {
            //        System.Windows.Forms.MessageBox.Show(ex.Message);
            //    }
            loadRpt();

        }

        private void lcardToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadRpt();
            }
        }

        public void loadRpt()
        {

            string cname = lcardToolStripTextBox.Text;
            try
            {

                lcacrd1TableAdapter.FillByCnmOut(outdataset.Lcacrd1, cname);


                crystalReportViewer1.ReportSource = reportDocument1;
                reportDocument1.Refresh();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            this.Width += Convert.ToInt32(this.Width * .1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Width -= Convert.ToInt32(this.Width * .1);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            string cname = lcardToolStripTextBox.Text;
            try
            {
                lcacrd1TableAdapter.FillByCnumber(outdataset.Lcacrd1, "%" + cname + "%");

                //reportDocument1.Load(Application.StartupPath + @"\reports\CrystalReport3.rpt");
                //reportDocument1.SetDataSource(this.outdataset);

                crystalReportViewer1.ReportSource = reportDocument1;
                reportDocument1.Refresh();
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

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string cname = cnameStripTextBox1.Text;
            try
            {
                lcacrd1TableAdapter.FillByCustName(outdataset.Lcacrd1, "%" + cname + "%");

                //reportDocument1.Load(Application.StartupPath + @"\reports\CrystalReport3.rpt");
                //reportDocument1.SetDataSource(this.outdataset);

                crystalReportViewer1.ReportSource = reportDocument1;
                reportDocument1.Refresh();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

            string cname = cnameStripTextBox1.Text;

            string cnum = lcardToolStripTextBox.Text;

            try
            {
                lcacrd1TableAdapter.FillByCustAndCnum(outdataset.Lcacrd1, "%" + cname + "%", "%" + cnum + "%");

                //reportDocument1.Load(Application.StartupPath + @"\reports\CrystalReport3.rpt");
                //reportDocument1.SetDataSource(this.outdataset);

                crystalReportViewer1.ReportSource = reportDocument1;
                reportDocument1.Refresh();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void showByDateBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showBydate();
        }
        private void showBydate()
        {

            string cname = cnameStripTextBox1.Text;

            string cnum = lcardToolStripTextBox.Text;

            try
            {
                DateTime sdate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString() + " 08:00:00");
                DateTime edate = Convert.ToDateTime(dateTimePicker1.Value.AddDays(1).ToShortDateString() + " 08:00:00");
                if (tocheckBox1.CheckState == CheckState.Checked)
                {
                    //dateTimePicker1.Format = DateTimePickerFormat.Long;

                    //sdate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString() + " 08:00:00");
                    edate = Convert.ToDateTime(todateTimePicker2.Value);

                }
                if (CommcheckBox1.CheckState == CheckState.Checked)
                {

                    this.lcacrd1TableAdapter.FillBydatcom(this.outdataset.Lcacrd1, "%" + cname + "%", "%" + cnum + "%", sdate + "", edate + "", comm_NAMEComboBox.Text, "تم");


                }
                else
                {

                    this.lcacrd1TableAdapter.FillByCNandDate(this.outdataset.Lcacrd1, "%" + cname + "%", "%" + cnum + "%", sdate + "", edate + "", "تم");
                }
                TextObject textObject = (TextObject)reportDocument1.ReportDefinition.ReportObjects["rdate"];
                textObject.Text = dateTimePicker1.Text;
                if (tocheckBox1.CheckState == CheckState.Checked && dateTimePicker1.Value!=todateTimePicker2.Value)
                {
                    textObject.Text = todateTimePicker2.Text+" - "+ dateTimePicker1.Text;
                }
                crystalReportViewer1.ReportSource = reportDocument1;
                reportDocument1.Refresh();
                // MessageBox.Show("bydate");
                //   summarygrid();
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CommcheckBox1.CheckState == CheckState.Checked)
            {
                comm_NAMEComboBox.Visible = true;
            }
            else
            {
                comm_NAMEComboBox.Visible = false;
            }
        }

        private void checkBoxcontr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxcontr.CheckState == CheckState.Checked)
            {
                reportDocument1.Load(Application.StartupPath + @"\reports\Contracts.rpt");

                reportDocument1.SetDataSource(this.outdataset);

                crystalReportViewer1.ReportSource = reportDocument1;
                reportDocument1.Refresh();
            }
            else
            {
                reportDocument1.Load(Application.StartupPath + @"\reports\DailyOut.rpt");
            }
        }
    }
}
