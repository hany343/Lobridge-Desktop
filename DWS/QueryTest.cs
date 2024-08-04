using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class QueryTest : Form
    {
        public QueryTest()
        {
            InitializeComponent();
        }
        DataQuery dq = new DataQuery();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = dq.GetDataTable(textBox1.Text);
            MessageBox.Show(dt.Columns.Count + "");

            for (int c = 0; c < dt.Columns.Count; c++)
            {
                dataGridView1.Columns.Add(dt.Columns[c].ColumnName, dt.Columns[c].ColumnName);
                dataGridView1.Columns[c].DataPropertyName = dt.Columns[c].ColumnName;

            }
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string v = dq.GetStringValu(textBox1.Text);
            textBox2.Text = v;
        }
    }
}
