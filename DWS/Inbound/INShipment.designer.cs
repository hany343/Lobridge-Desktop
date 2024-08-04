namespace LoBridge
{
    partial class INShipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contractLabel;
            System.Windows.Forms.Label commodityLabel;
            System.Windows.Forms.Label supp_NameLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label shippingLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label ship_IDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label ship_RQtyLabel;
            System.Windows.Forms.Label company_NameLabel;
            System.Windows.Forms.Label shusernameLabel;
            System.Windows.Forms.Label lading_PortLabel;
            this.dLWSDataSet = new LoBridge.DLWSDataSet();
            this.contractTextBox = new System.Windows.Forms.TextBox();
            this.shippingTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.sUP_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNdataset = new LoBridge.INdataset();
            this.button1 = new System.Windows.Forms.Button();
            this.commodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commodityTableAdapter = new LoBridge.DLWSDataSetTableAdapters.CommodityTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comm_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.lading_PortTextBox = new System.Windows.Forms.TextBox();
            this.TransCo = new System.Windows.Forms.ComboBox();
            this.transport_CoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ship_IDTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.ship_RQtyTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.shipmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.EditBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ShipmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.transport_CoTableAdapter = new LoBridge.DLWSDataSetTableAdapters.Transport_CoTableAdapter();
            this.shusernameTextBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentTableAdapter = new LoBridge.INdatasetTableAdapters.ShipmentTableAdapter();
            this.sUPPLIERSTableAdapter = new LoBridge.INdatasetTableAdapters.SUPPLIERSTableAdapter();
            contractLabel = new System.Windows.Forms.Label();
            commodityLabel = new System.Windows.Forms.Label();
            supp_NameLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            shippingLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ship_IDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ship_RQtyLabel = new System.Windows.Forms.Label();
            company_NameLabel = new System.Windows.Forms.Label();
            shusernameLabel = new System.Windows.Forms.Label();
            lading_PortLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transport_CoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentBindingNavigator)).BeginInit();
            this.ShipmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contractLabel
            // 
            contractLabel.AutoSize = true;
            contractLabel.Location = new System.Drawing.Point(684, 84);
            contractLabel.Name = "contractLabel";
            contractLabel.Size = new System.Drawing.Size(71, 22);
            contractLabel.TabIndex = 3;
            contractLabel.Text = "رقم العقد:";
            // 
            // commodityLabel
            // 
            commodityLabel.AutoSize = true;
            commodityLabel.Location = new System.Drawing.Point(684, 159);
            commodityLabel.Name = "commodityLabel";
            commodityLabel.Size = new System.Drawing.Size(62, 22);
            commodityLabel.TabIndex = 5;
            commodityLabel.Text = "الصنف:";
            // 
            // supp_NameLabel
            // 
            supp_NameLabel.AutoSize = true;
            supp_NameLabel.Location = new System.Drawing.Point(685, 195);
            supp_NameLabel.Name = "supp_NameLabel";
            supp_NameLabel.Size = new System.Drawing.Size(85, 22);
            supp_NameLabel.TabIndex = 9;
            supp_NameLabel.Text = "اسم المورد:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(684, 124);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(53, 22);
            qtyLabel.TabIndex = 11;
            qtyLabel.Text = "الكمية:";
            // 
            // shippingLabel
            // 
            shippingLabel.AutoSize = true;
            shippingLabel.Location = new System.Drawing.Point(683, 231);
            shippingLabel.Name = "shippingLabel";
            shippingLabel.Size = new System.Drawing.Size(86, 22);
            shippingLabel.TabIndex = 15;
            shippingLabel.Text = "اسم الشحنة:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(682, 335);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(78, 22);
            notesLabel.TabIndex = 23;
            notesLabel.Text = "ملاحظات:";
            // 
            // ship_IDLabel
            // 
            ship_IDLabel.AutoSize = true;
            ship_IDLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ship_IDLabel.Location = new System.Drawing.Point(425, 20);
            ship_IDLabel.Name = "ship_IDLabel";
            ship_IDLabel.Size = new System.Drawing.Size(114, 29);
            ship_IDLabel.TabIndex = 35;
            ship_IDLabel.Text = "كود الشحنة:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(260, 122);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(33, 22);
            label1.TabIndex = 37;
            label1.Text = "طن";
            // 
            // ship_RQtyLabel
            // 
            ship_RQtyLabel.AutoSize = true;
            ship_RQtyLabel.Location = new System.Drawing.Point(187, 242);
            ship_RQtyLabel.Name = "ship_RQtyLabel";
            ship_RQtyLabel.Size = new System.Drawing.Size(98, 22);
            ship_RQtyLabel.TabIndex = 37;
            ship_RQtyLabel.Text = "Ship RQty:";
            // 
            // company_NameLabel
            // 
            company_NameLabel.AutoSize = true;
            company_NameLabel.Location = new System.Drawing.Point(682, 265);
            company_NameLabel.Name = "company_NameLabel";
            company_NameLabel.Size = new System.Drawing.Size(86, 22);
            company_NameLabel.TabIndex = 39;
            company_NameLabel.Text = "شركة النقل:";
            // 
            // shusernameLabel
            // 
            shusernameLabel.AutoSize = true;
            shusernameLabel.Location = new System.Drawing.Point(547, 217);
            shusernameLabel.Name = "shusernameLabel";
            shusernameLabel.Size = new System.Drawing.Size(110, 22);
            shusernameLabel.TabIndex = 38;
            shusernameLabel.Text = "Shusername:";
            // 
            // lading_PortLabel
            // 
            lading_PortLabel.AutoSize = true;
            lading_PortLabel.Location = new System.Drawing.Point(681, 299);
            lading_PortLabel.Name = "lading_PortLabel";
            lading_PortLabel.Size = new System.Drawing.Size(100, 22);
            lading_PortLabel.TabIndex = 39;
            lading_PortLabel.Text = "مكان التحميل:";
            // 
            // dLWSDataSet
            // 
            this.dLWSDataSet.CaseSensitive = true;
            this.dLWSDataSet.DataSetName = "DLWSDataSet";
            this.dLWSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractTextBox
            // 
            this.contractTextBox.BackColor = System.Drawing.Color.White;
            this.contractTextBox.Location = new System.Drawing.Point(299, 81);
            this.contractTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contractTextBox.Name = "contractTextBox";
            this.contractTextBox.Size = new System.Drawing.Size(379, 30);
            this.contractTextBox.TabIndex = 11;
            // 
            // shippingTextBox
            // 
            this.shippingTextBox.BackColor = System.Drawing.Color.White;
            this.shippingTextBox.Location = new System.Drawing.Point(231, 227);
            this.shippingTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shippingTextBox.Name = "shippingTextBox";
            this.shippingTextBox.Size = new System.Drawing.Size(446, 30);
            this.shippingTextBox.TabIndex = 16;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(88, 333);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(589, 72);
            this.notesTextBox.TabIndex = 19;
            // 
            // sUP_NAMEComboBox
            // 
            this.sUP_NAMEComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.sUP_NAMEComboBox.BackColor = System.Drawing.Color.LightBlue;
            this.sUP_NAMEComboBox.DataSource = this.sUPPLIERSBindingSource;
            this.sUP_NAMEComboBox.DisplayMember = "SUP_NAME";
            this.sUP_NAMEComboBox.FormattingEnabled = true;
            this.sUP_NAMEComboBox.Location = new System.Drawing.Point(298, 190);
            this.sUP_NAMEComboBox.Name = "sUP_NAMEComboBox";
            this.sUP_NAMEComboBox.Size = new System.Drawing.Size(380, 30);
            this.sUP_NAMEComboBox.TabIndex = 15;
            this.sUP_NAMEComboBox.ValueMember = "SUP_ID";
            this.sUP_NAMEComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sUP_IDComboBox_MouseClick);
            // 
            // sUPPLIERSBindingSource
            // 
            this.sUPPLIERSBindingSource.DataMember = "SUPPLIERS";
            this.sUPPLIERSBindingSource.DataSource = this.iNdataset;
            // 
            // iNdataset
            // 
            this.iNdataset.DataSetName = "INdataset";
            this.iNdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "جديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // commodityBindingSource
            // 
            this.commodityBindingSource.DataMember = "Commodity";
            this.commodityBindingSource.DataSource = this.dLWSDataSet;
            // 
            // commodityTableAdapter
            // 
            this.commodityTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comm_NAMEComboBox);
            this.panel1.Controls.Add(lading_PortLabel);
            this.panel1.Controls.Add(this.lading_PortTextBox);
            this.panel1.Controls.Add(company_NameLabel);
            this.panel1.Controls.Add(this.TransCo);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(ship_IDLabel);
            this.panel1.Controls.Add(this.contractTextBox);
            this.panel1.Controls.Add(this.ship_IDTextBox);
            this.panel1.Controls.Add(contractLabel);
            this.panel1.Controls.Add(commodityLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.notesTextBox);
            this.panel1.Controls.Add(this.sUP_NAMEComboBox);
            this.panel1.Controls.Add(notesLabel);
            this.panel1.Controls.Add(this.shippingTextBox);
            this.panel1.Controls.Add(supp_NameLabel);
            this.panel1.Controls.Add(shippingLabel);
            this.panel1.Controls.Add(qtyLabel);
            this.panel1.Controls.Add(this.qtyTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(9, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 409);
            this.panel1.TabIndex = 35;
            // 
            // comm_NAMEComboBox
            // 
            this.comm_NAMEComboBox.DataSource = this.commodityBindingSource;
            this.comm_NAMEComboBox.DisplayMember = "Comm_NAME";
            this.comm_NAMEComboBox.FormattingEnabled = true;
            this.comm_NAMEComboBox.Location = new System.Drawing.Point(299, 155);
            this.comm_NAMEComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comm_NAMEComboBox.Name = "comm_NAMEComboBox";
            this.comm_NAMEComboBox.Size = new System.Drawing.Size(379, 30);
            this.comm_NAMEComboBox.TabIndex = 41;
            this.comm_NAMEComboBox.ValueMember = "Comm_ID";
            this.comm_NAMEComboBox.Click += new System.EventHandler(this.comm_NAMEComboBox_Click);
            // 
            // lading_PortTextBox
            // 
            this.lading_PortTextBox.Location = new System.Drawing.Point(231, 297);
            this.lading_PortTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lading_PortTextBox.Name = "lading_PortTextBox";
            this.lading_PortTextBox.Size = new System.Drawing.Size(446, 30);
            this.lading_PortTextBox.TabIndex = 40;
            // 
            // TransCo
            // 
            this.TransCo.DataSource = this.transport_CoBindingSource;
            this.TransCo.DisplayMember = "Company_Name";
            this.TransCo.FormattingEnabled = true;
            this.TransCo.Location = new System.Drawing.Point(231, 263);
            this.TransCo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransCo.Name = "TransCo";
            this.TransCo.Size = new System.Drawing.Size(446, 30);
            this.TransCo.TabIndex = 17;
            this.TransCo.ValueMember = "Company_ID";
            // 
            // transport_CoBindingSource
            // 
            this.transport_CoBindingSource.DataMember = "Transport_Co";
            this.transport_CoBindingSource.DataSource = this.dLWSDataSet;
            // 
            // ship_IDTextBox
            // 
            this.ship_IDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.ship_IDTextBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ship_IDTextBox.Location = new System.Drawing.Point(300, 12);
            this.ship_IDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ship_IDTextBox.Name = "ship_IDTextBox";
            this.ship_IDTextBox.ReadOnly = true;
            this.ship_IDTextBox.Size = new System.Drawing.Size(120, 46);
            this.ship_IDTextBox.TabIndex = 10;
            this.ship_IDTextBox.TabStop = false;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.BackColor = System.Drawing.Color.White;
            this.qtyTextBox.Location = new System.Drawing.Point(299, 119);
            this.qtyTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(380, 30);
            this.qtyTextBox.TabIndex = 12;
            // 
            // ship_RQtyTextBox
            // 
            this.ship_RQtyTextBox.Location = new System.Drawing.Point(277, 240);
            this.ship_RQtyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ship_RQtyTextBox.Name = "ship_RQtyTextBox";
            this.ship_RQtyTextBox.Size = new System.Drawing.Size(85, 30);
            this.ship_RQtyTextBox.TabIndex = 38;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bindingNavigatorAddNewItem.Image = global::LoBridge.Properties.Resources.add2;
            this.bindingNavigatorAddNewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(39, 40);
            this.bindingNavigatorAddNewItem.Text = "اضافة";
            this.bindingNavigatorAddNewItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // shipmentBindingNavigatorSaveItem
            // 
            this.shipmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shipmentBindingNavigatorSaveItem.Enabled = false;
            this.shipmentBindingNavigatorSaveItem.Image = global::LoBridge.Properties.Resources.save3;
            this.shipmentBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.shipmentBindingNavigatorSaveItem.Name = "shipmentBindingNavigatorSaveItem";
            this.shipmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(39, 40);
            this.shipmentBindingNavigatorSaveItem.Text = "حفظ";
            this.shipmentBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.shipmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.shipmentBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = global::LoBridge.Properties.Resources.cancel;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(42, 40);
            this.bindingNavigatorDeleteItem.Text = "الغاء";
            // 
            // EditBtn
            // 
            this.EditBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditBtn.Enabled = false;
            this.EditBtn.Image = global::LoBridge.Properties.Resources.edit;
            this.EditBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(39, 40);
            this.EditBtn.Text = "&New";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // ShipmentBindingNavigator
            // 
            this.ShipmentBindingNavigator.AddNewItem = null;
            this.ShipmentBindingNavigator.CountItem = null;
            this.ShipmentBindingNavigator.CountItemFormat = "من {0}";
            this.ShipmentBindingNavigator.DeleteItem = null;
            this.ShipmentBindingNavigator.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipmentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ShipmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator,
            this.shipmentBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.EditBtn,
            this.toolStripSeparator3,
            this.RefreshBtn,
            this.toolStripSeparator4,
            this.printToolStripButton,
            this.toolStripSeparator6,
            this.toolStripButton1});
            this.ShipmentBindingNavigator.Location = new System.Drawing.Point(9, 9);
            this.ShipmentBindingNavigator.MoveFirstItem = null;
            this.ShipmentBindingNavigator.MoveLastItem = null;
            this.ShipmentBindingNavigator.MoveNextItem = null;
            this.ShipmentBindingNavigator.MovePreviousItem = null;
            this.ShipmentBindingNavigator.Name = "ShipmentBindingNavigator";
            this.ShipmentBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ShipmentBindingNavigator.PositionItem = null;
            this.ShipmentBindingNavigator.Size = new System.Drawing.Size(802, 43);
            this.ShipmentBindingNavigator.TabIndex = 36;
            this.ShipmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshBtn.Enabled = false;
            this.RefreshBtn.Image = global::LoBridge.Properties.Resources.refresh;
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(39, 40);
            this.RefreshBtn.Text = "toolStripButton1";
            this.RefreshBtn.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Enabled = false;
            this.printToolStripButton.Image = global::LoBridge.Properties.Resources.Print;
            this.printToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(39, 40);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LoBridge.Properties.Resources.List;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(39, 40);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // transport_CoTableAdapter
            // 
            this.transport_CoTableAdapter.ClearBeforeFill = true;
            // 
            // shusernameTextBox
            // 
            this.shusernameTextBox.Location = new System.Drawing.Point(655, 215);
            this.shusernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shusernameTextBox.Name = "shusernameTextBox";
            this.shusernameTextBox.Size = new System.Drawing.Size(85, 30);
            this.shusernameTextBox.TabIndex = 39;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(775, 17);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(33, 30);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.iNdataset;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // INShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(820, 470);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShipmentBindingNavigator);
            this.Controls.Add(this.ship_RQtyTextBox);
            this.Controls.Add(ship_RQtyLabel);
            this.Controls.Add(shusernameLabel);
            this.Controls.Add(this.shusernameTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(838, 586);
            this.MinimumSize = new System.Drawing.Size(838, 511);
            this.Name = "INShipment";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شحنة جديدة";
            this.Load += new System.EventHandler(this.Shipping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transport_CoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentBindingNavigator)).EndInit();
            this.ShipmentBindingNavigator.ResumeLayout(false);
            this.ShipmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLWSDataSet dLWSDataSet;
        private System.Windows.Forms.TextBox contractTextBox;
        private System.Windows.Forms.TextBox shippingTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.ComboBox sUP_NAMEComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource commodityBindingSource;
        private DLWSDataSetTableAdapters.CommodityTableAdapter commodityTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ship_IDTextBox;
        private System.Windows.Forms.TextBox ship_RQtyTextBox;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton shipmentBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton EditBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.BindingNavigator ShipmentBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.ComboBox TransCo;
        private System.Windows.Forms.BindingSource transport_CoBindingSource;
        private DLWSDataSetTableAdapters.Transport_CoTableAdapter transport_CoTableAdapter;
        private System.Windows.Forms.TextBox shusernameTextBox;
        private System.Windows.Forms.TextBox lading_PortTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private INdataset iNdataset;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private INdatasetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
        private INdatasetTableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
        private System.Windows.Forms.ComboBox comm_NAMEComboBox;
    }
}