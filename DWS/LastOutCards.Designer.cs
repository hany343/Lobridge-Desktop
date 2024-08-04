namespace LoBridge
{
    partial class LastOutCards
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
            this.oUTDataset = new LoBridge.Outdataset();
            this.lcacrd1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastLadingoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastLadingoutTableAdapter = new LoBridge.OutdatasetTableAdapters.LastLadingoutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastLadingoutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dLWSDataSet
            // 
            this.oUTDataset.CaseSensitive = true;
            this.oUTDataset.DataSetName = "DLWSDataSet";
            this.oUTDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lcacrd1DataGridView
            // 
            this.lcacrd1DataGridView.AllowUserToAddRows = false;
            this.lcacrd1DataGridView.AllowUserToDeleteRows = false;
            this.lcacrd1DataGridView.AutoGenerateColumns = false;
            this.lcacrd1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lcacrd1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn4});
            this.lcacrd1DataGridView.DataSource = this.lastLadingoutBindingSource;
            this.lcacrd1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcacrd1DataGridView.Location = new System.Drawing.Point(0, 0);
            this.lcacrd1DataGridView.Name = "lcacrd1DataGridView";
            this.lcacrd1DataGridView.ReadOnly = true;
            this.lcacrd1DataGridView.Size = new System.Drawing.Size(1165, 353);
            this.lcacrd1DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ladingID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ladingID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn2.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cust_NAME";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cust_NAME";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Comm_NAME";
            this.dataGridViewTextBoxColumn10.HeaderText = "Comm_NAME";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Truck_number";
            this.dataGridViewTextBoxColumn11.HeaderText = "Truck_number";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Driver_Name";
            this.dataGridViewTextBoxColumn21.HeaderText = "Driver_Name";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 150;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Order_Number";
            this.dataGridViewTextBoxColumn19.HeaderText = "Order_Number";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Contract_Number";
            this.dataGridViewTextBoxColumn20.HeaderText = "Contract_Number";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LOusername";
            this.dataGridViewTextBoxColumn4.HeaderText = "LOusername";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lastLadingoutBindingSource
            // 
            this.lastLadingoutBindingSource.DataMember = "LastLadingout";
            this.lastLadingoutBindingSource.DataSource = this.oUTDataset;
            // 
            // lastLadingoutTableAdapter
            // 
            this.lastLadingoutTableAdapter.ClearBeforeFill = true;
            // 
            // LastOutCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 353);
            this.Controls.Add(this.lcacrd1DataGridView);
            this.MaximizeBox = false;
            this.Name = "LastOutCards";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastOutCards";
            this.Load += new System.EventHandler(this.LastOutCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oUTDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcacrd1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastLadingoutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Outdataset oUTDataset;
        private System.Windows.Forms.DataGridView lcacrd1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource lastLadingoutBindingSource;
        private OutdatasetTableAdapters.LastLadingoutTableAdapter lastLadingoutTableAdapter;
    }
}