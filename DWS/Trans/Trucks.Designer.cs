namespace LoBridge
{
    partial class Trucks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.truckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalDataSet = new LoBridge.DLWSDataSet();
            this.truckBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pagposTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.pagecountLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.truckTableAdapter = new LoBridge.DLWSDataSetTableAdapters.TruckTableAdapter();
            //this.queriesTableAdapter = new LoBridge.DLWSDataSetTableAdapters.QueriesTableAdapter();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRusernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trailertrafficDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trailerLicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trailernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trucktrafficDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckLicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Truck_numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trucksDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.add_Button3 = new System.Windows.Forms.ToolStripButton();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.searchButton1 = new System.Windows.Forms.ToolStripButton();
            this.refreshButton2 = new System.Windows.Forms.ToolStripButton();
            this.prepageButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingNavigator)).BeginInit();
            this.truckBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trucksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trucksDataGridView);
            this.panel1.Controls.Add(this.truckBindingNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 654);
            this.panel1.TabIndex = 0;
            // 
            // truckBindingSource
            // 
            this.truckBindingSource.DataMember = "Truck";
            this.truckBindingSource.DataSource = this.generalDataSet;
            // 
            // generalDataSet
            // 
            this.generalDataSet.DataSetName = "GeneralDataSet";
            this.generalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // truckBindingNavigator
            // 
            this.truckBindingNavigator.AddNewItem = null;
            this.truckBindingNavigator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.truckBindingNavigator.BindingSource = this.truckBindingSource;
            this.truckBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.truckBindingNavigator.CountItemFormat = "من {0}";
            this.truckBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.truckBindingNavigator.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truckBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.searchTextBox1,
            this.searchButton1,
            this.toolStripSeparator4,
            this.refreshButton2,
            this.toolStripSeparator3,
            this.prepageButton2,
            this.pagposTextBox1,
            this.pagecountLabel3,
            this.toolStripButton1,
            this.toolStripSeparator6});
            this.truckBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.truckBindingNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.truckBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.truckBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.truckBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.truckBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.truckBindingNavigator.Name = "truckBindingNavigator";
            this.truckBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.truckBindingNavigator.Size = new System.Drawing.Size(1352, 39);
            this.truckBindingNavigator.TabIndex = 14;
            this.truckBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 36);
            this.bindingNavigatorCountItem.Text = "من {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 36);
            this.toolStripLabel1.Text = "بحث برقم الجرار:";
            // 
            // searchTextBox1
            // 
            this.searchTextBox1.BackColor = System.Drawing.Color.White;
            this.searchTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox1.Name = "searchTextBox1";
            this.searchTextBox1.Size = new System.Drawing.Size(200, 35);
            this.searchTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // pagposTextBox1
            // 
            this.pagposTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pagposTextBox1.Name = "pagposTextBox1";
            this.pagposTextBox1.Size = new System.Drawing.Size(50, 39);
            // 
            // pagecountLabel3
            // 
            this.pagecountLabel3.Name = "pagecountLabel3";
            this.pagecountLabel3.Size = new System.Drawing.Size(30, 36);
            this.pagecountLabel3.Text = "(0)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // truckTableAdapter
            // 
            this.truckTableAdapter.ClearBeforeFill = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // create_dateColumn
            // 
            this.create_dateColumn.DataPropertyName = "create_date";
            this.create_dateColumn.HeaderText = "تاريخ التسجيل";
            this.create_dateColumn.Name = "create_dateColumn";
            this.create_dateColumn.ReadOnly = true;
            this.create_dateColumn.Width = 200;
            // 
            // TRusernameColumn
            // 
            this.TRusernameColumn.DataPropertyName = "TRusername";
            this.TRusernameColumn.HeaderText = "المستخدم";
            this.TRusernameColumn.Name = "TRusernameColumn";
            this.TRusernameColumn.ReadOnly = true;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            this.driverIDDataGridViewTextBoxColumn.DataPropertyName = "Driver_ID";
            this.driverIDDataGridViewTextBoxColumn.HeaderText = "Driver_ID";
            this.driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            this.driverIDDataGridViewTextBoxColumn.Visible = false;
            this.driverIDDataGridViewTextBoxColumn.Width = 85;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "مالك السيارة";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.Width = 150;
            // 
            // trailertrafficDataGridViewTextBoxColumn
            // 
            this.trailertrafficDataGridViewTextBoxColumn.DataPropertyName = "Trailer_traffic";
            this.trailertrafficDataGridViewTextBoxColumn.HeaderText = "وحدة مرور";
            this.trailertrafficDataGridViewTextBoxColumn.Name = "trailertrafficDataGridViewTextBoxColumn";
            // 
            // trailerLicenseDataGridViewTextBoxColumn
            // 
            this.trailerLicenseDataGridViewTextBoxColumn.DataPropertyName = "Trailer_License";
            this.trailerLicenseDataGridViewTextBoxColumn.HeaderText = "Trailer_License";
            this.trailerLicenseDataGridViewTextBoxColumn.Name = "trailerLicenseDataGridViewTextBoxColumn";
            this.trailerLicenseDataGridViewTextBoxColumn.Visible = false;
            this.trailerLicenseDataGridViewTextBoxColumn.Width = 112;
            // 
            // trailernumberDataGridViewTextBoxColumn
            // 
            this.trailernumberDataGridViewTextBoxColumn.DataPropertyName = "Trailer_number";
            this.trailernumberDataGridViewTextBoxColumn.HeaderText = "رقم المقطورة";
            this.trailernumberDataGridViewTextBoxColumn.Name = "trailernumberDataGridViewTextBoxColumn";
            // 
            // trucktrafficDataGridViewTextBoxColumn
            // 
            this.trucktrafficDataGridViewTextBoxColumn.DataPropertyName = "Truck_traffic";
            this.trucktrafficDataGridViewTextBoxColumn.HeaderText = "وحدة مرور";
            this.trucktrafficDataGridViewTextBoxColumn.Name = "trucktrafficDataGridViewTextBoxColumn";
            // 
            // truckLicenseDataGridViewTextBoxColumn
            // 
            this.truckLicenseDataGridViewTextBoxColumn.DataPropertyName = "Truck_License";
            this.truckLicenseDataGridViewTextBoxColumn.HeaderText = "Truck_License";
            this.truckLicenseDataGridViewTextBoxColumn.Name = "truckLicenseDataGridViewTextBoxColumn";
            this.truckLicenseDataGridViewTextBoxColumn.Visible = false;
            this.truckLicenseDataGridViewTextBoxColumn.Width = 110;
            // 
            // Truck_numberColumn
            // 
            this.Truck_numberColumn.DataPropertyName = "Truck_number";
            this.Truck_numberColumn.HeaderText = "رقم الجرار";
            this.Truck_numberColumn.Name = "Truck_numberColumn";
            // 
            // truckIDDataGridViewTextBoxColumn
            // 
            this.truckIDDataGridViewTextBoxColumn.DataPropertyName = "Truck_ID";
            this.truckIDDataGridViewTextBoxColumn.HeaderText = "الكود";
            this.truckIDDataGridViewTextBoxColumn.Name = "truckIDDataGridViewTextBoxColumn";
            this.truckIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trucksDataGridView
            // 
            this.trucksDataGridView.AllowUserToAddRows = false;
            this.trucksDataGridView.AutoGenerateColumns = false;
            this.trucksDataGridView.CausesValidation = false;
            this.trucksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trucksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.trucksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trucksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.truckIDDataGridViewTextBoxColumn,
            this.Truck_numberColumn,
            this.truckLicenseDataGridViewTextBoxColumn,
            this.trucktrafficDataGridViewTextBoxColumn,
            this.trailernumberDataGridViewTextBoxColumn,
            this.trailerLicenseDataGridViewTextBoxColumn,
            this.trailertrafficDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.driverIDDataGridViewTextBoxColumn,
            this.TRusernameColumn,
            this.create_dateColumn,
            this.notesDataGridViewTextBoxColumn});
            this.trucksDataGridView.DataSource = this.truckBindingSource;
            this.trucksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trucksDataGridView.EnableHeadersVisualStyles = false;
            this.trucksDataGridView.Location = new System.Drawing.Point(0, 39);
            this.trucksDataGridView.Name = "trucksDataGridView";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trucksDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.trucksDataGridView.RowTemplate.Height = 27;
            this.trucksDataGridView.ShowCellToolTips = false;
            this.trucksDataGridView.ShowEditingIcon = false;
            this.trucksDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.trucksDataGridView.TabIndex = 13;
            this.trucksDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.orderDataGridView_DefaultValuesNeeded);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = global::LoBridge.Properties.Resources.delete_icon;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(79, 36);
            this.bindingNavigatorDeleteItem.Text = "حذف";
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
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.Image = global::LoBridge.Properties.Resources.Save_icon__1_;
            this.orderBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(80, 36);
            this.orderBindingNavigatorSaveItem.Text = "حفظ";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // searchButton1
            // 
            this.searchButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchButton1.Image = global::LoBridge.Properties.Resources.search_icon__2_1;
            this.searchButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.Size = new System.Drawing.Size(36, 36);
            this.searchButton1.Text = "toolStripButton1";
            this.searchButton1.Click += new System.EventHandler(this.searchButton1_Click);
            // 
            // refreshButton2
            // 
            this.refreshButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton2.Image = global::LoBridge.Properties.Resources.arrow_refresh_3_icon;
            this.refreshButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton2.Name = "refreshButton2";
            this.refreshButton2.Size = new System.Drawing.Size(36, 36);
            this.refreshButton2.Text = "toolStripButton2";
            this.refreshButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // prepageButton2
            // 
            this.prepageButton2.Image = global::LoBridge.Properties.Resources.document_right_icon;
            this.prepageButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.prepageButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prepageButton2.Name = "prepageButton2";
            this.prepageButton2.Size = new System.Drawing.Size(88, 36);
            this.prepageButton2.Text = "صفحة";
            this.prepageButton2.Click += new System.EventHandler(this.prepageButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::LoBridge.Properties.Resources.document_left_icon;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 36);
            this.toolStripButton1.Text = "صفحة";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Trucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1352, 654);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Trucks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Trucks";
            this.Load += new System.EventHandler(this.Trucks_Load_1);
            this.Shown += new System.EventHandler(this.Trucks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingNavigator)).EndInit();
            this.truckBindingNavigator.ResumeLayout(false);
            this.truckBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trucksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator truckBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton add_Button3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchTextBox1;
        private System.Windows.Forms.ToolStripButton searchButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton refreshButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private DLWSDataSet generalDataSet;
        private System.Windows.Forms.BindingSource truckBindingSource;
        private DLWSDataSetTableAdapters.TruckTableAdapter truckTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox pagposTextBox1;
        private System.Windows.Forms.ToolStripLabel pagecountLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton prepageButton2;
        private System.Windows.Forms.DataGridView trucksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truck_numberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckLicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trucktrafficDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trailernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trailerLicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trailertrafficDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRusernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}