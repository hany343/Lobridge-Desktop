using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class INSHiftViewer : Form
    {
        public INSHiftViewer()
        {
            InitializeComponent();
        }

        private void INSHiftViewer_Load(object sender, EventArgs e)
        {
            DateTime sdate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString() + " 08:00:00");
            DateTime edate = Convert.ToDateTime(dateTimePicker1.Value.AddDays(1).ToShortDateString() + " 08:00:00");
            try
            {
                this.wCard1TableAdapter.FillShift(iNdataset.WCard1, sdate, edate);
                reportDocument1.Load(Application.StartupPath + @"\reports\INShiftrpt.rpt");
                reportDocument1.SetDataSource(this.iNdataset);

                //MessageBox.Show(this.iNdataset.WCard1.Rows.Count + "");
                //reportDocument1.SetParameterValue("@RptDate", dateTimePicker1.Text);
                reportDocument1.DataDefinition.FormulaFields["RptDate"].Text = "'Hello world'";
                //DetailedCustomerOrderReport aReport = new DetailedCustomerOrderReport(); // your crystalReport
                ParameterFields paramFields = new ParameterFields();

                ParameterField pfItemYr = new ParameterField();

                pfItemYr.ParameterFieldName = "RptDate"; //Employee ID is Crystal Report Parameter name.

                ParameterDiscreteValue dcItemYr = new ParameterDiscreteValue();

                dcItemYr.Value = dateTimePicker1.Text;

                pfItemYr.CurrentValues.Add(dcItemYr);

                paramFields.Add(pfItemYr);

                reportDocument1.ParameterFields.Add(paramFields);// = paramFields;
                reportDocument1.Refresh();

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message+" here1");
            }

        }
        public void load()
        {

            DateTime sdate = Convert.ToDateTime(System.DateTime.Now.AddDays(-1).ToShortDateString() + " 08:00:00");
            DateTime edate = Convert.ToDateTime(System.DateTime.Now.ToShortDateString() + " 08:00:00");

            this.wCard1TableAdapter.FillShift(iNdataset.WCard1, sdate, edate);

            reportDocument1.Load(Application.StartupPath + @"\reports\INShiftrpt.rpt");
            TextObject textObject2 = (TextObject)reportDocument1.ReportDefinition.Sections["Section1"].ReportObjects["rdate"];
            textObject2.Text = "hany";
            reportDocument1.SetDataSource(this.iNdataset);
            //MessageBox.Show(this.iNdataset.WCard1.Rows.Count + "");
            //MessageBox.Show(this.iNdataset.WCard1.Rows.Count + "");
            //reportDocument1.SetParameterValue("@RptDate", dateTimePicker1.Text);
            TextObject textObject = (TextObject)reportDocument1.ReportDefinition.Sections["Section1"].ReportObjects["rdate"];
            textObject.Text = "hany";
            reportDocument1.Refresh();


        }
        private void fillBYLIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //   this.wCard1TableAdapter.FillBYLID(this.iNdataset.WCard1, ((int)(System.Convert.ChangeType(lidToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBYLIDToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //   this.wCard1TableAdapter.FillBYLID(this.iNdataset.WCard1, ((int)(System.Convert.ChangeType(lidToolStripTextBox.Text, typeof(int)))));
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

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime sdate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString() + " 08:00:00");

                DateTime edate = Convert.ToDateTime(dateTimePicker1.Value.AddDays(1).ToShortDateString() + " 08:00:00");
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    edate = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString() + " 08:00:00");
                }

                this.wCard1TableAdapter.FillShift(iNdataset.WCard1, sdate, edate);

                reportDocument1.Load(Application.StartupPath + @"\reports\INShiftrpt.rpt");
                reportDocument1.SetDataSource(this.iNdataset);
                TextObject textObject = (TextObject)reportDocument1.ReportDefinition.ReportObjects["rdate"];
                textObject.Text = dateTimePicker1.Text;
                //MessageBox.Show(this.iNdataset.WCard1.Rows.Count + "");
                crystalReportViewer2.ReportSource = reportDocument1;
                reportDocument1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void INSHiftViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            // reportDocument1.SetDataSource(Null);

            reportDocument1.Close();
        }
    }
}
