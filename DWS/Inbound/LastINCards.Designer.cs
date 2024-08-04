namespace LoBridge
{
    partial class LastINCards
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ladingDataGridView = new System.Windows.Forms.DataGridView();
            this.ladingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InbatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNdataset = new LoBridge.INdataset();
            this.ladingTableAdapter = new LoBridge.INdatasetTableAdapters.LadingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ladingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).BeginInit();
            this.SuspendLayout();
            // 
            // ladingDataGridView
            // 
            this.ladingDataGridView.AllowUserToAddRows = false;
            this.ladingDataGridView.AllowUserToDeleteRows = false;
            this.ladingDataGridView.AllowUserToOrderColumns = true;
            this.ladingDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            this.ladingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ladingDataGridView.AutoGenerateColumns = false;
            this.ladingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ladingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ladingDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ladingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ladingDataGridView.ColumnHeadersHeight = 50;
            this.ladingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ladingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ladingIDDataGridViewTextBoxColumn,
            this.BLading,
            this.InbatchID,
            this.qtyDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.ladingDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ladingDataGridView.DataSource = this.ladingBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ladingDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ladingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ladingDataGridView.EnableHeadersVisualStyles = false;
            this.ladingDataGridView.GridColor = System.Drawing.Color.LightSeaGreen;
            this.ladingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ladingDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ladingDataGridView.MultiSelect = false;
            this.ladingDataGridView.Name = "ladingDataGridView";
            this.ladingDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ladingDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ladingDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.ladingDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ladingDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            this.ladingDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladingDataGridView.RowTemplate.DividerHeight = 3;
            this.ladingDataGridView.RowTemplate.Height = 40;
            this.ladingDataGridView.RowTemplate.ReadOnly = true;
            this.ladingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ladingDataGridView.Size = new System.Drawing.Size(502, 287);
            this.ladingDataGridView.TabIndex = 3;
            // 
            // ladingIDDataGridViewTextBoxColumn
            // 
            this.ladingIDDataGridViewTextBoxColumn.DataPropertyName = "ladingID";
            this.ladingIDDataGridViewTextBoxColumn.HeaderText = "رقم الكارت";
            this.ladingIDDataGridViewTextBoxColumn.Name = "ladingIDDataGridViewTextBoxColumn";
            this.ladingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladingIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // BLading
            // 
            this.BLading.DataPropertyName = "BLading";
            this.BLading.HeaderText = "بوليصة";
            this.BLading.Name = "BLading";
            this.BLading.ReadOnly = true;
            this.BLading.Width = 60;
            // 
            // InbatchID
            // 
            this.InbatchID.DataPropertyName = "Serial";
            this.InbatchID.HeaderText = "الافراج";
            this.InbatchID.Name = "InbatchID";
            this.InbatchID.ReadOnly = true;
            this.InbatchID.Width = 70;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "الكمية/طن";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 80;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ladingBindingSource
            // 
            this.ladingBindingSource.DataMember = "Lading";
            this.ladingBindingSource.DataSource = this.iNdataset;
            // 
            // iNdataset
            // 
            this.iNdataset.DataSetName = "DLWSDataSet";
            this.iNdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ladingTableAdapter
            // 
            this.ladingTableAdapter.ClearBeforeFill = true;
            // 
            // LastINCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 287);
            this.Controls.Add(this.ladingDataGridView);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LastINCards";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "LastINCards";
            this.Load += new System.EventHandler(this.LastINCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ladingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ladingDataGridView;
        private INdataset iNdataset;
        private System.Windows.Forms.BindingSource ladingBindingSource;
        private INdatasetTableAdapters.LadingTableAdapter ladingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLading;
        private System.Windows.Forms.DataGridViewTextBoxColumn InbatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}