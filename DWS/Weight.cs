using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWS
{
    public partial class Weight : Form
    {
        string username="";
        public Weight(string uname)
        {
            username = uname;
            InitializeComponent();
        }

        
        
        private void Weight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wdbDataSet.first_Weight' table. You can move, or remove it, as needed.
           // this.first_WeightTableAdapter.Fill(this.wdbDataSet.first_Weight);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form sw = new SecondWeight();
            sw.FormBorderStyle = FormBorderStyle.None;
            sw.TopLevel = false;
            sw.StartPosition = FormStartPosition.CenterParent;
            sw.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(sw);
            sw.Show();
        }

        private void btnInWeight_Click(object sender, EventArgs e)
        {
            LoadingWCard wCard = new LoadingWCard(username,"in");
            this.Hide();
            wCard.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form inbord = new InboardCard();
            this.Hide();
            inbord.ShowDialog();
            this.Show();
        }

        private void btnGWeight_Click(object sender, EventArgs e)
        {

        }
    }
}
