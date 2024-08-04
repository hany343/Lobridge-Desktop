using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class Transport : Form
    {
        DataTable perm;
        public Transport(DataTable permdt)
        {
            perm = permdt;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //dateTextBox.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //textBox1.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Transport_Load(object sender, EventArgs e)
        {

            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Start();

            listt();
            listD();
            listTrans();
            // TODO: This line of code loads data into the 'dLWSDataSet.Representative' table. You can move, or remove it, as needed.
            this.representativeTableAdapter.Fill(this.dLWSDataSet.Representative);



        }

        private void TransCoNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            panelTransCo.Enabled = true;
            Save_TransCo.Enabled = true;
            Add_TransCo.Enabled = false;
            TransCo_Code.Visible = false;
            label1.Visible = false;
        }

        private void transport_CoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                int cnum = int.Parse(transport_CoTableAdapter.FindCompany(company_NameTextBox1.Text) + "");
                if (cnum == 0)
                {
                    try
                    {
                        this.Validate();
                        this.transport_CoBindingSource.EndEdit();
                        this.transport_CoTableAdapter.Update(this.dLWSDataSet);

                        panelTransCo.Enabled = false;
                        Save_TransCo.Enabled = false;
                        Add_TransCo.Enabled = true;
                        TransCo_Code.Visible = true;
                        label1.Visible = true;
                        add_Driver.Enabled = true;
                        //TODO: This line of code loads data into the 'dLWSDataSet.Transport_Co' table.You can move, or remove it, as needed.
                        this.transport_CoTableAdapter.Fill(this.dLWSDataSet.Transport_Co);
                        this.transport_CoBindingSource.MoveLast();

                        transList.loadt();


                        MessageBox.Show("تم الحفظ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("موجود مسبقا");
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
            listTrans();
        }

        /// <summary>
        /// ////////////////////////////////  Driver Functions   /////////////////
        /// </summary>
        /// 

        private void Add_Driver_Click(object sender, EventArgs e)
        {
            drivergroupBox1.Enabled = true;
            Save_driver.Enabled = true;
            add_Driver.Enabled = false;

        }

        private void Save_Driver_Click(object sender, EventArgs e)
        {
            if (checkexist())
            {
                try
                {
                    dusernameTextBox.Text = Properties.Settings.Default.logedUN;
                    this.Validate();
                    this.driversBindingSource.EndEdit();
                    this.driversTableAdapter.Update(this.dLWSDataSet);

                    add_Driver.Enabled = true;
                    Save_driver.Enabled = false;
                    drivergroupBox1.Enabled = false;
                    //MessageBox.Show("Driver Save Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("السائق موجود سابقا");
            }
        }



        /// <summary>
        /// ////////////////////////////////  Truck Functions   /////////////////
        /// </summary>
        /// 

        private void Add_Truck_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            Save_Truck.Enabled = true;
            Add_Truck.Enabled = false;

            //// TODO: This line of code loads data into the 'dLWSDataSet.Transport_Co' table. You can move, or remove it, as needed.
            //this.transport_CoTableAdapter.Fill(this.dLWSDataSet.Transport_Co);
            //// TODO: This line of code loads data into the 'dLWSDataSet.Driver' table. You can move, or remove it, as needed.
            ////this.driverTableAdapter.Fill(this.dLWSDataSet.Driver);
            //ownerTextBox.Text = company_NameComboBox.Text;
        }

        private void Save_Truck_Click(object sender, EventArgs e)
        {
            try
            {
                int tn = int.Parse(truckTableAdapter.SearchTruck(truck_numberTextBox.Text, trailer_numberTextBox.Text) + "");
                if (tn == 0)
                {
                    try
                    {
                        tRusernameTextBox.Text = Properties.Settings.Default.logedUN;
                        this.Validate();
                        this.truckBindingSource.EndEdit();
                        this.truckTableAdapter.Update(this.dLWSDataSet);

                        groupBox2.Enabled = false;
                        Save_Truck.Enabled = false;
                        Add_Truck.Enabled = true;


                        //MessageBox.Show("Truck Save Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("السيارة معرفة من قبل");
                }

            }
            catch (Exception exx)
            {

                MessageBox.Show(exx.Message);
            }

        }


        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            //    if (checkBox1.Checked == true)
            //    {
            //        groupBox1.Visible = false;
            //        transCO_IDTextBox.Text = "NULL";
            //    }
            //    else
            //    {
            //        groupBox1.Visible = true;
            //        transCO_IDTextBox.Text = company_IDComboBox.Text;
            //        ownerTextBox.Text = company_NameComboBox.Text;
            //    }
        }

        private void panelTransCo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void representativeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                this.Validate();
                this.representativeBindingSource.EndEdit();
                this.representativeTableAdapter.Update(this.dLWSDataSet.Representative);

                // MessageBox.Show("Truck Save Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void driver_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            checkexist();
        }
        private bool checkexist()
        {

            int findd = 0;
            try
            {

                findd = int.Parse(driversTableAdapter.FindDriver(driver_NameTextBox.Text, n_CardTextBox.Text) + "");


                if (findd > 0)
                {

                    Save_driver.Enabled = false;
                    return false;
                }
                else
                {
                    Save_driver.Enabled = true;
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            trailer_trafficTextBox.Text = truck_trafficTextBox.Text;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            liscense_numTextBox.Text = n_CardTextBox.Text;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            listt();
        }

        private void listt()
        {
            ListTrucks listTrucks = new ListTrucks();

            listTrucks.TopLevel = false;
            listTrucks.Dock = DockStyle.Fill;
            listTpanel2.Controls.Add(listTrucks);
            listTrucks.Show();
        }
        private void TransNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void listD()
        {
            ListDrivers listDrivers = new ListDrivers();

            listDrivers.TopLevel = false;
            listDrivers.Dock = DockStyle.Fill;
            listDriverspanel2.Controls.Add(listDrivers);
            listDrivers.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        TransList transList;//= new TransList();
        private void listTrans()
        {
            transList = new TransList(perm);
            transList.TopLevel = false;
            //transList.FormBorderStyle = none;// BorderStyle.None;
            transList.Dock = DockStyle.Fill;
            panel2.Controls.Add(transList);
            transList.Show();
        }

    }
}

