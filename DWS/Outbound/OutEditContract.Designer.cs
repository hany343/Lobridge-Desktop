namespace LoBridge
{
    partial class OutEditContract
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
            System.Windows.Forms.Label contract_NumberLabel;
            System.Windows.Forms.Label comm_IDLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label remain_QTYLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label contract_IDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutEditContract));
            this.oUTDataset = new LoBridge.Outdataset();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contractBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.refreshBTn = new System.Windows.Forms.ToolStripButton();
            this.closeorderBtn = new System.Windows.Forms.ToolStripButton();
            this.enableOrderBtn = new System.Windows.Forms.ToolStripButton();
            this.contract_NumberTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.remain_QTYTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.comm_IDTextBox = new System.Windows.Forms.TextBox();
            this.orderTableAdapter = new LoBridge.OutdatasetTableAdapters.OrderTableAdapter();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.contract_IDTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.contractTableAdapter = new LoBridge.OutdatasetTableAdapters.ContractTableAdapter();
            contract_NumberLabel = new System.Windows.Forms.Label();
            comm_IDLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            remain_QTYLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            contract_IDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).BeginInit();
            this.contractBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // contract_NumberLabel
            // 
            contract_NumberLabel.AutoSize = true;
            contract_NumberLabel.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contract_NumberLabel.Location = new System.Drawing.Point(101, 88);
            contract_NumberLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            contract_NumberLabel.Name = "contract_NumberLabel";
            contract_NumberLabel.Size = new System.Drawing.Size(91, 32);
            contract_NumberLabel.TabIndex = 3;
            contract_NumberLabel.Text = "رقم العقد:";
            // 
            // comm_IDLabel
            // 
            comm_IDLabel.AutoSize = true;
            comm_IDLabel.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comm_IDLabel.Location = new System.Drawing.Point(85, 185);
            comm_IDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            comm_IDLabel.Name = "comm_IDLabel";
            comm_IDLabel.Size = new System.Drawing.Size(107, 32);
            comm_IDLabel.TabIndex = 5;
            comm_IDLabel.Text = "كود الصنف:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyLabel.Location = new System.Drawing.Point(90, 235);
            qtyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(102, 32);
            qtyLabel.TabIndex = 11;
            qtyLabel.Text = "كمية العقد:";
            // 
            // remain_QTYLabel
            // 
            remain_QTYLabel.AutoSize = true;
            remain_QTYLabel.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remain_QTYLabel.Location = new System.Drawing.Point(72, 280);
            remain_QTYLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            remain_QTYLabel.Name = "remain_QTYLabel";
            remain_QTYLabel.Size = new System.Drawing.Size(120, 32);
            remain_QTYLabel.TabIndex = 13;
            remain_QTYLabel.Text = "الكمية المتبقي:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(107, 378);
            notesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(85, 32);
            notesLabel.TabIndex = 25;
            notesLabel.Text = "ملاحظات:";
            // 
            // contract_IDLabel
            // 
            contract_IDLabel.AutoSize = true;
            contract_IDLabel.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contract_IDLabel.Location = new System.Drawing.Point(98, 137);
            contract_IDLabel.Name = "contract_IDLabel";
            contract_IDLabel.Size = new System.Drawing.Size(94, 32);
            contract_IDLabel.TabIndex = 113;
            contract_IDLabel.Text = "كود العقد:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(575, 235);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 32);
            label1.TabIndex = 115;
            label1.Text = "طن";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(575, 280);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 32);
            label2.TabIndex = 116;
            label2.Text = "طن";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(95, 329);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(101, 32);
            statusLabel.TabIndex = 116;
            statusLabel.Text = "حالة العقد:";
            // 
            // oUTDataset
            // 
            this.oUTDataset.CaseSensitive = true;
            this.oUTDataset.DataSetName = "DLWSDataSet";
            this.oUTDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.oUTDataset;
            // 
            // contractBindingNavigator
            // 
            this.contractBindingNavigator.AddNewItem = null;
            this.contractBindingNavigator.BindingSource = this.contractBindingSource;
            this.contractBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.contractBindingNavigatorSaveItem,
            this.refreshBTn,
            this.closeorderBtn,
            this.enableOrderBtn});
            this.contractBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractBindingNavigator.Name = "contractBindingNavigator";
            this.contractBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.contractBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractBindingNavigator.Size = new System.Drawing.Size(768, 42);
            this.contractBindingNavigator.TabIndex = 0;
            this.contractBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 39);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::LoBridge.Properties.Resources.delete_icon;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 39);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 39);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 39);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 39);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 39);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // contractBindingNavigatorSaveItem
            // 
            this.contractBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contractBindingNavigatorSaveItem.Image = global::LoBridge.Properties.Resources.save3;
            this.contractBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.contractBindingNavigatorSaveItem.Name = "contractBindingNavigatorSaveItem";
            this.contractBindingNavigatorSaveItem.Size = new System.Drawing.Size(39, 39);
            this.contractBindingNavigatorSaveItem.Text = "Save Data";
            this.contractBindingNavigatorSaveItem.Click += new System.EventHandler(this.contractBindingNavigatorSaveItem_Click);
            // 
            // refreshBTn
            // 
            this.refreshBTn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshBTn.Image = global::LoBridge.Properties.Resources.refresh;
            this.refreshBTn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshBTn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBTn.Name = "refreshBTn";
            this.refreshBTn.Size = new System.Drawing.Size(39, 39);
            this.refreshBTn.Text = "toolStripButton1";
            this.refreshBTn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // closeorderBtn
            // 
            this.closeorderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeorderBtn.Enabled = false;
            this.closeorderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeorderBtn.ForeColor = System.Drawing.Color.Red;
            this.closeorderBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeorderBtn.Image")));
            this.closeorderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeorderBtn.Name = "closeorderBtn";
            this.closeorderBtn.Size = new System.Drawing.Size(48, 39);
            this.closeorderBtn.Text = "اغلاق";
            this.closeorderBtn.Click += new System.EventHandler(this.closeorderBtn_Click);
            // 
            // enableOrderBtn
            // 
            this.enableOrderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.enableOrderBtn.Enabled = false;
            this.enableOrderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableOrderBtn.ForeColor = System.Drawing.Color.Red;
            this.enableOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("enableOrderBtn.Image")));
            this.enableOrderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enableOrderBtn.Name = "enableOrderBtn";
            this.enableOrderBtn.Size = new System.Drawing.Size(52, 39);
            this.enableOrderBtn.Text = "تفعيل";
            this.enableOrderBtn.Click += new System.EventHandler(this.enableOrderBtn_Click);
            // 
            // contract_NumberTextBox
            // 
            this.contract_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Contract_Number", true));
            this.contract_NumberTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_NumberTextBox.Location = new System.Drawing.Point(202, 79);
            this.contract_NumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.contract_NumberTextBox.Name = "contract_NumberTextBox";
            this.contract_NumberTextBox.Size = new System.Drawing.Size(363, 41);
            this.contract_NumberTextBox.TabIndex = 4;
            this.contract_NumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contract_NumberTextBox_KeyDown);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Qty", true));
            this.qtyTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextBox.Location = new System.Drawing.Point(202, 226);
            this.qtyTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(363, 41);
            this.qtyTextBox.TabIndex = 12;
            this.qtyTextBox.TextChanged += new System.EventHandler(this.qtyTextBox_TextChanged);
            // 
            // remain_QTYTextBox
            // 
            this.remain_QTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Remain_QTY", true));
            this.remain_QTYTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remain_QTYTextBox.Location = new System.Drawing.Point(202, 277);
            this.remain_QTYTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.remain_QTYTextBox.Name = "remain_QTYTextBox";
            this.remain_QTYTextBox.ReadOnly = true;
            this.remain_QTYTextBox.Size = new System.Drawing.Size(363, 41);
            this.remain_QTYTextBox.TabIndex = 14;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Notes", true));
            this.notesTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(202, 375);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(363, 41);
            this.notesTextBox.TabIndex = 26;
            // 
            // comm_IDTextBox
            // 
            this.comm_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Comm_ID", true));
            this.comm_IDTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comm_IDTextBox.Location = new System.Drawing.Point(202, 176);
            this.comm_IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.comm_IDTextBox.Name = "comm_IDTextBox";
            this.comm_IDTextBox.ReadOnly = true;
            this.comm_IDTextBox.Size = new System.Drawing.Size(363, 41);
            this.comm_IDTextBox.TabIndex = 29;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(708, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(47, 42);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // contract_IDTextBox
            // 
            this.contract_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Contract_ID", true));
            this.contract_IDTextBox.Enabled = false;
            this.contract_IDTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_IDTextBox.Location = new System.Drawing.Point(201, 128);
            this.contract_IDTextBox.Name = "contract_IDTextBox";
            this.contract_IDTextBox.Size = new System.Drawing.Size(364, 41);
            this.contract_IDTextBox.TabIndex = 114;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Status", true));
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.Location = new System.Drawing.Point(202, 326);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(363, 41);
            this.statusTextBox.TabIndex = 117;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // DEContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(768, 470);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(contract_IDLabel);
            this.Controls.Add(this.contract_IDTextBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.comm_IDTextBox);
            this.Controls.Add(contract_NumberLabel);
            this.Controls.Add(this.contract_NumberTextBox);
            this.Controls.Add(comm_IDLabel);
            this.Controls.Add(qtyLabel);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(remain_QTYLabel);
            this.Controls.Add(this.remain_QTYTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.contractBindingNavigator);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(784, 509);
            this.MinimumSize = new System.Drawing.Size(784, 509);
            this.Name = "DEContract";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "DEContract";
            this.Load += new System.EventHandler(this.DEContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).EndInit();
            this.contractBindingNavigator.ResumeLayout(false);
            this.contractBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Outdataset oUTDataset;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.BindingNavigator contractBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contractBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contract_NumberTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox remain_QTYTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox comm_IDTextBox;
        private System.Windows.Forms.ToolStripButton refreshBTn;
        private OutdatasetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox contract_IDTextBox;
        private System.Windows.Forms.ToolStripButton enableOrderBtn;
        private System.Windows.Forms.ToolStripButton closeorderBtn;
        private System.Windows.Forms.TextBox statusTextBox;
        private OutdatasetTableAdapters.ContractTableAdapter contractTableAdapter;
    }
}