namespace LoBridge
{
    partial class OutPrint_BLading
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.leaveDateTextBox = new System.Windows.Forms.TextBox();
            this.lcacrd1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oUTDataset = new LoBridge.Outdataset();
            this.outcardBtn = new System.Windows.Forms.LinkLabel();
            this.addrsBtn = new System.Windows.Forms.LinkLabel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saverepBtn = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripTextBox1 = new System.Windows.Forms.TextBox();
            this.LadidBox = new System.Windows.Forms.TextBox();
            this.lading_OutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportDocument2 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.lading_OutTableAdapter = new LoBridge.OutdatasetTableAdapters.Lading_OutTableAdapter();
            this.lcacrd1TableAdapter = new LoBridge.OutdatasetTableAdapters.Lcacrd1TableAdapter();
            this.tableAdapterManager = new LoBridge.OutdatasetTableAdapters.TableAdapterManager();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lading_OutBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.leaveDateTextBox);
            this.panel2.Controls.Add(this.outcardBtn);
            this.panel2.Controls.Add(this.addrsBtn);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.saverepBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.toolStripTextBox1);
            this.panel2.Controls.Add(this.LadidBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 37);
            this.panel2.TabIndex = 116;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(888, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 19);
            this.linkLabel1.TabIndex = 123;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "عرض";
            this.linkLabel1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // leaveDateTextBox
            // 
            this.leaveDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lcacrd1BindingSource, "LeaveDate", true));
            this.leaveDateTextBox.Location = new System.Drawing.Point(55, 5);
            this.leaveDateTextBox.Name = "leaveDateTextBox";
            this.leaveDateTextBox.ReadOnly = true;
            this.leaveDateTextBox.Size = new System.Drawing.Size(197, 27);
            this.leaveDateTextBox.TabIndex = 122;
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
            // outcardBtn
            // 
            this.outcardBtn.AutoSize = true;
            this.outcardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outcardBtn.Enabled = false;
            this.outcardBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcardBtn.Location = new System.Drawing.Point(258, 10);
            this.outcardBtn.Name = "outcardBtn";
            this.outcardBtn.Size = new System.Drawing.Size(80, 16);
            this.outcardBtn.TabIndex = 121;
            this.outcardBtn.TabStop = true;
            this.outcardBtn.Text = "تسجيل خروج";
            this.outcardBtn.Visible = false;
            this.outcardBtn.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // addrsBtn
            // 
            this.addrsBtn.AutoSize = true;
            this.addrsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrsBtn.Enabled = false;
            this.addrsBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrsBtn.Location = new System.Drawing.Point(339, 10);
            this.addrsBtn.Name = "addrsBtn";
            this.addrsBtn.Size = new System.Drawing.Size(72, 16);
            this.addrsBtn.TabIndex = 120;
            this.addrsBtn.TabStop = true;
            this.addrsBtn.Text = "جهة الوصول";
            this.addrsBtn.Visible = false;
            this.addrsBtn.Click += new System.EventHandler(this.linkLabel1_Click_1);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(46, 35);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(746, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 114;
            this.label1.Text = "اسم المندوب:";
            // 
            // saverepBtn
            // 
            this.saverepBtn.AutoSize = true;
            this.saverepBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saverepBtn.Enabled = false;
            this.saverepBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saverepBtn.Location = new System.Drawing.Point(417, 10);
            this.saverepBtn.Name = "saverepBtn";
            this.saverepBtn.Size = new System.Drawing.Size(80, 16);
            this.saverepBtn.TabIndex = 4;
            this.saverepBtn.TabStop = true;
            this.saverepBtn.Text = "حفظ المندوب";
            this.saverepBtn.Visible = false;
            this.saverepBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.toolStripButton2_LinkClicked);
            this.saverepBtn.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1037, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "رقم الكارت:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lcacrd1BindingSource, "Representative", true));
            this.toolStripTextBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Location = new System.Drawing.Point(503, 4);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(237, 29);
            this.toolStripTextBox1.TabIndex = 3;
            // 
            // LadidBox
            // 
            this.LadidBox.Location = new System.Drawing.Point(937, 5);
            this.LadidBox.Name = "LadidBox";
            this.LadidBox.Size = new System.Drawing.Size(94, 27);
            this.LadidBox.TabIndex = 117;
            this.LadidBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadidBox_KeyDown);
            // 
            // lading_OutBindingSource
            // 
            this.lading_OutBindingSource.DataMember = "Lading_Out";
            this.lading_OutBindingSource.DataSource = this.oUTDataset;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 708);
            this.panel1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.EnableToolTips = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 37);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1143, 671);
            this.crystalReportViewer1.TabIndex = 115;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lading_OutTableAdapter
            // 
            this.lading_OutTableAdapter.ClearBeforeFill = true;
            // 
            // lcacrd1TableAdapter
            // 
            this.lcacrd1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Lading_OutTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoBridge.OutdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WcardIDTableAdapter = null;
            // 
            // OutPrint_BLading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1143, 708);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OutPrint_BLading";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Print_Blading";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Print_Ladingcard_FormClosing);
            this.Load += new System.EventHandler(this.Print_Lcard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lading_OutBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource lcacrd1BindingSource;
        private Outdataset oUTDataset;
        private OutdatasetTableAdapters.Lading_OutTableAdapter lading_OutTableAdapter;
        private System.Windows.Forms.BindingSource lading_OutBindingSource;
        private OutdatasetTableAdapters.Lcacrd1TableAdapter lcacrd1TableAdapter;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel saverepBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toolStripTextBox1;
        private System.Windows.Forms.TextBox LadidBox;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument2;
        private System.Windows.Forms.LinkLabel addrsBtn;
        private System.Windows.Forms.LinkLabel outcardBtn;
        private System.Windows.Forms.TextBox leaveDateTextBox;
        private OutdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}