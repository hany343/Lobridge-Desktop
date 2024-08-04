﻿using System;
using System.Data;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class INShipment : Form
    {
        DataTable perm;
        public INShipment(DataTable dataTable)
        {
            perm = dataTable;
            InitializeComponent();
        }

        private void shipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {


                int ident = Convert.ToInt32(this.shipmentTableAdapter.InsertShipment(contractTextBox.Text, int.Parse(comm_NAMEComboBox.SelectedValue.ToString() + ""),
                    int.Parse(sUP_NAMEComboBox.SelectedValue + ""), shippingTextBox.Text
                    , notesTextBox.Text, "مفتوح", decimal.Parse(qtyTextBox.Text), decimal.Parse(qtyTextBox.Text)
                    , int.Parse(TransCo.SelectedValue + ""), Properties.Settings.Default.logedUN, lading_PortTextBox.Text).ToString());

                ship_IDTextBox.Text = ident + "";
                if (ident > 0)
                {
                    shipmentBindingNavigatorSaveItem.Enabled = false;
                    bindingNavigatorDeleteItem.Enabled = false;
                    this.panel1.Enabled = false;
                    bindingNavigatorAddNewItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            //dateTextBox.Text = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt");
        }
        private void Shipping_Load(object sender, EventArgs e)
        {
            ////// TODO: This line of code loads data into the 'iNdataset.SUPPLIERS' table. You can move, or remove it, as needed.
            ////this.sUPPLIERSTableAdapter.Fill(this.iNdataset.SUPPLIERS);
            ////// TODO: This line of code loads data into the 'iNdataset.Shipment' table. You can move, or remove it, as needed.
            ////this.shipmentTableAdapter.Fill(this.iNdataset.Shipment);
            //timer1.Tick += new EventHandler(timer1_Tick);

            //timer1.Start();
            this.panel1.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            INSupplier createSupplier = new INSupplier(perm);
            createSupplier.ShowDialog();
        }

        private void sUP_IDComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (sUP_NAMEComboBox.SelectedIndex < 0)
                {
                    // TODO: This line of code loads data into the 'dLWSDataSet.SUPPLIERS' table. You can move, or remove it, as needed.
                    this.sUPPLIERSTableAdapter.Fill(this.iNdataset.SUPPLIERS);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddComm_Click(object sender, EventArgs e)
        {
            Commodity commodity = new Commodity(perm);
            commodity.ShowDialog();
        }

        private void comm_NAMEComboBox_Click(object sender, EventArgs e)
        {
            if (comm_NAMEComboBox.SelectedIndex < 0)
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Commodity' table. You can move, or remove it, as needed.
                this.commodityTableAdapter.FillBystatus(this.dLWSDataSet.Commodity, "مفتوح");
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
            this.shipmentBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            RefreshBtn.Enabled = true;

            ship_IDTextBox.Text = "";

            // TODO: This line of code loads data into the 'dLWSDataSet.Transport_Co' table. You can move, or remove it, as needed.
            this.transport_CoTableAdapter.Fill(this.dLWSDataSet.Transport_Co);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Commodity' table. You can move, or remove it, as needed.
                this.commodityTableAdapter.Fill(this.dLWSDataSet.Commodity);
                //comm_IDTextBox.Text = comm_NAMEComboBox.SelectedValue.ToString();
                // TODO: This line of code loads data into the 'dLWSDataSet.Transport_Co' table. You can move, or remove it, as needed.
                this.transport_CoTableAdapter.Fill(this.dLWSDataSet.Transport_Co);
                // TODO: This line of code loads data into the 'dLWSDataSet.SUPPLIERS' table. You can move, or remove it, as needed.
                this.sUPPLIERSTableAdapter.Fill(this.iNdataset.SUPPLIERS);
            }
            catch (Exception ex)
            {

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            INListShips sh = new INListShips(perm);
            sh.ShowDialog();
        }


        //private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked == true)
        //    {
        //        shippingTextBox.Text = "محلي";
        //        shippingTextBox.ReadOnly = true;
        //    }
        //    else
        //    {
        //        shippingTextBox.Text = "";
        //        shippingTextBox.ReadOnly = false;
        //    }
        //}

        //private void checkBox1_Click(object sender, EventArgs e)
        //{
        //    if (checkBox1.CheckState == CheckState.Checked)
        //    {
        //        checkBox1.CheckState = CheckState.Checked ;
        //    }
        //    else
        //    {
        //        checkBox1.CheckState = CheckState.Unchecked;
        //    }
        //}

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}