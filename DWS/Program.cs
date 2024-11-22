using System;
using System.Configuration;
using System.Diagnostics;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace LoBridge
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // [STAThread]
        [STAThreadAttribute]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                //Open the configuration file and retrieve
                // the connectionStrings section.
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.StartupPath + @"\LoBridge.exe");


                ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;

                if (section.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    //  section.SectionInformation.UnprotectSection();
                }
                else
                {
                    // Encrypt the section.
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }

                ConfigurationSection section2 = config.GetSection("userSettings/LoBridge.Properties.Settings") as ConfigurationSection;

                if (section2.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    // section2.SectionInformation.UnprotectSection();
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
                    // section3.SectionInformation.UnprotectSection();
                }
                else
                {
                    // Encrypt the section.
                    section3.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }

                config3.Save();

            }
            catch (Exception ex)
            {
                //    MessageBox.Show(ex.Message );
            }

            Application.Run(new Login());

            //if (Properties.Settings.Default.license == 0)
            //{
            //    activating();
            //}
            //else
            //{

            //    Thread mt = new Thread(loginthread);
            //    mt.SetApartmentState(ApartmentState.STA);

            //    mt.Start();
            //}

        }
        static void loginthread()
        {
            double days = (Convert.ToDateTime(Properties.Settings.Default.enddate) - DateTime.Now).TotalDays;
            //MessageBox.Show(days+" "+ Properties.Settings.Default.enddate);
            if (Properties.Settings.Default.enddate < DateTime.Now)
            {
                Properties.Settings.Default.license = 0;
                activating();
            }
            else
            {
                if (days < 30)
                {
                    MessageBox.Show("License will expire soon, Days remaining " + days + ", Pleas Activate System!");
                }
                Application.Run(new Login());
                // Application.Run(new Home("admin", "1"));
                // Application.Run(new INWCard());
                //Application.Run(new QueryTest());
            }
        }
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }


        private static void activating()
        {

            if (!Program.IsAdministrator())
            {
                // Restart and run as admin
                var exeName = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                startInfo.Verb = "runas";
                startInfo.Arguments = "restart";
                Process.Start(startInfo);
                Application.Exit();
                return;
            }


            if (Properties.Settings.Default.firstrun == "yes")
            {
                Properties.Settings.Default.WBridge = "BridgeName";

                Properties.Settings.Default.startdate = System.DateTime.Now;

                Properties.Settings.Default.Save();

            }
            Activation activator = new Activation();
            if (!activator.RegistryKey())
            {
                activator.ShowDialog();
            }
        }

        //static bool IsApplicationAlreadyRunning()
        //{
        //    string proc = Process.GetCurrentProcess().ProcessName;
        //    Process[] processes = Process.GetProcessesByName(proc);
        //    if (processes.Length > 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
