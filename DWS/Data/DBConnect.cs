using System;
using System.Configuration;
using System.Windows.Forms;


namespace LoBridge
{
    public partial class DBConnect : Form
    {
        public DBConnect()
        {
            InitializeComponent();
        }
        bool saved = false;
        private void DBConnect_Load(object sender, EventArgs e)
        {
        }

        string connectionString = "";
        private void btnConnect_Click(object sender, EventArgs e)
        {
            saved = false;
       
                connectionString = string.Format("Data Source={0};Initial Catalog={1};Connect Timeout=10;MultipleActiveResultSets=True;Persist Security Info=True;User ID=sa;Password=dareen", cboServer.Text, txtDatabase.Text);
                
            
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //Set connection string
            bool devmode= Properties.Settings.Default.devmode;
            //string connectionString = "";// string.Format("Data Source={0};Initial Catalog={1};Connect Timeout=5;Persist Security Info=True;User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DLWSP\DLWSP.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    
                    AppSetting setting = new AppSetting();
                    if(devmode)
                    {
                        setting.SaveConnectionString("LoBridge.Properties.Settings.DevString", connectionString);

                        Properties.Settings.Default.devmode = true;
                    }
                    else
                    {
                        setting.SaveConnectionString("LoBridge.Properties.Settings.wdbConnectionString", connectionString);
                        Properties.Settings.Default.devmode = false;
                    }
                    Properties.Settings.Default.server =  cboServer.Text.Trim();
                    Properties.Settings.Default.databse = txtDatabase.Text.Trim();
                    Properties.Settings.Default.Save();

                    MessageBox.Show("Your connection string has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saved = true;
                    
                    ConfigurationManager.RefreshSection("connectionStrings");
                    this.Visible = false;
                    this.Close();
                    Application.Restart();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "dbconnect error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
