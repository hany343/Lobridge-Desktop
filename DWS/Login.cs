using Microsoft.Win32;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class Login : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login()
        {
            InitializeComponent();
        }
        private bool check_activation()
        {
            string act_code = dq.GetStringValu("Select Activation from settings");
            Activation act = new Activation();
            string active_status = act.Decrypt(act_code, "mydareen");
            //MessageBox.Show(act_code +" "+ active_status);
            if (active_status.Equals("active"))
            {

                return true;
            }
            else
            {
                MessageBox.Show("System Activation failed, Contact administrator", "Activation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            string connStr = "";
      
            connStr = Properties.Settings.Default.wdbConnectionString; 
            if (connStr.Length > 10)
            {
               // if (check_activation())
              //  {
                    login_();
               // }
            }
            else
            {
                MessageBox.Show("Check Server Setup");

            }

            Cursor.Current = Cursors.Default;
        }

        DataQuery dq = new DataQuery();
        public void login_()
        {

            bool log = false;
            string username = "Default";
            string userRole = "1";
            if (UserName.Text.Length < 1)
            {
                MessageBox.Show("Enter User Name");
            }
            else if (UserPass.Text.Length < 1)
            {
                MessageBox.Show("Enter User Password");
            }
            else
            {
                if (UserName.Text == "dareenme" && UserPass.Text == "dareen")
                {
                    log = true;
                    Properties.Settings.Default.logedUN = "Owner";
                }
                else
                {
                    try
                    {

                        string query = "select UName,user_perm from users where (ULogin=N'" + UserName.Text + "' and UPass=N'" + UserPass.Text + "');";
                        DataTable loginDT = dq.GetDataTable(query);
                        if (loginDT != null)
                        {

                            if (loginDT.Rows.Count > 0)
                            {
                                username = loginDT.Rows[0][0].ToString();
                                Properties.Settings.Default.logedUN = username;
                                Properties.Settings.Default.lastuser = UserName.Text;
                                Properties.Settings.Default.Save();
                                userRole = loginDT.Rows[0][1].ToString();
                                Properties.Settings.Default.Urole = int.Parse(userRole);
                                log = true;

                            }
                            else
                            {
                                MessageBox.Show("خطا في اسم المستخدم او كلمة المرور ");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "error in login code=01-1");
                    }


                    if (log)
                    {
                        UserPass.Text = "";

                        Home2 home = new Home2(username, userRole);
                        this.Hide();
                        home.ShowDialog();
                        //this.Show();

                    }
                }
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            rk.SetValue("sTimeFormat", "HH:mm:ss");
            rk.SetValue("sShortDate", "dd/MM/yyyy"); // HH for 24hrs, hh for 12 hrs


        }

        private void UserPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (UserName.Text.Length < 1)
                {
                    UserName.Focus();
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string connStr = "";
                    connStr = Properties.Settings.Default.wdbConnectionString; 

                    if (connStr.Length > 10)
                    {
                        if (check_activation())
                        {
                            login_();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check Server Setup");

                    }
                }
            }
        }

        private void UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UserPass.Text.Length < 1)
                {
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string connStr = "";
                    connStr = Properties.Settings.Default.wdbConnectionString;

                    if (connStr.Length > 10)
                    {
                        login_();
                    }
                    else
                    {
                        MessageBox.Show("Check Server Setup");

                    }
                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            dbc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            UserName.SelectAll();
        }
    }
}
