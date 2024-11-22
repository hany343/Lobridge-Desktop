using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class SysSettingsForm : Form
    {
        public SysSettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.WBridge = bridgetextBox1.Text.ToString();
                //Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Bridge name er1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.serialcom = comtextBox2.Text.Trim();
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                Properties.Settings.Default.inwcam = areacodetextBox1.Text.ToString();
                if (Convert.ToInt32(areacodetextBox1.Text.ToString()) > 0)
                {
                    //Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("رقم غير صحيح , يجب ان يكون الرقم اكبر من 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "er1");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(areacodetextBox1.Text.ToString()) > 0)
                {
                    Properties.Settings.Default.inwcam = areacodetextBox1.Text.ToString();
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("رقم غير صحيح , يجب ان يكون الرقم اكبر من 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "er1");
            }
        }
    }
}
