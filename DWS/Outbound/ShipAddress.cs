using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class ShipAddress : Form
    {
        int CardID = 0;
        public ShipAddress(int card)
        {
            CardID = card;
            InitializeComponent();
        }

        private void SaveAddressBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("!ادخل العنوان");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("!برجاء اختيار المحافظة");
            }
            else
            {
                try
                {
                    // TODO: This line of code loads data into the 'outdataset.Lading_Out' table. You can move, or remove it, as needed.
                    // this.lading_OutTableAdapter.UpdateShipAddress(textBox1.Text.Trim().ToString(), CardID, CardID);
                    DataQuery dq = new DataQuery();
                    string upquery = "Update [lading_Out] set ShipAddress=N'" + textBox1.Text.Trim() + "', Ship_City=N'" + comboBox1.Text + "' where ladingid=" + CardID;
                    if (!dq.RunNonQuery(upquery))
                    {
                        MessageBox.Show("حدث خطأ برجاء المحاولة مرة اخري");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ShipAddress_Load(object sender, EventArgs e)
        {
        }
    }
}
