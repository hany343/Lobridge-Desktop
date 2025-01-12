namespace LoBridge.Common
{
    partial class TruckTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruckTypes));
            this.dLWSDataSet = new LoBridge.DLWSDataSet();
            this.truck_TypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truck_TypesTableAdapter = new LoBridge.DLWSDataSetTableAdapters.Truck_TypesTableAdapter();
            this.tableAdapterManager = new LoBridge.DLWSDataSetTableAdapters.TableAdapterManager();
            this.truck_TypesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.truck_TypesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.truck_TypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck_TypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck_TypesBindingNavigator)).BeginInit();
            this.truck_TypesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truck_TypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dLWSDataSet
            // 
            this.dLWSDataSet.CaseSensitive = true;
            this.dLWSDataSet.DataSetName = "DLWSDataSet";
            this.dLWSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // truck_TypesBindingSource
            // 
            this.truck_TypesBindingSource.DataMember = "Truck_Types";
            this.truck_TypesBindingSource.DataSource = this.dLWSDataSet;
            // 
            // truck_TypesTableAdapter
            // 
            this.truck_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CameraTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.CommodityTableAdapter = null;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.EmailsTableAdapter = null;
            this.tableAdapterManager.GWCardTableAdapter = null;
            this.tableAdapterManager.Lading_PortsTableAdapter = null;
            this.tableAdapterManager.LogsTableAdapter = null;
            this.tableAdapterManager.RepresentativeTableAdapter = null;
            this.tableAdapterManager.Transport_CoTableAdapter = null;
            this.tableAdapterManager.Truck_TypesTableAdapter = this.truck_TypesTableAdapter;
            this.tableAdapterManager.TruckTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoBridge.DLWSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_PermTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WcardIDTableAdapter = null;
            // 
            // truck_TypesBindingNavigator
            // 
            this.truck_TypesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.truck_TypesBindingNavigator.BindingSource = this.truck_TypesBindingSource;
            this.truck_TypesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.truck_TypesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.truck_TypesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.truck_TypesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.truck_TypesBindingNavigatorSaveItem});
            this.truck_TypesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.truck_TypesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.truck_TypesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.truck_TypesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.truck_TypesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.truck_TypesBindingNavigator.Name = "truck_TypesBindingNavigator";
            this.truck_TypesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.truck_TypesBindingNavigator.Size = new System.Drawing.Size(534, 31);
            this.truck_TypesBindingNavigator.TabIndex = 0;
            this.truck_TypesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // truck_TypesBindingNavigatorSaveItem
            // 
            this.truck_TypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.truck_TypesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("truck_TypesBindingNavigatorSaveItem.Image")));
            this.truck_TypesBindingNavigatorSaveItem.Name = "truck_TypesBindingNavigatorSaveItem";
            this.truck_TypesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.truck_TypesBindingNavigatorSaveItem.Text = "Save Data";
            this.truck_TypesBindingNavigatorSaveItem.Click += new System.EventHandler(this.truck_TypesBindingNavigatorSaveItem_Click);
            // 
            // truck_TypesDataGridView
            // 
            this.truck_TypesDataGridView.AutoGenerateColumns = false;
            this.truck_TypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.truck_TypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.truck_TypesDataGridView.DataSource = this.truck_TypesBindingSource;
            this.truck_TypesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.truck_TypesDataGridView.Location = new System.Drawing.Point(0, 31);
            this.truck_TypesDataGridView.Name = "truck_TypesDataGridView";
            this.truck_TypesDataGridView.RowHeadersWidth = 51;
            this.truck_TypesDataGridView.RowTemplate.Height = 26;
            this.truck_TypesDataGridView.Size = new System.Drawing.Size(534, 419);
            this.truck_TypesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Truck_Type";
            this.dataGridViewTextBoxColumn1.HeaderText = "Truck_Type";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // TruckTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.truck_TypesDataGridView);
            this.Controls.Add(this.truck_TypesBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(552, 497);
            this.MinimumSize = new System.Drawing.Size(552, 497);
            this.Name = "TruckTypes";
            this.Text = "TruckTypes";
            this.Load += new System.EventHandler(this.TruckTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck_TypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck_TypesBindingNavigator)).EndInit();
            this.truck_TypesBindingNavigator.ResumeLayout(false);
            this.truck_TypesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truck_TypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLWSDataSet dLWSDataSet;
        private System.Windows.Forms.BindingSource truck_TypesBindingSource;
        private DLWSDataSetTableAdapters.Truck_TypesTableAdapter truck_TypesTableAdapter;
        private DLWSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator truck_TypesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton truck_TypesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView truck_TypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}