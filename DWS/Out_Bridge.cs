using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoBridge_V2
{
    public partial class Out_Bridge : Form
    {
        public Out_Bridge()
        {
            InitializeComponent();
        }


        private void Bridge_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'outDataSet.Lading_Out' table. You can move, or remove it, as needed.
            //this.lading_OutTableAdapter.Fill(this.outDataSet.Lading_Out);

        }

        private void Out_Bridge_Shown(object sender, EventArgs e)
        {
            //    WScreen wScreen = new WScreen();
            //    wScreen.Show();
            //    wScreen.TopLevel = false;
            //    Wpanel.Controls.Add(wScreen);
            //    wScreen.Dock = DockStyle.Fill;
           // Campanel
        }
    }
}
