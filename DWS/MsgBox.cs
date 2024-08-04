using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {

        }
    }
}
