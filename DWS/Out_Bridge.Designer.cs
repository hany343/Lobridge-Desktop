namespace LoBridge_V2
{
    partial class Out_Bridge
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label weight_NotesLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label loading_stationLabel;
            System.Windows.Forms.Label s_weightLabel;
            System.Windows.Forms.Label f_weightLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label wCardIDLabel;
            System.Windows.Forms.Label bLadingLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.datapanel = new System.Windows.Forms.Panel();
            this.wCardIDTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.s_WdateTextBox = new System.Windows.Forms.TextBox();
            this.bagstextBox1 = new System.Windows.Forms.TextBox();
            this.f_WdateTextBox = new System.Windows.Forms.TextBox();
            this.stacktextBox2 = new System.Windows.Forms.TextBox();
            this.weight_NotesTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.s_weightTextBox = new System.Windows.Forms.TextBox();
            this.loading_stationComboBox = new System.Windows.Forms.ComboBox();
            this.f_weightTextBox = new System.Windows.Forms.TextBox();
            this.nettextBox1 = new System.Windows.Forms.TextBox();
            this.shrinktextBox1 = new System.Windows.Forms.TextBox();
            this.Campanel = new System.Windows.Forms.Panel();
            this.SW_button = new System.Windows.Forms.Button();
            this.FW_button = new System.Windows.Forms.Button();
            this.lading_OutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outDataSet = new LoBridge_V2.Outdataset();
            this.lading_OutTableAdapter = new LoBridge_V2.OutDataSetTableAdapters.Lading_OutTableAdapter();
            this.ladingIDtextBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            weight_NotesLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            loading_stationLabel = new System.Windows.Forms.Label();
            s_weightLabel = new System.Windows.Forms.Label();
            f_weightLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            wCardIDLabel = new System.Windows.Forms.Label();
            bLadingLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.datapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lading_OutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(496, 344);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 25);
            label3.TabIndex = 98;
            label3.Text = "شريط الترصيص:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(120, 265);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(113, 25);
            label5.TabIndex = 103;
            label5.Text = "الكمية المسموحة:";
            // 
            // weight_NotesLabel
            // 
            weight_NotesLabel.AutoSize = true;
            weight_NotesLabel.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weight_NotesLabel.Location = new System.Drawing.Point(497, 381);
            weight_NotesLabel.Name = "weight_NotesLabel";
            weight_NotesLabel.Size = new System.Drawing.Size(63, 25);
            weight_NotesLabel.TabIndex = 102;
            weight_NotesLabel.Text = "ملحوظة:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(122, 305);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 25);
            label4.TabIndex = 99;
            label4.Text = "عدد الاجولة:";
            // 
            // loading_stationLabel
            // 
            loading_stationLabel.AutoSize = true;
            loading_stationLabel.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loading_stationLabel.Location = new System.Drawing.Point(496, 305);
            loading_stationLabel.Name = "loading_stationLabel";
            loading_stationLabel.Size = new System.Drawing.Size(87, 25);
            loading_stationLabel.TabIndex = 96;
            loading_stationLabel.Text = "محطة تحميل";
            // 
            // s_weightLabel
            // 
            s_weightLabel.AutoSize = true;
            s_weightLabel.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            s_weightLabel.Location = new System.Drawing.Point(496, 185);
            s_weightLabel.Name = "s_weightLabel";
            s_weightLabel.Size = new System.Drawing.Size(84, 25);
            s_weightLabel.TabIndex = 89;
            s_weightLabel.Text = "الوزن الثاني:";
            s_weightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // f_weightLabel
            // 
            f_weightLabel.AutoSize = true;
            f_weightLabel.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            f_weightLabel.Location = new System.Drawing.Point(496, 145);
            f_weightLabel.Name = "f_weightLabel";
            f_weightLabel.Size = new System.Drawing.Size(80, 25);
            f_weightLabel.TabIndex = 85;
            f_weightLabel.Text = "الوزن الاول:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(496, 225);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 25);
            label1.TabIndex = 88;
            label1.Text = "صافي الوزن:";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(496, 265);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 25);
            label2.TabIndex = 87;
            label2.Text = "فارق الحمولة:";
            label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // wCardIDLabel
            // 
            wCardIDLabel.AutoSize = true;
            wCardIDLabel.BackColor = System.Drawing.Color.Transparent;
            wCardIDLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            wCardIDLabel.Location = new System.Drawing.Point(129, 25);
            wCardIDLabel.Name = "wCardIDLabel";
            wCardIDLabel.Size = new System.Drawing.Size(82, 24);
            wCardIDLabel.TabIndex = 108;
            wCardIDLabel.Text = "تذكرة وزن";
            // 
            // bLadingLabel
            // 
            bLadingLabel.AutoSize = true;
            bLadingLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bLadingLabel.Location = new System.Drawing.Point(496, 24);
            bLadingLabel.Name = "bLadingLabel";
            bLadingLabel.Size = new System.Drawing.Size(92, 24);
            bLadingLabel.TabIndex = 107;
            bLadingLabel.Text = "رقم الكارت:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datapanel);
            this.panel1.Controls.Add(this.Campanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 721);
            this.panel1.TabIndex = 0;
            // 
            // datapanel
            // 
            this.datapanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.datapanel.Controls.Add(this.ladingIDtextBox1);
            this.datapanel.Controls.Add(this.SW_button);
            this.datapanel.Controls.Add(this.FW_button);
            this.datapanel.Controls.Add(wCardIDLabel);
            this.datapanel.Controls.Add(bLadingLabel);
            this.datapanel.Controls.Add(this.wCardIDTextBox);
            this.datapanel.Controls.Add(this.statusTextBox);
            this.datapanel.Controls.Add(label3);
            this.datapanel.Controls.Add(label5);
            this.datapanel.Controls.Add(weight_NotesLabel);
            this.datapanel.Controls.Add(this.s_WdateTextBox);
            this.datapanel.Controls.Add(this.bagstextBox1);
            this.datapanel.Controls.Add(this.f_WdateTextBox);
            this.datapanel.Controls.Add(this.stacktextBox2);
            this.datapanel.Controls.Add(label4);
            this.datapanel.Controls.Add(this.weight_NotesTextBox);
            this.datapanel.Controls.Add(loading_stationLabel);
            this.datapanel.Controls.Add(s_weightLabel);
            this.datapanel.Controls.Add(this.qtyTextBox);
            this.datapanel.Controls.Add(this.s_weightTextBox);
            this.datapanel.Controls.Add(this.loading_stationComboBox);
            this.datapanel.Controls.Add(f_weightLabel);
            this.datapanel.Controls.Add(label1);
            this.datapanel.Controls.Add(this.f_weightTextBox);
            this.datapanel.Controls.Add(label2);
            this.datapanel.Controls.Add(this.nettextBox1);
            this.datapanel.Controls.Add(this.shrinktextBox1);
            this.datapanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.datapanel.Location = new System.Drawing.Point(670, 0);
            this.datapanel.MinimumSize = new System.Drawing.Size(614, 640);
            this.datapanel.Name = "datapanel";
            this.datapanel.Size = new System.Drawing.Size(614, 721);
            this.datapanel.TabIndex = 2;
            // 
            // wCardIDTextBox
            // 
            this.wCardIDTextBox.BackColor = System.Drawing.Color.White;
            this.wCardIDTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wCardIDTextBox.Location = new System.Drawing.Point(23, 21);
            this.wCardIDTextBox.Name = "wCardIDTextBox";
            this.wCardIDTextBox.ReadOnly = true;
            this.wCardIDTextBox.Size = new System.Drawing.Size(100, 32);
            this.wCardIDTextBox.TabIndex = 109;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.White;
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "Status", true));
            this.statusTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.Location = new System.Drawing.Point(258, 21);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(100, 32);
            this.statusTextBox.TabIndex = 105;
            this.statusTextBox.TabStop = false;
            // 
            // s_WdateTextBox
            // 
            this.s_WdateTextBox.BackColor = System.Drawing.Color.White;
            this.s_WdateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "S_Wdate", true));
            this.s_WdateTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_WdateTextBox.Location = new System.Drawing.Point(23, 182);
            this.s_WdateTextBox.Name = "s_WdateTextBox";
            this.s_WdateTextBox.ReadOnly = true;
            this.s_WdateTextBox.Size = new System.Drawing.Size(225, 34);
            this.s_WdateTextBox.TabIndex = 92;
            // 
            // bagstextBox1
            // 
            this.bagstextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.bagstextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "Bags_Count", true));
            this.bagstextBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagstextBox1.Location = new System.Drawing.Point(23, 302);
            this.bagstextBox1.Name = "bagstextBox1";
            this.bagstextBox1.Size = new System.Drawing.Size(93, 34);
            this.bagstextBox1.TabIndex = 101;
            // 
            // f_WdateTextBox
            // 
            this.f_WdateTextBox.BackColor = System.Drawing.Color.White;
            this.f_WdateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "F_Wdate", true));
            this.f_WdateTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_WdateTextBox.Location = new System.Drawing.Point(23, 142);
            this.f_WdateTextBox.Name = "f_WdateTextBox";
            this.f_WdateTextBox.ReadOnly = true;
            this.f_WdateTextBox.Size = new System.Drawing.Size(225, 34);
            this.f_WdateTextBox.TabIndex = 91;
            // 
            // stacktextBox2
            // 
            this.stacktextBox2.BackColor = System.Drawing.Color.LightBlue;
            this.stacktextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "Stack_Bar", true));
            this.stacktextBox2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stacktextBox2.Location = new System.Drawing.Point(23, 341);
            this.stacktextBox2.Name = "stacktextBox2";
            this.stacktextBox2.Size = new System.Drawing.Size(467, 34);
            this.stacktextBox2.TabIndex = 100;
            // 
            // weight_NotesTextBox
            // 
            this.weight_NotesTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.weight_NotesTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_NotesTextBox.Location = new System.Drawing.Point(24, 381);
            this.weight_NotesTextBox.Multiline = true;
            this.weight_NotesTextBox.Name = "weight_NotesTextBox";
            this.weight_NotesTextBox.Size = new System.Drawing.Size(467, 75);
            this.weight_NotesTextBox.TabIndex = 104;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.BackColor = System.Drawing.Color.White;
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "Qty", true));
            this.qtyTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextBox.Location = new System.Drawing.Point(23, 262);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.ReadOnly = true;
            this.qtyTextBox.Size = new System.Drawing.Size(93, 34);
            this.qtyTextBox.TabIndex = 95;
            // 
            // s_weightTextBox
            // 
            this.s_weightTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.s_weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "S_weight", true));
            this.s_weightTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_weightTextBox.Location = new System.Drawing.Point(319, 182);
            this.s_weightTextBox.Name = "s_weightTextBox";
            this.s_weightTextBox.ReadOnly = true;
            this.s_weightTextBox.Size = new System.Drawing.Size(171, 34);
            this.s_weightTextBox.TabIndex = 90;
            // 
            // loading_stationComboBox
            // 
            this.loading_stationComboBox.BackColor = System.Drawing.Color.LightBlue;
            this.loading_stationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "Loading_Station", true));
            this.loading_stationComboBox.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_stationComboBox.FormattingEnabled = true;
            this.loading_stationComboBox.Items.AddRange(new object[] {
            "محطة1",
            "محطة2",
            "محطة3",
            "محطة4",
            "محطة5",
            "مخزن القشرة",
            "ساحة التحميل"});
            this.loading_stationComboBox.Location = new System.Drawing.Point(319, 302);
            this.loading_stationComboBox.Name = "loading_stationComboBox";
            this.loading_stationComboBox.Size = new System.Drawing.Size(171, 33);
            this.loading_stationComboBox.TabIndex = 97;
            // 
            // f_weightTextBox
            // 
            this.f_weightTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.f_weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "F_weight", true));
            this.f_weightTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_weightTextBox.Location = new System.Drawing.Point(319, 142);
            this.f_weightTextBox.Name = "f_weightTextBox";
            this.f_weightTextBox.ReadOnly = true;
            this.f_weightTextBox.Size = new System.Drawing.Size(171, 34);
            this.f_weightTextBox.TabIndex = 86;
            // 
            // nettextBox1
            // 
            this.nettextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.nettextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "Net_Weight", true));
            this.nettextBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nettextBox1.Location = new System.Drawing.Point(319, 222);
            this.nettextBox1.Name = "nettextBox1";
            this.nettextBox1.ReadOnly = true;
            this.nettextBox1.Size = new System.Drawing.Size(171, 34);
            this.nettextBox1.TabIndex = 94;
            // 
            // shrinktextBox1
            // 
            this.shrinktextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.shrinktextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "Shrink", true));
            this.shrinktextBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shrinktextBox1.Location = new System.Drawing.Point(319, 262);
            this.shrinktextBox1.Name = "shrinktextBox1";
            this.shrinktextBox1.ReadOnly = true;
            this.shrinktextBox1.Size = new System.Drawing.Size(171, 34);
            this.shrinktextBox1.TabIndex = 93;
            // 
            // Campanel
            // 
            this.Campanel.BackColor = System.Drawing.Color.White;
            this.Campanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Campanel.Location = new System.Drawing.Point(0, 0);
            this.Campanel.Name = "Campanel";
            this.Campanel.Size = new System.Drawing.Size(1284, 721);
            this.Campanel.TabIndex = 1;
            // 
            // SW_button
            // 
            this.SW_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SW_button.FlatAppearance.BorderSize = 0;
            this.SW_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SW_button.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SW_button.Image = global::LoBridge_V2.Properties.Resources.W_icon;
            this.SW_button.Location = new System.Drawing.Point(276, 185);
            this.SW_button.Name = "SW_button";
            this.SW_button.Size = new System.Drawing.Size(37, 23);
            this.SW_button.TabIndex = 110;
            this.SW_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SW_button.UseMnemonic = false;
            this.SW_button.UseVisualStyleBackColor = false;
            // 
            // FW_button
            // 
            this.FW_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FW_button.FlatAppearance.BorderSize = 0;
            this.FW_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FW_button.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FW_button.Image = global::LoBridge_V2.Properties.Resources.W_icon;
            this.FW_button.Location = new System.Drawing.Point(276, 145);
            this.FW_button.Name = "FW_button";
            this.FW_button.Size = new System.Drawing.Size(37, 23);
            this.FW_button.TabIndex = 110;
            this.FW_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FW_button.UseMnemonic = false;
            this.FW_button.UseVisualStyleBackColor = false;
            // 
            // lading_OutBindingSource
            // 
            this.lading_OutBindingSource.DataMember = "Lading_Out";
            this.lading_OutBindingSource.DataSource = this.outDataSet;
            // 
            // outDataSet
            // 
            this.outDataSet.DataSetName = "OutDataSet";
            this.outDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lading_OutTableAdapter
            // 
            this.lading_OutTableAdapter.ClearBeforeFill = true;
            // 
            // ladingIDtextBox1
            // 
            this.ladingIDtextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.ladingIDtextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lading_OutBindingSource, "ladingID", true));
            this.ladingIDtextBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladingIDtextBox1.Location = new System.Drawing.Point(364, 19);
            this.ladingIDtextBox1.Name = "ladingIDtextBox1";
            this.ladingIDtextBox1.ReadOnly = true;
            this.ladingIDtextBox1.Size = new System.Drawing.Size(126, 34);
            this.ladingIDtextBox1.TabIndex = 111;
            // 
            // Out_Bridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 721);
            this.Controls.Add(this.panel1);
            this.Name = "Out_Bridge";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Bridge";
            this.Load += new System.EventHandler(this.Bridge_Load);
            this.Shown += new System.EventHandler(this.Out_Bridge_Shown);
            this.panel1.ResumeLayout(false);
            this.datapanel.ResumeLayout(false);
            this.datapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lading_OutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel datapanel;
        private System.Windows.Forms.Panel Campanel;
        private System.Windows.Forms.TextBox s_WdateTextBox;
        private System.Windows.Forms.TextBox bagstextBox1;
        private System.Windows.Forms.TextBox f_WdateTextBox;
        private System.Windows.Forms.TextBox stacktextBox2;
        private System.Windows.Forms.TextBox weight_NotesTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox s_weightTextBox;
        private System.Windows.Forms.ComboBox loading_stationComboBox;
        private System.Windows.Forms.TextBox f_weightTextBox;
        private System.Windows.Forms.TextBox nettextBox1;
        private System.Windows.Forms.TextBox shrinktextBox1;
        private Outdataset outDataSet;
        private System.Windows.Forms.BindingSource lading_OutBindingSource;
        private OutDataSetTableAdapters.Lading_OutTableAdapter lading_OutTableAdapter;
        private System.Windows.Forms.TextBox wCardIDTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button FW_button;
        private System.Windows.Forms.Button SW_button;
        private System.Windows.Forms.TextBox ladingIDtextBox1;
    }
}