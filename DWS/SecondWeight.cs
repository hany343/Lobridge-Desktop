using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace DWS
{
    public partial class SecondWeight : Form
    {
        public int wcidnumber = 1;
        public SecondWeight()
        {
            InitializeComponent();
        }

        
        private void SecondWeight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wdbDataSet.GWCard' table. You can move, or remove it, as needed.
            this.gWCardTableAdapter.Fillsw(this.wdbDataSet.GWCard);

            //DGVPrinter printer = new DGVPrinter();
            //printer.SubTitle = "print test";
            //printer.PageNumbers = true;
            //printer.PrintDataGridView(this.first_WeightDataGridView);

        }


        private void first_WeightDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                wdbDataSet.GWCardDataTable dataTable = new wdbDataSet.GWCardDataTable();
                try
                {
                    this.gWCardTableAdapter.FillBy(dataTable, e.RowIndex + 1);
                    wcidnumber = int.Parse(this.first_WeightDataGridView[0, e.RowIndex].Value.ToString());

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
        }

        private void first_WeightDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
