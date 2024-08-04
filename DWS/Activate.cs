using Microsoft.Win32;
using System;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class Activation : Form
    {
        public Activation()
        {
            InitializeComponent();
        }
        string serialNumber = string.Empty;

        [DllImport("wininet.dll")]


        private extern static bool InternetGetConnectedState(out int conn, int val);
        private void Activate_Load(object sender, EventArgs e)
        {


            ManagementObjectSearcher MOS = new ManagementObjectSearcher(" Select * From Win32_BIOS ");
            foreach (ManagementObject getserial in MOS.Get())
            {
                serialNumber = getserial["SerialNumber"].ToString().Trim();

            }
        }

        public bool RegistryKey()
        {
            bool validL = false;

            ManagementObjectSearcher MOS = new ManagementObjectSearcher(" Select * From Win32_BIOS ");
            foreach (ManagementObject getserial in MOS.Get())
            {
                serialNumber = getserial["SerialNumber"].ToString().Trim();

            }
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\LoBridge");
            //if it does exist, retrieve the stored values  
            if (key != null)
            {
                string lic = Decrypt(key.GetValue("key").ToString(), serialNumber);
                if (lic.Substring(0, 1).Equals("-") && lic.Substring(lic.Length - 1, 1).Equals("-"))
                {
                    try
                    {
                        lic = lic.Substring(1, lic.Length - 2);

                        string format = "dd/MM/yyyy";
                        DateTime dateTime;
                        if (DateTime.TryParseExact(lic, format, new CultureInfo("en-US"),
                                   DateTimeStyles.None, out dateTime))
                        {
                            //DateTime dt = Convert.ToDateTime(lic);
                            double daysleft = (Convert.ToDateTime(dateTime) - DateTime.Now).TotalDays;
                            if (daysleft >= 1)
                            {
                                Properties.Settings.Default.enddate = dateTime;
                                Properties.Settings.Default.license = 1;
                                Properties.Settings.Default.Save();
                                sendmail("Activated regkey", "h");

                                MessageBox.Show("Valid liscense found, Expires on : " + dateTime);
                                this.Close();
                                Application.Restart();

                            }
                            else
                            {
                                validL = false;

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        validL = false;
                    }

                }
                key.Close();
            }
            return validL;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;

            if (Codetextbox.Text.Length > 0)
            {
                string lic = Decrypt(Codetextbox.Text.Trim(), serialNumber);
                if (lic.Substring(0, 1).Equals("-") && lic.Substring(lic.Length - 1, 1).Equals("-"))
                {
                    try
                    {
                        lic = lic.Substring(1, lic.Length - 2);

                        string format = "dd/MM/yyyy";
                        DateTime dateTime;
                        if (DateTime.TryParseExact(lic, format, new CultureInfo("en-US"),
                                   DateTimeStyles.None, out dateTime))
                        {
                            //DateTime dt = Convert.ToDateTime(lic);
                            double daysleft = (Convert.ToDateTime(dateTime) - DateTime.Now).TotalDays;
                            if (daysleft >= 1)
                            {
                                Properties.Settings.Default.enddate = dateTime;
                                Properties.Settings.Default.license = 1;
                                Properties.Settings.Default.Save();
                                sendmail("Activated", "h");
                                //opening the subkey  
                                RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\LoBridge");
                                key.SetValue("Key", Codetextbox.Text);
                                key.Close();


                                MessageBox.Show("Valid liscense, Expire on : " + dateTime);
                                Application.Restart();
                            }
                            else
                            {
                                MessageBox.Show("Expired liscense ");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid License Format, call administrator");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid License Format, call administrator");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid License, call administrator");
                    sendmail("invalid liscense", "");
                }

            }

            Cursor.Current = Cursors.Default;

        }
        public string encrypt(string encryptString, string ekey)
        {
            string EncryptionKey = ekey; // "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());

                }
            }
            return encryptString;
        }

        public string Decrypt(string cipherText, string ekey)
        {
            try
            {
                //cipherText = cipherText.Substring(1, cipherText.Length - 1);

                string EncryptionKey = ekey;// "dareen";// "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                cipherText = cipherText.Replace(" ", "+");
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return cipherText;
        }
        private void sendmail(string msgs, string hid)
        {

            try
            {
                int Out;

                if (InternetGetConnectedState(out Out, 0) == true)
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    double days = (Convert.ToDateTime(Properties.Settings.Default.enddate) - DateTime.Now).TotalDays;

                    string strComputerName = Environment.MachineName.ToString();

                    mail.From = new MailAddress("h.ragab611@gmail.com");
                    mail.To.Add("h.ragab611@gmail.com");
                    mail.Subject = "Lobridge system ";
                    mail.Body = @"SN\" + serialNumber + "  \n" + Convert.ToInt32(days) + " days remaining  \n" + strComputerName + "  " + Environment.UserName + "\n" + msgs;
                    SmtpServer.Port = 465;

                    SmtpServer.Credentials = new System.Net.NetworkCredential("h.ragab611@gmail.com", "katqbzpbqrtqlrhv");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Timeout = 5000;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Send(mail);
                    Properties.Settings.Default.mail = 1;
                    Properties.Settings.Default.Save();
                    if (hid != "h")
                    {
                        MessageBox.Show("Request Sent, Please contact admin.");
                    }
                }
                else
                {
                    MessageBox.Show("Must connect to internet first !");
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;

            sendmail(Codetextbox.Text, "");
            //Codetextbox.Text= encrypt(textBox1.Text, textBox2.Text);

            Cursor.Current = Cursors.Default;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Codetextbox.Text = encrypt(date.Text, keys.Text);
        }

        private void keys_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Codetextbox.Text = encrypt( date.Text, keys.Text);

        }
    }
}
