using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class INRelease : Form
    {
        public INRelease()
        {
            InitializeComponent();
        }

        private void iNBatchBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (checkReamainQuanty())
            {
                if (validateRNUM(serialTextBox.Text))
                {

                    try
                    {

                        int shid = int.Parse(ship_IDComboBox.Text.ToString());
                        int ident = int.Parse(this.iNBatchTableAdapter.InsertRelease(shid, serialTextBox.Text, arrivalDateDateTimePicker.Value.ToShortDateString(),
                            notesTextBox.Text, "مفتوح", decimal.Parse(BatchqtyTextBox.Text), decimal.Parse(BatchqtyTextBox.Text), Properties.Settings.Default.logedUN, "").ToString());
                        bindingNavigatorAddNewItem.Enabled = true;
                        iNBatchBindingNavigatorSaveItem.Enabled = false;
                        panel1.Enabled = false;

                        RefreshBtn.Enabled = false;
                        bindingNavigatorDeleteItem.Enabled = false;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "m4");
                    }
                }
            }
        }
        public bool validateRNUM(string Rnum)
        {
            try
            {
                int scount = int.Parse(iNBatchTableAdapter.FindSerial(Rnum).ToString());
                if (scount > 0)
                {
                    MessageBox.Show("رقم الافراج/الدفعة مسجل من قبل");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في تعريف البيانات, يرجي المحاولة مرة اخري.");
                return false;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            // dateTextBox.Text = System.DateTime.Now.ToString("MM/dd/yyyy   HH:mm:ss");

        }

        private void INBatch_Load(object sender, EventArgs e)
        {
             try
            {
               
           
                // TODO: This line of code loads data into the 'iNdataset.SUPPLIERS' table. You can move, or remove it, as needed.
                this.sUPPLIERSTableAdapter.Fill(this.iNdataset.SUPPLIERS);
                // TODO: This line of code loads data into the 'dLWSDataSet1.Commodity' table. You can move, or remove it, as needed.
                this.commodityTableAdapter.Fill(this.dLWSDataSet1.Commodity);
                // TODO: This line of code loads data into the 'dLWSDataSet.Shipment' table. You can move, or remove it, as needed.
                //this.shipmentTableAdapter.Fill(this.dLWSDataSet.Shipment);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            timer1.Tick += new EventHandler(timer1_Tick);

            // timer1.Start();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            try
            {
                bindingNavigatorAddNewItem.Enabled = false;
                this.panel1.Enabled = true;
                iNBatchBindingNavigatorSaveItem.Enabled = true;
                // TODO: This line of code loads data into the 'iNdataset.ShipToRelease' table. You can move, or remove it, as needed.
                this.shipToReleaseTableAdapter.FillforRelease(this.iNdataset.ShipToRelease, "مفتوح");

                ship_IDComboBox.SelectedIndex = ship_IDComboBox.Items.Count - 1;
                RefreshBtn.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "m3");
            }
        }

        public Boolean checkReamainQuanty()
        {

            if (BatchqtyTextBox.Text.Length > 0 && ship_RQtyTextBox.Text.Length > 0)
            {
                int Sid = 0;
                if (ship_IDComboBox.SelectedIndex > -1)
                {
                    Sid = int.Parse(ship_IDComboBox.SelectedValue.ToString());

                }
                decimal batchqty = decimal.Parse(BatchqtyTextBox.Text.ToString());
                decimal shipQty = decimal.Parse(shipqtyTextBox1.Text.ToString());
                decimal sumbatq = decimal.Parse(this.iNBatchTableAdapter.SumQTybyShid(Sid).ToString());
                //MessageBox.Show(sumbatq + " " + shipQty + " " + batchqty);
                if ((sumbatq + batchqty) > shipQty)
                {

                    ship_RQtyTextBox.Text = (shipQty - sumbatq) + "";
                    MessageBox.Show("خطأ في الكمية او كمية غير متوفرة");
                    iNBatchBindingNavigatorSaveItem.Enabled = false;
                    BatchqtyTextBox.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                else
                {

                    iNBatchBindingNavigatorSaveItem.Enabled = true;
                    BatchqtyTextBox.ForeColor = System.Drawing.Color.Black;

                }

            }
            return true;
        }

        private void qtyTextBox_TextChanged(object sender, EventArgs e)
        {
            checkReamainQuanty();
        }

        private void iNBatchBindingNavigatorSaveItem_MouseHover(object sender, EventArgs e)
        {
            //dateDateTimePicker.Text = System.DateTime.Now.ToString();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'iNdataset.SUPPLIERS' table. You can move, or remove it, as needed.
                this.sUPPLIERSTableAdapter.Fill(this.iNdataset.SUPPLIERS);
                // TODO: This line of code loads data into the 'dLWSDataSet1.Commodity' table. You can move, or remove it, as needed.
                this.commodityTableAdapter.Fill(this.dLWSDataSet1.Commodity);
                // TODO: This line of code loads data into the 'dLWSDataSet.Shipment' table. You can move, or remove it, as needed.
                //this.shipmentTableAdapter.Fill(this.dLWSDataSet.Shipment);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            iNBatchBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            RefreshBtn.Enabled = false;


            try
            {

                // this.shipmentTableAdapter.FillByRQST(this.dLWSDataSet.Shipment, 0, "NONE");
                //ship_IDComboBox.SelectedIndex = ship_IDComboBox.Items.Count - 1;
                //ship_IDTextBox.Text = ship_IDComboBox.Text;


                // TODO: This line of code loads data into the 'dLWSDataSet.Commodity' table. You can move, or remove it, as needed.
                //    this.commodityTableAdapter.FillByCID(this.dLWSDataSet.Commodity, -1);

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message + "m3");
            }
            this.panel1.Enabled = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
