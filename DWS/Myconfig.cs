using System;
using System.Configuration;
using System.Management;
using System.Net.Mail;
using System.Runtime.InteropServices;

using System.Windows.Forms;

namespace LoBridge
{
    class Myconfig
    {

        Timer tmr = new Timer();

        public void check_license()
        {
            string serialNumber = string.Empty;

            //MessageBox.Show(Application.StartupPath + @"\report\RCardds.rpt");
            ManagementObjectSearcher MOS = new ManagementObjectSearcher(" Select * From Win32_BIOS ");
            foreach (ManagementObject getserial in MOS.Get())
            {
                serialNumber = getserial["SerialNumber"].ToString();
                // MessageBox.Show("Machine Serial : " + serialNumber);

            }
        }

        public void Sql_check()
        {

            tmr.Interval = 500;//ticks every 1 second
            tmr.Start();
            tmr.Tick += new EventHandler(_check);

        }

        private void _check(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


            string connectionString = config.ConnectionStrings.ConnectionStrings["LoBridge.Properties.Settings.wdbConnectionString"].ConnectionString;
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    return;
                // MessageBox.Show("Test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                tmr.Stop();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DBConnect dBConnect = new DBConnect();
                dBConnect.ShowDialog();
                tmr.Start();
            }

            //string connectionString = Properties.Settings.Default.wdbConnectionString;
            //SqlConnection sc = new SqlConnection();
            //try
            //{
            //sc.Open();
            //sc.Close();
            //    MessageBox.Show("Your ok.");
            //}
            //catch (Exception ex)
            //{
            //    tmr.Stop();
            //    DBConnect dBConnect = new DBConnect();
            //    dBConnect.ShowDialog();
            //    tmr.Start();
            //}
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);
        public void send_email()
        {
            try
            {

                int Out;

                if (InternetGetConnectedState(out Out, 0) == true)
                {
                    //    MessageBox.Show("Connected !");
                }
                else
                {
                    MessageBox.Show("Not Connected !");
                }

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("oilex.com.eg");

                mail.From = new MailAddress("hany.ragab@oilex.com.eg");
                mail.To.Add("hany.ragab@oilex.com.eg");
                mail.Subject = "Logistics Test Mail";
                mail.Body = "بريد اليكتروني اختبار نظام اللوجيستيك و الموازين";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("hany.ragab@oilex.com.eg", "D@reen117");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void crypt_settings()
        {

            try
            {
                //    Open the configuration file and retrieve
                //     the connectionStrings section.
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.StartupPath + @"\LoBridge.exe");

                ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;

                if (section.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    section.SectionInformation.UnprotectSection();
                }
                else
                {
                    // Encrypt the section.
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }

                // config = ConfigurationManager.OpenExeConfiguration(Application.StartupPath + @"\LoBridge.exe");

                ConfigurationSection section2 = config.GetSection("userSettings/LoBridge.Properties.Settings") as ConfigurationSection;


                if (section2.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    section2.SectionInformation.UnprotectSection();
                }
                else
                {
                    // Encrypt the section.
                    section2.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }


                // Save the current configuration.
                config.Save();
                // config2.Save();

                System.Configuration.Configuration config3 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

                ConfigurationSection section3 = config3.GetSection("userSettings/LoBridge.Properties.Settings") as ConfigurationSection;


                if (section3.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    section3.SectionInformation.UnprotectSection();
                }
                else
                {
                    // Encrypt the section.
                    section3.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }

                config3.Save();

                //if (Properties.Settings.Default.firstrun == "yes")
                //{
                //    MessageBox.Show("نسخة تجريبية لمدة 30 يوم");
                //    Properties.Settings.Default.firstrun = "NO";

                //    Properties.Settings.Default.startdate = System.DateTime.Now;
                //    Properties.Settings.Default.enddate = System.DateTime.Now.AddDays(30);
                //    MessageBox.Show("تنتهي في :" + Properties.Settings.Default.enddate);
                //    if (Properties.Settings.Default.WBridge == "Default1")
                //    {
                //        MessageBox.Show(Properties.Settings.Default.WBridge);
                //        Properties.Settings.Default.WBridge = "w1";

                //        //  MessageBox.Show(Properties.Settings.Default.WBridge + " ch");
                //    }
                //    else
                //    {
                //        // MessageBox.Show(Properties.Settings.Default.WBridge + " else");
                //    }
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();


                //}
                //else if (Properties.Settings.Default.firstrun == "NO")
                //{
                //    if (Properties.Settings.Default.license == "Trial")
                //    {
                //        //     MessageBox.Show("سوف ينتهي التفعيل بعد:" + (Properties.Settings.Default.enddate - Properties.Settings.Default.startdate).TotalDays + " يوم");
                //    }
                //}
            }
            catch (Exception ex)
            {
                //    MessageBox.Show(ex.Message );
            }
        }
    }
}
