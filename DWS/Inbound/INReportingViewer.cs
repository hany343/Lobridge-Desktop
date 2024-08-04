using CrystalDecisions.Shared;
using System;
using System.Net.Mail;
using System.Windows.Forms;
using MailMessage = System.Net.Mail.MailMessage;
//using System.Net.Mail;

namespace LoBridge
{
    public partial class INReportingViewer : Form
    {
        public INReportingViewer()
        {
            InitializeComponent();
        }

        private void INReportingViewer_Load(object sender, EventArgs e)
        {

        }
        public void loadrpt(string stext)
        {
            try
            {
                // TODO: This line of code loads data into the 'iNdataset.INRpt' table. You can move, or remove it, as needed.
                this.iNRptTableAdapter.FillForRpt(this.iNdataset.INRpt, stext);

                reportDocument1.Load(Application.StartupPath + @"\reports\INShipsDetails.rpt");
                reportDocument1.SetDataSource(this.iNdataset);

                crystalReportViewer1.ReportSource = reportDocument1;
                reportDocument1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string pdfFile = "C:\\LoBridge Inbound Report.pdf";

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                CrDiskFileDestinationOptions.DiskFileName = pdfFile;
                CrExportOptions = reportDocument1.ExportOptions;
                CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                CrExportOptions.FormatOptions = CrFormatTypeOptions;

                reportDocument1.Export();

                sendmail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sendmail()
        {
            try
            {
                if (mailtextBox1.Text.Length > 20)
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("oilex.com.eg");
                    double days = (Convert.ToDateTime(Properties.Settings.Default.enddate) - DateTime.Now).TotalDays;
                    //MessageBox.Show(days+" "+ Properties.Settings.Default.enddate);
                    string strComputerName = Environment.MachineName.ToString();

                    mail.From = new MailAddress("hany.ragab@oilex.com.eg");
                    mail.To.Add(mailtextBox1.Text);
                    mail.Subject = "Lobridge system ";
                    mail.Body = "";// @"SN\" + serialNumber + "  \n" + Convert.ToInt32(days) + " days remaining  \n" + strComputerName + "  " + Environment.UserName;
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("hany.ragab@oilex.com.eg", "D@reen117");
                    SmtpServer.EnableSsl = true;
                    mail.Attachments.Add(new Attachment(pdfFile));
                    SmtpServer.Send(mail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void INReportingViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportDocument1.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (textBox1search.Text.Length > 0)
            {
                loadrpt("%" + textBox1search.Text.Trim() + "%");
            }
        }
    }
}
