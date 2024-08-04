using System;
using System.Data;
using System.Data.SqlClient;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class Trucks : Form
    {
        public Trucks()
        {
            InitializeComponent();
        }

        int rowscount = 0;
        // int pagcount = 0;

        int pagePos = 1;
        private void Trucks_Load(object sender, EventArgs e)
        {

            Load_page();
        }

        private void Load_page()
        {

            try
            {
                // TODO: This line of code loads data into the 'generalDataSet.Truck' table. You can move, or remove it, as needed.
                rowscount = Convert.ToInt32(this.truckTableAdapter.countRows()) + 39;
                pagesCount = (rowscount / 40);

                pagecountLabel3.Text = pagesCount + "";
                pagposTextBox1.Text = pagePos + "";

                SqlConnection sql_connection;
                sql_connection = new SqlConnection(Properties.Settings.Default.wdbConnectionString);

                SqlCommand sqlComm = new SqlCommand("getTruckPage", sql_connection);
                sqlComm.Parameters.AddWithValue("@PageIndex", pagePos);
                sqlComm.Parameters.AddWithValue("@PageSize", 40);
                sqlComm.Parameters.AddWithValue("@RecordCount", rowscount);

                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                this.generalDataSet.Truck.Clear();
                da.Fill(this.generalDataSet.Truck);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " حدثت مشكلة في تحميل البيانات 2 ", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log error()
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();
            //Load_page(0);
        }
        private void orderDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

            e.Row.Cells["TRusernameColumn"].Value = Properties.Settings.Default.logedUN;
            //e.Row.Cells["StatusColumn"].Value = "مفتوح";
            e.Row.Cells["create_dateColumn"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                find_truck(searchTextBox1.Text.Trim());
            }
        }
        private void find_truck(string trucknum)
        {
            try
            {
                // TODO: This line of code loads data into the 'generalDataSet.Truck' table. You can move, or remove it, as needed.
                this.truckTableAdapter.FillBytnum(this.generalDataSet.Truck, "%" + trucknum + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " حدثت مشكلة في تحميل البيانات 2 ", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log error()
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();

        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            find_truck(searchTextBox1.Text.Trim());
        }
        int pagesCount = 0;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Load_page();
        }

        private void add_Button3_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'generalDataSet.Truck' table. You can move, or remove it, as needed.
                this.truckTableAdapter.FillBytnum(this.generalDataSet.Truck, "--.-");
                trucksDataGridView.AllowUserToAddRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " حدثت مشكلة في تحميل البيانات 2 ", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log error()
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.Validate();
                this.truckBindingSource.EndEdit();
                this.truckTableAdapter.Update(this.generalDataSet);
                trucksDataGridView.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " حدثت مشكلة في حفظ البيانات 2 ", "مشكلة في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //log error()
            }
            Cursor.Current = Cursors.Default;
            this.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (pagePos < pagesCount)
            {
                pagePos += 1;
                Load_page();
            }
        }

        private void prepageButton2_Click(object sender, EventArgs e)
        {
            if (pagePos > 1)
            {
                pagePos--;
                Load_page();
            }
        }

        private void Trucks_Load_1(object sender, EventArgs e)
        {

        }
    }
}
