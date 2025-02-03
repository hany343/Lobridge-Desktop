namespace LoBridge
{
    partial class Print_Wcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_Wcard));
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.lcacrd1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LadidBox = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.typeCombobox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.A5paperBtn = new System.Windows.Forms.ToolStripButton();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.inDataSet = new LoBridge.INdataset();
            this.wCard1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wCard1TableAdapter = new LoBridge.INdatasetTableAdapters.WCard1TableAdapter();
            this.outdataset = new LoBridge.Outdataset();
            this.outWcard1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outWcard1TableAdapter = new LoBridge.OutdatasetTableAdapters.OutWcard1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingNavigator)).BeginInit();
            this.lcacrd1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCard1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outWcard1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 47);
            this.crystalReportViewer2.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ShowCloseButton = false;
            this.crystalReportViewer2.ShowGroupTreeButton = false;
            this.crystalReportViewer2.ShowLogo = false;
            this.crystalReportViewer2.ShowParameterPanelButton = false;
            this.crystalReportViewer2.ShowTextSearchButton = false;
            this.crystalReportViewer2.ShowZoomButton = false;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1864, 987);
            this.crystalReportViewer2.TabIndex = 1;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lcacrd1BindingNavigator
            // 
            this.lcacrd1BindingNavigator.AddNewItem = null;
            this.lcacrd1BindingNavigator.CountItem = null;
            this.lcacrd1BindingNavigator.DeleteItem = null;
            this.lcacrd1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lcacrd1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.LadidBox,
            this.bindingNavigatorSeparator,
            this.toolStripLabel2,
            this.typeCombobox,
            this.toolStripButton1,
            this.toolStripButton3,
            this.A5paperBtn});
            this.lcacrd1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lcacrd1BindingNavigator.MoveFirstItem = null;
            this.lcacrd1BindingNavigator.MoveLastItem = null;
            this.lcacrd1BindingNavigator.MoveNextItem = null;
            this.lcacrd1BindingNavigator.MovePreviousItem = null;
            this.lcacrd1BindingNavigator.Name = "lcacrd1BindingNavigator";
            this.lcacrd1BindingNavigator.PositionItem = null;
            this.lcacrd1BindingNavigator.Size = new System.Drawing.Size(1864, 47);
            this.lcacrd1BindingNavigator.TabIndex = 4;
            this.lcacrd1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 44);
            this.toolStripLabel1.Text = "رقم الكارت";
            // 
            // LadidBox
            // 
            this.LadidBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LadidBox.Name = "LadidBox";
            this.LadidBox.Size = new System.Drawing.Size(124, 47);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 44);
            this.toolStripLabel2.Text = "نوع الوزن";
            // 
            // typeCombobox
            // 
            this.typeCombobox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.typeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombobox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCombobox.Items.AddRange(new object[] {
            "صادر",
            "وارد"});
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(150, 47);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LoBridge.Properties.Resources.refresh;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(39, 44);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(103, 44);
            this.toolStripButton3.Text = "A4 Paper Size";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // A5paperBtn
            // 
            this.A5paperBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.A5paperBtn.ForeColor = System.Drawing.Color.Blue;
            this.A5paperBtn.Image = ((System.Drawing.Image)(resources.GetObject("A5paperBtn.Image")));
            this.A5paperBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.A5paperBtn.Name = "A5paperBtn";
            this.A5paperBtn.Size = new System.Drawing.Size(103, 44);
            this.A5paperBtn.Text = "A5 Paper Size";
            this.A5paperBtn.Click += new System.EventHandler(this.A5paperBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(1804, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(60, 52);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // inDataSet
            // 
            this.inDataSet.CaseSensitive = true;
            this.inDataSet.DataSetName = "DLWSDataSet";
            this.inDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wCard1BindingSource
            // 
            this.wCard1BindingSource.DataMember = "WCard1";
            this.wCard1BindingSource.DataSource = this.inDataSet;
            // 
            // wCard1TableAdapter
            // 
            this.wCard1TableAdapter.ClearBeforeFill = true;
            // 
            // outdataset
            // 
            this.outdataset.DataSetName = "Outdataset";
            this.outdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outWcard1BindingSource
            // 
            this.outWcard1BindingSource.DataMember = "OutWcard1";
            this.outWcard1BindingSource.DataSource = this.outdataset;
            // 
            // outWcard1TableAdapter
            // 
            this.outWcard1TableAdapter.ClearBeforeFill = true;
            // 
            // Print_Wcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1421, 1055);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.lcacrd1BindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Print_Wcard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "طباعة تذكرة وزن";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Print_Wcard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1BindingNavigator)).EndInit();
            this.lcacrd1BindingNavigator.ResumeLayout(false);
            this.lcacrd1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCard1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outWcard1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private INdataset inDataSet;
        private Outdataset outdataset;
        private System.Windows.Forms.BindingSource wCard1BindingSource;
        private INdatasetTableAdapters.WCard1TableAdapter wCard1TableAdapter;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private System.Windows.Forms.BindingSource outWcard1BindingSource;
        private OutdatasetTableAdapters.OutWcard1TableAdapter outWcard1TableAdapter;
        private System.Windows.Forms.BindingNavigator lcacrd1BindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox LadidBox;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox typeCombobox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ToolStripButton A5paperBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        //private CrystalReport3 CrystalReport31;
    }
}