namespace LoBridge
{
    partial class OUTOrder
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
            System.Windows.Forms.Label order_NumberLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label start_DateLabel;
            System.Windows.Forms.Label end_DateLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label contract_NumberLabel;
            System.Windows.Forms.Label cust_NameLabel;
            System.Windows.Forms.Label remain_QTYLabel1;
            System.Windows.Forms.Label comm_NAMELabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label qtyLabel1;
            System.Windows.Forms.Label label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cust_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.order_NumberTextBox = new System.Windows.Forms.TextBox();
            this.OrderqtyTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.end_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.start_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ContractqtyTextBox = new System.Windows.Forms.TextBox();
            this.comm_NAMETextBox = new System.Windows.Forms.TextBox();
            this.Contract_numComboBox = new System.Windows.Forms.ComboBox();
            this.remain_ContractQTYTextBox1 = new System.Windows.Forms.TextBox();
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            order_NumberLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            start_DateLabel = new System.Windows.Forms.Label();
            end_DateLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            contract_NumberLabel = new System.Windows.Forms.Label();
            cust_NameLabel = new System.Windows.Forms.Label();
            remain_QTYLabel1 = new System.Windows.Forms.Label();
            comm_NAMELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            qtyLabel1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // order_NumberLabel
            // 
            order_NumberLabel.AutoSize = true;
            order_NumberLabel.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            order_NumberLabel.Location = new System.Drawing.Point(813, 40);
            order_NumberLabel.Name = "order_NumberLabel";
            order_NumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            order_NumberLabel.Size = new System.Drawing.Size(106, 26);
            order_NumberLabel.TabIndex = 2;
            order_NumberLabel.Text = "رقم امر التوريد:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyLabel.Location = new System.Drawing.Point(813, 81);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            qtyLabel.Size = new System.Drawing.Size(57, 26);
            qtyLabel.TabIndex = 6;
            qtyLabel.Text = "الكمية:";
            // 
            // start_DateLabel
            // 
            start_DateLabel.AutoSize = true;
            start_DateLabel.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            start_DateLabel.Location = new System.Drawing.Point(816, 166);
            start_DateLabel.Name = "start_DateLabel";
            start_DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            start_DateLabel.Size = new System.Drawing.Size(87, 26);
            start_DateLabel.TabIndex = 16;
            start_DateLabel.Text = "بداية العقد:";
            // 
            // end_DateLabel
            // 
            end_DateLabel.AutoSize = true;
            end_DateLabel.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            end_DateLabel.Location = new System.Drawing.Point(554, 168);
            end_DateLabel.Name = "end_DateLabel";
            end_DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            end_DateLabel.Size = new System.Drawing.Size(83, 26);
            end_DateLabel.TabIndex = 18;
            end_DateLabel.Text = "نهاية العقد:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(816, 213);
            notesLabel.Name = "notesLabel";
            notesLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            notesLabel.Size = new System.Drawing.Size(73, 26);
            notesLabel.TabIndex = 22;
            notesLabel.Text = "ملاحظات:";
            // 
            // contract_NumberLabel
            // 
            contract_NumberLabel.AutoEllipsis = true;
            contract_NumberLabel.AutoSize = true;
            contract_NumberLabel.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contract_NumberLabel.Location = new System.Drawing.Point(835, 25);
            contract_NumberLabel.Name = "contract_NumberLabel";
            contract_NumberLabel.Size = new System.Drawing.Size(77, 26);
            contract_NumberLabel.TabIndex = 25;
            contract_NumberLabel.Text = "رقم العقد:";
            // 
            // cust_NameLabel
            // 
            cust_NameLabel.AutoSize = true;
            cust_NameLabel.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cust_NameLabel.Location = new System.Drawing.Point(811, 124);
            cust_NameLabel.Name = "cust_NameLabel";
            cust_NameLabel.Size = new System.Drawing.Size(90, 26);
            cust_NameLabel.TabIndex = 27;
            cust_NameLabel.Text = "اسم العميل:";
            // 
            // remain_QTYLabel1
            // 
            remain_QTYLabel1.AutoSize = true;
            remain_QTYLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remain_QTYLabel1.Location = new System.Drawing.Point(408, 66);
            remain_QTYLabel1.Name = "remain_QTYLabel1";
            remain_QTYLabel1.Size = new System.Drawing.Size(106, 26);
            remain_QTYLabel1.TabIndex = 28;
            remain_QTYLabel1.Text = "الكمية المتبقية:";
            // 
            // comm_NAMELabel
            // 
            comm_NAMELabel.AutoSize = true;
            comm_NAMELabel.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comm_NAMELabel.Location = new System.Drawing.Point(835, 68);
            comm_NAMELabel.Name = "comm_NAMELabel";
            comm_NAMELabel.Size = new System.Drawing.Size(65, 26);
            comm_NAMELabel.TabIndex = 34;
            comm_NAMELabel.Text = "الصنف:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(459, 89);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 26);
            label1.TabIndex = 24;
            label1.Text = "طن";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(180, 72);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 26);
            label2.TabIndex = 25;
            label2.Text = "طن";
            // 
            // qtyLabel1
            // 
            qtyLabel1.AutoSize = true;
            qtyLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyLabel1.Location = new System.Drawing.Point(408, 25);
            qtyLabel1.Name = "qtyLabel1";
            qtyLabel1.Size = new System.Drawing.Size(85, 26);
            qtyLabel1.TabIndex = 35;
            qtyLabel1.Text = "كمية العقد:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(180, 31);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 26);
            label3.TabIndex = 25;
            label3.Text = "طن";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.orderBindingNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(970, 588);
            this.panel1.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(10, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(46, 47);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.cust_NAMEComboBox);
            this.groupBox2.Controls.Add(this.order_NumberTextBox);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(order_NumberLabel);
            this.groupBox2.Controls.Add(this.OrderqtyTextBox);
            this.groupBox2.Controls.Add(notesLabel);
            this.groupBox2.Controls.Add(this.notesTextBox);
            this.groupBox2.Controls.Add(qtyLabel);
            this.groupBox2.Controls.Add(cust_NameLabel);
            this.groupBox2.Controls.Add(start_DateLabel);
            this.groupBox2.Controls.Add(this.end_DateDateTimePicker);
            this.groupBox2.Controls.Add(this.start_DateDateTimePicker);
            this.groupBox2.Controls.Add(end_DateLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(950, 395);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات امر البيع";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cust_NAMEComboBox
            // 
            this.cust_NAMEComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cust_NAMEComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cust_NAMEComboBox.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_NAMEComboBox.Location = new System.Drawing.Point(326, 121);
            this.cust_NAMEComboBox.Name = "cust_NAMEComboBox";
            this.cust_NAMEComboBox.Size = new System.Drawing.Size(482, 34);
            this.cust_NAMEComboBox.TabIndex = 40;
            this.cust_NAMEComboBox.Click += new System.EventHandler(this.cust_NAMEComboBox_Click);
            // 
            // order_NumberTextBox
            // 
            this.order_NumberTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.order_NumberTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_NumberTextBox.Location = new System.Drawing.Point(495, 35);
            this.order_NumberTextBox.Name = "order_NumberTextBox";
            this.order_NumberTextBox.Size = new System.Drawing.Size(312, 37);
            this.order_NumberTextBox.TabIndex = 39;
            this.order_NumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.order_NumberTextBox_KeyDown_1);
            this.order_NumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.order_NumberTextBox_KeyPress);
            this.order_NumberTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.order_NumberTextBox_PreviewKeyDown);
            // 
            // OrderqtyTextBox
            // 
            this.OrderqtyTextBox.BackColor = System.Drawing.Color.White;
            this.OrderqtyTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderqtyTextBox.Location = new System.Drawing.Point(495, 78);
            this.OrderqtyTextBox.Name = "OrderqtyTextBox";
            this.OrderqtyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderqtyTextBox.Size = new System.Drawing.Size(313, 37);
            this.OrderqtyTextBox.TabIndex = 7;
            // 
            // notesTextBox
            // 
            this.notesTextBox.BackColor = System.Drawing.Color.White;
            this.notesTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(326, 210);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notesTextBox.Size = new System.Drawing.Size(482, 61);
            this.notesTextBox.TabIndex = 23;
            // 
            // end_DateDateTimePicker
            // 
            this.end_DateDateTimePicker.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_DateDateTimePicker.Location = new System.Drawing.Point(327, 161);
            this.end_DateDateTimePicker.Name = "end_DateDateTimePicker";
            this.end_DateDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.end_DateDateTimePicker.RightToLeftLayout = true;
            this.end_DateDateTimePicker.Size = new System.Drawing.Size(221, 37);
            this.end_DateDateTimePicker.TabIndex = 19;
            // 
            // start_DateDateTimePicker
            // 
            this.start_DateDateTimePicker.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_DateDateTimePicker.Location = new System.Drawing.Point(669, 161);
            this.start_DateDateTimePicker.Name = "start_DateDateTimePicker";
            this.start_DateDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.start_DateDateTimePicker.RightToLeftLayout = true;
            this.start_DateDateTimePicker.Size = new System.Drawing.Size(138, 37);
            this.start_DateDateTimePicker.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(qtyLabel1);
            this.groupBox1.Controls.Add(this.ContractqtyTextBox);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(comm_NAMELabel);
            this.groupBox1.Controls.Add(this.comm_NAMETextBox);
            this.groupBox1.Controls.Add(this.Contract_numComboBox);
            this.groupBox1.Controls.Add(remain_QTYLabel1);
            this.groupBox1.Controls.Add(this.remain_ContractQTYTextBox1);
            this.groupBox1.Controls.Add(contract_NumberLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(10, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(950, 130);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العقد";
            // 
            // ContractqtyTextBox
            // 
            this.ContractqtyTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractqtyTextBox.Location = new System.Drawing.Point(221, 20);
            this.ContractqtyTextBox.Name = "ContractqtyTextBox";
            this.ContractqtyTextBox.Size = new System.Drawing.Size(181, 37);
            this.ContractqtyTextBox.TabIndex = 36;
            // 
            // comm_NAMETextBox
            // 
            this.comm_NAMETextBox.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comm_NAMETextBox.Location = new System.Drawing.Point(602, 65);
            this.comm_NAMETextBox.Name = "comm_NAMETextBox";
            this.comm_NAMETextBox.Size = new System.Drawing.Size(227, 37);
            this.comm_NAMETextBox.TabIndex = 35;
            // 
            // Contract_numComboBox
            // 
            this.Contract_numComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Contract_numComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Contract_numComboBox.BackColor = System.Drawing.Color.LightBlue;
            this.Contract_numComboBox.DisplayMember = "Contract_ID";
            this.Contract_numComboBox.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contract_numComboBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Contract_numComboBox.FormattingEnabled = true;
            this.Contract_numComboBox.Location = new System.Drawing.Point(602, 22);
            this.Contract_numComboBox.Name = "Contract_numComboBox";
            this.Contract_numComboBox.Size = new System.Drawing.Size(227, 34);
            this.Contract_numComboBox.TabIndex = 33;
            this.Contract_numComboBox.ValueMember = "Contract_ID";
            this.Contract_numComboBox.TextChanged += new System.EventHandler(this.comm_NAMEComboBox_TextChanged);
            // 
            // remain_ContractQTYTextBox1
            // 
            this.remain_ContractQTYTextBox1.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remain_ContractQTYTextBox1.Location = new System.Drawing.Point(221, 63);
            this.remain_ContractQTYTextBox1.Name = "remain_ContractQTYTextBox1";
            this.remain_ContractQTYTextBox1.Size = new System.Drawing.Size(181, 37);
            this.remain_ContractQTYTextBox1.TabIndex = 29;
            this.remain_ContractQTYTextBox1.TextChanged += new System.EventHandler(this.remain_ContractQTYTextBox1_TextChanged);
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = null;
            this.orderBindingNavigator.CountItem = null;
            this.orderBindingNavigator.DeleteItem = null;
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator,
            this.orderBindingNavigatorSaveItem,
            this.bindingNavigatorSeparator2});
            this.orderBindingNavigator.Location = new System.Drawing.Point(10, 10);
            this.orderBindingNavigator.MoveFirstItem = null;
            this.orderBindingNavigator.MoveLastItem = null;
            this.orderBindingNavigator.MoveNextItem = null;
            this.orderBindingNavigator.MovePreviousItem = null;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.orderBindingNavigator.PositionItem = null;
            this.orderBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderBindingNavigator.Size = new System.Drawing.Size(950, 43);
            this.orderBindingNavigator.TabIndex = 1;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::LoBridge.Properties.Resources.add2;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(69, 40);
            this.bindingNavigatorAddNewItem.Text = "جديد";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = global::LoBridge.Properties.Resources.cancel;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(71, 40);
            this.bindingNavigatorDeleteItem.Text = "الغاء";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.Enabled = false;
            this.orderBindingNavigatorSaveItem.Image = global::LoBridge.Properties.Resources.save3;
            this.orderBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 40);
            this.orderBindingNavigatorSaveItem.Text = "حفظ";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // OUTOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(970, 588);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(986, 627);
            this.Name = "OUTOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "امر اوريد";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OUTOrder_FormClosing);
            this.Load += new System.EventHandler(this.OrderOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox OrderqtyTextBox;
        private System.Windows.Forms.DateTimePicker start_DateDateTimePicker;
        private System.Windows.Forms.DateTimePicker end_DateDateTimePicker;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox remain_ContractQTYTextBox1;
        private System.Windows.Forms.ComboBox Contract_numComboBox;
        private System.Windows.Forms.TextBox comm_NAMETextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ContractqtyTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox order_NumberTextBox;
        private System.Windows.Forms.ComboBox cust_NAMEComboBox;
    }
}