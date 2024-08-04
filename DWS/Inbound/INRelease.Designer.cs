namespace LoBridge
{
    partial class INRelease
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
            System.Windows.Forms.Label serialLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label arrivalDateLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label ship_IDLabel1;
            System.Windows.Forms.Label shippingLabel;
            System.Windows.Forms.Label supp_NameLabel;
            System.Windows.Forms.Label comm_NAMELabel;
            System.Windows.Forms.Label notesLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label ship_RQtyLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label qtyLabel1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label contractLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.BatchqtyTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contractTextBox = new System.Windows.Forms.TextBox();
            this.shipToReleaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNdataset = new LoBridge.INdataset();
            this.sUP_NAMETextBox = new System.Windows.Forms.TextBox();
            this.comm_NAMETextBox = new System.Windows.Forms.TextBox();
            this.ship_RQtyTextBox = new System.Windows.Forms.TextBox();
            this.shipqtyTextBox1 = new System.Windows.Forms.TextBox();
            this.notesTextBox1 = new System.Windows.Forms.TextBox();
            this.ship_IDComboBox = new System.Windows.Forms.ComboBox();
            this.shippingComboBox = new System.Windows.Forms.ComboBox();
            this.commodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dLWSDataSet1 = new LoBridge.DLWSDataSet();
            this.dLWSDataSet = new LoBridge.DLWSDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ExitBtn = new System.Windows.Forms.Button();
            this.commodityTableAdapter = new LoBridge.DLWSDataSetTableAdapters.CommodityTableAdapter();
            this.shipToReleaseTableAdapter = new LoBridge.INdatasetTableAdapters.ShipToReleaseTableAdapter();
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNBatchTableAdapter = new LoBridge.INdatasetTableAdapters.INBatchTableAdapter();
            this.sUPPLIERSTableAdapter = new LoBridge.INdatasetTableAdapters.SUPPLIERSTableAdapter();
            this.tableAdapterManager = new LoBridge.INdatasetTableAdapters.TableAdapterManager();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.iNBatchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.iNBatchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            serialLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            arrivalDateLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ship_IDLabel1 = new System.Windows.Forms.Label();
            shippingLabel = new System.Windows.Forms.Label();
            supp_NameLabel = new System.Windows.Forms.Label();
            comm_NAMELabel = new System.Windows.Forms.Label();
            notesLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ship_RQtyLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            qtyLabel1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            contractLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipToReleaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNBatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNBatchBindingNavigator)).BeginInit();
            this.iNBatchBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialLabel
            // 
            serialLabel.AutoSize = true;
            serialLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serialLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            serialLabel.Location = new System.Drawing.Point(992, 38);
            serialLabel.Name = "serialLabel";
            serialLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            serialLabel.Size = new System.Drawing.Size(129, 25);
            serialLabel.TabIndex = 4;
            serialLabel.Text = "رقم الافراج/الدفعة:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            qtyLabel.Location = new System.Drawing.Point(994, 81);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            qtyLabel.Size = new System.Drawing.Size(56, 25);
            qtyLabel.TabIndex = 6;
            qtyLabel.Text = "الكمية:";
            // 
            // arrivalDateLabel
            // 
            arrivalDateLabel.AutoSize = true;
            arrivalDateLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            arrivalDateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            arrivalDateLabel.Location = new System.Drawing.Point(994, 119);
            arrivalDateLabel.Name = "arrivalDateLabel";
            arrivalDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            arrivalDateLabel.Size = new System.Drawing.Size(96, 25);
            arrivalDateLabel.TabIndex = 12;
            arrivalDateLabel.Text = "تاريخ الوصول:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            notesLabel.Location = new System.Drawing.Point(994, 160);
            notesLabel.Name = "notesLabel";
            notesLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            notesLabel.Size = new System.Drawing.Size(69, 25);
            notesLabel.TabIndex = 16;
            notesLabel.Text = "ملاحظات:";
            // 
            // ship_IDLabel1
            // 
            ship_IDLabel1.AutoSize = true;
            ship_IDLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ship_IDLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            ship_IDLabel1.Location = new System.Drawing.Point(994, 69);
            ship_IDLabel1.Name = "ship_IDLabel1";
            ship_IDLabel1.Size = new System.Drawing.Size(86, 25);
            ship_IDLabel1.TabIndex = 19;
            ship_IDLabel1.Text = "رقم الشحنة:";
            // 
            // shippingLabel
            // 
            shippingLabel.AutoSize = true;
            shippingLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shippingLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            shippingLabel.Location = new System.Drawing.Point(994, 30);
            shippingLabel.Name = "shippingLabel";
            shippingLabel.Size = new System.Drawing.Size(62, 25);
            shippingLabel.TabIndex = 20;
            shippingLabel.Text = "الشحنة:";
            // 
            // supp_NameLabel
            // 
            supp_NameLabel.AutoSize = true;
            supp_NameLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supp_NameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            supp_NameLabel.Location = new System.Drawing.Point(992, 108);
            supp_NameLabel.Name = "supp_NameLabel";
            supp_NameLabel.Size = new System.Drawing.Size(77, 25);
            supp_NameLabel.TabIndex = 21;
            supp_NameLabel.Text = "اسم المورد:";
            // 
            // comm_NAMELabel
            // 
            comm_NAMELabel.AutoSize = true;
            comm_NAMELabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comm_NAMELabel.ForeColor = System.Drawing.SystemColors.ControlText;
            comm_NAMELabel.Location = new System.Drawing.Point(550, 112);
            comm_NAMELabel.Name = "comm_NAMELabel";
            comm_NAMELabel.Size = new System.Drawing.Size(62, 25);
            comm_NAMELabel.TabIndex = 24;
            comm_NAMELabel.Text = "الصنف:";
            // 
            // notesLabel1
            // 
            notesLabel1.AutoSize = true;
            notesLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            notesLabel1.Location = new System.Drawing.Point(994, 189);
            notesLabel1.Name = "notesLabel1";
            notesLabel1.Size = new System.Drawing.Size(69, 25);
            notesLabel1.TabIndex = 26;
            notesLabel1.Text = "ملاحظات:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(751, 74);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(33, 25);
            label1.TabIndex = 4;
            label1.Text = "طن";
            // 
            // ship_RQtyLabel
            // 
            ship_RQtyLabel.AutoSize = true;
            ship_RQtyLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ship_RQtyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            ship_RQtyLabel.Location = new System.Drawing.Point(550, 67);
            ship_RQtyLabel.Name = "ship_RQtyLabel";
            ship_RQtyLabel.Size = new System.Drawing.Size(102, 25);
            ship_RQtyLabel.TabIndex = 28;
            ship_RQtyLabel.Text = "الكمية المتبقية:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(256, 69);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(33, 25);
            label2.TabIndex = 18;
            label2.Text = "طن";
            // 
            // qtyLabel1
            // 
            qtyLabel1.AutoSize = true;
            qtyLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            qtyLabel1.Location = new System.Drawing.Point(550, 30);
            qtyLabel1.Name = "qtyLabel1";
            qtyLabel1.Size = new System.Drawing.Size(56, 25);
            qtyLabel1.TabIndex = 30;
            qtyLabel1.Text = "الكمية:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(256, 30);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(33, 25);
            label3.TabIndex = 32;
            label3.Text = "طن";
            // 
            // contractLabel
            // 
            contractLabel.AutoSize = true;
            contractLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contractLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            contractLabel.Location = new System.Drawing.Point(994, 147);
            contractLabel.Name = "contractLabel";
            contractLabel.Size = new System.Drawing.Size(75, 25);
            contractLabel.TabIndex = 35;
            contractLabel.Text = "رقم العقد:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(2, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 555);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.serialTextBox);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(serialLabel);
            this.groupBox2.Controls.Add(this.notesTextBox);
            this.groupBox2.Controls.Add(qtyLabel);
            this.groupBox2.Controls.Add(notesLabel);
            this.groupBox2.Controls.Add(this.BatchqtyTextBox);
            this.groupBox2.Controls.Add(this.arrivalDateDateTimePicker);
            this.groupBox2.Controls.Add(arrivalDateLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.groupBox2.Location = new System.Drawing.Point(0, 268);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1137, 287);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الافراج";
            // 
            // serialTextBox
            // 
            this.serialTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.serialTextBox.Location = new System.Drawing.Point(791, 28);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serialTextBox.Size = new System.Drawing.Size(197, 35);
            this.serialTextBox.TabIndex = 5;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notesTextBox.Location = new System.Drawing.Point(323, 157);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notesTextBox.Size = new System.Drawing.Size(665, 69);
            this.notesTextBox.TabIndex = 17;
            // 
            // BatchqtyTextBox
            // 
            this.BatchqtyTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchqtyTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BatchqtyTextBox.Location = new System.Drawing.Point(791, 71);
            this.BatchqtyTextBox.Name = "BatchqtyTextBox";
            this.BatchqtyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BatchqtyTextBox.Size = new System.Drawing.Size(197, 35);
            this.BatchqtyTextBox.TabIndex = 7;
            this.BatchqtyTextBox.TextChanged += new System.EventHandler(this.qtyTextBox_TextChanged);
            // 
            // arrivalDateDateTimePicker
            // 
            this.arrivalDateDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.arrivalDateDateTimePicker.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.arrivalDateDateTimePicker.Location = new System.Drawing.Point(743, 114);
            this.arrivalDateDateTimePicker.Name = "arrivalDateDateTimePicker";
            this.arrivalDateDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.arrivalDateDateTimePicker.RightToLeftLayout = true;
            this.arrivalDateDateTimePicker.Size = new System.Drawing.Size(245, 35);
            this.arrivalDateDateTimePicker.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(contractLabel);
            this.groupBox1.Controls.Add(this.contractTextBox);
            this.groupBox1.Controls.Add(this.sUP_NAMETextBox);
            this.groupBox1.Controls.Add(this.comm_NAMETextBox);
            this.groupBox1.Controls.Add(this.ship_RQtyTextBox);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(qtyLabel1);
            this.groupBox1.Controls.Add(this.shipqtyTextBox1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(notesLabel1);
            this.groupBox1.Controls.Add(this.notesTextBox1);
            this.groupBox1.Controls.Add(comm_NAMELabel);
            this.groupBox1.Controls.Add(supp_NameLabel);
            this.groupBox1.Controls.Add(ship_IDLabel1);
            this.groupBox1.Controls.Add(shippingLabel);
            this.groupBox1.Controls.Add(ship_RQtyLabel);
            this.groupBox1.Controls.Add(this.ship_IDComboBox);
            this.groupBox1.Controls.Add(this.shippingComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1137, 268);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الشحنة";
            // 
            // contractTextBox
            // 
            this.contractTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipToReleaseBindingSource, "Contract", true));
            this.contractTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contractTextBox.Location = new System.Drawing.Point(737, 146);
            this.contractTextBox.Name = "contractTextBox";
            this.contractTextBox.ReadOnly = true;
            this.contractTextBox.Size = new System.Drawing.Size(251, 35);
            this.contractTextBox.TabIndex = 36;
            // 
            // shipToReleaseBindingSource
            // 
            this.shipToReleaseBindingSource.DataMember = "ShipToRelease";
            this.shipToReleaseBindingSource.DataSource = this.iNdataset;
            // 
            // iNdataset
            // 
            this.iNdataset.DataSetName = "INdataset";
            this.iNdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUP_NAMETextBox
            // 
            this.sUP_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipToReleaseBindingSource, "SUP_NAME", true));
            this.sUP_NAMETextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sUP_NAMETextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sUP_NAMETextBox.Location = new System.Drawing.Point(737, 105);
            this.sUP_NAMETextBox.Name = "sUP_NAMETextBox";
            this.sUP_NAMETextBox.ReadOnly = true;
            this.sUP_NAMETextBox.Size = new System.Drawing.Size(251, 35);
            this.sUP_NAMETextBox.TabIndex = 35;
            // 
            // comm_NAMETextBox
            // 
            this.comm_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipToReleaseBindingSource, "Comm_NAME", true));
            this.comm_NAMETextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comm_NAMETextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comm_NAMETextBox.Location = new System.Drawing.Point(295, 105);
            this.comm_NAMETextBox.Name = "comm_NAMETextBox";
            this.comm_NAMETextBox.ReadOnly = true;
            this.comm_NAMETextBox.Size = new System.Drawing.Size(249, 35);
            this.comm_NAMETextBox.TabIndex = 34;
            // 
            // ship_RQtyTextBox
            // 
            this.ship_RQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipToReleaseBindingSource, "Ship_RQty", true));
            this.ship_RQtyTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ship_RQtyTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ship_RQtyTextBox.Location = new System.Drawing.Point(295, 64);
            this.ship_RQtyTextBox.Name = "ship_RQtyTextBox";
            this.ship_RQtyTextBox.ReadOnly = true;
            this.ship_RQtyTextBox.Size = new System.Drawing.Size(249, 35);
            this.ship_RQtyTextBox.TabIndex = 33;
            // 
            // shipqtyTextBox1
            // 
            this.shipqtyTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipToReleaseBindingSource, "Qty", true));
            this.shipqtyTextBox1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipqtyTextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shipqtyTextBox1.Location = new System.Drawing.Point(295, 23);
            this.shipqtyTextBox1.Name = "shipqtyTextBox1";
            this.shipqtyTextBox1.ReadOnly = true;
            this.shipqtyTextBox1.Size = new System.Drawing.Size(249, 35);
            this.shipqtyTextBox1.TabIndex = 31;
            // 
            // notesTextBox1
            // 
            this.notesTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipToReleaseBindingSource, "Notes", true));
            this.notesTextBox1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notesTextBox1.Location = new System.Drawing.Point(295, 189);
            this.notesTextBox1.Multiline = true;
            this.notesTextBox1.Name = "notesTextBox1";
            this.notesTextBox1.ReadOnly = true;
            this.notesTextBox1.Size = new System.Drawing.Size(693, 56);
            this.notesTextBox1.TabIndex = 27;
            // 
            // ship_IDComboBox
            // 
            this.ship_IDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ship_IDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ship_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipToReleaseBindingSource, "Ship_ID", true));
            this.ship_IDComboBox.DataSource = this.shipToReleaseBindingSource;
            this.ship_IDComboBox.DisplayMember = "Ship_ID";
            this.ship_IDComboBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ship_IDComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ship_IDComboBox.FormattingEnabled = true;
            this.ship_IDComboBox.Location = new System.Drawing.Point(737, 66);
            this.ship_IDComboBox.Name = "ship_IDComboBox";
            this.ship_IDComboBox.Size = new System.Drawing.Size(251, 33);
            this.ship_IDComboBox.TabIndex = 20;
            this.ship_IDComboBox.ValueMember = "Ship_ID";
            // 
            // shippingComboBox
            // 
            this.shippingComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.shippingComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.shippingComboBox.DataSource = this.shipToReleaseBindingSource;
            this.shippingComboBox.DisplayMember = "Shipping";
            this.shippingComboBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shippingComboBox.FormattingEnabled = true;
            this.shippingComboBox.Location = new System.Drawing.Point(737, 27);
            this.shippingComboBox.Name = "shippingComboBox";
            this.shippingComboBox.Size = new System.Drawing.Size(251, 33);
            this.shippingComboBox.TabIndex = 21;
            this.shippingComboBox.ValueMember = "Shipping";
            // 
            // commodityBindingSource
            // 
            this.commodityBindingSource.DataMember = "Commodity";
            this.commodityBindingSource.DataSource = this.dLWSDataSet1;
            // 
            // dLWSDataSet1
            // 
            this.dLWSDataSet1.CaseSensitive = true;
            this.dLWSDataSet1.DataSetName = "DLWSDataSet";
            this.dLWSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dLWSDataSet
            // 
            this.dLWSDataSet.CaseSensitive = true;
            this.dLWSDataSet.DataSetName = "DLWSDataSet";
            this.dLWSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(1042, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(39, 40);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // commodityTableAdapter
            // 
            this.commodityTableAdapter.ClearBeforeFill = true;
            // 
            // shipToReleaseTableAdapter
            // 
            this.shipToReleaseTableAdapter.ClearBeforeFill = true;
            // 
            // sUPPLIERSBindingSource
            // 
            this.sUPPLIERSBindingSource.DataMember = "SUPPLIERS";
            this.sUPPLIERSBindingSource.DataSource = this.iNdataset;
            // 
            // iNBatchBindingSource
            // 
            this.iNBatchBindingSource.DataMember = "INBatch";
            this.iNBatchBindingSource.DataSource = this.iNdataset;
            // 
            // iNBatchTableAdapter
            // 
            this.iNBatchTableAdapter.ClearBeforeFill = true;
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.INBatchTableAdapter = this.iNBatchTableAdapter;
            this.tableAdapterManager.LadingTableAdapter = null;
            this.tableAdapterManager.ShipmentTableAdapter = null;
            this.tableAdapterManager.SUPPLIERSTableAdapter = this.sUPPLIERSTableAdapter;
            this.tableAdapterManager.UpdateOrder = LoBridge.INdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WcardIDTableAdapter = null;
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::LoBridge.Properties.Resources.add2;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(79, 40);
            this.bindingNavigatorAddNewItem.Text = "جديد";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // iNBatchBindingNavigatorSaveItem
            // 
            this.iNBatchBindingNavigatorSaveItem.Enabled = false;
            this.iNBatchBindingNavigatorSaveItem.Image = global::LoBridge.Properties.Resources.save3;
            this.iNBatchBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iNBatchBindingNavigatorSaveItem.Name = "iNBatchBindingNavigatorSaveItem";
            this.iNBatchBindingNavigatorSaveItem.Size = new System.Drawing.Size(77, 40);
            this.iNBatchBindingNavigatorSaveItem.Text = "حفظ";
            this.iNBatchBindingNavigatorSaveItem.Click += new System.EventHandler(this.iNBatchBindingNavigatorSaveItem_Click);
            this.iNBatchBindingNavigatorSaveItem.MouseHover += new System.EventHandler(this.iNBatchBindingNavigatorSaveItem_MouseHover);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = global::LoBridge.Properties.Resources.cancel;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(81, 40);
            this.bindingNavigatorDeleteItem.Text = "الغاء";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Enabled = false;
            this.RefreshBtn.Image = global::LoBridge.Properties.Resources.refresh;
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(91, 40);
            this.RefreshBtn.Text = "تحديث";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // iNBatchBindingNavigator
            // 
            this.iNBatchBindingNavigator.AddNewItem = null;
            this.iNBatchBindingNavigator.BackColor = System.Drawing.Color.White;
            this.iNBatchBindingNavigator.CountItem = null;
            this.iNBatchBindingNavigator.DeleteItem = null;
            this.iNBatchBindingNavigator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNBatchBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iNBatchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator,
            this.iNBatchBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.RefreshBtn,
            this.toolStripSeparator3});
            this.iNBatchBindingNavigator.Location = new System.Drawing.Point(2, 2);
            this.iNBatchBindingNavigator.MoveFirstItem = null;
            this.iNBatchBindingNavigator.MoveLastItem = null;
            this.iNBatchBindingNavigator.MoveNextItem = null;
            this.iNBatchBindingNavigator.MovePreviousItem = null;
            this.iNBatchBindingNavigator.Name = "iNBatchBindingNavigator";
            this.iNBatchBindingNavigator.PositionItem = null;
            this.iNBatchBindingNavigator.Size = new System.Drawing.Size(1137, 43);
            this.iNBatchBindingNavigator.TabIndex = 1;
            this.iNBatchBindingNavigator.Text = "bindingNavigator1";
            // 
            // INRelease
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1141, 602);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iNBatchBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1176, 803);
            this.Name = "INRelease";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة افراج جمركي";
            this.Load += new System.EventHandler(this.INBatch_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipToReleaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNBatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNBatchBindingNavigator)).EndInit();
            this.iNBatchBindingNavigator.ResumeLayout(false);
            this.iNBatchBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DLWSDataSet dLWSDataSet;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.TextBox BatchqtyTextBox;
        private System.Windows.Forms.DateTimePicker arrivalDateDateTimePicker;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.ComboBox shippingComboBox;
        private System.Windows.Forms.ComboBox ship_IDComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox notesTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox shipqtyTextBox1;
        private System.Windows.Forms.TextBox ship_RQtyTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private INdataset iNdataset;
        private System.Windows.Forms.BindingSource iNBatchBindingSource;
        private INdatasetTableAdapters.INBatchTableAdapter iNBatchTableAdapter;
        private DLWSDataSet dLWSDataSet1;
        private System.Windows.Forms.BindingSource commodityBindingSource;
        private DLWSDataSetTableAdapters.CommodityTableAdapter commodityTableAdapter;
        private INdatasetTableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
        private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
        private System.Windows.Forms.BindingSource shipToReleaseBindingSource;
        private INdatasetTableAdapters.ShipToReleaseTableAdapter shipToReleaseTableAdapter;
        private System.Windows.Forms.TextBox sUP_NAMETextBox;
        private System.Windows.Forms.TextBox comm_NAMETextBox;
        private System.Windows.Forms.TextBox contractTextBox;
        private INdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton iNBatchBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.BindingNavigator iNBatchBindingNavigator;
    }
}