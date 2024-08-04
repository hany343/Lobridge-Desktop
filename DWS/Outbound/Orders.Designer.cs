namespace LoBridge
{
    partial class Orders
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
            System.Windows.Forms.Label contract_IDLabel;
            System.Windows.Forms.Label contract_NumberLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label remain_QTYLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outDataSet = new LoBridge.Outdataset();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contract_NumberComboBox = new System.Windows.Forms.ComboBox();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contract_IDTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.remain_QTYTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.add_Button3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.orderTableAdapter = new LoBridge.OutdatasetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new LoBridge.OutdatasetTableAdapters.TableAdapterManager();
            this.contractTableAdapter = new LoBridge.OutdatasetTableAdapters.ContractTableAdapter();
            this.customersTableAdapter = new LoBridge.OutdatasetTableAdapters.CustomersTableAdapter();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OusernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allowed_qtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remain_QtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_IDColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Contract_IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            contract_IDLabel = new System.Windows.Forms.Label();
            contract_NumberLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            remain_QTYLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // contract_IDLabel
            // 
            contract_IDLabel.AutoSize = true;
            contract_IDLabel.ForeColor = System.Drawing.Color.White;
            contract_IDLabel.Location = new System.Drawing.Point(1096, 10);
            contract_IDLabel.Margin = new System.Windows.Forms.Padding(20, 5, 3, 0);
            contract_IDLabel.Name = "contract_IDLabel";
            contract_IDLabel.Size = new System.Drawing.Size(53, 13);
            contract_IDLabel.TabIndex = 0;
            contract_IDLabel.Text = "كود العقد:";
            // 
            // contract_NumberLabel
            // 
            contract_NumberLabel.AutoSize = true;
            contract_NumberLabel.ForeColor = System.Drawing.Color.White;
            contract_NumberLabel.Location = new System.Drawing.Point(1299, 10);
            contract_NumberLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            contract_NumberLabel.Name = "contract_NumberLabel";
            contract_NumberLabel.Size = new System.Drawing.Size(55, 13);
            contract_NumberLabel.TabIndex = 2;
            contract_NumberLabel.Text = "رقم العقد:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.ForeColor = System.Drawing.Color.White;
            qtyLabel.Location = new System.Drawing.Point(867, 10);
            qtyLabel.Margin = new System.Windows.Forms.Padding(20, 5, 3, 0);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(79, 13);
            qtyLabel.TabIndex = 4;
            qtyLabel.Text = "كمية العقد/طن:";
            // 
            // remain_QTYLabel
            // 
            remain_QTYLabel.AutoSize = true;
            remain_QTYLabel.ForeColor = System.Drawing.Color.White;
            remain_QTYLabel.Location = new System.Drawing.Point(681, 10);
            remain_QTYLabel.Margin = new System.Windows.Forms.Padding(20, 5, 3, 0);
            remain_QTYLabel.Name = "remain_QTYLabel";
            remain_QTYLabel.Size = new System.Drawing.Size(57, 13);
            remain_QTYLabel.TabIndex = 6;
            remain_QTYLabel.Text = "المتاح/طن:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.ForeColor = System.Drawing.Color.White;
            dateLabel.Location = new System.Drawing.Point(296, 10);
            dateLabel.Margin = new System.Windows.Forms.Padding(20, 5, 3, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(76, 13);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "تاريخ التسجيل:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = System.Drawing.Color.White;
            statusLabel.Location = new System.Drawing.Point(501, 10);
            statusLabel.Margin = new System.Windows.Forms.Padding(20, 5, 3, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(51, 13);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "الصلاحية:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderDataGridView);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.orderBindingNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 654);
            this.panel1.TabIndex = 0;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.CausesValidation = false;
            this.orderDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Order_NumberColumn,
            this.Contract_IDColumn,
            this.Cust_IDColumn,
            this.QtyColumn,
            this.Remain_QtyColumn,
            this.Allowed_qtyColumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.DateColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.OusernameColumn,
            this.StatusColumn,
            this.dataGridViewTextBoxColumn12});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.EnableHeadersVisualStyles = false;
            this.orderDataGridView.FilterAndSortEnabled = true;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 72);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderDataGridView.RowTemplate.Height = 30;
            this.orderDataGridView.Size = new System.Drawing.Size(1367, 582);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.orderDataGridView_DataError);
            this.orderDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.orderDataGridView_DefaultValuesNeeded);
            this.orderDataGridView.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.orderDataGridView_NewRowNeeded);
            this.orderDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_RowLeave);
            this.orderDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.orderDataGridView_RowsAdded);
            this.orderDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_RowValidated);
            this.orderDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.orderDataGridView_RowValidating);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.outDataSet;
            // 
            // outDataSet
            // 
            this.outDataSet.DataSetName = "OutDataSet";
            this.outDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.outDataSet;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Peru;
            this.flowLayoutPanel1.Controls.Add(contract_NumberLabel);
            this.flowLayoutPanel1.Controls.Add(this.contract_NumberComboBox);
            this.flowLayoutPanel1.Controls.Add(contract_IDLabel);
            this.flowLayoutPanel1.Controls.Add(this.contract_IDTextBox);
            this.flowLayoutPanel1.Controls.Add(qtyLabel);
            this.flowLayoutPanel1.Controls.Add(this.qtyTextBox);
            this.flowLayoutPanel1.Controls.Add(remain_QTYLabel);
            this.flowLayoutPanel1.Controls.Add(this.remain_QTYTextBox);
            this.flowLayoutPanel1.Controls.Add(statusLabel);
            this.flowLayoutPanel1.Controls.Add(this.statusTextBox);
            this.flowLayoutPanel1.Controls.Add(dateLabel);
            this.flowLayoutPanel1.Controls.Add(this.dateTextBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(1350, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1367, 33);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // contract_NumberComboBox
            // 
            this.contract_NumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.contract_NumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contract_NumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Contract_Number", true));
            this.contract_NumberComboBox.DataSource = this.contractBindingSource;
            this.contract_NumberComboBox.DisplayMember = "Contract_Number";
            this.contract_NumberComboBox.FormattingEnabled = true;
            this.contract_NumberComboBox.Location = new System.Drawing.Point(1172, 8);
            this.contract_NumberComboBox.Name = "contract_NumberComboBox";
            this.contract_NumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.contract_NumberComboBox.TabIndex = 3;
            this.contract_NumberComboBox.ValueMember = "Contract_Number";
            this.contract_NumberComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contract_NumberComboBox_MouseClick);
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.outDataSet;
            // 
            // contract_IDTextBox
            // 
            this.contract_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Contract_ID", true));
            this.contract_IDTextBox.Location = new System.Drawing.Point(969, 8);
            this.contract_IDTextBox.Name = "contract_IDTextBox";
            this.contract_IDTextBox.ReadOnly = true;
            this.contract_IDTextBox.Size = new System.Drawing.Size(121, 20);
            this.contract_IDTextBox.TabIndex = 1;
            this.contract_IDTextBox.TextChanged += new System.EventHandler(this.contract_IDTextBox_TextChanged);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Qty", true));
            this.qtyTextBox.Location = new System.Drawing.Point(761, 8);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.ReadOnly = true;
            this.qtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtyTextBox.TabIndex = 5;
            // 
            // remain_QTYTextBox
            // 
            this.remain_QTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Remain_QTY", true));
            this.remain_QTYTextBox.Location = new System.Drawing.Point(575, 8);
            this.remain_QTYTextBox.Name = "remain_QTYTextBox";
            this.remain_QTYTextBox.ReadOnly = true;
            this.remain_QTYTextBox.Size = new System.Drawing.Size(100, 20);
            this.remain_QTYTextBox.TabIndex = 7;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(395, 8);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 11;
            this.statusTextBox.TextChanged += new System.EventHandler(this.statusTextBox_TextChanged);
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(110, 8);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(180, 20);
            this.dateTextBox.TabIndex = 9;
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = null;
            this.orderBindingNavigator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.orderBindingNavigator.BindingSource = this.orderBindingSource;
            this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderBindingNavigator.CountItemFormat = "من {0}";
            this.orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderBindingNavigator.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.add_Button3,
            this.toolStripSeparator5,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.orderBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripSeparator6});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderBindingNavigator.Size = new System.Drawing.Size(1367, 39);
            this.orderBindingNavigator.TabIndex = 1;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 36);
            this.bindingNavigatorCountItem.Text = "من {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = global::LoBridge.Properties.Resources.delete_icon;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(79, 36);
            this.bindingNavigatorDeleteItem.Text = "حذف";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::LoBridge.Properties.Resources.Actions_go_first_view_icon;
            this.bindingNavigatorMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::LoBridge.Properties.Resources.Actions_go_previous_view_icon;
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 34);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::LoBridge.Properties.Resources.Actions_go_next_view_icon;
            this.bindingNavigatorMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::LoBridge.Properties.Resources.Actions_go_last_view_icon;
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // add_Button3
            // 
            this.add_Button3.Image = global::LoBridge.Properties.Resources.Add_icon;
            this.add_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.add_Button3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_Button3.Name = "add_Button3";
            this.add_Button3.Size = new System.Drawing.Size(78, 36);
            this.add_Button3.Text = "جديد";
            this.add_Button3.Click += new System.EventHandler(this.add_Button3_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.Image = global::LoBridge.Properties.Resources.Save_icon__1_;
            this.orderBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(80, 36);
            this.orderBindingNavigatorSaveItem.Text = "حفظ";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(129, 36);
            this.toolStripLabel1.Text = "بحث برقم امر التوريد";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.White;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 35);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.find_OTextBox1_KeyDown);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LoBridge.Properties.Resources.search_icon__2_1;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.find_OButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LoBridge.Properties.Resources.arrow_refresh_3_icon;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Lading_OutTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.UpdateOrder = LoBridge.OutdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WcardIDTableAdapter = null;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 36);
            this.toolStripButton3.Text = "اغلاق";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn12.HeaderText = "ملاحظات";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StatusColumn
            // 
            this.StatusColumn.DataPropertyName = "Status";
            this.StatusColumn.HeaderText = "النشاط";
            this.StatusColumn.MinimumWidth = 22;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // OusernameColumn
            // 
            this.OusernameColumn.DataPropertyName = "Ousername";
            this.OusernameColumn.HeaderText = "اسم المستخدم";
            this.OusernameColumn.MinimumWidth = 22;
            this.OusernameColumn.Name = "OusernameColumn";
            this.OusernameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.OusernameColumn.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "End_Date";
            this.dataGridViewTextBoxColumn10.HeaderText = "End_Date";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Start_Date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Start_Date";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "Date";
            this.DateColumn.HeaderText = "تاريخ التسجيل";
            this.DateColumn.MinimumWidth = 22;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DateColumn.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Delivery_Type";
            this.dataGridViewTextBoxColumn6.HeaderText = "Delivery_Type";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fill_Type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fill_Type";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // Allowed_qtyColumn
            // 
            this.Allowed_qtyColumn.DataPropertyName = "Allowed_qty";
            this.Allowed_qtyColumn.HeaderText = "الكمية الحرة";
            this.Allowed_qtyColumn.MinimumWidth = 22;
            this.Allowed_qtyColumn.Name = "Allowed_qtyColumn";
            this.Allowed_qtyColumn.ReadOnly = true;
            this.Allowed_qtyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Allowed_qtyColumn.Width = 120;
            // 
            // Remain_QtyColumn
            // 
            this.Remain_QtyColumn.DataPropertyName = "Remain_Qty";
            this.Remain_QtyColumn.HeaderText = "الكمية المتبقية/طن";
            this.Remain_QtyColumn.MinimumWidth = 22;
            this.Remain_QtyColumn.Name = "Remain_QtyColumn";
            this.Remain_QtyColumn.ReadOnly = true;
            this.Remain_QtyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Remain_QtyColumn.Width = 120;
            // 
            // QtyColumn
            // 
            this.QtyColumn.DataPropertyName = "Qty";
            this.QtyColumn.HeaderText = "كمية الامر/طن";
            this.QtyColumn.MinimumWidth = 22;
            this.QtyColumn.Name = "QtyColumn";
            this.QtyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.QtyColumn.Width = 120;
            // 
            // Cust_IDColumn
            // 
            this.Cust_IDColumn.DataPropertyName = "Cust_ID";
            this.Cust_IDColumn.DataSource = this.customersBindingSource;
            this.Cust_IDColumn.DisplayMember = "Cust_NAME";
            this.Cust_IDColumn.DisplayStyleForCurrentCellOnly = true;
            this.Cust_IDColumn.HeaderText = "العميل";
            this.Cust_IDColumn.MinimumWidth = 22;
            this.Cust_IDColumn.Name = "Cust_IDColumn";
            this.Cust_IDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cust_IDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Cust_IDColumn.ValueMember = "Cust_ID";
            this.Cust_IDColumn.Width = 250;
            // 
            // Contract_IDColumn
            // 
            this.Contract_IDColumn.DataPropertyName = "Contract_ID";
            this.Contract_IDColumn.HeaderText = "رقم العقد";
            this.Contract_IDColumn.MinimumWidth = 22;
            this.Contract_IDColumn.Name = "Contract_IDColumn";
            this.Contract_IDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Contract_IDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Order_NumberColumn
            // 
            this.Order_NumberColumn.DataPropertyName = "Order_Number";
            this.Order_NumberColumn.HeaderText = "رقم الامر";
            this.Order_NumberColumn.MinimumWidth = 22;
            this.Order_NumberColumn.Name = "Order_NumberColumn";
            this.Order_NumberColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Order_NumberColumn.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Order_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "الكود";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 654);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1323, 693);
            this.Name = "Orders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Orders_FormClosing);
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Outdataset outDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private OutdatasetTableAdapters.OrderTableAdapter orderTableAdapter;
        private OutdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
       // private System.Windows.Forms.DataGridView orderDataGridView;
        private Zuby.ADGV.AdvancedDataGridView orderDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton add_Button3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private OutdatasetTableAdapters.ContractTableAdapter contractTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private OutdatasetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox remain_QTYTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.ComboBox contract_NumberComboBox;
        private System.Windows.Forms.TextBox contract_IDTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract_IDColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cust_IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remain_QtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allowed_qtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn OusernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}