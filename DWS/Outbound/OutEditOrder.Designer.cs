namespace LoBridge
{
    partial class OutEditOrder
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
            System.Windows.Forms.Label order_IDLabel;
            System.Windows.Forms.Label contract_IDLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label remain_QtyLabel;
            System.Windows.Forms.Label order_NumberLabel;
            System.Windows.Forms.Label cust_IDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.order_IDTextBox = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outdataset = new LoBridge.Outdataset();
            this.contract_IDTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.order_NumberTextBox = new System.Windows.Forms.TextBox();
            this.cust_IDTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.remain_QtyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cust_Nametxtbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Contract_numComboBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new LoBridge.OutdatasetTableAdapters.OrderTableAdapter();
            this.contractTableAdapter = new LoBridge.OutdatasetTableAdapters.ContractTableAdapter();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new LoBridge.OutdatasetTableAdapters.CustomersTableAdapter();
            order_IDLabel = new System.Windows.Forms.Label();
            contract_IDLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            remain_QtyLabel = new System.Windows.Forms.Label();
            order_NumberLabel = new System.Windows.Forms.Label();
            cust_IDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // order_IDLabel
            // 
            order_IDLabel.AutoSize = true;
            order_IDLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            order_IDLabel.Location = new System.Drawing.Point(718, 43);
            order_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            order_IDLabel.Name = "order_IDLabel";
            order_IDLabel.Size = new System.Drawing.Size(80, 22);
            order_IDLabel.TabIndex = 1;
            order_IDLabel.Text = "كود امر التوريد";
            // 
            // contract_IDLabel
            // 
            contract_IDLabel.AutoSize = true;
            contract_IDLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contract_IDLabel.Location = new System.Drawing.Point(946, 33);
            contract_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contract_IDLabel.Name = "contract_IDLabel";
            contract_IDLabel.Size = new System.Drawing.Size(58, 22);
            contract_IDLabel.TabIndex = 3;
            contract_IDLabel.Text = "كود العقد";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(933, 135);
            dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(78, 22);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "تاريخ التسجيل";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(933, 179);
            notesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(53, 22);
            notesLabel.TabIndex = 15;
            notesLabel.Text = "ملاحظات";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(441, 42);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(58, 22);
            statusLabel.TabIndex = 17;
            statusLabel.Text = "حالة الامر";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyLabel.Location = new System.Drawing.Point(933, 83);
            qtyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(84, 22);
            qtyLabel.TabIndex = 19;
            qtyLabel.Text = "كمية امر التوريد";
            // 
            // remain_QtyLabel
            // 
            remain_QtyLabel.AutoSize = true;
            remain_QtyLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remain_QtyLabel.Location = new System.Drawing.Point(717, 86);
            remain_QtyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remain_QtyLabel.Name = "remain_QtyLabel";
            remain_QtyLabel.Size = new System.Drawing.Size(80, 22);
            remain_QtyLabel.TabIndex = 21;
            remain_QtyLabel.Text = "الكمية المتبيقية";
            // 
            // order_NumberLabel
            // 
            order_NumberLabel.AutoSize = true;
            order_NumberLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            order_NumberLabel.Location = new System.Drawing.Point(933, 42);
            order_NumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            order_NumberLabel.Name = "order_NumberLabel";
            order_NumberLabel.Size = new System.Drawing.Size(79, 22);
            order_NumberLabel.TabIndex = 25;
            order_NumberLabel.Text = "رقم امر التوريد";
            // 
            // cust_IDLabel
            // 
            cust_IDLabel.AutoSize = true;
            cust_IDLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cust_IDLabel.Location = new System.Drawing.Point(928, 38);
            cust_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cust_IDLabel.Name = "cust_IDLabel";
            cust_IDLabel.Size = new System.Drawing.Size(63, 22);
            cust_IDLabel.TabIndex = 27;
            cust_IDLabel.Text = "كود العميل";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(707, 41);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 22);
            label1.TabIndex = 27;
            label1.Text = "اسم العميل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(716, 33);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 22);
            label2.TabIndex = 3;
            label2.Text = "رقم العقد";
            // 
            // order_IDTextBox
            // 
            this.order_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Order_ID", true));
            this.order_IDTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_IDTextBox.Location = new System.Drawing.Point(519, 41);
            this.order_IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.order_IDTextBox.Name = "order_IDTextBox";
            this.order_IDTextBox.ReadOnly = true;
            this.order_IDTextBox.Size = new System.Drawing.Size(190, 30);
            this.order_IDTextBox.TabIndex = 2;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.outdataset;
            // 
            // outdataset
            // 
            this.outdataset.DataSetName = "Outdataset";
            this.outdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contract_IDTextBox
            // 
            this.contract_IDTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_IDTextBox.Location = new System.Drawing.Point(811, 30);
            this.contract_IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contract_IDTextBox.Name = "contract_IDTextBox";
            this.contract_IDTextBox.ReadOnly = true;
            this.contract_IDTextBox.Size = new System.Drawing.Size(113, 30);
            this.contract_IDTextBox.TabIndex = 4;
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Date", true));
            this.dateTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(519, 127);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(405, 30);
            this.dateTextBox.TabIndex = 10;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(228, 176);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(696, 68);
            this.notesTextBox.TabIndex = 16;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Status", true));
            this.statusTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.Location = new System.Drawing.Point(315, 40);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(118, 30);
            this.statusTextBox.TabIndex = 18;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Qty", true));
            this.qtyTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextBox.Location = new System.Drawing.Point(811, 80);
            this.qtyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(113, 30);
            this.qtyTextBox.TabIndex = 20;
            this.qtyTextBox.TextChanged += new System.EventHandler(this.qtyTextBox_TextChanged);
            // 
            // order_NumberTextBox
            // 
            this.order_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Order_Number", true));
            this.order_NumberTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_NumberTextBox.Location = new System.Drawing.Point(811, 43);
            this.order_NumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.order_NumberTextBox.Name = "order_NumberTextBox";
            this.order_NumberTextBox.Size = new System.Drawing.Size(113, 30);
            this.order_NumberTextBox.TabIndex = 26;
            // 
            // cust_IDTextBox
            // 
            this.cust_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Cust_ID", true));
            this.cust_IDTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_IDTextBox.Location = new System.Drawing.Point(811, 35);
            this.cust_IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cust_IDTextBox.Name = "cust_IDTextBox";
            this.cust_IDTextBox.Size = new System.Drawing.Size(113, 30);
            this.cust_IDTextBox.TabIndex = 28;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.Enabled = false;
            this.orderBindingNavigatorSaveItem.Image = global::LoBridge.Properties.Resources.save3;
            this.orderBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(88, 39);
            this.orderBindingNavigatorSaveItem.Text = "حفظ";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = null;
            this.orderBindingNavigator.BackColor = System.Drawing.Color.White;
            this.orderBindingNavigator.CountItem = null;
            this.orderBindingNavigator.DeleteItem = null;
            this.orderBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.orderBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.MoveFirstItem = null;
            this.orderBindingNavigator.MoveLastItem = null;
            this.orderBindingNavigator.MoveNextItem = null;
            this.orderBindingNavigator.MovePreviousItem = null;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.orderBindingNavigator.PositionItem = null;
            this.orderBindingNavigator.Size = new System.Drawing.Size(1021, 42);
            this.orderBindingNavigator.TabIndex = 0;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            this.orderBindingNavigator.RefreshItems += new System.EventHandler(this.orderBindingNavigator_RefreshItems);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(965, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 42);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1021, 481);
            this.panel1.TabIndex = 114;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.order_NumberTextBox);
            this.groupBox1.Controls.Add(this.metroToggle1);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(notesLabel);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Controls.Add(this.notesTextBox);
            this.groupBox1.Controls.Add(order_NumberLabel);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(qtyLabel);
            this.groupBox1.Controls.Add(this.dateTextBox);
            this.groupBox1.Controls.Add(this.qtyTextBox);
            this.groupBox1.Controls.Add(order_IDLabel);
            this.groupBox1.Controls.Add(remain_QtyLabel);
            this.groupBox1.Controls.Add(this.remain_QtyTextBox);
            this.groupBox1.Controls.Add(this.order_IDTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1021, 309);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات امر التوريد";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroToggle1.Location = new System.Drawing.Point(228, 42);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 23);
            this.metroToggle1.TabIndex = 30;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseStyleColors = true;
            this.metroToggle1.UseVisualStyleBackColor = true;
            this.metroToggle1.CheckStateChanged += new System.EventHandler(this.metroToggle1_CheckStateChanged);
            // 
            // remain_QtyTextBox
            // 
            this.remain_QtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Remain_Qty", true));
            this.remain_QtyTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remain_QtyTextBox.Location = new System.Drawing.Point(519, 78);
            this.remain_QtyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.remain_QtyTextBox.Name = "remain_QtyTextBox";
            this.remain_QtyTextBox.ReadOnly = true;
            this.remain_QtyTextBox.Size = new System.Drawing.Size(190, 30);
            this.remain_QtyTextBox.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.Cust_Nametxtbox);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(this.cust_IDTextBox);
            this.groupBox3.Controls.Add(cust_IDLabel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1021, 85);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات العميل ";
            // 
            // Cust_Nametxtbox
            // 
            this.Cust_Nametxtbox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_Nametxtbox.Location = new System.Drawing.Point(228, 35);
            this.Cust_Nametxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.Cust_Nametxtbox.Name = "Cust_Nametxtbox";
            this.Cust_Nametxtbox.ReadOnly = true;
            this.Cust_Nametxtbox.Size = new System.Drawing.Size(481, 30);
            this.Cust_Nametxtbox.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.Contract_numComboBox);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.contract_IDTextBox);
            this.groupBox2.Controls.Add(contract_IDLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(0, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1021, 82);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العقد ";
            // 
            // Contract_numComboBox
            // 
            this.Contract_numComboBox.FormattingEnabled = true;
            this.Contract_numComboBox.Location = new System.Drawing.Point(516, 29);
            this.Contract_numComboBox.Name = "Contract_numComboBox";
            this.Contract_numComboBox.Size = new System.Drawing.Size(193, 27);
            this.Contract_numComboBox.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(415, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 23);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "تغيير العقد";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.outdataset;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.outdataset;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // OutEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 523);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderBindingNavigator);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1037, 562);
            this.Name = "OutEditOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات امر توريد";
            this.Load += new System.EventHandler(this.DEOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox order_IDTextBox;
        private System.Windows.Forms.TextBox contract_IDTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox order_NumberTextBox;
        private System.Windows.Forms.TextBox cust_IDTextBox;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox remain_QtyTextBox;
        private Outdataset outdataset;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private OutdatasetTableAdapters.OrderTableAdapter orderTableAdapter;
        private OutdatasetTableAdapters.ContractTableAdapter contractTableAdapter;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private OutdatasetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Cust_Nametxtbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Contract_numComboBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}