namespace LoBridge
{
    partial class ListTrucks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTrucks));
            this.dLWSDataSet = new LoBridge.DLWSDataSet();
            this.truckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truckTableAdapter = new LoBridge.DLWSDataSetTableAdapters.TruckTableAdapter();
            this.truckBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.truckBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.truckDataGridView = new System.Windows.Forms.DataGridView();
            this.fillByTNumberToolStrip = new System.Windows.Forms.ToolStrip();
            this.tnumToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tnumToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByTNumberToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trailer_traffic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingNavigator)).BeginInit();
            this.truckBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckDataGridView)).BeginInit();
            this.fillByTNumberToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dLWSDataSet
            // 
            this.dLWSDataSet.CaseSensitive = true;
            this.dLWSDataSet.DataSetName = "DLWSDataSet";
            this.dLWSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // truckBindingSource
            // 
            this.truckBindingSource.DataMember = "Truck";
            this.truckBindingSource.DataSource = this.dLWSDataSet;
            // 
            // truckTableAdapter
            // 
            this.truckTableAdapter.ClearBeforeFill = true;
            // 
            // truckBindingNavigator
            // 
            this.truckBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.truckBindingNavigator.BindingSource = this.truckBindingSource;
            this.truckBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.truckBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.truckBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.truckBindingNavigatorSaveItem});
            this.truckBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.truckBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.truckBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.truckBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.truckBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.truckBindingNavigator.Name = "truckBindingNavigator";
            this.truckBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.truckBindingNavigator.Size = new System.Drawing.Size(1127, 25);
            this.truckBindingNavigator.TabIndex = 0;
            this.truckBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // truckBindingNavigatorSaveItem
            // 
            this.truckBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.truckBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("truckBindingNavigatorSaveItem.Image")));
            this.truckBindingNavigatorSaveItem.Name = "truckBindingNavigatorSaveItem";
            this.truckBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.truckBindingNavigatorSaveItem.Text = "Save Data";
            this.truckBindingNavigatorSaveItem.Click += new System.EventHandler(this.truckBindingNavigatorSaveItem_Click);
            // 
            // truckDataGridView
            // 
            this.truckDataGridView.AutoGenerateColumns = false;
            this.truckDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.truckDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Trailer_traffic,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn10});
            this.truckDataGridView.DataSource = this.truckBindingSource;
            this.truckDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truckDataGridView.Location = new System.Drawing.Point(0, 53);
            this.truckDataGridView.Name = "truckDataGridView";
            this.truckDataGridView.RowTemplate.Height = 30;
            this.truckDataGridView.Size = new System.Drawing.Size(1127, 397);
            this.truckDataGridView.TabIndex = 1;
            this.truckDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.truckDataGridView_CellContentClick);
            // 
            // fillByTNumberToolStrip
            // 
            this.fillByTNumberToolStrip.BackColor = System.Drawing.Color.SteelBlue;
            this.fillByTNumberToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByTNumberToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tnumToolStripLabel,
            this.tnumToolStripTextBox,
            this.fillByTNumberToolStripButton});
            this.fillByTNumberToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByTNumberToolStrip.Name = "fillByTNumberToolStrip";
            this.fillByTNumberToolStrip.Size = new System.Drawing.Size(1127, 28);
            this.fillByTNumberToolStrip.TabIndex = 2;
            this.fillByTNumberToolStrip.Text = "fillByTNumberToolStrip";
            // 
            // tnumToolStripLabel
            // 
            this.tnumToolStripLabel.Name = "tnumToolStripLabel";
            this.tnumToolStripLabel.Size = new System.Drawing.Size(86, 25);
            this.tnumToolStripLabel.Text = "رقم السيارة:";
            // 
            // tnumToolStripTextBox
            // 
            this.tnumToolStripTextBox.Name = "tnumToolStripTextBox";
            this.tnumToolStripTextBox.Size = new System.Drawing.Size(100, 28);
            this.tnumToolStripTextBox.TextChanged += new System.EventHandler(this.tnumToolStripTextBox_TextChanged);
            // 
            // fillByTNumberToolStripButton
            // 
            this.fillByTNumberToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByTNumberToolStripButton.Name = "fillByTNumberToolStripButton";
            this.fillByTNumberToolStripButton.Size = new System.Drawing.Size(43, 25);
            this.fillByTNumberToolStripButton.Text = "بحث";
            this.fillByTNumberToolStripButton.Click += new System.EventHandler(this.fillByTNumberToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Truck_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "كود";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Truck_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "رقم السيارة";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Truck_traffic";
            this.dataGridViewTextBoxColumn4.HeaderText = "وحدة مرور";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Trailer_number";
            this.dataGridViewTextBoxColumn5.HeaderText = "رقم مقطورة";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // Trailer_traffic
            // 
            this.Trailer_traffic.DataPropertyName = "Trailer_traffic";
            this.Trailer_traffic.HeaderText = "مرور المقطورة";
            this.Trailer_traffic.Name = "Trailer_traffic";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Owner";
            this.dataGridViewTextBoxColumn8.HeaderText = "مالك السيارة";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn12.HeaderText = "تاريخ التسجيل";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn10.HeaderText = "ملاحظات";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // ListTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.truckDataGridView);
            this.Controls.Add(this.fillByTNumberToolStrip);
            this.Controls.Add(this.truckBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListTrucks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ListTrucks";
            this.Load += new System.EventHandler(this.ListTrucks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckBindingNavigator)).EndInit();
            this.truckBindingNavigator.ResumeLayout(false);
            this.truckBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckDataGridView)).EndInit();
            this.fillByTNumberToolStrip.ResumeLayout(false);
            this.fillByTNumberToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLWSDataSet dLWSDataSet;
        private System.Windows.Forms.BindingSource truckBindingSource;
        private DLWSDataSetTableAdapters.TruckTableAdapter truckTableAdapter;
        private System.Windows.Forms.BindingNavigator truckBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton truckBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView truckDataGridView;
        private System.Windows.Forms.ToolStrip fillByTNumberToolStrip;
        private System.Windows.Forms.ToolStripLabel tnumToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tnumToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByTNumberToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trailer_traffic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}