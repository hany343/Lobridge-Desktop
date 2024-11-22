namespace LoBridge.Inbound
{
    partial class INladAdvEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INladAdvEdit));
            this.iNdataset = new LoBridge.INdataset();
            this.tableAdapterManager = new LoBridge.INdatasetTableAdapters.TableAdapterManager();
            this.fillRCardToolStrip = new System.Windows.Forms.ToolStrip();
            this.lidToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lidToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillRCardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rcard1DataGridView = new System.Windows.Forms.DataGridView();
            this.ladingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladingTableAdapter = new LoBridge.INdatasetTableAdapters.LadingTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Truck_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcard1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rcard1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).BeginInit();
            this.fillRCardToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcard1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcard1BindingNavigator)).BeginInit();
            this.rcard1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iNdataset
            // 
            this.iNdataset.DataSetName = "INdataset";
            this.iNdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.INBatchTableAdapter = null;
            this.tableAdapterManager.LadingTableAdapter = this.ladingTableAdapter;
            this.tableAdapterManager.Local_SuppliersTableAdapter = null;
            this.tableAdapterManager.ShipmentTableAdapter = null;
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoBridge.INdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WcardIDTableAdapter = null;
            // 
            // fillRCardToolStrip
            // 
            this.fillRCardToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillRCardToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lidToolStripLabel,
            this.lidToolStripTextBox,
            this.fillRCardToolStripButton});
            this.fillRCardToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillRCardToolStrip.Name = "fillRCardToolStrip";
            this.fillRCardToolStrip.Size = new System.Drawing.Size(1137, 27);
            this.fillRCardToolStrip.TabIndex = 1;
            this.fillRCardToolStrip.Text = "fillRCardToolStrip";
            // 
            // lidToolStripLabel
            // 
            this.lidToolStripLabel.Name = "lidToolStripLabel";
            this.lidToolStripLabel.Size = new System.Drawing.Size(32, 24);
            this.lidToolStripLabel.Text = "Lid:";
            // 
            // lidToolStripTextBox
            // 
            this.lidToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lidToolStripTextBox.Name = "lidToolStripTextBox";
            this.lidToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillRCardToolStripButton
            // 
            this.fillRCardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillRCardToolStripButton.Name = "fillRCardToolStripButton";
            this.fillRCardToolStripButton.Size = new System.Drawing.Size(72, 24);
            this.fillRCardToolStripButton.Text = "FillRCard";
            this.fillRCardToolStripButton.Click += new System.EventHandler(this.fillRCardToolStripButton_Click);
            // 
            // rcard1DataGridView
            // 
            this.rcard1DataGridView.AllowUserToAddRows = false;
            this.rcard1DataGridView.AllowUserToDeleteRows = false;
            this.rcard1DataGridView.AutoGenerateColumns = false;
            this.rcard1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rcard1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.BatchID,
            this.Driver_ID,
            this.Truck_ID,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn32});
            this.rcard1DataGridView.DataSource = this.ladingBindingSource;
            this.rcard1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcard1DataGridView.Location = new System.Drawing.Point(0, 54);
            this.rcard1DataGridView.Name = "rcard1DataGridView";
            this.rcard1DataGridView.RowHeadersWidth = 51;
            this.rcard1DataGridView.RowTemplate.Height = 26;
            this.rcard1DataGridView.Size = new System.Drawing.Size(1137, 429);
            this.rcard1DataGridView.TabIndex = 2;
            // 
            // ladingBindingSource
            // 
            this.ladingBindingSource.DataMember = "Lading";
            this.ladingBindingSource.DataSource = this.iNdataset;
            // 
            // ladingTableAdapter
            // 
            this.ladingTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ladingID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ladingID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn2.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // BatchID
            // 
            this.BatchID.DataPropertyName = "BatchID";
            this.BatchID.HeaderText = "BatchID";
            this.BatchID.MinimumWidth = 6;
            this.BatchID.Name = "BatchID";
            this.BatchID.Width = 125;
            // 
            // Driver_ID
            // 
            this.Driver_ID.DataPropertyName = "Driver_ID";
            this.Driver_ID.HeaderText = "Driver_ID";
            this.Driver_ID.MinimumWidth = 6;
            this.Driver_ID.Name = "Driver_ID";
            this.Driver_ID.Width = 125;
            // 
            // Truck_ID
            // 
            this.Truck_ID.DataPropertyName = "Truck_ID";
            this.Truck_ID.HeaderText = "Truck_ID";
            this.Truck_ID.MinimumWidth = 6;
            this.Truck_ID.Name = "Truck_ID";
            this.Truck_ID.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Loading_Station";
            this.dataGridViewTextBoxColumn4.HeaderText = "Loading_Station";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fill_Type";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fill_Type";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Bags_Count";
            this.dataGridViewTextBoxColumn8.HeaderText = "Bags_Count";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Stack_Bar";
            this.dataGridViewTextBoxColumn9.HeaderText = "Stack_Bar";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "BLading";
            this.dataGridViewTextBoxColumn32.HeaderText = "BLading";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 125;
            // 
            // rcard1BindingNavigatorSaveItem
            // 
            this.rcard1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rcard1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rcard1BindingNavigatorSaveItem.Image")));
            this.rcard1BindingNavigatorSaveItem.Name = "rcard1BindingNavigatorSaveItem";
            this.rcard1BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.rcard1BindingNavigatorSaveItem.Text = "Save Data";
            this.rcard1BindingNavigatorSaveItem.Click += new System.EventHandler(this.ladingBindingNavigatorSaveItem_Click);
            // 
            // rcard1BindingNavigator
            // 
            this.rcard1BindingNavigator.AddNewItem = null;
            this.rcard1BindingNavigator.CountItem = null;
            this.rcard1BindingNavigator.DeleteItem = null;
            this.rcard1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rcard1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rcard1BindingNavigatorSaveItem});
            this.rcard1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rcard1BindingNavigator.MoveFirstItem = null;
            this.rcard1BindingNavigator.MoveLastItem = null;
            this.rcard1BindingNavigator.MoveNextItem = null;
            this.rcard1BindingNavigator.MovePreviousItem = null;
            this.rcard1BindingNavigator.Name = "rcard1BindingNavigator";
            this.rcard1BindingNavigator.PositionItem = null;
            this.rcard1BindingNavigator.Size = new System.Drawing.Size(1137, 27);
            this.rcard1BindingNavigator.TabIndex = 0;
            this.rcard1BindingNavigator.Text = "bindingNavigator1";
            // 
            // INladAdvEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 483);
            this.Controls.Add(this.rcard1DataGridView);
            this.Controls.Add(this.fillRCardToolStrip);
            this.Controls.Add(this.rcard1BindingNavigator);
            this.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "INladAdvEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "INladAdvEdit";
            this.Load += new System.EventHandler(this.INladAdvEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).EndInit();
            this.fillRCardToolStrip.ResumeLayout(false);
            this.fillRCardToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcard1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcard1BindingNavigator)).EndInit();
            this.rcard1BindingNavigator.ResumeLayout(false);
            this.rcard1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INdataset iNdataset;
        private INdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillRCardToolStrip;
        private System.Windows.Forms.ToolStripLabel lidToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lidToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillRCardToolStripButton;
        private System.Windows.Forms.DataGridView rcard1DataGridView;
        private INdatasetTableAdapters.LadingTableAdapter ladingTableAdapter;
        private System.Windows.Forms.BindingSource ladingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truck_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.ToolStripButton rcard1BindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator rcard1BindingNavigator;
    }
}