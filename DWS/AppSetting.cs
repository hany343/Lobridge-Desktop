using System.Configuration;
using System.Windows.Forms;
namespace LoBridge
{
    public class AppSetting
    {
        Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

        }

        //Get connection string from App.Config file
        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        //Save connection string to App.config file
        public void SaveConnectionString(string key, string value)
        {
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
                //section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }

            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            //Properties.Settings.Default["wdbConnectionString"] = value;
            config.Save(ConfigurationSaveMode.Modified, true);
            if (section.SectionInformation.IsProtected)
            {
                // Remove encryption.
                //section.SectionInformation.UnprotectSection();
            }
            else
            {
                // Encrypt the section.
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            config.Save();
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }

    }
}