namespace LoBridge
{
    partial class OutListCustomers
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
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oUTDataset = new LoBridge.Outdataset();
            this.customersTableAdapter = new LoBridge.OutdatasetTableAdapters.CustomersTableAdapter();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByCNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.cnameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cnameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fillByCNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportXlsBtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.fillByCNameToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.oUTDataset;
            // 
            // oUTDataset
            // 
            this.oUTDataset.CaseSensitive = true;
            this.oUTDataset.DataSetName = "DLWSDataSet";
            this.oUTDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.CausesValidation = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Status,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn2});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersDataGridView.Location = new System.Drawing.Point(0, 41);
            this.customersDataGridView.MultiSelect = false;
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowTemplate.Height = 30;
            this.customersDataGridView.Size = new System.Drawing.Size(1084, 424);
            this.customersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cust_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "كود";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cust_NAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "اسم العميل";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 300;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "الحالة";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CITY";
            this.dataGridViewTextBoxColumn9.HeaderText = "المدينة";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ADDRESS";
            this.dataGridViewTextBoxColumn1.HeaderText = "تفاصيل العنوان";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PHONE";
            this.dataGridViewTextBoxColumn7.HeaderText = "تليفون";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MOBILE";
            this.dataGridViewTextBoxColumn8.HeaderText = "موبيل";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "تاريخ التسجيل";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOTES";
            this.dataGridViewTextBoxColumn2.HeaderText = "ملاحظات";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // fillByCNameToolStrip
            // 
            this.fillByCNameToolStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fillByCNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnameToolStripLabel,
            this.cnameToolStripTextBox,
            this.toolStripSeparator3,
            this.fillByCNameToolStripButton,
            this.toolStripSeparator2,
            this.EditBtn,
            this.toolStripSeparator1,
            this.ExportXlsBtn});
            this.fillByCNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByCNameToolStrip.Name = "fillByCNameToolStrip";
            this.fillByCNameToolStrip.Size = new System.Drawing.Size(1084, 41);
            this.fillByCNameToolStrip.TabIndex = 1;
            this.fillByCNameToolStrip.Text = "fillByCNameToolStrip";
            // 
            // cnameToolStripLabel
            // 
            this.cnameToolStripLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.cnameToolStripLabel.Name = "cnameToolStripLabel";
            this.cnameToolStripLabel.Size = new System.Drawing.Size(69, 38);
            this.cnameToolStripLabel.Text = "اسم العميل:";
            // 
            // cnameToolStripTextBox
            // 
            this.cnameToolStripTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.cnameToolStripTextBox.Name = "cnameToolStripTextBox";
            this.cnameToolStripTextBox.Size = new System.Drawing.Size(250, 41);
            this.cnameToolStripTextBox.TextChanged += new System.EventHandler(this.cnameToolStripTextBox_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // fillByCNameToolStripButton
            // 
            this.fillByCNameToolStripButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fillByCNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByCNameToolStripButton.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.fillByCNameToolStripButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fillByCNameToolStripButton.Name = "fillByCNameToolStripButton";
            this.fillByCNameToolStripButton.Size = new System.Drawing.Size(38, 38);
            this.fillByCNameToolStripButton.Text = "بحث";
            this.fillByCNameToolStripButton.Click += new System.EventHandler(this.fillByCNameToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditBtn.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditBtn.Image = global::LoBridge.Properties.Resources.edit;
            this.EditBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(79, 38);
            this.EditBtn.Text = "تعديل";
            this.EditBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // ExportXlsBtn
            // 
            this.ExportXlsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExportXlsBtn.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportXlsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExportXlsBtn.Image = global::LoBridge.Properties.Resources.xls_icon;
            this.ExportXlsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportXlsBtn.Name = "ExportXlsBtn";
            this.ExportXlsBtn.Size = new System.Drawing.Size(64, 38);
            this.ExportXlsBtn.Text = "Export";
            this.ExportXlsBtn.Click += new System.EventHandler(this.ExportXlsBtn_Click);
            // 
            // OutListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 465);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.fillByCNameToolStrip);
            this.Name = "OutListCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "قائمة العملاء";
            this.Load += new System.EventHandler(this.ListData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.fillByCNameToolStrip.ResumeLayout(false);
            this.fillByCNameToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Outdataset oUTDataset;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private OutdatasetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.ToolStrip fillByCNameToolStrip;
        private System.Windows.Forms.ToolStripLabel cnameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox cnameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByCNameToolStripButton;
        private System.Windows.Forms.ToolStripButton EditBtn;
        private System.Windows.Forms.ToolStripButton ExportXlsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}