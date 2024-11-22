namespace LoBridge
{
    partial class INSHiftViewer
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
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comm_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableAdapterManager = new LoBridge.DLWSDataSetTableAdapters.TableAdapterManager();
            this.iNdataset = new LoBridge.INdataset();
            this.wCard1TableAdapter = new LoBridge.INdatasetTableAdapters.WCard1TableAdapter();
            this.commodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commodityTableAdapter = new LoBridge.INdatasetTableAdapters.CommodityTableAdapter();
            this.tableAdapterManager1 = new LoBridge.INdatasetTableAdapters.TableAdapterManager();
            this.fKShipmentCommodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentTableAdapter = new LoBridge.INdatasetTableAdapters.ShipmentTableAdapter();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKShipmentCommodityBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 44);
            this.crystalReportViewer2.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ShowCloseButton = false;
            this.crystalReportViewer2.ShowGroupTreeButton = false;
            this.crystalReportViewer2.ShowLogo = false;
            this.crystalReportViewer2.ShowParameterPanelButton = false;
            this.crystalReportViewer2.ShowTextSearchButton = false;
            this.crystalReportViewer2.ShowZoomButton = false;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1225, 798);
            this.crystalReportViewer2.TabIndex = 2;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(10, 4);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(41, 34);
            this.ExitBtn.TabIndex = 114;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.crystalReportViewer2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1225, 842);
            this.panel1.TabIndex = 115;
            // 
            // comm_NAMEComboBox
            // 
            this.comm_NAMEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commodityBindingSource, "Comm_NAME", true));
            this.comm_NAMEComboBox.DataSource = this.commodityBindingSource;
            this.comm_NAMEComboBox.DisplayMember = "Comm_NAME";
            this.comm_NAMEComboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.comm_NAMEComboBox.Enabled = false;
            this.comm_NAMEComboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comm_NAMEComboBox.FormattingEnabled = true;
            this.comm_NAMEComboBox.Location = new System.Drawing.Point(837, 10);
            this.comm_NAMEComboBox.Name = "comm_NAMEComboBox";
            this.comm_NAMEComboBox.Size = new System.Drawing.Size(259, 28);
            this.comm_NAMEComboBox.TabIndex = 120;
            this.comm_NAMEComboBox.ValueMember = "Comm_ID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(598, 10);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 24);
            this.checkBox1.TabIndex = 119;
            this.checkBox1.Text = "الي";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(812, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "من";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(434, 10);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(164, 28);
            this.dateTimePicker2.TabIndex = 117;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(387, 10);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 20);
            this.linkLabel1.TabIndex = 116;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "عرض";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 10);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 28);
            this.dateTimePicker1.TabIndex = 115;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CameraTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = null;
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
            // iNdataset
            // 
            this.iNdataset.DataSetName = "INdataset";
            this.iNdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wCard1TableAdapter
            // 
            this.wCard1TableAdapter.ClearBeforeFill = true;
            // 
            // commodityBindingSource
            // 
            this.commodityBindingSource.DataMember = "Commodity";
            this.commodityBindingSource.DataSource = this.iNdataset;
            // 
            // commodityTableAdapter
            // 
            this.commodityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CommodityTableAdapter = this.commodityTableAdapter;
            this.tableAdapterManager1.INBatchTableAdapter = null;
            this.tableAdapterManager1.LadingTableAdapter = null;
            this.tableAdapterManager1.Local_SuppliersTableAdapter = null;
            this.tableAdapterManager1.ShipmentTableAdapter = this.shipmentTableAdapter;
            this.tableAdapterManager1.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = LoBridge.INdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WcardIDTableAdapter = null;
            // 
            // fKShipmentCommodityBindingSource
            // 
            this.fKShipmentCommodityBindingSource.DataMember = "FK_Shipment_Commodity";
            this.fKShipmentCommodityBindingSource.DataSource = this.commodityBindingSource;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(1096, 10);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(119, 24);
            this.checkBox2.TabIndex = 121;
            this.checkBox2.Text = "فلتر بالصنف:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comm_NAMEComboBox);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(1225, 44);
            this.panel2.TabIndex = 122;
            // 
            // INSHiftViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1225, 842);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "INSHiftViewer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "INSHiftViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.INSHiftViewer_FormClosing);
            this.Load += new System.EventHandler(this.INSHiftViewer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKShipmentCommodityBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private INdataset iNdataset;
        private INdatasetTableAdapters.WCard1TableAdapter wCard1TableAdapter;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private DLWSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comm_NAMEComboBox;
        private System.Windows.Forms.BindingSource commodityBindingSource;
        private INdatasetTableAdapters.CommodityTableAdapter commodityTableAdapter;
        private INdatasetTableAdapters.TableAdapterManager tableAdapterManager1;
        private INdatasetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.BindingSource fKShipmentCommodityBindingSource;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel2;
    }
}