namespace LoBridge
{
    partial class Commodity
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
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label comm_IDLabel;
            System.Windows.Forms.Label comm_NAMELabel;
            System.Windows.Forms.Label comm_TYPELabel;
            System.Windows.Forms.Label descriptionLabel;
            this.commodityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.commodityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.commodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dLWSDataSet = new LoBridge.DLWSDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CommIDTextBox = new System.Windows.Forms.TextBox();
            this.comm_NAMETextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.comm_TYPETextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.commodityTableAdapter = new LoBridge.DLWSDataSetTableAdapters.CommodityTableAdapter();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.listcommPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            notesLabel = new System.Windows.Forms.Label();
            comm_IDLabel = new System.Windows.Forms.Label();
            comm_NAMELabel = new System.Windows.Forms.Label();
            comm_TYPELabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingNavigator)).BeginInit();
            this.commodityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(812, 204);
            notesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            notesLabel.Name = "notesLabel";
            notesLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            notesLabel.Size = new System.Drawing.Size(67, 25);
            notesLabel.TabIndex = 9;
            notesLabel.Text = "ملاحظات:";
            // 
            // comm_IDLabel
            // 
            comm_IDLabel.AutoSize = true;
            comm_IDLabel.Location = new System.Drawing.Point(812, 19);
            comm_IDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            comm_IDLabel.Name = "comm_IDLabel";
            comm_IDLabel.Size = new System.Drawing.Size(84, 25);
            comm_IDLabel.TabIndex = 1;
            comm_IDLabel.Text = "كود الصنف:";
            // 
            // comm_NAMELabel
            // 
            comm_NAMELabel.AutoSize = true;
            comm_NAMELabel.Location = new System.Drawing.Point(812, 66);
            comm_NAMELabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            comm_NAMELabel.Name = "comm_NAMELabel";
            comm_NAMELabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            comm_NAMELabel.Size = new System.Drawing.Size(85, 25);
            comm_NAMELabel.TabIndex = 3;
            comm_NAMELabel.Text = "اسم الصنف:";
            // 
            // comm_TYPELabel
            // 
            comm_TYPELabel.AutoSize = true;
            comm_TYPELabel.Location = new System.Drawing.Point(812, 160);
            comm_TYPELabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            comm_TYPELabel.Name = "comm_TYPELabel";
            comm_TYPELabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            comm_TYPELabel.Size = new System.Drawing.Size(81, 25);
            comm_TYPELabel.TabIndex = 7;
            comm_TYPELabel.Text = "نوع الصنف:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(812, 114);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            descriptionLabel.Size = new System.Drawing.Size(48, 25);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "المنشأ:";
            // 
            // commodityBindingNavigator
            // 
            this.commodityBindingNavigator.AddNewItem = null;
            this.commodityBindingNavigator.CountItem = null;
            this.commodityBindingNavigator.DeleteItem = null;
            this.commodityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator,
            this.commodityBindingNavigatorSaveItem});
            this.commodityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.commodityBindingNavigator.MoveFirstItem = null;
            this.commodityBindingNavigator.MoveLastItem = null;
            this.commodityBindingNavigator.MoveNextItem = null;
            this.commodityBindingNavigator.MovePreviousItem = null;
            this.commodityBindingNavigator.Name = "commodityBindingNavigator";
            this.commodityBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.commodityBindingNavigator.PositionItem = null;
            this.commodityBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.commodityBindingNavigator.Size = new System.Drawing.Size(1001, 43);
            this.commodityBindingNavigator.TabIndex = 0;
            this.commodityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::LoBridge.Properties.Resources.add2;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(39, 40);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = global::LoBridge.Properties.Resources.cancel;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(42, 40);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // commodityBindingNavigatorSaveItem
            // 
            this.commodityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.commodityBindingNavigatorSaveItem.Enabled = false;
            this.commodityBindingNavigatorSaveItem.Image = global::LoBridge.Properties.Resources.save3;
            this.commodityBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.commodityBindingNavigatorSaveItem.Name = "commodityBindingNavigatorSaveItem";
            this.commodityBindingNavigatorSaveItem.Size = new System.Drawing.Size(39, 40);
            this.commodityBindingNavigatorSaveItem.Text = "Save Data";
            this.commodityBindingNavigatorSaveItem.Click += new System.EventHandler(this.commodityBindingNavigatorSaveItem_Click);
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
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.CommIDTextBox);
            this.panel3.Controls.Add(this.comm_NAMETextBox);
            this.panel3.Controls.Add(notesLabel);
            this.panel3.Controls.Add(comm_IDLabel);
            this.panel3.Controls.Add(this.notesTextBox);
            this.panel3.Controls.Add(comm_NAMELabel);
            this.panel3.Controls.Add(this.comm_TYPETextBox);
            this.panel3.Controls.Add(comm_TYPELabel);
            this.panel3.Controls.Add(descriptionLabel);
            this.panel3.Controls.Add(this.descriptionTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Enabled = false;
            this.panel3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(99, 0);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(902, 252);
            this.panel3.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(303, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 29);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "وحدة القياس بالعدد";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CommIDTextBox
            // 
            this.CommIDTextBox.Location = new System.Drawing.Point(665, 19);
            this.CommIDTextBox.Name = "CommIDTextBox";
            this.CommIDTextBox.ReadOnly = true;
            this.CommIDTextBox.Size = new System.Drawing.Size(139, 34);
            this.CommIDTextBox.TabIndex = 12;
            this.CommIDTextBox.TabStop = false;
            // 
            // comm_NAMETextBox
            // 
            this.comm_NAMETextBox.BackColor = System.Drawing.Color.LightBlue;
            this.comm_NAMETextBox.Location = new System.Drawing.Point(469, 63);
            this.comm_NAMETextBox.Name = "comm_NAMETextBox";
            this.comm_NAMETextBox.Size = new System.Drawing.Size(335, 34);
            this.comm_NAMETextBox.TabIndex = 11;
            // 
            // notesTextBox
            // 
            this.notesTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.notesTextBox.Location = new System.Drawing.Point(239, 198);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notesTextBox.Size = new System.Drawing.Size(565, 50);
            this.notesTextBox.TabIndex = 10;
            // 
            // comm_TYPETextBox
            // 
            this.comm_TYPETextBox.BackColor = System.Drawing.Color.LightBlue;
            this.comm_TYPETextBox.Location = new System.Drawing.Point(469, 152);
            this.comm_TYPETextBox.Margin = new System.Windows.Forms.Padding(5);
            this.comm_TYPETextBox.Name = "comm_TYPETextBox";
            this.comm_TYPETextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comm_TYPETextBox.Size = new System.Drawing.Size(335, 34);
            this.comm_TYPETextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "امريكا",
            "البرازيل",
            "هولاندا"});
            this.descriptionTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.descriptionTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.descriptionTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.descriptionTextBox.Location = new System.Drawing.Point(469, 106);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descriptionTextBox.Size = new System.Drawing.Size(335, 34);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // commodityTableAdapter
            // 
            this.commodityTableAdapter.ClearBeforeFill = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(963, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(38, 37);
            this.ExitBtn.TabIndex = 113;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // listcommPanel
            // 
            this.listcommPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listcommPanel.Location = new System.Drawing.Point(0, 295);
            this.listcommPanel.Name = "listcommPanel";
            this.listcommPanel.Size = new System.Drawing.Size(1001, 433);
            this.listcommPanel.TabIndex = 114;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 252);
            this.panel1.TabIndex = 0;
            // 
            // Commodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1001, 728);
            this.Controls.Add(this.listcommPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.commodityBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1017, 398);
            this.Name = "Commodity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تكويد الاصناف";
            this.Load += new System.EventHandler(this.Commodity_Load_1);
            this.Shown += new System.EventHandler(this.Commodity_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingNavigator)).EndInit();
            this.commodityBindingNavigator.ResumeLayout(false);
            this.commodityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLWSDataSet dLWSDataSet;
        private DLWSDataSetTableAdapters.CommodityTableAdapter commodityTableAdapter;
        private System.Windows.Forms.BindingNavigator commodityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton commodityBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox comm_NAMETextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox comm_TYPETextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox CommIDTextBox;
        private System.Windows.Forms.BindingSource commodityBindingSource;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel listcommPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}