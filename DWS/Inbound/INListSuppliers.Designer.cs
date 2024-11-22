namespace LoBridge
{
    partial class INListSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INListSuppliers));
            this.sUPPLIERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNdataset = new LoBridge.INdataset();
            this.sUPPLIERSTableAdapter = new LoBridge.INdatasetTableAdapters.SUPPLIERSTableAdapter();
            this.snameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.snameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBySNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.fillBySNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.shwcardBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.shwblBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.showwcBtn = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).BeginInit();
            this.fillBySNameToolStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sUPPLIERSDataGridView
            // 
            this.sUPPLIERSDataGridView.AllowUserToAddRows = false;
            this.sUPPLIERSDataGridView.AutoGenerateColumns = false;
            this.sUPPLIERSDataGridView.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.sUPPLIERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sUPPLIERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7});
            this.sUPPLIERSDataGridView.DataSource = this.sUPPLIERSBindingSource;
            this.sUPPLIERSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sUPPLIERSDataGridView.Location = new System.Drawing.Point(0, 38);
            this.sUPPLIERSDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.sUPPLIERSDataGridView.Name = "sUPPLIERSDataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sUPPLIERSDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sUPPLIERSDataGridView.RowHeadersVisible = false;
            this.sUPPLIERSDataGridView.RowHeadersWidth = 51;
            this.sUPPLIERSDataGridView.RowTemplate.Height = 30;
            this.sUPPLIERSDataGridView.Size = new System.Drawing.Size(1469, 623);
            this.sUPPLIERSDataGridView.TabIndex = 1;
            this.sUPPLIERSDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sUPPLIERSDataGridView_CellMouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SUP_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "كود";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SUP_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم المورد";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PHONE";
            this.dataGridViewTextBoxColumn3.HeaderText = "تليفون";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MOBILE";
            this.dataGridViewTextBoxColumn4.HeaderText = "موبيل";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CITY";
            this.dataGridViewTextBoxColumn5.HeaderText = "المدينة";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ADDRESS";
            this.dataGridViewTextBoxColumn6.HeaderText = "تفاصيل العنوان";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn9.HeaderText = "تاريخ التسجيل";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NOTES";
            this.dataGridViewTextBoxColumn7.HeaderText = "ملاحظات";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // sUPPLIERSBindingSource
            // 
            this.sUPPLIERSBindingSource.DataMember = "SUPPLIERS";
            this.sUPPLIERSBindingSource.DataSource = this.iNdataset;
            // 
            // iNdataset
            // 
            this.iNdataset.DataSetName = "INdataset";
            this.iNdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // snameToolStripLabel
            // 
            this.snameToolStripLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snameToolStripLabel.Name = "snameToolStripLabel";
            this.snameToolStripLabel.Size = new System.Drawing.Size(80, 29);
            this.snameToolStripLabel.Text = "اسم المورد";
            // 
            // snameToolStripTextBox
            // 
            this.snameToolStripTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snameToolStripTextBox.Name = "snameToolStripTextBox";
            this.snameToolStripTextBox.Size = new System.Drawing.Size(291, 32);
            this.snameToolStripTextBox.TextChanged += new System.EventHandler(this.snameToolStripTextBox_TextChanged);
            // 
            // fillBySNameToolStripButton
            // 
            this.fillBySNameToolStripButton.BackColor = System.Drawing.Color.White;
            this.fillBySNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBySNameToolStripButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBySNameToolStripButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.fillBySNameToolStripButton.Name = "fillBySNameToolStripButton";
            this.fillBySNameToolStripButton.Size = new System.Drawing.Size(53, 29);
            this.fillBySNameToolStripButton.Text = "بحث";
            this.fillBySNameToolStripButton.Click += new System.EventHandler(this.fillBySNameToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(57, 29);
            this.saveBtn.Text = "حفظ ";
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.sUPPLIERSBindingNavigatorSaveItem_Click);
            // 
            // fillBySNameToolStrip
            // 
            this.fillBySNameToolStrip.BackColor = System.Drawing.Color.SlateGray;
            this.fillBySNameToolStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBySNameToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBySNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snameToolStripLabel,
            this.snameToolStripTextBox,
            this.fillBySNameToolStripButton,
            this.toolStripSeparator1,
            this.saveBtn});
            this.fillBySNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBySNameToolStrip.Name = "fillBySNameToolStrip";
            this.fillBySNameToolStrip.Padding = new System.Windows.Forms.Padding(0, 6, 1, 0);
            this.fillBySNameToolStrip.Size = new System.Drawing.Size(1469, 38);
            this.fillBySNameToolStrip.TabIndex = 2;
            this.fillBySNameToolStrip.Text = "fillBySNameToolStrip";
            this.fillBySNameToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillBySNameToolStrip_ItemClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contextMenuStrip1.DropShadowEnabled = false;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.shwcardBtn,
            this.shwblBtn,
            this.showwcBtn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 100);
            this.contextMenuStrip1.Text = "الخيارات";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(163, 6);
            // 
            // shwcardBtn
            // 
            this.shwcardBtn.Name = "shwcardBtn";
            this.shwcardBtn.Size = new System.Drawing.Size(166, 30);
            this.shwcardBtn.Text = "تعديل";
            this.shwcardBtn.Click += new System.EventHandler(this.shwcardBtn_Click);
            // 
            // shwblBtn
            // 
            this.shwblBtn.Name = "shwblBtn";
            this.shwblBtn.Size = new System.Drawing.Size(166, 30);
            this.shwblBtn.Text = "عرض البوليصة";
            this.shwblBtn.Visible = false;
            // 
            // showwcBtn
            // 
            this.showwcBtn.Name = "showwcBtn";
            this.showwcBtn.Size = new System.Drawing.Size(166, 30);
            this.showwcBtn.Text = "عرض تذكرة الوزن";
            this.showwcBtn.Visible = false;
            // 
            // INListSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 661);
            this.Controls.Add(this.sUPPLIERSDataGridView);
            this.Controls.Add(this.fillBySNameToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "INListSuppliers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ListSuppliers";
            this.Load += new System.EventHandler(this.ListSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).EndInit();
            this.fillBySNameToolStrip.ResumeLayout(false);
            this.fillBySNameToolStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView sUPPLIERSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private INdataset iNdataset;
        private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
        private INdatasetTableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
        private System.Windows.Forms.ToolStripLabel snameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox snameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBySNameToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStrip fillBySNameToolStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem shwcardBtn;
        private System.Windows.Forms.ToolStripMenuItem shwblBtn;
        private System.Windows.Forms.ToolStripMenuItem showwcBtn;
    }
}