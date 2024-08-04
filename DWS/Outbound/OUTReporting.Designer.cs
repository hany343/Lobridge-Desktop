namespace LoBridge
{
    partial class OutDailyreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutDailyreport));
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lcardToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lcardToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillForLadoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillForLadoutToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cnameStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxcontr = new System.Windows.Forms.CheckBox();
            this.comm_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.commodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dLWSDataSet = new LoBridge.DLWSDataSet();
            this.CommcheckBox1 = new System.Windows.Forms.CheckBox();
            this.tocheckBox1 = new System.Windows.Forms.CheckBox();
            this.todateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.showByDateBtn = new System.Windows.Forms.LinkLabel();
            this.commodityTableAdapter = new LoBridge.DLWSDataSetTableAdapters.CommodityTableAdapter();
            this.tableAdapterManager = new LoBridge.DLWSDataSetTableAdapters.TableAdapterManager();
            this.outdataset = new LoBridge.Outdataset();
            this.lcacrd1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lcacrd1TableAdapter = new LoBridge.OutdatasetTableAdapters.Lcacrd1TableAdapter();
            this.fillForLadoutToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.EnableToolTips = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 109);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1619, 780);
            this.crystalReportViewer1.TabIndex = 116;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lcardToolStripLabel
            // 
            this.lcardToolStripLabel.Name = "lcardToolStripLabel";
            this.lcardToolStripLabel.Size = new System.Drawing.Size(75, 29);
            this.lcardToolStripLabel.Text = "رقم العقد:";
            // 
            // lcardToolStripTextBox
            // 
            this.lcardToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lcardToolStripTextBox.Name = "lcardToolStripTextBox";
            this.lcardToolStripTextBox.Size = new System.Drawing.Size(124, 32);
            this.lcardToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lcardToolStripTextBox_KeyDown);
            // 
            // fillForLadoutToolStripButton
            // 
            this.fillForLadoutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillForLadoutToolStripButton.Name = "fillForLadoutToolStripButton";
            this.fillForLadoutToolStripButton.Size = new System.Drawing.Size(44, 29);
            this.fillForLadoutToolStripButton.Text = "بحث";
            this.fillForLadoutToolStripButton.Click += new System.EventHandler(this.fillForLadoutToolStripButton_Click);
            // 
            // fillForLadoutToolStrip
            // 
            this.fillForLadoutToolStrip.BackColor = System.Drawing.Color.Silver;
            this.fillForLadoutToolStrip.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillForLadoutToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillForLadoutToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lcardToolStripLabel,
            this.lcardToolStripTextBox,
            this.fillForLadoutToolStripButton,
            this.toolStripButton4,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripLabel1,
            this.cnameStripTextBox1,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.toolStripButton6,
            this.toolStripButton7});
            this.fillForLadoutToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillForLadoutToolStrip.Name = "fillForLadoutToolStrip";
            this.fillForLadoutToolStrip.Size = new System.Drawing.Size(1619, 32);
            this.fillForLadoutToolStrip.TabIndex = 118;
            this.fillForLadoutToolStrip.Text = "fillForLadoutToolStrip";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(79, 29);
            this.toolStripButton4.Text = "عرض الكل";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(121, 29);
            this.toolStripLabel1.Text = "بحث باسم العميل:";
            // 
            // cnameStripTextBox1
            // 
            this.cnameStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cnameStripTextBox1.Name = "cnameStripTextBox1";
            this.cnameStripTextBox1.Size = new System.Drawing.Size(186, 32);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(44, 29);
            this.toolStripButton5.Text = "بحث";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(162, 29);
            this.toolStripButton6.Text = "بحث بالعميل و العقد معا";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.toolStripButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(1559, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(35, 31);
            this.ExitBtn.TabIndex = 119;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxcontr);
            this.panel1.Controls.Add(this.comm_NAMEComboBox);
            this.panel1.Controls.Add(this.CommcheckBox1);
            this.panel1.Controls.Add(this.tocheckBox1);
            this.panel1.Controls.Add(this.todateTimePicker2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.showByDateBtn);
            this.panel1.Controls.Add(this.fillForLadoutToolStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1619, 109);
            this.panel1.TabIndex = 120;
            // 
            // checkBoxcontr
            // 
            this.checkBoxcontr.AutoSize = true;
            this.checkBoxcontr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxcontr.Location = new System.Drawing.Point(258, 54);
            this.checkBoxcontr.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxcontr.Name = "checkBoxcontr";
            this.checkBoxcontr.Size = new System.Drawing.Size(162, 28);
            this.checkBoxcontr.TabIndex = 133;
            this.checkBoxcontr.Text = "عقود تفصيلي";
            this.checkBoxcontr.UseVisualStyleBackColor = true;
            this.checkBoxcontr.CheckedChanged += new System.EventHandler(this.checkBoxcontr_CheckedChanged);
            // 
            // comm_NAMEComboBox
            // 
            this.comm_NAMEComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comm_NAMEComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comm_NAMEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commodityBindingSource, "Comm_NAME", true));
            this.comm_NAMEComboBox.DataSource = this.commodityBindingSource;
            this.comm_NAMEComboBox.DisplayMember = "Comm_NAME";
            this.comm_NAMEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comm_NAMEComboBox.FormattingEnabled = true;
            this.comm_NAMEComboBox.Location = new System.Drawing.Point(478, 54);
            this.comm_NAMEComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.comm_NAMEComboBox.Name = "comm_NAMEComboBox";
            this.comm_NAMEComboBox.Size = new System.Drawing.Size(280, 24);
            this.comm_NAMEComboBox.TabIndex = 132;
            // 
            // commodityBindingSource
            // 
            this.commodityBindingSource.DataMember = "Commodity";
            this.commodityBindingSource.DataSource = this.dLWSDataSet;
            // 
            // dLWSDataSet
            // 
            this.dLWSDataSet.CaseSensitive = true;
            this.dLWSDataSet.DataSetName = "DLWSDataSet";
            this.dLWSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CommcheckBox1
            // 
            this.CommcheckBox1.AutoSize = true;
            this.CommcheckBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommcheckBox1.Location = new System.Drawing.Point(766, 54);
            this.CommcheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.CommcheckBox1.Name = "CommcheckBox1";
            this.CommcheckBox1.Size = new System.Drawing.Size(102, 28);
            this.CommcheckBox1.TabIndex = 131;
            this.CommcheckBox1.Text = "بالصنف";
            this.CommcheckBox1.UseVisualStyleBackColor = true;
            this.CommcheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tocheckBox1
            // 
            this.tocheckBox1.AutoSize = true;
            this.tocheckBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tocheckBox1.Location = new System.Drawing.Point(1196, 55);
            this.tocheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.tocheckBox1.Name = "tocheckBox1";
            this.tocheckBox1.Size = new System.Drawing.Size(103, 28);
            this.tocheckBox1.TabIndex = 130;
            this.tocheckBox1.Text = "من الي";
            this.tocheckBox1.UseVisualStyleBackColor = true;
            // 
            // todateTimePicker2
            // 
            this.todateTimePicker2.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todateTimePicker2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todateTimePicker2.Location = new System.Drawing.Point(1029, 49);
            this.todateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.todateTimePicker2.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.todateTimePicker2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.todateTimePicker2.Name = "todateTimePicker2";
            this.todateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.todateTimePicker2.RightToLeftLayout = true;
            this.todateTimePicker2.Size = new System.Drawing.Size(159, 32);
            this.todateTimePicker2.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1481, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 128;
            this.label3.Text = "تقرير بتاريخ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1309, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 32);
            this.dateTimePicker1.TabIndex = 126;
            // 
            // showByDateBtn
            // 
            this.showByDateBtn.AutoSize = true;
            this.showByDateBtn.BackColor = System.Drawing.Color.Transparent;
            this.showByDateBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showByDateBtn.LinkColor = System.Drawing.Color.Blue;
            this.showByDateBtn.Location = new System.Drawing.Point(950, 51);
            this.showByDateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showByDateBtn.Name = "showByDateBtn";
            this.showByDateBtn.Size = new System.Drawing.Size(73, 33);
            this.showByDateBtn.TabIndex = 127;
            this.showByDateBtn.TabStop = true;
            this.showByDateBtn.Text = "عرض";
            this.showByDateBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showByDateBtn_LinkClicked);
            // 
            // commodityTableAdapter
            // 
            this.commodityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CameraTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.CommodityTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.EmailsTableAdapter = null;
            this.tableAdapterManager.GWCardTableAdapter = null;
            this.tableAdapterManager.LogsTableAdapter = null;
            this.tableAdapterManager.RepresentativeTableAdapter = null;
            this.tableAdapterManager.Transport_CoTableAdapter = null;
            this.tableAdapterManager.TruckTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoBridge.DLWSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_PermTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WcardIDTableAdapter = null;
            // 
            // outdataset
            // 
            this.outdataset.DataSetName = "Outdataset";
            this.outdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lcacrd1BindingSource
            // 
            this.lcacrd1BindingSource.DataMember = "Lcacrd1";
            this.lcacrd1BindingSource.DataSource = this.outdataset;
            // 
            // lcacrd1TableAdapter
            // 
            this.lcacrd1TableAdapter.ClearBeforeFill = true;
            // 
            // OutDailyreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(1619, 889);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OutDailyreport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Reporting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reporting_FormClosing);
            this.Load += new System.EventHandler(this.Reporting_Load);
            this.fillForLadoutToolStrip.ResumeLayout(false);
            this.fillForLadoutToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Outdataset outdataset;
        private System.Windows.Forms.BindingSource lcacrd1BindingSource;
        private OutdatasetTableAdapters.Lcacrd1TableAdapter lcacrd1TableAdapter;
        private System.Windows.Forms.ToolStripLabel lcardToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lcardToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillForLadoutToolStripButton;
        private System.Windows.Forms.ToolStrip fillForLadoutToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox cnameStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox tocheckBox1;
        private System.Windows.Forms.DateTimePicker todateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.LinkLabel showByDateBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.CheckBox CommcheckBox1;
        private DLWSDataSet dLWSDataSet;
        private System.Windows.Forms.BindingSource commodityBindingSource;
        private DLWSDataSetTableAdapters.CommodityTableAdapter commodityTableAdapter;
        private DLWSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comm_NAMEComboBox;
        private System.Windows.Forms.CheckBox checkBoxcontr;
    }
}