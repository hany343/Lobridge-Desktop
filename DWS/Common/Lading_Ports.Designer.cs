namespace LoBridge.Common
{
    partial class Lading_Ports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lading_Ports));
            this.dLWSDataSet = new LoBridge.DLWSDataSet();
            this.lading_PortsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lading_PortsTableAdapter = new LoBridge.DLWSDataSetTableAdapters.Lading_PortsTableAdapter();
            this.tableAdapterManager = new LoBridge.DLWSDataSetTableAdapters.TableAdapterManager();
            this.lading_PortsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lading_PortsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lading_PortsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lading_PortsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lading_PortsBindingNavigator)).BeginInit();
            this.lading_PortsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lading_PortsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dLWSDataSet
            // 
            this.dLWSDataSet.CaseSensitive = true;
            this.dLWSDataSet.DataSetName = "DLWSDataSet";
            this.dLWSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lading_PortsBindingSource
            // 
            this.lading_PortsBindingSource.DataMember = "Lading_Ports";
            this.lading_PortsBindingSource.DataSource = this.dLWSDataSet;
            // 
            // lading_PortsTableAdapter
            // 
            this.lading_PortsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Lading_PortsTableAdapter = this.lading_PortsTableAdapter;
            this.tableAdapterManager.LogsTableAdapter = null;
            this.tableAdapterManager.RepresentativeTableAdapter = null;
            this.tableAdapterManager.Transport_CoTableAdapter = null;
            this.tableAdapterManager.TruckTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoBridge.DLWSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_PermTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WcardIDTableAdapter = null;
            // 
            // lading_PortsBindingNavigator
            // 
            this.lading_PortsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lading_PortsBindingNavigator.BindingSource = this.lading_PortsBindingSource;
            this.lading_PortsBindingNavigator.CountItem = null;
            this.lading_PortsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lading_PortsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lading_PortsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.lading_PortsBindingNavigatorSaveItem});
            this.lading_PortsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lading_PortsBindingNavigator.MoveFirstItem = null;
            this.lading_PortsBindingNavigator.MoveLastItem = null;
            this.lading_PortsBindingNavigator.MoveNextItem = null;
            this.lading_PortsBindingNavigator.MovePreviousItem = null;
            this.lading_PortsBindingNavigator.Name = "lading_PortsBindingNavigator";
            this.lading_PortsBindingNavigator.PositionItem = null;
            this.lading_PortsBindingNavigator.Size = new System.Drawing.Size(282, 27);
            this.lading_PortsBindingNavigator.TabIndex = 0;
            this.lading_PortsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
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
            // lading_PortsBindingNavigatorSaveItem
            // 
            this.lading_PortsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lading_PortsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lading_PortsBindingNavigatorSaveItem.Image")));
            this.lading_PortsBindingNavigatorSaveItem.Name = "lading_PortsBindingNavigatorSaveItem";
            this.lading_PortsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lading_PortsBindingNavigatorSaveItem.Text = "Save Data";
            this.lading_PortsBindingNavigatorSaveItem.Click += new System.EventHandler(this.lading_PortsBindingNavigatorSaveItem_Click_1);
            // 
            // lading_PortsDataGridView
            // 
            this.lading_PortsDataGridView.AutoGenerateColumns = false;
            this.lading_PortsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lading_PortsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.lading_PortsDataGridView.DataSource = this.lading_PortsBindingSource;
            this.lading_PortsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lading_PortsDataGridView.Location = new System.Drawing.Point(0, 27);
            this.lading_PortsDataGridView.Name = "lading_PortsDataGridView";
            this.lading_PortsDataGridView.RowHeadersWidth = 51;
            this.lading_PortsDataGridView.RowTemplate.Height = 26;
            this.lading_PortsDataGridView.Size = new System.Drawing.Size(282, 304);
            this.lading_PortsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "lading_Port";
            this.dataGridViewTextBoxColumn1.HeaderText = "lading_Port";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Lading_Ports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(282, 331);
            this.Controls.Add(this.lading_PortsDataGridView);
            this.Controls.Add(this.lading_PortsBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(300, 378);
            this.MinimumSize = new System.Drawing.Size(300, 378);
            this.Name = "Lading_Ports";
            this.Text = "Lading_Ports";
            this.Load += new System.EventHandler(this.Lading_Ports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lading_PortsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lading_PortsBindingNavigator)).EndInit();
            this.lading_PortsBindingNavigator.ResumeLayout(false);
            this.lading_PortsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lading_PortsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLWSDataSet dLWSDataSet;
        private System.Windows.Forms.BindingSource lading_PortsBindingSource;
        private DLWSDataSetTableAdapters.Lading_PortsTableAdapter lading_PortsTableAdapter;
        private DLWSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lading_PortsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton lading_PortsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lading_PortsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}