namespace LoBridge
{
    partial class INWCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cardnumberTxtbx = new System.Windows.Forms.TextBox();
            this.wbtextbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ladingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.cameraTableAdapter = new LoBridge.DLWSDataSetTableAdapters.CameraTableAdapter();
            this.ladinginDataGridView = new System.Windows.Forms.DataGridView();
            this.iNdataset = new LoBridge.INdataset();
            this.ladingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladingTableAdapter = new LoBridge.INdatasetTableAdapters.LadingTableAdapter();
            this.ladingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Truck_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladingNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ladingBindingNavigator)).BeginInit();
            this.ladingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ladinginDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ladinginDataGridView);
            this.panel3.Controls.Add(this.cardnumberTxtbx);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(5, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Size = new System.Drawing.Size(1452, 672);
            this.panel3.TabIndex = 9;
            // 
            // cardnumberTxtbx
            // 
            this.cardnumberTxtbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardnumberTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.cardnumberTxtbx.Location = new System.Drawing.Point(5, 4);
            this.cardnumberTxtbx.Name = "cardnumberTxtbx";
            this.cardnumberTxtbx.Size = new System.Drawing.Size(1438, 80);
            this.cardnumberTxtbx.TabIndex = 115;
            this.cardnumberTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cardnumberTxtbx.Enter += new System.EventHandler(this.cardnumberTxtbx_Enter);
            this.cardnumberTxtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardnumberTxtbx_KeyDown);
            // 
            // wbtextbox
            // 
            this.wbtextbox.BackColor = System.Drawing.Color.White;
            this.wbtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wbtextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LoBridge.Properties.Settings.Default, "WBridge", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wbtextbox.Font = new System.Drawing.Font("Doppio One", 27.75F);
            this.wbtextbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wbtextbox.Location = new System.Drawing.Point(964, 12);
            this.wbtextbox.Name = "wbtextbox";
            this.wbtextbox.ReadOnly = true;
            this.wbtextbox.Size = new System.Drawing.Size(250, 47);
            this.wbtextbox.TabIndex = 12;
            this.wbtextbox.TabStop = false;
            this.wbtextbox.Text = global::LoBridge.Properties.Settings.Default.WBridge;
            this.wbtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ladinginDataGridView_KeyPress);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 62);
            // 
            // ladingBindingNavigator
            // 
            this.ladingBindingNavigator.AddNewItem = null;
            this.ladingBindingNavigator.CountItem = null;
            this.ladingBindingNavigator.DeleteItem = null;
            this.ladingBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladingBindingNavigator.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ladingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.toolStripLabel1});
            this.ladingBindingNavigator.Location = new System.Drawing.Point(5, 4);
            this.ladingBindingNavigator.MoveFirstItem = null;
            this.ladingBindingNavigator.MoveLastItem = null;
            this.ladingBindingNavigator.MoveNextItem = null;
            this.ladingBindingNavigator.MovePreviousItem = null;
            this.ladingBindingNavigator.Name = "ladingBindingNavigator";
            this.ladingBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ladingBindingNavigator.PositionItem = null;
            this.ladingBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ladingBindingNavigator.Size = new System.Drawing.Size(1452, 62);
            this.ladingBindingNavigator.TabIndex = 10;
            this.ladingBindingNavigator.Text = "bindingNavigator1";
            this.ladingBindingNavigator.RefreshItems += new System.EventHandler(this.ladingBindingNavigator_RefreshItems);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.Image = global::LoBridge.Properties.Resources.refresh;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(50, 59);
            this.toolStripButton1.Text = "تحديث";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 62);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripLabel1.Font = new System.Drawing.Font("Doppio One", 27.75F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(235, 59);
            this.toolStripLabel1.Text = "    وزن وارد    ";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(1400, 15);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 44);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTextBox.Font = new System.Drawing.Font("Doppio One", 27.75F);
            this.dateTextBox.Location = new System.Drawing.Point(522, 12);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTextBox.Size = new System.Drawing.Size(402, 47);
            this.dateTextBox.TabIndex = 114;
            this.dateTextBox.TabStop = false;
            this.dateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ladinginDataGridView_KeyPress);
            // 
            // cameraTableAdapter
            // 
            this.cameraTableAdapter.ClearBeforeFill = true;
            // 
            // ladinginDataGridView
            // 
            this.ladinginDataGridView.AllowUserToAddRows = false;
            this.ladinginDataGridView.AllowUserToDeleteRows = false;
            this.ladinginDataGridView.AllowUserToOrderColumns = true;
            this.ladinginDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ladinginDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ladinginDataGridView.AutoGenerateColumns = false;
            this.ladinginDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ladinginDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ladinginDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ladinginDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ladinginDataGridView.ColumnHeadersHeight = 60;
            this.ladinginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ladinginDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ladingIDDataGridViewTextBoxColumn,
            this.BatchSerial,
            this.Truck_number,
            this.Driver_Name,
            this.Comname,
            this.dateDataGridViewTextBoxColumn,
            this.fweightDataGridViewTextBoxColumn,
            this.fWdateDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.ladingNotesDataGridViewTextBoxColumn});
            this.ladinginDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ladinginDataGridView.DataSource = this.ladingBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ladinginDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.ladinginDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ladinginDataGridView.EnableHeadersVisualStyles = false;
            this.ladinginDataGridView.GridColor = System.Drawing.Color.Sienna;
            this.ladinginDataGridView.Location = new System.Drawing.Point(5, 84);
            this.ladinginDataGridView.MultiSelect = false;
            this.ladinginDataGridView.Name = "ladinginDataGridView";
            this.ladinginDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ladinginDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ladinginDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            this.ladinginDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ladinginDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            this.ladinginDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladinginDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ladinginDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ladinginDataGridView.RowTemplate.DividerHeight = 3;
            this.ladinginDataGridView.RowTemplate.Height = 50;
            this.ladinginDataGridView.RowTemplate.ReadOnly = true;
            this.ladinginDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ladinginDataGridView.Size = new System.Drawing.Size(1438, 580);
            this.ladinginDataGridView.TabIndex = 116;
            this.ladinginDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ladinginDataGridView_KeyPress);
            // 
            // iNdataset
            // 
            this.iNdataset.DataSetName = "INdataset";
            this.iNdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ladingBindingSource
            // 
            this.ladingBindingSource.DataMember = "Lading";
            this.ladingBindingSource.DataSource = this.iNdataset;
            // 
            // ladingTableAdapter
            // 
            this.ladingTableAdapter.ClearBeforeFill = true;
            // 
            // ladingIDDataGridViewTextBoxColumn
            // 
            this.ladingIDDataGridViewTextBoxColumn.DataPropertyName = "ladingID";
            this.ladingIDDataGridViewTextBoxColumn.HeaderText = "رقم الكارت";
            this.ladingIDDataGridViewTextBoxColumn.Name = "ladingIDDataGridViewTextBoxColumn";
            this.ladingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BatchSerial
            // 
            this.BatchSerial.DataPropertyName = "Serial";
            this.BatchSerial.HeaderText = "افراج";
            this.BatchSerial.Name = "BatchSerial";
            this.BatchSerial.ReadOnly = true;
            // 
            // Truck_number
            // 
            this.Truck_number.DataPropertyName = "Truck_number";
            this.Truck_number.HeaderText = "رقم الجرار";
            this.Truck_number.Name = "Truck_number";
            this.Truck_number.ReadOnly = true;
            // 
            // Driver_Name
            // 
            this.Driver_Name.DataPropertyName = "Driver_Name";
            this.Driver_Name.HeaderText = "اسم السائق";
            this.Driver_Name.Name = "Driver_Name";
            this.Driver_Name.ReadOnly = true;
            this.Driver_Name.Width = 200;
            // 
            // Comname
            // 
            this.Comname.DataPropertyName = "Comm_Name";
            this.Comname.HeaderText = "الصنف";
            this.Comname.Name = "Comname";
            this.Comname.ReadOnly = true;
            this.Comname.Width = 200;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 200;
            // 
            // fweightDataGridViewTextBoxColumn
            // 
            this.fweightDataGridViewTextBoxColumn.DataPropertyName = "F_weight";
            this.fweightDataGridViewTextBoxColumn.HeaderText = "وزن اول";
            this.fweightDataGridViewTextBoxColumn.Name = "fweightDataGridViewTextBoxColumn";
            this.fweightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fWdateDataGridViewTextBoxColumn
            // 
            this.fWdateDataGridViewTextBoxColumn.DataPropertyName = "F_Wdate";
            this.fWdateDataGridViewTextBoxColumn.HeaderText = "وقت الوزن";
            this.fWdateDataGridViewTextBoxColumn.Name = "fWdateDataGridViewTextBoxColumn";
            this.fWdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.fWdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "حالة الوزن";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ladingNotesDataGridViewTextBoxColumn
            // 
            this.ladingNotesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ladingNotesDataGridViewTextBoxColumn.DataPropertyName = "Lading_Notes";
            this.ladingNotesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.ladingNotesDataGridViewTextBoxColumn.Name = "ladingNotesDataGridViewTextBoxColumn";
            this.ladingNotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // INWCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1462, 742);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.wbtextbox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ladingBindingNavigator);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 657);
            this.Name = "INWCard";
            this.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تذكرة وزن";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.INWCard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WCard_FormClosed);
            this.Load += new System.EventHandler(this.INWCard_Load);
            this.Shown += new System.EventHandler(this.INWCard_Shown_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.INWCard_Paint);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ladingBindingNavigator)).EndInit();
            this.ladingBindingNavigator.ResumeLayout(false);
            this.ladingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ladinginDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox wbtextbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.BindingNavigator ladingBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button ExitBtn;
        public System.Windows.Forms.TextBox dateTextBox;
        private DLWSDataSetTableAdapters.CameraTableAdapter cameraTableAdapter;
        private System.Windows.Forms.TextBox cardnumberTxtbx;
        private System.Windows.Forms.DataGridView ladinginDataGridView;
        private INdataset iNdataset;
        private System.Windows.Forms.BindingSource ladingBindingSource;
        private INdatasetTableAdapters.LadingTableAdapter ladingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truck_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladingNotesDataGridViewTextBoxColumn;
    }
}