namespace LoBridge
{
    partial class OutWCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ladingDataGridView = new System.Windows.Forms.DataGridView();
            this.lcacrd1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oUTDataset = new LoBridge.Outdataset();
            this.cardnumberTxtbx = new System.Windows.Forms.TextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ladingoutBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.wbtextbox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.lcacrd1TableAdapter = new LoBridge.OutdatasetTableAdapters.Lcacrd1TableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ladingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Truck_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fill_Typec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladingNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ladingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladingoutBindingNavigator)).BeginInit();
            this.ladingoutBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ladingDataGridView);
            this.panel3.Controls.Add(this.cardnumberTxtbx);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(5, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(1425, 730);
            this.panel3.TabIndex = 9;
            // 
            // ladingDataGridView
            // 
            this.ladingDataGridView.AllowUserToAddRows = false;
            this.ladingDataGridView.AllowUserToDeleteRows = false;
            this.ladingDataGridView.AllowUserToOrderColumns = true;
            this.ladingDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ladingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ladingDataGridView.AutoGenerateColumns = false;
            this.ladingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ladingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ladingDataGridView.CausesValidation = false;
            this.ladingDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ladingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ladingDataGridView.ColumnHeadersHeight = 60;
            this.ladingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ladingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ladingIDDataGridViewTextBoxColumn,
            this.Truck_number,
            this.Driver_Name,
            this.Cust_Name,
            this.Commname,
            this.dateDataGridViewTextBoxColumn,
            this.fweightDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.Fill_Typec,
            this.ladingNotesDataGridViewTextBoxColumn});
            this.ladingDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ladingDataGridView.DataSource = this.lcacrd1BindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ladingDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ladingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ladingDataGridView.EnableHeadersVisualStyles = false;
            this.ladingDataGridView.GridColor = System.Drawing.Color.Sienna;
            this.ladingDataGridView.Location = new System.Drawing.Point(3, 83);
            this.ladingDataGridView.MultiSelect = false;
            this.ladingDataGridView.Name = "ladingDataGridView";
            this.ladingDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ladingDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ladingDataGridView.RowHeadersVisible = false;
            this.ladingDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ladingDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ladingDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.ladingDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladingDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ladingDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ladingDataGridView.RowTemplate.DividerHeight = 4;
            this.ladingDataGridView.RowTemplate.Height = 50;
            this.ladingDataGridView.RowTemplate.ReadOnly = true;
            this.ladingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ladingDataGridView.Size = new System.Drawing.Size(1415, 640);
            this.ladingDataGridView.TabIndex = 2;
            this.ladingDataGridView.TabStop = false;
            this.ladingDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ladingDataGridView_CellMouseDoubleClick);
            this.ladingDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTextBox_KeyPress);
            // 
            // lcacrd1BindingSource
            // 
            this.lcacrd1BindingSource.DataMember = "Lcacrd1";
            this.lcacrd1BindingSource.DataSource = this.oUTDataset;
            // 
            // oUTDataset
            // 
            this.oUTDataset.CaseSensitive = true;
            this.oUTDataset.DataSetName = "DLWSDataSet";
            this.oUTDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardnumberTxtbx
            // 
            this.cardnumberTxtbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardnumberTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardnumberTxtbx.Location = new System.Drawing.Point(3, 3);
            this.cardnumberTxtbx.Margin = new System.Windows.Forms.Padding(0);
            this.cardnumberTxtbx.MaxLength = 20;
            this.cardnumberTxtbx.Name = "cardnumberTxtbx";
            this.cardnumberTxtbx.Size = new System.Drawing.Size(1415, 80);
            this.cardnumberTxtbx.TabIndex = 114;
            this.cardnumberTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cardnumberTxtbx.Enter += new System.EventHandler(this.cardnumberTxtbx_Enter);
            this.cardnumberTxtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardnumberTxtbx_KeyDown);
            this.cardnumberTxtbx.Leave += new System.EventHandler(this.cardnumberTxtbx_Leave);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 62);
            // 
            // ladingoutBindingNavigator
            // 
            this.ladingoutBindingNavigator.AddNewItem = null;
            this.ladingoutBindingNavigator.CountItem = null;
            this.ladingoutBindingNavigator.DeleteItem = null;
            this.ladingoutBindingNavigator.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladingoutBindingNavigator.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ladingoutBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.toolStripButton1,
            this.toolStripLabel1});
            this.ladingoutBindingNavigator.Location = new System.Drawing.Point(5, 5);
            this.ladingoutBindingNavigator.MoveFirstItem = null;
            this.ladingoutBindingNavigator.MoveLastItem = null;
            this.ladingoutBindingNavigator.MoveNextItem = null;
            this.ladingoutBindingNavigator.MovePreviousItem = null;
            this.ladingoutBindingNavigator.Name = "ladingoutBindingNavigator";
            this.ladingoutBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ladingoutBindingNavigator.PositionItem = null;
            this.ladingoutBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ladingoutBindingNavigator.Size = new System.Drawing.Size(1425, 62);
            this.ladingoutBindingNavigator.TabIndex = 10;
            this.ladingoutBindingNavigator.Text = "bindingNavigator1";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripLabel1.Font = new System.Drawing.Font("Doppio One", 27.75F);
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(164, 59);
            this.toolStripLabel1.Text = "وزن صادر";
            // 
            // wbtextbox
            // 
            this.wbtextbox.BackColor = System.Drawing.SystemColors.Control;
            this.wbtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wbtextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LoBridge.Properties.Settings.Default, "WBridge", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wbtextbox.Font = new System.Drawing.Font("Doppio One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbtextbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wbtextbox.Location = new System.Drawing.Point(895, 12);
            this.wbtextbox.Name = "wbtextbox";
            this.wbtextbox.ReadOnly = true;
            this.wbtextbox.Size = new System.Drawing.Size(292, 47);
            this.wbtextbox.TabIndex = 12;
            this.wbtextbox.TabStop = false;
            this.wbtextbox.Text = global::LoBridge.Properties.Settings.Default.WBridge;
            this.wbtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wbtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTextBox_KeyPress);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(1375, 10);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 49);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // lcacrd1TableAdapter
            // 
            this.lcacrd1TableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // ladingIDDataGridViewTextBoxColumn
            // 
            this.ladingIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ladingIDDataGridViewTextBoxColumn.DataPropertyName = "ladingID";
            this.ladingIDDataGridViewTextBoxColumn.HeaderText = "رقم الكارت";
            this.ladingIDDataGridViewTextBoxColumn.Name = "ladingIDDataGridViewTextBoxColumn";
            this.ladingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladingIDDataGridViewTextBoxColumn.Width = 105;
            // 
            // Truck_number
            // 
            this.Truck_number.DataPropertyName = "Truck_number";
            this.Truck_number.HeaderText = "رقم الجرار";
            this.Truck_number.MinimumWidth = 6;
            this.Truck_number.Name = "Truck_number";
            this.Truck_number.ReadOnly = true;
            this.Truck_number.Width = 80;
            // 
            // Driver_Name
            // 
            this.Driver_Name.DataPropertyName = "Driver_Name";
            this.Driver_Name.HeaderText = "اسم السائق";
            this.Driver_Name.MinimumWidth = 6;
            this.Driver_Name.Name = "Driver_Name";
            this.Driver_Name.ReadOnly = true;
            this.Driver_Name.Width = 160;
            // 
            // Cust_Name
            // 
            this.Cust_Name.DataPropertyName = "Cust_NAME";
            this.Cust_Name.HeaderText = "اسم العميل";
            this.Cust_Name.Name = "Cust_Name";
            this.Cust_Name.ReadOnly = true;
            this.Cust_Name.Width = 200;
            // 
            // Commname
            // 
            this.Commname.DataPropertyName = "Comm_NAME";
            this.Commname.HeaderText = "الصنف";
            this.Commname.Name = "Commname";
            this.Commname.ReadOnly = true;
            this.Commname.Width = 160;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 180;
            // 
            // fweightDataGridViewTextBoxColumn
            // 
            this.fweightDataGridViewTextBoxColumn.DataPropertyName = "F_weight";
            this.fweightDataGridViewTextBoxColumn.HeaderText = "وزن اول /كجم";
            this.fweightDataGridViewTextBoxColumn.Name = "fweightDataGridViewTextBoxColumn";
            this.fweightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "الكمية /طن";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Fill_Typec
            // 
            this.Fill_Typec.DataPropertyName = "Fill_Type";
            this.Fill_Typec.HeaderText = "نوع التعبئة";
            this.Fill_Typec.Name = "Fill_Typec";
            this.Fill_Typec.ReadOnly = true;
            // 
            // ladingNotesDataGridViewTextBoxColumn
            // 
            this.ladingNotesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ladingNotesDataGridViewTextBoxColumn.DataPropertyName = "Lading_Notes";
            this.ladingNotesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.ladingNotesDataGridViewTextBoxColumn.Name = "ladingNotesDataGridViewTextBoxColumn";
            this.ladingNotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OutWCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1435, 802);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.wbtextbox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ladingoutBindingNavigator);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OutWCard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تذكرة وزن صادر";
            this.Load += new System.EventHandler(this.OUTWCard_Load);
            this.Shown += new System.EventHandler(this.OutWCard_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OutWCard_Paint);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ladingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladingoutBindingNavigator)).EndInit();
            this.ladingoutBindingNavigator.ResumeLayout(false);
            this.ladingoutBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox wbtextbox;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.BindingNavigator ladingoutBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView ladingDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private Outdataset oUTDataset;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.BindingSource lcacrd1BindingSource;
        private System.Windows.Forms.TextBox cardnumberTxtbx;
        private OutdatasetTableAdapters.Lcacrd1TableAdapter lcacrd1TableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truck_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fill_Typec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladingNotesDataGridViewTextBoxColumn;
    }
}