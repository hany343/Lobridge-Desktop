using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class InboardCard : Form
    {
        DataTable perm;
        public InboardCard(DataTable pdt)
        {
            perm = pdt;
            InitializeComponent();
        }


        bool edit = false;

        private void timer1_Tick(object sender, EventArgs e)
        {

            // dateTextBox.Text = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }
        LastINCards lc = new LastINCards();

        private void InboardCard_Load(object sender, EventArgs e)
        {

            if (perm.Rows[0]["__ladingin_editBtn"].ToString() == "1")
            {
                editBtn.Enabled = true;
            }


            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.WcardID' table. You can move, or remove it, as needed.
                this.wcardIDTableAdapter.Fill(this.dLWSDataSet.WcardID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lc.TopLevel = false;
            lc.Dock = DockStyle.Fill;

            LastCardpanel.Controls.Add(lc);
            lc.Show();

            timer1.Tick += new EventHandler(timer1_Tick);

            // timer1.Start();
            ladingBindingNavigatorSaveItem.Enabled = false;

        }

        private void ladingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (truck_IDTextBox.Text.Length < 1)
            {
                MessageBox.Show("تأكد من رقم السيارة");
            }
            else if (driver_IDTextBox.Text.Length < 1)
            {
                MessageBox.Show("تأكد من بيانات السائق");
            }
            else if (LadingqtyTextBox.Text.Length < 1)
            {
                MessageBox.Show("ادخل الكمية");
            }
            else
            {
                if (checkReamainQuanty())
                {

                    try
                    {
                        if (editing)
                        {
                            lading_NotesTextBox.Text = "تم التعديل بواسطة " + Properties.Settings.Default.logedUN + "  بتاريخ:" + DateTime.Now;
                            lusernameTextBox.Text = Properties.Settings.Default.logedUN;

                            this.ladingTableAdapter.UpdateLading(int.Parse(batch_IDComboBox.Text), lading_NotesTextBox.Text, loading_StationComboBox.Text, 0,
                                    int.Parse(driver_IDTextBox.Text.ToString()), "صب", "", int.Parse(truck_IDTextBox.Text.ToString()), rnameComboBox.Text
                                    , decimal.Parse(LadingqtyTextBox.Text), b_LadingTextBox.Text,
                                    Convert.ToInt32(ladingIDTextBox.Text), Convert.ToInt32(ladingIDTextBox.Text));
                            linkLabel2.Visible = false;
                            MessageBox.Show("تم الحفظ  ");
                        }
                        else
                        {
                            try
                            {
                                int ident = Convert.ToInt32(this.ladingTableAdapter.InsertQuery(int.Parse(batch_IDComboBox.Text), lading_NotesTextBox.Text, loading_StationComboBox.Text, 0,
                                     int.Parse(driver_IDTextBox.Text.ToString()), 0, "صب", 0, "", int.Parse(truck_IDTextBox.Text.ToString()), rnameComboBox.Text
                                     , decimal.Parse(LadingqtyTextBox.Text), Properties.Settings.Default.logedUN, "اول", b_LadingTextBox.Text).ToString());
                                ladingIDTextBox.Text = ident + "";
                                linkLabel2.Visible = false;
                                MessageBox.Show("تم الحفظ برقم : " + ident);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + "  er011");
                            }
                        }
                        ladingBindingNavigatorSaveItem.Enabled = false;
                        panel1.Enabled = false;
                        bindingNavigatorAddNewItem.Enabled = true;
                        PrintBtn.Enabled = true;

                        lc.reload();

                        editing = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " err");
                    }

                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {

            try
            {
                truck_numberComboBox.DataBindings.Clear();// = null;
                driver_NameComboBox.DataBindings.Clear();

                // TODO: This line of code loads data into the 'dLWSDataSet.Driver' table. You can move, or remove it, as needed.
                this.driversTableAdapter.FillByDid(this.dLWSDataSet.Drivers, -1);
                // TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
                this.truckTableAdapter.FillByTid(this.dLWSDataSet.Truck, -1);

                panel1.Enabled = true;

                chart1.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                ladingBindingNavigatorSaveItem.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = false;

                // TODO: This line of code loads data into the 'dLWSDataSet.BatchTrelease' table. You can move, or remove it, as needed.
                this.batchToLadingTableAdapter.FillbatchtoLading(this.iNdataset.BatchToLading, "مفتوح");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (batch_IDComboBox.Text.Length > 0)
            {
                groupBox2.Enabled = true;

            }
            else
            {
                groupBox2.Enabled = false;
            }

            ladingTableAdapter.FillByLadingid(iNdataset.Lading, -1);
            string last = ladingTableAdapter.GetlastID().ToString();
            int lastid = 1;
            try
            {
                lastid = int.Parse(last) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ladingIDTextBox.Text = lastid + "";

        }

        public Boolean checkReamainQuanty()
        {

            if (LadingqtyTextBox.Text.Length > 0 && BatchqtyTextBox1.Text.Length > 0)
            {
                int Bid = 0;
                if (batch_IDComboBox.SelectedIndex > -1)
                {
                    Bid = int.Parse(batch_IDComboBox.SelectedValue.ToString());

                }

                decimal ladQ = decimal.Parse(LadingqtyTextBox.Text.ToString());
                decimal batchQ = decimal.Parse(BatchqtyTextBox1.Text.ToString());
                decimal sumbatq = decimal.Parse(this.ladingTableAdapter.Getsumqtyforbatch(Bid).ToString());
                if ((sumbatq + ladQ) > batchQ)
                {

                    Batchremain_QtyTextBox.Text = (batchQ - sumbatq) + "";
                    MessageBox.Show("خطأ في الكمية او كمية غير متوفرة");
                    ladingBindingNavigatorSaveItem.Enabled = false;
                    LadingqtyTextBox.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                else
                {

                    ladingBindingNavigatorSaveItem.Enabled = true;
                    LadingqtyTextBox.ForeColor = System.Drawing.Color.Black;

                }

            }
            return true;
        }

        private void qtyTextBox_TextChanged(object sender, EventArgs e)
        {
            checkReamainQuanty();

        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dLWSDataSet.BatchTrelease' table. You can move, or remove it, as needed.
            ////--this.batchTreleaseTableAdapter.Fillbatchtorelease(this.dLWSDataSet.BatchTrelease);

            //// TODO: This line of code loads data into the 'dLWSDataSet.Driver' table. You can move, or remove it, as needed.
            //this.driversTableAdapter.FillByDid(this.dLWSDataSet.Drivers,-1);
            //// TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
            //this.truckTableAdapter.FillByTid(this.dLWSDataSet.Truck,-1);

            //// TODO: This line of code loads data into the 'dLWSDataSet.Lading' table. You can move, or remove it, as needed.
            // this.ladingTableAdapter.FillByLadingid(this.iNdataset.Lading,-1);

            //panel1.Enabled = false;

            //ladingBindingNavigatorSaveItem.Enabled = false;
            //bindingNavigatorAddNewItem.Enabled = true;
            //this.Dispose();
            //this.InitializeComponent();
            // this.InitLayout();
            /// this.Visible = true;

        }

        private void batch_IDComboBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (batch_IDComboBox.SelectedIndex >= 0)
                {

                    INdataset.INBatchDataTable ind = new INdataset.INBatchDataTable();

                    int id = int.Parse(batch_IDComboBox.Text.ToString());
                    // this.iNBatchTableAdapter.FillByBID(ind, id);

                    chart1.Series["Series2"].XValueMember = "Serial";
                    chart1.Series["Series1"].XValueMember = "Serial";
                    //chart1.Series["Series1"].YAxisType

                    chart1.Series["Series1"].YValueMembers = "Qty";
                    chart1.Series["Series2"].YValueMembers = "remain_Qty";
                    chart1.DataSource = ind;
                    chart1.DataBind();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " er2");
            }
            if (batch_IDComboBox.Text.Length > 0)
            {
                groupBox2.Enabled = true;


            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ladingIDTextBox.Text.Length > 0)
            {
                try
                {
                    int rc = int.Parse(ladingIDTextBox.Text.ToString());
                    INPrint_RCard prc = new INPrint_RCard(rc);
                    prc.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " er1");
                }

            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.BatchTrelease' table. You can move, or remove it, as needed.
                this.batchToLadingTableAdapter.FillbatchtoLading(this.iNdataset.BatchToLading, "مفتوح");

                lc.reload();

                // TODO: This line of code loads data into the 'dLWSDataSet.Driver' table. You can move, or remove it, as needed.
                if (groupBox2.Enabled == true)
                {
                    this.driversTableAdapter.Fill(this.dLWSDataSet.Drivers);
                    driver_NameComboBox.SelectedIndex = driver_NameComboBox.Items.Count - 1;

                    // TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
                    this.truckTableAdapter.Fill(this.dLWSDataSet.Truck);
                    truck_numberComboBox.SelectedIndex = truck_numberComboBox.Items.Count - 1;


                    //// TODO: This line of code loads data into the 'dLWSDataSet.Representative' table. You can move, or remove it, as needed.
                    this.representativeTableAdapter.Fill(this.dLWSDataSet.Representative);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void batch_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (batch_IDComboBox.Text.Length > 0)
            {
                groupBox2.Enabled = true;
            }
        }

        private void batch_IDComboBox_Click(object sender, EventArgs e)
        {

            //// batch_IDComboBox.Text=batch_IDComboBox.SelectedItem.ToString();
            try
            {

                if (batch_IDComboBox.SelectedIndex < 0)
                {
                    // TODO: This line of code loads data into the 'dLWSDataSet.BatchTrelease' table. You can move, or remove it, as needed.
                    this.batchToLadingTableAdapter.FillbatchtoLading(this.iNdataset.BatchToLading, "مفتوح");
                }

                if (batch_IDComboBox.SelectedIndex >= 0)
                {

                    INdataset.INBatchDataTable ind = new INdataset.INBatchDataTable();

                    int id = int.Parse(batch_IDComboBox.Text.ToString());
                    // this.iNBatchTableAdapter.FillByBID(ind, id);

                    chart1.Series["Series2"].XValueMember = "Serial";
                    chart1.Series["Series1"].XValueMember = "Serial";
                    //chart1.Series["Series1"].YAxisType

                    chart1.Series["Series1"].YValueMembers = "Qty";
                    chart1.Series["Series2"].YValueMembers = "remain_Qty";
                    chart1.DataSource = ind;
                    chart1.DataBind();
                    if (!editing)
                    {
                        try
                        {

                            int lastc = ladingTableAdapter.GetlastID().Value + 1;
                            ladingIDTextBox.Text = lastc + "";

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " er2");
            }


            if (batch_IDComboBox.Text.Length > 0)
            {
                groupBox2.Enabled = true;
            }

        }


        bool editing = false;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            linkLabel2.Visible = true;

            panel1.Enabled = true;

            groupBox2.Enabled = true;

            ladingBindingNavigatorSaveItem.Enabled = true;

            editing = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ladingIDTextBox.Text.Length > 0)
                {
                    int cardID = int.Parse(ladingIDTextBox.Text);
                    if (Properties.Settings.Default.Urole < 1)
                    {
                        ladingTableAdapter.FillByLadingid(iNdataset.Lading, cardID);
                    }
                    else
                    {
                        ladingTableAdapter.Fillforedit(iNdataset.Lading, cardID);

                    }

                    if (iNdataset.Lading.Rows.Count < 1)
                    {
                        MessageBox.Show("لا يمكن التعديل او غير موجود !");
                        ladingBindingNavigatorSaveItem.Enabled = false;
                    }
                    else
                    {
                        ladingBindingNavigatorSaveItem.Enabled = true;

                        editing = true;
                        try
                        {
                            if (ladingIDTextBox.Text.Length < 1)
                            {
                                ladingBindingNavigatorSaveItem.Enabled = false;
                            }
                            else
                            {
                                //int cardID = int.Parse(ladingIDTextBox.Text);
                                ladingTableAdapter.FillByLadingid(iNdataset.Lading, cardID);
                                ladingBindingNavigatorSaveItem.Enabled = true;
                                truckTableAdapter.FillByTid(dLWSDataSet.Truck, Convert.ToInt32(truck_IDTextBox1.Text));
                                driversTableAdapter.FillByDid(dLWSDataSet.Drivers, Convert.ToInt32(driver_IDTextBox1.Text));
                                batchToLadingTableAdapter.FillByID(iNdataset.BatchToLading, Convert.ToInt32(batch_IDTextBox.Text));
                                checkReamainQuanty();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "er02");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.BatchTrelease' table. You can move, or remove it, as needed.
                this.batchToLadingTableAdapter.FillbatchtoLading(this.iNdataset.BatchToLading, "مفتوح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)

        {
            if (n_CardTextBox.Text.Length > 0)
            {
                try
                {
                    decimal ncard = decimal.Parse(n_CardTextBox.Text.ToString().Trim());
                    driversTableAdapter.FillBy(dLWSDataSet.Drivers, 0, "-1", ncard);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ladingBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }


        private void InboardCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                //    //this.Dispose();
                //    this.truckBindingSource.Clear();
                //    truck_numberComboBox.DataBindings.Clear();// = null;
                //    truck_IDTextBox.DataBindings.Clear();
                //    driver_IDTextBox.DataBindings.Clear();
                //    driver_NameTextBox.DataBindings.Clear();

                //    try
                //    {
                //        truck_numberComboBox.DataBindings.Clear();// = null;
                //        driver_NameTextBox.DataBindings.Clear();
                //    }
                //    catch (Exception ex)
                //    {

                //    }

                //    // TODO: This line of code loads data into the 'dLWSDataSet.Driver' table. You can move, or remove it, as needed.
                //    this.driversTableAdapter.FillByDid(this.dLWSDataSet.Drivers, -1);
                //    // TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
                //    this.truckTableAdapter.FillByTid(this.dLWSDataSet.Truck, -1);
            }
            catch (Exception ex)
            {

            }
        }


        private void truck_numberComboBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    truck_numberComboBox.SelectedIndex = truck_numberComboBox.FindStringExact(truck_numberComboBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // SendKeys.Send("{TAB}");
            }
        }

        private void driver_NameTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    driver_NameComboBox.SelectedIndex = driver_NameComboBox.FindStringExact(driver_NameComboBox.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void n_CardTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (n_CardTextBox.Text.Length > 0)
                {
                    try
                    {
                        decimal ncard = decimal.Parse(n_CardTextBox.Text.ToString().Trim());
                        driversTableAdapter.FillBy(dLWSDataSet.Drivers, 0, "-1", ncard);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void fillTbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                // TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
                this.truckTableAdapter.Fill(this.dLWSDataSet.Truck);
                truck_numberComboBox.SelectedIndex = truck_numberComboBox.Items.Count - 1;
            }
            catch (Exception ex)
            {

            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.driversTableAdapter.Fill(this.dLWSDataSet.Drivers);
                driver_NameComboBox.SelectedIndex = driver_NameComboBox.Items.Count - 1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void truck_IDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    truckTableAdapter.FillByTid(dLWSDataSet.Truck, Convert.ToInt32(truck_IDTextBox.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void truck_numberComboBox_Click(object sender, EventArgs e)
        {
            if (truck_numberComboBox.Items.Count < 1)
            {
                try
                {

                    // TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
                    this.truckTableAdapter.Fill(this.dLWSDataSet.Truck);
                    //   truck_numberComboBox.SelectedIndex = truck_numberComboBox.Items.Count - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void driver_NameTextBox_Click(object sender, EventArgs e)
        {
            if (driver_NameComboBox.Items.Count < 1)
            {

                try
                {
                    this.driversTableAdapter.Fill(this.dLWSDataSet.Drivers);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void refreshTrucks_Click(object sender, EventArgs e)
        {

            try
            {

                // TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
                this.truckTableAdapter.Fill(this.dLWSDataSet.Truck);
                //   truck_numberComboBox.SelectedIndex = truck_numberComboBox.Items.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshDrivers_Click(object sender, EventArgs e)
        {
            try
            {
                this.driversTableAdapter.Fill(this.dLWSDataSet.Drivers);
                //   driver_NameComboBox.SelectedIndex = driver_NameComboBox.Items.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void truck_numberComboBox_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    truck_numberComboBox.SelectedIndex = truck_numberComboBox.FindStringExact(truck_numberComboBox.Text);
                    SendKeys.Send("{TAB}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
