namespace LoBridge
{
    partial class ListInCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListInCards));
            this.incardsDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Wdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Net_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wCard1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNdataset = new LoBridge.INdataset();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.wCard1TableAdapter = new LoBridge.INdatasetTableAdapters.WCard1TableAdapter();
            this.ladingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ladingTableAdapter = new LoBridge.INdatasetTableAdapters.LadingTableAdapter();
            this.summaryPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.countlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countFlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.netsumlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttunsPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.loadingBtn = new System.Windows.Forms.Button();
            this.WaitingInBtn = new System.Windows.Forms.Button();
            this.cancelledBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.enableBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rw1Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.rw2Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.shwcardBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.showwcBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tocheckBox1 = new System.Windows.Forms.CheckBox();
            this.todateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchStripTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchCBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.incardsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCard1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladingBindingSource)).BeginInit();
            this.summaryPanel1.SuspendLayout();
            this.buttunsPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // incardsDataGridView
            // 
            this.incardsDataGridView.AllowUserToAddRows = false;
            this.incardsDataGridView.AllowUserToDeleteRows = false;
            this.incardsDataGridView.AllowUserToOrderColumns = true;
            this.incardsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.incardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn11,
            this.F_weight,
            this.F_Wdate,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Net_Weight,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.Status});
            this.incardsDataGridView.DataSource = this.wCard1BindingSource;
            this.incardsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incardsDataGridView.EnableHeadersVisualStyles = false;
            this.incardsDataGridView.FilterAndSortEnabled = true;
            this.incardsDataGridView.Location = new System.Drawing.Point(5, 77);
            this.incardsDataGridView.Name = "incardsDataGridView";
            this.incardsDataGridView.ReadOnly = true;
            this.incardsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.incardsDataGridView.RowHeadersWidth = 51;
            this.incardsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incardsDataGridView.RowTemplate.Height = 30;
            this.incardsDataGridView.Size = new System.Drawing.Size(1306, 518);
            this.incardsDataGridView.TabIndex = 2;
            this.incardsDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.wCard1DataGridView_CellMouseDown);
            this.incardsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.wCard1DataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ladingID";
            this.dataGridViewTextBoxColumn9.HeaderText = "رقم الكارت";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "BLading";
            this.dataGridViewTextBoxColumn14.HeaderText = "رقم البوليصة";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Serial";
            this.dataGridViewTextBoxColumn13.HeaderText = "رقم الافراج";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn13.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Comm_NAME";
            this.dataGridViewTextBoxColumn11.HeaderText = "الصنف";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // F_weight
            // 
            this.F_weight.DataPropertyName = "F_weight";
            this.F_weight.HeaderText = "وزن اول";
            this.F_weight.MinimumWidth = 22;
            this.F_weight.Name = "F_weight";
            this.F_weight.ReadOnly = true;
            this.F_weight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.F_weight.Width = 80;
            // 
            // F_Wdate
            // 
            this.F_Wdate.DataPropertyName = "F_Wdate";
            this.F_Wdate.HeaderText = "تاريخ وزن اول";
            this.F_Wdate.MinimumWidth = 22;
            this.F_Wdate.Name = "F_Wdate";
            this.F_Wdate.ReadOnly = true;
            this.F_Wdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.F_Wdate.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "S_weight";
            this.dataGridViewTextBoxColumn4.HeaderText = "وزن ثان";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "S_Wdate";
            this.dataGridViewTextBoxColumn5.HeaderText = "تاريخ وزن ثان";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // Net_Weight
            // 
            this.Net_Weight.DataPropertyName = "Net_Weight";
            this.Net_Weight.HeaderText = "صافي الوزن";
            this.Net_Weight.MinimumWidth = 22;
            this.Net_Weight.Name = "Net_Weight";
            this.Net_Weight.ReadOnly = true;
            this.Net_Weight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Net_Weight.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Truck_number";
            this.dataGridViewTextBoxColumn7.HeaderText = "رقم السيارة";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Trailer_number";
            this.dataGridViewTextBoxColumn8.HeaderText = "رقم المقطورة";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Driver_Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "السائق";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "الحالة";
            this.Status.MinimumWidth = 22;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Status.Width = 60;
            // 
            // wCard1BindingSource
            // 
            this.wCard1BindingSource.DataMember = "WCard1";
            this.wCard1BindingSource.DataSource = this.iNdataset;
            // 
            // iNdataset
            // 
            this.iNdataset.DataSetName = "DLWSDataSet";
            this.iNdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(0, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(43, 38);
            this.ExitBtn.TabIndex = 114;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // wCard1TableAdapter
            // 
            this.wCard1TableAdapter.ClearBeforeFill = true;
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
            // summaryPanel1
            // 
            this.summaryPanel1.BackColor = System.Drawing.Color.White;
            this.summaryPanel1.ColumnCount = 10;
            this.summaryPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.summaryPanel1.Controls.Add(this.countlabel, 1, 0);
            this.summaryPanel1.Controls.Add(this.label1, 0, 0);
            this.summaryPanel1.Controls.Add(this.label2, 2, 0);
            this.summaryPanel1.Controls.Add(this.countFlabel, 3, 0);
            this.summaryPanel1.Controls.Add(this.label3, 7, 0);
            this.summaryPanel1.Controls.Add(this.label5, 4, 0);
            this.summaryPanel1.Controls.Add(this.netsumlabel, 8, 0);
            this.summaryPanel1.Controls.Add(this.label6, 9, 0);
            this.summaryPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.summaryPanel1.Location = new System.Drawing.Point(5, 595);
            this.summaryPanel1.Name = "summaryPanel1";
            this.summaryPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.summaryPanel1.RowCount = 2;
            this.summaryPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.summaryPanel1.Size = new System.Drawing.Size(1306, 40);
            this.summaryPanel1.TabIndex = 115;
            // 
            // countlabel
            // 
            this.countlabel.AutoSize = true;
            this.countlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.countlabel.Location = new System.Drawing.Point(1140, 10);
            this.countlabel.Name = "countlabel";
            this.countlabel.Size = new System.Drawing.Size(25, 26);
            this.countlabel.TabIndex = 1;
            this.countlabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1171, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "العدد الاجمالي:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1013, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "             تم وزن: ";
            // 
            // countFlabel
            // 
            this.countFlabel.AutoSize = true;
            this.countFlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countFlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countFlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.countFlabel.Location = new System.Drawing.Point(982, 10);
            this.countFlabel.Name = "countFlabel";
            this.countFlabel.Size = new System.Drawing.Size(25, 26);
            this.countFlabel.TabIndex = 6;
            this.countFlabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "اجمالي وزن المصنع:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(893, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "طن           ";
            // 
            // netsumlabel
            // 
            this.netsumlabel.AutoSize = true;
            this.netsumlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netsumlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netsumlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.netsumlabel.Location = new System.Drawing.Point(705, 10);
            this.netsumlabel.Name = "netsumlabel";
            this.netsumlabel.Size = new System.Drawing.Size(25, 26);
            this.netsumlabel.TabIndex = 3;
            this.netsumlabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(616, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "طن           ";
            // 
            // buttunsPanel1
            // 
            this.buttunsPanel1.BackColor = System.Drawing.Color.White;
            this.buttunsPanel1.Controls.Add(this.button4);
            this.buttunsPanel1.Controls.Add(this.loadingBtn);
            this.buttunsPanel1.Controls.Add(this.WaitingInBtn);
            this.buttunsPanel1.Controls.Add(this.cancelledBtn);
            this.buttunsPanel1.Controls.Add(this.button3);
            this.buttunsPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttunsPanel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttunsPanel1.Location = new System.Drawing.Point(40, 0);
            this.buttunsPanel1.Name = "buttunsPanel1";
            this.buttunsPanel1.Size = new System.Drawing.Size(1266, 38);
            this.buttunsPanel1.TabIndex = 116;
            this.buttunsPanel1.WrapContents = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Lavender;
            this.button4.Location = new System.Drawing.Point(1205, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 32);
            this.button4.TabIndex = 116;
            this.button4.Text = "طباعة ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // loadingBtn
            // 
            this.loadingBtn.BackColor = System.Drawing.Color.Transparent;
            this.loadingBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadingBtn.BackgroundImage")));
            this.loadingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadingBtn.FlatAppearance.BorderSize = 0;
            this.loadingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadingBtn.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingBtn.ForeColor = System.Drawing.Color.Lavender;
            this.loadingBtn.Location = new System.Drawing.Point(1113, 3);
            this.loadingBtn.Name = "loadingBtn";
            this.loadingBtn.Size = new System.Drawing.Size(86, 32);
            this.loadingBtn.TabIndex = 118;
            this.loadingBtn.Text = "جاري التفريغ";
            this.loadingBtn.UseVisualStyleBackColor = false;
            this.loadingBtn.Click += new System.EventHandler(this.unLoadingBtn_Click);
            // 
            // WaitingInBtn
            // 
            this.WaitingInBtn.BackColor = System.Drawing.Color.Transparent;
            this.WaitingInBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WaitingInBtn.BackgroundImage")));
            this.WaitingInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WaitingInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WaitingInBtn.FlatAppearance.BorderSize = 0;
            this.WaitingInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WaitingInBtn.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingInBtn.ForeColor = System.Drawing.Color.Lavender;
            this.WaitingInBtn.Location = new System.Drawing.Point(1029, 3);
            this.WaitingInBtn.Name = "WaitingInBtn";
            this.WaitingInBtn.Size = new System.Drawing.Size(78, 32);
            this.WaitingInBtn.TabIndex = 119;
            this.WaitingInBtn.Text = "خارج المصنع";
            this.WaitingInBtn.UseVisualStyleBackColor = false;
            this.WaitingInBtn.Click += new System.EventHandler(this.outwaitingBtn_Click);
            // 
            // cancelledBtn
            // 
            this.cancelledBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelledBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelledBtn.BackgroundImage")));
            this.cancelledBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelledBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelledBtn.FlatAppearance.BorderSize = 0;
            this.cancelledBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelledBtn.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelledBtn.ForeColor = System.Drawing.Color.Lavender;
            this.cancelledBtn.Location = new System.Drawing.Point(948, 3);
            this.cancelledBtn.Name = "cancelledBtn";
            this.cancelledBtn.Size = new System.Drawing.Size(75, 32);
            this.cancelledBtn.TabIndex = 120;
            this.cancelledBtn.Text = "عرض الملغي";
            this.cancelledBtn.UseVisualStyleBackColor = false;
            this.cancelledBtn.Click += new System.EventHandler(this.cancelledBtn_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::LoBridge.Properties.Resources.Blue_button;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(853, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 32);
            this.button3.TabIndex = 124;
            this.button3.Text = "Export XLS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.exportXLSBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.buttunsPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 38);
            this.panel1.TabIndex = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.contextMenuStrip1.DropShadowEnabled = false;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelBtn,
            this.toolStripSeparator2,
            this.enableBtn,
            this.toolStripSeparator3,
            this.rw1Btn,
            this.toolStripSeparator6,
            this.rw2Btn,
            this.shwcardBtn,
            this.showwcBtn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 202);
            this.contextMenuStrip1.Text = "الخيارات";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(166, 30);
            this.cancelBtn.Text = "الغاء الكارت";
            this.cancelBtn.Click += new System.EventHandler(this.CancelInCard_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // enableBtn
            // 
            this.enableBtn.BackColor = System.Drawing.Color.Green;
            this.enableBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.enableBtn.Enabled = false;
            this.enableBtn.Name = "enableBtn";
            this.enableBtn.Size = new System.Drawing.Size(166, 30);
            this.enableBtn.Text = "تفعيل الكارت";
            this.enableBtn.Click += new System.EventHandler(this.enablecardBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // rw1Btn
            // 
            this.rw1Btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rw1Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rw1Btn.Enabled = false;
            this.rw1Btn.Name = "rw1Btn";
            this.rw1Btn.Size = new System.Drawing.Size(166, 30);
            this.rw1Btn.Text = "اعادة الوزن الاول";
            this.rw1Btn.Click += new System.EventHandler(this.rw1Btn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(163, 6);
            // 
            // rw2Btn
            // 
            this.rw2Btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rw2Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rw2Btn.Enabled = false;
            this.rw2Btn.Name = "rw2Btn";
            this.rw2Btn.Size = new System.Drawing.Size(166, 30);
            this.rw2Btn.Text = "اعادة الوزن الثاني";
            this.rw2Btn.Click += new System.EventHandler(this.ReWseconed_Click);
            // 
            // shwcardBtn
            // 
            this.shwcardBtn.Name = "shwcardBtn";
            this.shwcardBtn.Size = new System.Drawing.Size(166, 30);
            this.shwcardBtn.Text = "عرض الكارت";
            this.shwcardBtn.Click += new System.EventHandler(this.shwcardBtn_Click);
            // 
            // showwcBtn
            // 
            this.showwcBtn.Name = "showwcBtn";
            this.showwcBtn.Size = new System.Drawing.Size(166, 30);
            this.showwcBtn.Text = "عرض تذكرة الوزن";
            this.showwcBtn.Click += new System.EventHandler(this.showwcBtn_Click);
            // 
            // filterPanel
            // 
            this.filterPanel.AutoSize = true;
            this.filterPanel.Controls.Add(this.button2);
            this.filterPanel.Controls.Add(this.tocheckBox1);
            this.filterPanel.Controls.Add(this.todateTimePicker2);
            this.filterPanel.Controls.Add(this.label4);
            this.filterPanel.Controls.Add(this.button1);
            this.filterPanel.Controls.Add(this.SearchStripTextBox);
            this.filterPanel.Controls.Add(this.dateTimePicker1);
            this.filterPanel.Controls.Add(this.searchCBox);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1306, 34);
            this.filterPanel.TabIndex = 125;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(388, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 31);
            this.button2.TabIndex = 134;
            this.button2.Text = "عرض";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.searchbyDate_Click);
            // 
            // tocheckBox1
            // 
            this.tocheckBox1.AutoSize = true;
            this.tocheckBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tocheckBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tocheckBox1.Location = new System.Drawing.Point(581, 8);
            this.tocheckBox1.Name = "tocheckBox1";
            this.tocheckBox1.Size = new System.Drawing.Size(68, 28);
            this.tocheckBox1.TabIndex = 133;
            this.tocheckBox1.Text = "الي";
            this.tocheckBox1.UseVisualStyleBackColor = false;
            // 
            // todateTimePicker2
            // 
            this.todateTimePicker2.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todateTimePicker2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todateTimePicker2.Location = new System.Drawing.Point(447, 4);
            this.todateTimePicker2.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.todateTimePicker2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.todateTimePicker2.Name = "todateTimePicker2";
            this.todateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.todateTimePicker2.RightToLeftLayout = true;
            this.todateTimePicker2.Size = new System.Drawing.Size(128, 32);
            this.todateTimePicker2.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 131;
            this.label4.Text = "تقرير بتاريخ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(940, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 32);
            this.button1.TabIndex = 128;
            this.button1.Text = "عرض";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.fillBYLIDToolStripButton_Click);
            // 
            // SearchStripTextBox
            // 
            this.SearchStripTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStripTextBox.Location = new System.Drawing.Point(998, 1);
            this.SearchStripTextBox.Name = "SearchStripTextBox";
            this.SearchStripTextBox.Size = new System.Drawing.Size(120, 38);
            this.SearchStripTextBox.TabIndex = 127;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(645, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 32);
            this.dateTimePicker1.TabIndex = 129;
            // 
            // searchCBox
            // 
            this.searchCBox.BackColor = System.Drawing.Color.White;
            this.searchCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCBox.FormattingEnabled = true;
            this.searchCBox.Items.AddRange(new object[] {
            "بحث برقم الكارت",
            "بحث اخر عدد",
            "بحث برقم الافراج",
            "بحث بالشحنة"});
            this.searchCBox.Location = new System.Drawing.Point(1124, 3);
            this.searchCBox.Name = "searchCBox";
            this.searchCBox.Size = new System.Drawing.Size(179, 32);
            this.searchCBox.TabIndex = 126;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.filterPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 34);
            this.panel2.TabIndex = 135;
            // 
            // ListInCards
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1316, 640);
            this.Controls.Add(this.incardsDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.summaryPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListInCards";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ListInCards";
            this.Load += new System.EventHandler(this.ListInCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incardsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCard1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladingBindingSource)).EndInit();
            this.summaryPanel1.ResumeLayout(false);
            this.summaryPanel1.PerformLayout();
            this.buttunsPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private INdataset iNdataset;
        private System.Windows.Forms.BindingSource wCard1BindingSource;
        private INdatasetTableAdapters.WCard1TableAdapter wCard1TableAdapter;
        private Zuby.ADGV.AdvancedDataGridView incardsDataGridView;
        private System.Windows.Forms.BindingSource ladingBindingSource;
        private INdatasetTableAdapters.LadingTableAdapter ladingTableAdapter;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TableLayoutPanel summaryPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label netsumlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countFlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Wdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Net_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.FlowLayoutPanel buttunsPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button loadingBtn;
        private System.Windows.Forms.Button WaitingInBtn;
        private System.Windows.Forms.Button cancelledBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem enableBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem rw1Btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem rw2Btn;
        private System.Windows.Forms.ToolStripMenuItem shwcardBtn;
        private System.Windows.Forms.ToolStripMenuItem showwcBtn;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox tocheckBox1;
        private System.Windows.Forms.DateTimePicker todateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchStripTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox searchCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}