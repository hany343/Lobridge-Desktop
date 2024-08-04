namespace LoBridge
{
    partial class OUTContract
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
            System.Windows.Forms.Label contract_TypeLabel;
            System.Windows.Forms.Label contractLabel;
            System.Windows.Forms.Label commodityLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label qtyLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.comm_IDComboBox = new System.Windows.Forms.ComboBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.contract_TypeTextBox = new System.Windows.Forms.TextBox();
            this.contract_NumberTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewItemBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteItemBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveItemBtn = new System.Windows.Forms.ToolStripButton();
            this.contractBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshButton1 = new System.Windows.Forms.ToolStripButton();
            this.editButton1 = new System.Windows.Forms.ToolStripButton();
            contract_TypeLabel = new System.Windows.Forms.Label();
            contractLabel = new System.Windows.Forms.Label();
            commodityLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).BeginInit();
            this.contractBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // contract_TypeLabel
            // 
            contract_TypeLabel.AutoSize = true;
            contract_TypeLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contract_TypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            contract_TypeLabel.Location = new System.Drawing.Point(401, 20);
            contract_TypeLabel.Name = "contract_TypeLabel";
            contract_TypeLabel.Size = new System.Drawing.Size(59, 22);
            contract_TypeLabel.TabIndex = 36;
            contract_TypeLabel.Text = "نوع العقد:";
            // 
            // contractLabel
            // 
            contractLabel.AutoSize = true;
            contractLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contractLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            contractLabel.Location = new System.Drawing.Point(662, 20);
            contractLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contractLabel.Name = "contractLabel";
            contractLabel.Size = new System.Drawing.Size(60, 22);
            contractLabel.TabIndex = 3;
            contractLabel.Text = "رقم العقد:";
            // 
            // commodityLabel
            // 
            commodityLabel.AutoSize = true;
            commodityLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            commodityLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            commodityLabel.Location = new System.Drawing.Point(662, 57);
            commodityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            commodityLabel.Name = "commodityLabel";
            commodityLabel.Size = new System.Drawing.Size(50, 22);
            commodityLabel.TabIndex = 5;
            commodityLabel.Text = "الصنف:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            notesLabel.Location = new System.Drawing.Point(658, 129);
            notesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(56, 22);
            notesLabel.TabIndex = 23;
            notesLabel.Text = "ملاحظات:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(439, 101);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(26, 22);
            label1.TabIndex = 11;
            label1.Text = "طن";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            qtyLabel.Location = new System.Drawing.Point(662, 96);
            qtyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(44, 22);
            qtyLabel.TabIndex = 11;
            qtyLabel.Text = "الكمية:";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.notesTextBox);
            this.panel2.Controls.Add(this.comm_IDComboBox);
            this.panel2.Controls.Add(this.qtyTextBox);
            this.panel2.Controls.Add(this.contract_TypeTextBox);
            this.panel2.Controls.Add(this.contract_NumberTextBox);
            this.panel2.Controls.Add(contract_TypeLabel);
            this.panel2.Controls.Add(contractLabel);
            this.panel2.Controls.Add(commodityLabel);
            this.panel2.Controls.Add(notesLabel);
            this.panel2.Controls.Add(label1);
            this.panel2.Controls.Add(qtyLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Enabled = false;
            this.panel2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(732, 263);
            this.panel2.TabIndex = 56;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notesTextBox.Location = new System.Drawing.Point(225, 129);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(430, 77);
            this.notesTextBox.TabIndex = 52;
            // 
            // comm_IDComboBox
            // 
            this.comm_IDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comm_IDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comm_IDComboBox.DisplayMember = "Comm_ID";
            this.comm_IDComboBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comm_IDComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comm_IDComboBox.FormattingEnabled = true;
            this.comm_IDComboBox.Location = new System.Drawing.Point(225, 57);
            this.comm_IDComboBox.Name = "comm_IDComboBox";
            this.comm_IDComboBox.Size = new System.Drawing.Size(430, 30);
            this.comm_IDComboBox.TabIndex = 48;
            this.comm_IDComboBox.ValueMember = "Comm_ID";
            this.comm_IDComboBox.TextChanged += new System.EventHandler(this.comm_IDComboBox_Click);
            this.comm_IDComboBox.Click += new System.EventHandler(this.comm_IDComboBox_Click);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.qtyTextBox.Location = new System.Drawing.Point(472, 93);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(183, 30);
            this.qtyTextBox.TabIndex = 41;
            // 
            // contract_TypeTextBox
            // 
            this.contract_TypeTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_TypeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contract_TypeTextBox.Location = new System.Drawing.Point(225, 17);
            this.contract_TypeTextBox.Name = "contract_TypeTextBox";
            this.contract_TypeTextBox.Size = new System.Drawing.Size(169, 30);
            this.contract_TypeTextBox.TabIndex = 38;
            // 
            // contract_NumberTextBox
            // 
            this.contract_NumberTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_NumberTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contract_NumberTextBox.Location = new System.Drawing.Point(472, 17);
            this.contract_NumberTextBox.Name = "contract_NumberTextBox";
            this.contract_NumberTextBox.Size = new System.Drawing.Size(184, 30);
            this.contract_NumberTextBox.TabIndex = 37;
            this.contract_NumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contract_NumberTextBox_KeyDown);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // AddNewItemBtn
            // 
            this.AddNewItemBtn.Image = global::LoBridge.Properties.Resources.add2;
            this.AddNewItemBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewItemBtn.Name = "AddNewItemBtn";
            this.AddNewItemBtn.RightToLeftAutoMirrorImage = true;
            this.AddNewItemBtn.Size = new System.Drawing.Size(69, 40);
            this.AddNewItemBtn.Text = "جديد";
            this.AddNewItemBtn.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.Enabled = false;
            this.DeleteItemBtn.Image = global::LoBridge.Properties.Resources.cancel;
            this.DeleteItemBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.RightToLeftAutoMirrorImage = true;
            this.DeleteItemBtn.Size = new System.Drawing.Size(71, 40);
            this.DeleteItemBtn.Text = "الغاء";
            this.DeleteItemBtn.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // SaveItemBtn
            // 
            this.SaveItemBtn.Enabled = false;
            this.SaveItemBtn.Image = global::LoBridge.Properties.Resources.save3;
            this.SaveItemBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveItemBtn.Name = "SaveItemBtn";
            this.SaveItemBtn.Size = new System.Drawing.Size(69, 40);
            this.SaveItemBtn.Text = "حفظ";
            this.SaveItemBtn.Click += new System.EventHandler(this.contractBindingNavigatorSaveItem_Click);
            // 
            // contractBindingNavigator
            // 
            this.contractBindingNavigator.AddNewItem = null;
            this.contractBindingNavigator.CountItem = null;
            this.contractBindingNavigator.DeleteItem = null;
            this.contractBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contractBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.AddNewItemBtn,
            this.bindingNavigatorSeparator1,
            this.DeleteItemBtn,
            this.bindingNavigatorSeparator2,
            this.SaveItemBtn,
            this.toolStripSeparator1,
            this.refreshButton1,
            this.editButton1});
            this.contractBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractBindingNavigator.MoveFirstItem = null;
            this.contractBindingNavigator.MoveLastItem = null;
            this.contractBindingNavigator.MoveNextItem = null;
            this.contractBindingNavigator.MovePreviousItem = null;
            this.contractBindingNavigator.Name = "contractBindingNavigator";
            this.contractBindingNavigator.PositionItem = null;
            this.contractBindingNavigator.Size = new System.Drawing.Size(732, 43);
            this.contractBindingNavigator.TabIndex = 37;
            this.contractBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // refreshButton1
            // 
            this.refreshButton1.Enabled = false;
            this.refreshButton1.Image = global::LoBridge.Properties.Resources.refresh;
            this.refreshButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton1.Name = "refreshButton1";
            this.refreshButton1.Size = new System.Drawing.Size(78, 40);
            this.refreshButton1.Text = "تحديث";
            this.refreshButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // editButton1
            // 
            this.editButton1.Enabled = false;
            this.editButton1.Image = global::LoBridge.Properties.Resources.edit;
            this.editButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(75, 40);
            this.editButton1.Text = "تعديل";
            this.editButton1.Click += new System.EventHandler(this.editButton1_Click);
            // 
            // OUTContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(732, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contractBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(748, 345);
            this.Name = "OUTContract";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "انشاء عقد جديد";
            this.Load += new System.EventHandler(this.OUTContract_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).EndInit();
            this.contractBindingNavigator.ResumeLayout(false);
            this.contractBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comm_IDComboBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox contract_TypeTextBox;
        private System.Windows.Forms.TextBox contract_NumberTextBox;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton AddNewItemBtn;
        private System.Windows.Forms.ToolStripButton DeleteItemBtn;
        private System.Windows.Forms.ToolStripButton SaveItemBtn;
        private System.Windows.Forms.BindingNavigator contractBindingNavigator;
        private System.Windows.Forms.ToolStripButton refreshButton1;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton editButton1;
    }
}