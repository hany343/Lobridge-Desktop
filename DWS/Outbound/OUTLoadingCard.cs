using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OUTLoadingCard : Form
    {
        //string usrnme = "";
        bool edit = false;
        DataTable perm;
        public OUTLoadingCard(DataTable dataTable)
        {
            perm = dataTable;
            // usrnme = usrname;
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            // dateTextBox.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void LoadingCard_Load(object sender, EventArgs e)
        {

            if (perm.Rows[0]["__ladingout_editBtn"].ToString() != "1")
            {
                editBtn.Enabled = false;
            }
            // timer1.Tick += new EventHandler(timer1_Tick);

            // timer1.Start();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        bool editing = false;
        bool savecase = false;

        private void lading_OutBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            // Execute your time-intensive hashing code here...
            if (transType.SelectedIndex < 0)
            {
                MessageBox.Show("ادخل نوع الشحن");
            }
            else if (fill_TypeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("ادخل نوع التعبئة");
            }
            else if (transCocomboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("ادخل شركة الشحن");
            }
            else if (truck_numberComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("ادخل رقم السيارة ");
            }
            else if (driver_NameComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("ادخل السائق ");
            }
            else
            {

                if (checkReamainQuanty())
                {
                    //savecase = true;
                    string Cstatus = "اول";
                    if (noWcheckBox1.CheckState == CheckState.Checked)
                    {
                        Cstatus = "تم";
                    }

                    try
                    {

                        if (!editing)
                        {
                            int ld = int.Parse(this.lading_OutTableAdapter.InsertQuery(fill_TypeComboBox.Text + "", Properties.Settings.Default.logedUN
                             , notesTextBox.Text + "", int.Parse(order_Number1ComboBox.SelectedValue.ToString()), decimal.Parse(lad_qty_requiredTextBox.Text),
                             representativeTextBox.Text + "", Cstatus, transType.Text, int.Parse(driver_IDTextBox.Text), int.Parse(transCocomboBox1.SelectedValue.ToString()),
                             int.Parse(truck_IDTextBox.Text), 0, 0).ToString());
                            ladingIDTextBox.Text = ld + "";
                            MessageBox.Show("تم الحفظ برقم : " + ld);

                        }

                        if (editing)
                        {
                            String notes = "تم التعديل بواسطة " + Properties.Settings.Default.logedUN + "  بتاريخ:" + DateTime.Now;

                            if (reWeightBtn.CheckState == CheckState.Checked)
                            {
                                this.lading_OutTableAdapter.UpdateQuery1Reweight(fill_TypeComboBox.Text + ""
                                                        , notesTextBox.Text + notes, Properties.Settings.Default.logedUN, int.Parse(order_Number1ComboBox.SelectedValue.ToString()),
                                                        decimal.Parse(lad_qty_requiredTextBox.Text), representativeTextBox.Text + "", transType.Text, int.Parse(driver_IDTextBox.Text), int.Parse(transCocomboBox1.SelectedValue.ToString()),
                                                        int.Parse(truck_IDTextBox.Text), Cstatus, int.Parse(ladingIDTextBox.Text));
                                MessageBox.Show("تم الحفظ مع اعادة الوزن ");
                                editing = false;
                            }
                            else
                            {
                                this.lading_OutTableAdapter.UpdateQuery(fill_TypeComboBox.Text + ""
                                                        , notesTextBox.Text, Properties.Settings.Default.logedUN, int.Parse(order_Number1ComboBox.SelectedValue.ToString()),
                                                        decimal.Parse(lad_qty_requiredTextBox.Text), representativeTextBox.Text + "", transType.Text, int.Parse(driver_IDTextBox.Text), int.Parse(transCocomboBox1.SelectedValue.ToString()),
                                                        int.Parse(truck_IDTextBox.Text), int.Parse(ladingIDTextBox.Text), int.Parse(ladingIDTextBox.Text));
                                MessageBox.Show("تم الحفظ ");
                                editing = false;
                            }
                            dq.RunNonQuery("insert into logs(username,tablename,uaction,cdata,code) values (N'" + Properties.Settings.Default.logedUN +
                                "','Ladingout','edit',N'q=" + lad_qty_requiredTextBox.Text + "  onum=" + order_Number1ComboBox.Text + " contnum =" + contract_idTextBox.Text + "  custname=" + cust_NAMETextBox.Text + "'," + ladingIDTextBox.Text + ")");
                            oldQty.Visible = false;
                        }


                        bindingNavigatorAddNewItem.Enabled = true;
                        saveItemBtn.Enabled = false;
                        panel1.Enabled = false;
                        panel1.Enabled = false;
                        groupBox2.Enabled = false;
                        if (perm.Rows[0]["__ladingout_editBtn"].ToString() != "1")
                        {
                            editBtn.Enabled = false;
                        }
                        printBtn.Enabled = true;
                        reWeightBtn.Visible = false;
                        bindingNavigatorDeleteItem.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                editing = false;
                loadbtn.Visible = false;
                ladingIDTextBox.ReadOnly = true;

                // Set cursor as default arrow

            }
            Cursor.Current = Cursors.Default;
        }
        DataQuery dq = new DataQuery();
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            lad_qty_requiredTextBox.Text = "0";
            editing = false;

            panel1.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            saveItemBtn.Enabled = true;
            printBtn.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = true;
            ladingIDTextBox.Text = "0";
            editBtn.Enabled = false;

        }

        private void contract_idTextBox_TextChanged(object sender, EventArgs e)
        {
            //int oid = int.Parse(order_IDTextBox1.Text.ToString());
            //this.orderTableAdapter.UpdateRQ(oid);

        }

        private void order_IDComboBox_Click(object sender, EventArgs e)
        {
            //  int Oid = 0;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.OrderForLad' table. You can move, or remove it, as needed.
                this.orderForLadTableAdapter.FillForLad(this.outdataset.OrderForLad);
                groupBox2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "error01");
            }

            checkReamainQuanty();



            Cursor.Current = Cursors.Default;
        }

        public Boolean checkReamainQuanty()
        {
            try
            {
                if (order_Number1ComboBox.SelectedIndex > -1)
                {
                    int Oid = int.Parse(order_Number1ComboBox.SelectedValue.ToString());

                    decimal remQty = 0;
                    remQty = decimal.Parse(orderremain_QtyTextBox.Text.ToString());

                    decimal allowedQ = 0;
                    allowedQ = decimal.Parse(AllowedtextBox2.Text);
                    //MessageBox.Show(allowedQ + " " + remQty + " " + reserverLadQ);
                    string orderid = dq.GetStringValu("select order_id from [Order] where order_Number=N'" + order_Number1ComboBox.Text + "'");
                    //  MessageBox.Show("select sum(Qty) from Lading_out where (order_id=" + order_IDTextBox.Text + " AND (Status='اول' or Status='ثاني' ))");
                    reservedQtextBox1.Text = dq.GetStringValu("select sum(Qty) from Lading_Out where Order_ID=" + orderid + " and (Status=N'اول' or Status=N'ثان')");
                    if (reservedQtextBox1.Text == "") reservedQtextBox1.Text = "0";
                    if (lad_qty_requiredTextBox.Text.Length > 0)
                    {
                        decimal LadQ = decimal.Parse(lad_qty_requiredTextBox.Text.ToString());
                        if (editing)
                        {
                            allowedQ += decimal.Parse(oldQty.Text.ToString());
                        }
                        if (LadQ > allowedQ)
                        {
                            //orderremain_QtyTextBox.Text = (OrderQ - sumLadQ) + "";
                            MessageBox.Show("خطأ في الكمية او كمية غير متوفرة");
                            saveItemBtn.Enabled = false;
                            lad_qty_requiredTextBox.ForeColor = System.Drawing.Color.Red;
                            return false;
                        }
                        else
                        {
                            saveItemBtn.Enabled = true;
                            lad_qty_requiredTextBox.ForeColor = System.Drawing.Color.Black;
                            // return true;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return true;

        }
        private void qty_requiredTextBox_TextChanged(object sender, EventArgs e)
        {

            checkReamainQuanty();
        }

        private void lading_OutBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ladingIDTextBox.Text.Length > 0)
                {
                    int lc = int.Parse(ladingIDTextBox.Text);
                    if (lc > 0)
                    {
                        string counted = "";
                        if (label1.Text == "وحدة")
                        {
                            counted = "pack";
                        }
                        OUTPrint_Loadingcard print_Lcard = new OUTPrint_Loadingcard(lc, "new", counted);
                        print_Lcard.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            panel1.Enabled = true;
            groupBox2.Enabled = true;
            editing = true;
            loadbtn.Visible = true;
            ladingIDTextBox.ReadOnly = false;
            reWeightBtn.Checked = false;

            //try
            //{

            //    // TODO: This line of code loads data into the 'dLWSDataSet.Transport_Co' table. You can move, or remove it, as needed.
            //    this.transport_CoTableAdapter.Fill(this.dLWSDataSet.Transport_Co);

            //    // TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
            //    this.truckTableAdapter.Fill(this.dLWSDataSet.Truck);
            //    truck_numberComboBox.SelectedIndex = truck_numberComboBox.Items.Count - 1;

            //    // TODO: This line of code loads data into the 'dLWSDataSet.Drivers' table. You can move, or remove it, as needed.
            //    this.driversTableAdapter.Fill(this.dLWSDataSet.Drivers);
            //    if (driver_NameComboBox.Items.Count > 0)
            //    {
            //        driver_NameComboBox.SelectedIndex = driver_NameComboBox.Items.Count - 1;
            //    }
            //}
            //catch (Exception ex)
            //{

            //}



            ////  int Oid = 0;
            //if (order_Number1ComboBox.SelectedIndex < 0)
            //{
            //    try
            //    {
            //        // TODO: This line of code loads data into the 'dLWSDataSet.OrderForLad' table. You can move, or remove it, as needed.
            //        this.orderForLadTableAdapter.FillForLad(this.outdataset.OrderForLad);
            //        //if()
            //        // order_Number1ComboBox.SelectedIndex = order_Number1ComboBox.Items.Count - 1;

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message + "error01");
            //    }
            //}

            //Cursor.Current = Cursors.Default;
        }

        private void orderqtyTextBox_TextChanged(object sender, EventArgs e)
        {

            if (order_Number1ComboBox.SelectedIndex > -1)
            {
                if (orderqtyTextBox.Text.Length > 0)
                {
                    checkReamainQuanty();
                }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.Transport_Co' table. You can move, or remove it, as needed.
            this.transport_CoTableAdapter.Fill(this.dLWSDataSet.Transport_Co);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            saveItemBtn.Enabled = false;
            //orderForLadTableAdapter.ClearBeforeFill=true;
            if (groupBox2.Enabled == true)
            {
                try
                {
                    lading_OutTableAdapter.FillByStatsAndlid(outdataset.Lading_Out, -1);
                }
                catch (Exception ex)
                {

                }
            }
            panel1.Enabled = false;
            groupBox2.Enabled = false;

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            LastOutCards lo = new LastOutCards();
            lo.ShowDialog();
        }

        private void truck_numberComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            //    if (e.KeyCode == Keys.Enter)
            //    {
            //        SendKeys.Send("{TAB}");
            //    }
        }

        private void OUTLoadingCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // dateTextBox.DataBindings.Clear();
            representativeTextBox.DataBindings.Clear();
            truck_numberComboBox.DataBindings.Clear();
            driver_NameComboBox.DataBindings.Clear();
            transCocomboBox1.DataBindings.Clear();
            //  lading_OutBindingSource.DataSource;
        }

        private void loadbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int lid = int.Parse(ladingIDTextBox.Text);
            outdataset.Lading_Out.Clear();
            dLWSDataSet.Truck.Clear();
            dLWSDataSet.Drivers.Clear();
            outdataset.OrderForLad.Clear();
            saveItemBtn.Enabled = false;

            var cardStatus = this.lading_OutTableAdapter.GetStatus(lid);
                if (cardStatus != "اول" && cardStatus != "ثان" && perm.Rows[0]["outeditafter"].ToString()!="1")
                {
                    int cardID = int.Parse(ladingIDTextBox.Text);

                editing = false;
                MessageBox.Show("لا يمكن التعديل بعد الوزن");

            }
            else
            {
                editing = true;
                try
                {
                    if (ladingIDTextBox.Text.Length < 1)
                    {
                        saveItemBtn.Enabled = false;
                    }
                    else
                    {
                        lading_OutTableAdapter.FillForEdit(outdataset.Lading_Out, lid);
                        saveItemBtn.Enabled = true;
                        truckTableAdapter.FillByTid(dLWSDataSet.Truck, Convert.ToInt32(truck_IDTextBox1.Text));
                        driversTableAdapter.FillByDid(dLWSDataSet.Drivers, Convert.ToInt32(driver_IDTextBox1.Text));
                        orderForLadTableAdapter.FillBy(outdataset.OrderForLad, Convert.ToInt32(order_IDTextBox.Text));
                        oldQty.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "er02");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            // TODO: This line of code loads data into the 'dLWSDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.dLWSDataSet.Drivers);
            if (driver_NameComboBox.Items.Count > 0)
            {
                driver_NameComboBox.SelectedIndex = driver_NameComboBox.Items.Count - 1;
            }
        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

                }
            }
        }


        private void driver_NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    driver_NameComboBox.SelectedIndex = driver_NameComboBox.FindStringExact(driver_NameComboBox.Text.ToString());
                    // SendKeys.Send("{TAB}");
                }
                catch (Exception ex)
                { }
            }
        }
        private void truck_numberComboBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            //if (e.KeyCode == Keys.Enter)
            //{
            //    try
            //    {
            //        truck_numberComboBox.SelectedIndex = truck_numberComboBox.FindStringExact(truck_numberComboBox.Text);
            //        SendKeys.Send("{TAB}");
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}
        }

        private void transCocomboBox1_Click(object sender, EventArgs e)
        {
            if (transCocomboBox1.Items.Count < 1)
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Transport_Co' table. You can move, or remove it, as needed.
                this.transport_CoTableAdapter.Fill(this.dLWSDataSet.Transport_Co);
                if (transCocomboBox1.Items.Count > 0)
                {
                    transCocomboBox1.SelectedIndex = transCocomboBox1.Items.Count - 1;
                }
            }
        }

        private void order_Number1ComboBox_Leave(object sender, EventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            try
            {
                order_Number1ComboBox.SelectedIndex = order_Number1ComboBox.FindStringExact(order_Number1ComboBox.Text);
                //SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {

            }
            //}
        }

        private void truck_numberComboBox_Click(object sender, EventArgs e)
        {
            if (truck_numberComboBox.Items.Count < 1)
            {
                try
                {
                    // TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
                    this.truckTableAdapter.Fill(this.dLWSDataSet.Truck);
                    if (truck_numberComboBox.Items.Count > 0)
                    {
                        truck_numberComboBox.SelectedIndex = truck_numberComboBox.Items.Count - 1;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void driver_NameComboBox_Click(object sender, EventArgs e)
        {
            if (driver_NameComboBox.Items.Count < 1)
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Drivers' table. You can move, or remove it, as needed.
                this.driversTableAdapter.Fill(this.dLWSDataSet.Drivers);
                if (driver_NameComboBox.Items.Count > 0)
                {
                    driver_NameComboBox.SelectedIndex = driver_NameComboBox.Items.Count - 1;
                }
            }
        }


        private void orderremain_QtyTextBox_TextChanged(object sender, EventArgs e)
        {
            checkReamainQuanty();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        { // TODO: This line of code loads data into the 'dLWSDataSet.Truck' table. You can move, or remove it, as needed.
            this.truckTableAdapter.Fill(this.dLWSDataSet.Truck);
            if (truck_numberComboBox.Items.Count > 0)
            {
                truck_numberComboBox.SelectedIndex = truck_numberComboBox.Items.Count - 1;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // TODO: This line of code loads data into the 'dLWSDataSet.Drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.dLWSDataSet.Drivers);
            if (driver_NameComboBox.Items.Count > 0)
            {
                driver_NameComboBox.SelectedIndex = driver_NameComboBox.Items.Count - 1;
            }

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

                }
            }
        }

        private void order_Number1ComboBox_Click(object sender, EventArgs e)
        {
            if (order_Number1ComboBox.Items.Count < 1)
            {

                //  int Oid = 0;
                if (order_Number1ComboBox.SelectedIndex < 0)
                {
                    try
                    {
                        // TODO: This line of code loads data into the 'dLWSDataSet.OrderForLad' table. You can move, or remove it, as needed.
                        this.orderForLadTableAdapter.FillForLad(this.outdataset.OrderForLad);
                        //if()
                        // order_Number1ComboBox.SelectedIndex = order_Number1ComboBox.Items.Count - 1;
                        checkReamainQuanty();
                        groupBox2.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "  error02");
                    }
                }
            }
        }

        private void ladingIDTextBox_TextChanged(object sender, EventArgs e)
        {
            reWeightBtn.Checked = false;
        }

        private void transCocomboBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comm_NAMETextBox_TextChanged(object sender, EventArgs e)
        {
            if (order_Number1ComboBox.SelectedIndex > 0)
            {
                if (this.outdataset.OrderForLad.Rows.Count > 0)
                {
                    if (outdataset.OrderForLad.Rows[order_Number1ComboBox.SelectedIndex]["counted"].ToString() == "yes")
                    {
                        label1.Text = "وحدة";
                        label2.Text = "وحدة";
                        label3.Text = "وحدة";
                        label5.Text = "وحدة";
                        label10.Text = "وحدة";
                        fill_TypeComboBox.SelectedIndex = 1;
                        fill_TypeComboBox.Enabled = false;
                        // string rqnty=dq.GetStringValu("select ")
                    }
                    else
                    {

                        label1.Text = "طن";
                        label2.Text = "طن";
                        label3.Text = "طن";
                        label5.Text = "طن";
                        label10.Text = "طن";
                        fill_TypeComboBox.SelectedIndex = 0;
                        fill_TypeComboBox.Enabled = Enabled;
                    }
                }
            }
        }

        private void unitlabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
