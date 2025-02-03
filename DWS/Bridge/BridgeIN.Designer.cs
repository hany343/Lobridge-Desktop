

namespace LoBridge
{
    partial class BridgeIN
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
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label f_weightLabel;
            System.Windows.Forms.Label s_weightLabel;
            System.Windows.Forms.Label net_WeightLabel;
            System.Windows.Forms.Label cust_NAMELabel;
            System.Windows.Forms.Label comm_NAMELabel;
            System.Windows.Forms.Label truck_numberLabel;
            System.Windows.Forms.Label trailer_numberLabel;
            System.Windows.Forms.Label order_NumberLabel;
            System.Windows.Forms.Label driver_NameLabel;
            System.Windows.Forms.Label company_NameLabel;
            System.Windows.Forms.Label wCardIDLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label lading_NotesLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label weight_NotesLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label truck_TypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BridgeIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2Menu = new System.Windows.Forms.Panel();
            this.truck_numberLinkLabel = new System.Windows.Forms.LinkLabel();
            this.wCard1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNdataset = new LoBridge.INdataset();
            this.ladingIDLabel1 = new System.Windows.Forms.Label();
            this.qtyLabel1 = new System.Windows.Forms.Label();
            this.statusLabel1 = new System.Windows.Forms.Label();
            this.wCardIDLabel1 = new System.Windows.Forms.Label();
            this.trailer_numberLabel1 = new System.Windows.Forms.Label();
            this.panel3wscreen = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6Cam = new System.Windows.Forms.Panel();
            this.panel5CardInfo = new System.Windows.Forms.Panel();
            this.truck_TypeComboBox = new System.Windows.Forms.ComboBox();
            this.shrinktxtbx = new System.Windows.Forms.TextBox();
            this.button2saveSW = new System.Windows.Forms.Button();
            this.button1saveFW = new System.Windows.Forms.Button();
            this.weight_NotesTextBox = new System.Windows.Forms.TextBox();
            this.f_WdateLabel1 = new System.Windows.Forms.Label();
            this.company_NameLabel1 = new System.Windows.Forms.Label();
            this.s_WdateLabel1 = new System.Windows.Forms.Label();
            this.driver_NameLabel1 = new System.Windows.Forms.Label();
            this.lading_NotesLabel1 = new System.Windows.Forms.Label();
            this.order_NumberLabel1 = new System.Windows.Forms.Label();
            this.f_weightLabel1 = new System.Windows.Forms.Label();
            this.s_weightLabel1 = new System.Windows.Forms.Label();
            this.net_WeightLabel1 = new System.Windows.Forms.Label();
            this.cust_NAMELabel1 = new System.Windows.Forms.Label();
            this.comm_NAMELabel1 = new System.Windows.Forms.Label();
            this.wCard1TableAdapter = new LoBridge.INdatasetTableAdapters.WCard1TableAdapter();
            this.tableAdapterManager = new LoBridge.INdatasetTableAdapters.TableAdapterManager();
            qtyLabel = new System.Windows.Forms.Label();
            f_weightLabel = new System.Windows.Forms.Label();
            s_weightLabel = new System.Windows.Forms.Label();
            net_WeightLabel = new System.Windows.Forms.Label();
            cust_NAMELabel = new System.Windows.Forms.Label();
            comm_NAMELabel = new System.Windows.Forms.Label();
            truck_numberLabel = new System.Windows.Forms.Label();
            trailer_numberLabel = new System.Windows.Forms.Label();
            order_NumberLabel = new System.Windows.Forms.Label();
            driver_NameLabel = new System.Windows.Forms.Label();
            company_NameLabel = new System.Windows.Forms.Label();
            wCardIDLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            lading_NotesLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            weight_NotesLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            truck_TypeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wCard1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5CardInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.BackColor = System.Drawing.Color.White;
            qtyLabel.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyLabel.Location = new System.Drawing.Point(684, 51);
            qtyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            qtyLabel.Size = new System.Drawing.Size(113, 31);
            qtyLabel.TabIndex = 2;
            qtyLabel.Text = "الكمية المحملة:";
            qtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f_weightLabel
            // 
            f_weightLabel.AutoSize = true;
            f_weightLabel.BackColor = System.Drawing.Color.Transparent;
            f_weightLabel.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            f_weightLabel.Location = new System.Drawing.Point(555, 15);
            f_weightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            f_weightLabel.Name = "f_weightLabel";
            f_weightLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            f_weightLabel.Size = new System.Drawing.Size(86, 35);
            f_weightLabel.TabIndex = 10;
            f_weightLabel.Text = "وزن اول:";
            f_weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // s_weightLabel
            // 
            s_weightLabel.AutoSize = true;
            s_weightLabel.BackColor = System.Drawing.Color.Transparent;
            s_weightLabel.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            s_weightLabel.Location = new System.Drawing.Point(555, 58);
            s_weightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            s_weightLabel.Name = "s_weightLabel";
            s_weightLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            s_weightLabel.Size = new System.Drawing.Size(84, 35);
            s_weightLabel.TabIndex = 12;
            s_weightLabel.Text = "وزن ثان:";
            s_weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // net_WeightLabel
            // 
            net_WeightLabel.AutoSize = true;
            net_WeightLabel.BackColor = System.Drawing.Color.Transparent;
            net_WeightLabel.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            net_WeightLabel.Location = new System.Drawing.Point(555, 102);
            net_WeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            net_WeightLabel.Name = "net_WeightLabel";
            net_WeightLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            net_WeightLabel.Size = new System.Drawing.Size(114, 35);
            net_WeightLabel.TabIndex = 14;
            net_WeightLabel.Text = "صافي الوزن:";
            net_WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cust_NAMELabel
            // 
            cust_NAMELabel.AutoSize = true;
            cust_NAMELabel.BackColor = System.Drawing.Color.Transparent;
            cust_NAMELabel.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cust_NAMELabel.Location = new System.Drawing.Point(555, 282);
            cust_NAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cust_NAMELabel.Name = "cust_NAMELabel";
            cust_NAMELabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cust_NAMELabel.Size = new System.Drawing.Size(84, 35);
            cust_NAMELabel.TabIndex = 16;
            cust_NAMELabel.Text = "الشحنة:";
            cust_NAMELabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comm_NAMELabel
            // 
            comm_NAMELabel.AutoSize = true;
            comm_NAMELabel.BackColor = System.Drawing.Color.Transparent;
            comm_NAMELabel.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comm_NAMELabel.Location = new System.Drawing.Point(555, 326);
            comm_NAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            comm_NAMELabel.Name = "comm_NAMELabel";
            comm_NAMELabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            comm_NAMELabel.Size = new System.Drawing.Size(84, 35);
            comm_NAMELabel.TabIndex = 18;
            comm_NAMELabel.Text = "الصنف:";
            comm_NAMELabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // truck_numberLabel
            // 
            truck_numberLabel.AutoSize = true;
            truck_numberLabel.BackColor = System.Drawing.Color.White;
            truck_numberLabel.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            truck_numberLabel.Location = new System.Drawing.Point(682, 90);
            truck_numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            truck_numberLabel.Name = "truck_numberLabel";
            truck_numberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            truck_numberLabel.Size = new System.Drawing.Size(92, 31);
            truck_numberLabel.TabIndex = 20;
            truck_numberLabel.Text = "رقم السيارة:";
            truck_numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trailer_numberLabel
            // 
            trailer_numberLabel.AutoSize = true;
            trailer_numberLabel.BackColor = System.Drawing.Color.Transparent;
            trailer_numberLabel.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trailer_numberLabel.Location = new System.Drawing.Point(482, 88);
            trailer_numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trailer_numberLabel.Name = "trailer_numberLabel";
            trailer_numberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            trailer_numberLabel.Size = new System.Drawing.Size(99, 31);
            trailer_numberLabel.TabIndex = 24;
            trailer_numberLabel.Text = "رقم المقطورة:";
            trailer_numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // order_NumberLabel
            // 
            order_NumberLabel.AutoSize = true;
            order_NumberLabel.BackColor = System.Drawing.Color.Transparent;
            order_NumberLabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            order_NumberLabel.Location = new System.Drawing.Point(236, 282);
            order_NumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            order_NumberLabel.Name = "order_NumberLabel";
            order_NumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            order_NumberLabel.Size = new System.Drawing.Size(62, 25);
            order_NumberLabel.TabIndex = 36;
            order_NumberLabel.Text = "الشهادة:";
            order_NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driver_NameLabel
            // 
            driver_NameLabel.AutoSize = true;
            driver_NameLabel.BackColor = System.Drawing.Color.Transparent;
            driver_NameLabel.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            driver_NameLabel.Location = new System.Drawing.Point(555, 373);
            driver_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            driver_NameLabel.Name = "driver_NameLabel";
            driver_NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            driver_NameLabel.Size = new System.Drawing.Size(78, 35);
            driver_NameLabel.TabIndex = 40;
            driver_NameLabel.Text = "السائق:";
            driver_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // company_NameLabel
            // 
            company_NameLabel.AutoSize = true;
            company_NameLabel.BackColor = System.Drawing.Color.Transparent;
            company_NameLabel.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            company_NameLabel.Location = new System.Drawing.Point(555, 416);
            company_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            company_NameLabel.Name = "company_NameLabel";
            company_NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            company_NameLabel.Size = new System.Drawing.Size(131, 35);
            company_NameLabel.TabIndex = 48;
            company_NameLabel.Text = "شركة الشحن:";
            company_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wCardIDLabel
            // 
            wCardIDLabel.AutoSize = true;
            wCardIDLabel.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            wCardIDLabel.Location = new System.Drawing.Point(684, 13);
            wCardIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            wCardIDLabel.Name = "wCardIDLabel";
            wCardIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            wCardIDLabel.Size = new System.Drawing.Size(86, 31);
            wCardIDLabel.TabIndex = 54;
            wCardIDLabel.Text = "تذكرة وزن:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(451, 16);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            statusLabel.Size = new System.Drawing.Size(81, 31);
            statusLabel.TabIndex = 64;
            statusLabel.Text = "نوع الوزن:";
            // 
            // lading_NotesLabel
            // 
            lading_NotesLabel.AutoSize = true;
            lading_NotesLabel.BackColor = System.Drawing.Color.Transparent;
            lading_NotesLabel.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lading_NotesLabel.Location = new System.Drawing.Point(555, 454);
            lading_NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lading_NotesLabel.Name = "lading_NotesLabel";
            lading_NotesLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lading_NotesLabel.Size = new System.Drawing.Size(88, 35);
            lading_NotesLabel.TabIndex = 66;
            lading_NotesLabel.Text = "ملحوظة:";
            lading_NotesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(394, 58);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(40, 25);
            label1.TabIndex = 44;
            label1.Text = "كجم";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(394, 15);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(40, 25);
            label2.TabIndex = 44;
            label2.Text = "كجم";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(394, 58);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(40, 25);
            label3.TabIndex = 44;
            label3.Text = "كجم";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(394, 15);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label4.Size = new System.Drawing.Size(40, 25);
            label4.TabIndex = 44;
            label4.Text = "كجم";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(394, 102);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label5.Size = new System.Drawing.Size(40, 25);
            label5.TabIndex = 44;
            label5.Text = "كجم";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weight_NotesLabel
            // 
            weight_NotesLabel.AutoSize = true;
            weight_NotesLabel.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weight_NotesLabel.Location = new System.Drawing.Point(555, 187);
            weight_NotesLabel.Name = "weight_NotesLabel";
            weight_NotesLabel.Size = new System.Drawing.Size(95, 35);
            weight_NotesLabel.TabIndex = 91;
            weight_NotesLabel.Text = "ملاحظات:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(551, 52);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label6.Size = new System.Drawing.Size(38, 31);
            label6.TabIndex = 66;
            label6.Text = "طن";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(163, 106);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label7.Size = new System.Drawing.Size(97, 25);
            label7.TabIndex = 94;
            label7.Text = "العجز/الزيادة:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // truck_TypeLabel
            // 
            truck_TypeLabel.AutoSize = true;
            truck_TypeLabel.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            truck_TypeLabel.Location = new System.Drawing.Point(555, 146);
            truck_TypeLabel.Name = "truck_TypeLabel";
            truck_TypeLabel.Size = new System.Drawing.Size(123, 35);
            truck_TypeLabel.TabIndex = 95;
            truck_TypeLabel.Text = "نوع الشاحنة:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2Menu);
            this.panel1.Controls.Add(this.panel3wscreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 131);
            this.panel1.TabIndex = 0;
            // 
            // panel2Menu
            // 
            this.panel2Menu.AutoSize = true;
            this.panel2Menu.Controls.Add(this.truck_numberLinkLabel);
            this.panel2Menu.Controls.Add(this.ladingIDLabel1);
            this.panel2Menu.Controls.Add(label6);
            this.panel2Menu.Controls.Add(this.qtyLabel1);
            this.panel2Menu.Controls.Add(statusLabel);
            this.panel2Menu.Controls.Add(this.statusLabel1);
            this.panel2Menu.Controls.Add(qtyLabel);
            this.panel2Menu.Controls.Add(wCardIDLabel);
            this.panel2Menu.Controls.Add(this.wCardIDLabel1);
            this.panel2Menu.Controls.Add(truck_numberLabel);
            this.panel2Menu.Controls.Add(trailer_numberLabel);
            this.panel2Menu.Controls.Add(this.trailer_numberLabel1);
            this.panel2Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2Menu.Location = new System.Drawing.Point(415, 0);
            this.panel2Menu.Margin = new System.Windows.Forms.Padding(4);
            this.panel2Menu.Name = "panel2Menu";
            this.panel2Menu.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel2Menu.Size = new System.Drawing.Size(821, 131);
            this.panel2Menu.TabIndex = 0;
            // 
            // truck_numberLinkLabel
            // 
            this.truck_numberLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Truck_number", true));
            this.truck_numberLinkLabel.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truck_numberLinkLabel.Location = new System.Drawing.Point(579, 88);
            this.truck_numberLinkLabel.Name = "truck_numberLinkLabel";
            this.truck_numberLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.truck_numberLinkLabel.TabIndex = 1;
            this.truck_numberLinkLabel.TabStop = true;
            this.truck_numberLinkLabel.Text = "linkLabel1";
            // 
            // wCard1BindingSource
            // 
            this.wCard1BindingSource.DataMember = "WCard1";
            this.wCard1BindingSource.DataSource = this.iNdataset;
            // 
            // iNdataset
            // 
            this.iNdataset.DataSetName = "INdataset";
            this.iNdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ladingIDLabel1
            // 
            this.ladingIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "ladingID", true));
            this.ladingIDLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ladingIDLabel1.Font = new System.Drawing.Font("IDAutomationHC39M", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladingIDLabel1.ForeColor = System.Drawing.Color.Black;
            this.ladingIDLabel1.Location = new System.Drawing.Point(0, 0);
            this.ladingIDLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.ladingIDLabel1.Name = "ladingIDLabel1";
            this.ladingIDLabel1.Size = new System.Drawing.Size(316, 131);
            this.ladingIDLabel1.TabIndex = 4;
            this.ladingIDLabel1.Text = "*00000000*";
            this.ladingIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qtyLabel1
            // 
            this.qtyLabel1.BackColor = System.Drawing.Color.White;
            this.qtyLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Qty", true));
            this.qtyLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.qtyLabel1.Location = new System.Drawing.Point(595, 51);
            this.qtyLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qtyLabel1.Name = "qtyLabel1";
            this.qtyLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qtyLabel1.Size = new System.Drawing.Size(82, 26);
            this.qtyLabel1.TabIndex = 3;
            this.qtyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel1
            // 
            this.statusLabel1.BackColor = System.Drawing.Color.White;
            this.statusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Status", true));
            this.statusLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.statusLabel1.Location = new System.Drawing.Point(348, 16);
            this.statusLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusLabel1.Size = new System.Drawing.Size(86, 34);
            this.statusLabel1.TabIndex = 65;
            this.statusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabel1.TextChanged += new System.EventHandler(this.statusLabel1_TextChanged);
            // 
            // wCardIDLabel1
            // 
            this.wCardIDLabel1.BackColor = System.Drawing.Color.White;
            this.wCardIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "WCardID", true));
            this.wCardIDLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wCardIDLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wCardIDLabel1.Location = new System.Drawing.Point(573, 13);
            this.wCardIDLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wCardIDLabel1.Name = "wCardIDLabel1";
            this.wCardIDLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wCardIDLabel1.Size = new System.Drawing.Size(101, 27);
            this.wCardIDLabel1.TabIndex = 55;
            this.wCardIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wCardIDLabel1.TextChanged += new System.EventHandler(this.wCardIDLabel1_TextChanged);
            // 
            // trailer_numberLabel1
            // 
            this.trailer_numberLabel1.BackColor = System.Drawing.Color.White;
            this.trailer_numberLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Trailer_number", true));
            this.trailer_numberLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trailer_numberLabel1.ForeColor = System.Drawing.Color.Black;
            this.trailer_numberLabel1.Location = new System.Drawing.Point(384, 81);
            this.trailer_numberLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trailer_numberLabel1.Name = "trailer_numberLabel1";
            this.trailer_numberLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trailer_numberLabel1.Size = new System.Drawing.Size(90, 34);
            this.trailer_numberLabel1.TabIndex = 25;
            this.trailer_numberLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3wscreen
            // 
            this.panel3wscreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3wscreen.Location = new System.Drawing.Point(0, 0);
            this.panel3wscreen.Margin = new System.Windows.Forms.Padding(4);
            this.panel3wscreen.MaximumSize = new System.Drawing.Size(500, 124);
            this.panel3wscreen.MinimumSize = new System.Drawing.Size(449, 124);
            this.panel3wscreen.Name = "panel3wscreen";
            this.panel3wscreen.Size = new System.Drawing.Size(500, 124);
            this.panel3wscreen.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.panel6Cam);
            this.panel4.Controls.Add(this.panel5CardInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 131);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1236, 853);
            this.panel4.TabIndex = 1;
            // 
            // panel6Cam
            // 
            this.panel6Cam.AutoScroll = true;
            this.panel6Cam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6Cam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6Cam.Location = new System.Drawing.Point(0, 0);
            this.panel6Cam.Margin = new System.Windows.Forms.Padding(4);
            this.panel6Cam.Name = "panel6Cam";
            this.panel6Cam.Size = new System.Drawing.Size(536, 853);
            this.panel6Cam.TabIndex = 1;
            this.panel6Cam.SizeChanged += new System.EventHandler(this.panel6Cam_SizeChanged);
            // 
            // panel5CardInfo
            // 
            this.panel5CardInfo.AutoScroll = true;
            this.panel5CardInfo.AutoSize = true;
            this.panel5CardInfo.BackColor = System.Drawing.Color.DarkGray;
            this.panel5CardInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5CardInfo.CausesValidation = false;
            this.panel5CardInfo.Controls.Add(this.truck_TypeComboBox);
            this.panel5CardInfo.Controls.Add(truck_TypeLabel);
            this.panel5CardInfo.Controls.Add(this.shrinktxtbx);
            this.panel5CardInfo.Controls.Add(label7);
            this.panel5CardInfo.Controls.Add(this.button2saveSW);
            this.panel5CardInfo.Controls.Add(this.button1saveFW);
            this.panel5CardInfo.Controls.Add(weight_NotesLabel);
            this.panel5CardInfo.Controls.Add(this.weight_NotesTextBox);
            this.panel5CardInfo.Controls.Add(company_NameLabel);
            this.panel5CardInfo.Controls.Add(this.f_WdateLabel1);
            this.panel5CardInfo.Controls.Add(this.company_NameLabel1);
            this.panel5CardInfo.Controls.Add(this.s_WdateLabel1);
            this.panel5CardInfo.Controls.Add(label4);
            this.panel5CardInfo.Controls.Add(label5);
            this.panel5CardInfo.Controls.Add(label3);
            this.panel5CardInfo.Controls.Add(label2);
            this.panel5CardInfo.Controls.Add(label1);
            this.panel5CardInfo.Controls.Add(driver_NameLabel);
            this.panel5CardInfo.Controls.Add(order_NumberLabel);
            this.panel5CardInfo.Controls.Add(this.driver_NameLabel1);
            this.panel5CardInfo.Controls.Add(lading_NotesLabel);
            this.panel5CardInfo.Controls.Add(this.lading_NotesLabel1);
            this.panel5CardInfo.Controls.Add(this.order_NumberLabel1);
            this.panel5CardInfo.Controls.Add(f_weightLabel);
            this.panel5CardInfo.Controls.Add(this.f_weightLabel1);
            this.panel5CardInfo.Controls.Add(s_weightLabel);
            this.panel5CardInfo.Controls.Add(this.s_weightLabel1);
            this.panel5CardInfo.Controls.Add(net_WeightLabel);
            this.panel5CardInfo.Controls.Add(this.net_WeightLabel1);
            this.panel5CardInfo.Controls.Add(cust_NAMELabel);
            this.panel5CardInfo.Controls.Add(this.cust_NAMELabel1);
            this.panel5CardInfo.Controls.Add(this.comm_NAMELabel1);
            this.panel5CardInfo.Controls.Add(comm_NAMELabel);
            this.panel5CardInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5CardInfo.Location = new System.Drawing.Point(536, 0);
            this.panel5CardInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panel5CardInfo.Name = "panel5CardInfo";
            this.panel5CardInfo.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel5CardInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel5CardInfo.Size = new System.Drawing.Size(700, 853);
            this.panel5CardInfo.TabIndex = 0;
            // 
            // truck_TypeComboBox
            // 
            this.truck_TypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Truck_Type", true));
            this.truck_TypeComboBox.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truck_TypeComboBox.FormattingEnabled = true;
            this.truck_TypeComboBox.Location = new System.Drawing.Point(335, 139);
            this.truck_TypeComboBox.Name = "truck_TypeComboBox";
            this.truck_TypeComboBox.Size = new System.Drawing.Size(212, 39);
            this.truck_TypeComboBox.TabIndex = 96;
            // 
            // shrinktxtbx
            // 
            this.shrinktxtbx.BackColor = System.Drawing.Color.Crimson;
            this.shrinktxtbx.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shrinktxtbx.ForeColor = System.Drawing.Color.Black;
            this.shrinktxtbx.Location = new System.Drawing.Point(40, 102);
            this.shrinktxtbx.Name = "shrinktxtbx";
            this.shrinktxtbx.Size = new System.Drawing.Size(116, 35);
            this.shrinktxtbx.TabIndex = 95;
            // 
            // button2saveSW
            // 
            this.button2saveSW.BackgroundImage = global::LoBridge.Properties.Resources.search_icon__2_;
            this.button2saveSW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2saveSW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2saveSW.FlatAppearance.BorderSize = 0;
            this.button2saveSW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2saveSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2saveSW.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2saveSW.Location = new System.Drawing.Point(344, 50);
            this.button2saveSW.Name = "button2saveSW";
            this.button2saveSW.Size = new System.Drawing.Size(40, 37);
            this.button2saveSW.TabIndex = 93;
            this.button2saveSW.UseVisualStyleBackColor = true;
            this.button2saveSW.Visible = false;
            this.button2saveSW.Click += new System.EventHandler(this.button2saveSW_Click);
            // 
            // button1saveFW
            // 
            this.button1saveFW.BackgroundImage = global::LoBridge.Properties.Resources.search_icon__2_;
            this.button1saveFW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1saveFW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1saveFW.FlatAppearance.BorderSize = 0;
            this.button1saveFW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1saveFW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1saveFW.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1saveFW.Location = new System.Drawing.Point(344, 7);
            this.button1saveFW.Name = "button1saveFW";
            this.button1saveFW.Size = new System.Drawing.Size(40, 37);
            this.button1saveFW.TabIndex = 93;
            this.button1saveFW.UseVisualStyleBackColor = true;
            this.button1saveFW.Visible = false;
            this.button1saveFW.Click += new System.EventHandler(this.button1saveFW_Click);
            // 
            // weight_NotesTextBox
            // 
            this.weight_NotesTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.weight_NotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Weight_Notes", true));
            this.weight_NotesTextBox.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_NotesTextBox.ForeColor = System.Drawing.Color.Black;
            this.weight_NotesTextBox.Location = new System.Drawing.Point(43, 187);
            this.weight_NotesTextBox.Multiline = true;
            this.weight_NotesTextBox.Name = "weight_NotesTextBox";
            this.weight_NotesTextBox.Size = new System.Drawing.Size(504, 75);
            this.weight_NotesTextBox.TabIndex = 92;
            // 
            // f_WdateLabel1
            // 
            this.f_WdateLabel1.BackColor = System.Drawing.Color.White;
            this.f_WdateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "F_Wdate", true));
            this.f_WdateLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_WdateLabel1.ForeColor = System.Drawing.Color.Black;
            this.f_WdateLabel1.Location = new System.Drawing.Point(40, 7);
            this.f_WdateLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.f_WdateLabel1.Name = "f_WdateLabel1";
            this.f_WdateLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f_WdateLabel1.Size = new System.Drawing.Size(232, 34);
            this.f_WdateLabel1.TabIndex = 51;
            this.f_WdateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // company_NameLabel1
            // 
            this.company_NameLabel1.BackColor = System.Drawing.Color.White;
            this.company_NameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Company_Name", true));
            this.company_NameLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_NameLabel1.ForeColor = System.Drawing.Color.Black;
            this.company_NameLabel1.Location = new System.Drawing.Point(316, 408);
            this.company_NameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.company_NameLabel1.Name = "company_NameLabel1";
            this.company_NameLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.company_NameLabel1.Size = new System.Drawing.Size(231, 34);
            this.company_NameLabel1.TabIndex = 49;
            this.company_NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // s_WdateLabel1
            // 
            this.s_WdateLabel1.BackColor = System.Drawing.Color.White;
            this.s_WdateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "S_Wdate", true));
            this.s_WdateLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_WdateLabel1.ForeColor = System.Drawing.Color.Black;
            this.s_WdateLabel1.Location = new System.Drawing.Point(40, 50);
            this.s_WdateLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.s_WdateLabel1.Name = "s_WdateLabel1";
            this.s_WdateLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.s_WdateLabel1.Size = new System.Drawing.Size(232, 34);
            this.s_WdateLabel1.TabIndex = 53;
            this.s_WdateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // driver_NameLabel1
            // 
            this.driver_NameLabel1.BackColor = System.Drawing.Color.White;
            this.driver_NameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Driver_Name", true));
            this.driver_NameLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver_NameLabel1.ForeColor = System.Drawing.Color.Black;
            this.driver_NameLabel1.Location = new System.Drawing.Point(316, 365);
            this.driver_NameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.driver_NameLabel1.Name = "driver_NameLabel1";
            this.driver_NameLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.driver_NameLabel1.Size = new System.Drawing.Size(231, 34);
            this.driver_NameLabel1.TabIndex = 41;
            this.driver_NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lading_NotesLabel1
            // 
            this.lading_NotesLabel1.BackColor = System.Drawing.Color.White;
            this.lading_NotesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Lading_Notes", true));
            this.lading_NotesLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lading_NotesLabel1.Location = new System.Drawing.Point(42, 454);
            this.lading_NotesLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lading_NotesLabel1.Name = "lading_NotesLabel1";
            this.lading_NotesLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lading_NotesLabel1.Size = new System.Drawing.Size(505, 73);
            this.lading_NotesLabel1.TabIndex = 67;
            this.lading_NotesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // order_NumberLabel1
            // 
            this.order_NumberLabel1.BackColor = System.Drawing.Color.White;
            this.order_NumberLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Serial", true));
            this.order_NumberLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_NumberLabel1.ForeColor = System.Drawing.Color.Black;
            this.order_NumberLabel1.Location = new System.Drawing.Point(42, 274);
            this.order_NumberLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.order_NumberLabel1.Name = "order_NumberLabel1";
            this.order_NumberLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.order_NumberLabel1.Size = new System.Drawing.Size(189, 34);
            this.order_NumberLabel1.TabIndex = 37;
            this.order_NumberLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // f_weightLabel1
            // 
            this.f_weightLabel1.BackColor = System.Drawing.Color.White;
            this.f_weightLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f_weightLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "F_weight", true));
            this.f_weightLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_weightLabel1.ForeColor = System.Drawing.Color.Black;
            this.f_weightLabel1.Location = new System.Drawing.Point(447, 7);
            this.f_weightLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.f_weightLabel1.Name = "f_weightLabel1";
            this.f_weightLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f_weightLabel1.Size = new System.Drawing.Size(100, 34);
            this.f_weightLabel1.TabIndex = 11;
            this.f_weightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.f_weightLabel1.DoubleClick += new System.EventHandler(this.f_weightLabel1_DoubleClick);
            // 
            // s_weightLabel1
            // 
            this.s_weightLabel1.BackColor = System.Drawing.Color.White;
            this.s_weightLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.s_weightLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "S_weight", true));
            this.s_weightLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_weightLabel1.ForeColor = System.Drawing.Color.Black;
            this.s_weightLabel1.Location = new System.Drawing.Point(447, 50);
            this.s_weightLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.s_weightLabel1.Name = "s_weightLabel1";
            this.s_weightLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.s_weightLabel1.Size = new System.Drawing.Size(100, 34);
            this.s_weightLabel1.TabIndex = 13;
            this.s_weightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.s_weightLabel1.DoubleClick += new System.EventHandler(this.s_weightLabel1_DoubleClick);
            // 
            // net_WeightLabel1
            // 
            this.net_WeightLabel1.BackColor = System.Drawing.Color.White;
            this.net_WeightLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Net_Weight", true));
            this.net_WeightLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net_WeightLabel1.ForeColor = System.Drawing.Color.Black;
            this.net_WeightLabel1.Location = new System.Drawing.Point(447, 94);
            this.net_WeightLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.net_WeightLabel1.Name = "net_WeightLabel1";
            this.net_WeightLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.net_WeightLabel1.Size = new System.Drawing.Size(100, 34);
            this.net_WeightLabel1.TabIndex = 15;
            this.net_WeightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cust_NAMELabel1
            // 
            this.cust_NAMELabel1.BackColor = System.Drawing.Color.White;
            this.cust_NAMELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Shipping", true));
            this.cust_NAMELabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_NAMELabel1.ForeColor = System.Drawing.Color.Black;
            this.cust_NAMELabel1.Location = new System.Drawing.Point(371, 274);
            this.cust_NAMELabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_NAMELabel1.Name = "cust_NAMELabel1";
            this.cust_NAMELabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cust_NAMELabel1.Size = new System.Drawing.Size(176, 34);
            this.cust_NAMELabel1.TabIndex = 17;
            this.cust_NAMELabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comm_NAMELabel1
            // 
            this.comm_NAMELabel1.BackColor = System.Drawing.Color.White;
            this.comm_NAMELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wCard1BindingSource, "Comm_NAME", true));
            this.comm_NAMELabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comm_NAMELabel1.ForeColor = System.Drawing.Color.Black;
            this.comm_NAMELabel1.Location = new System.Drawing.Point(47, 318);
            this.comm_NAMELabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comm_NAMELabel1.Name = "comm_NAMELabel1";
            this.comm_NAMELabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comm_NAMELabel1.Size = new System.Drawing.Size(500, 34);
            this.comm_NAMELabel1.TabIndex = 19;
            this.comm_NAMELabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wCard1TableAdapter
            // 
            this.wCard1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CommodityTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.INBatchTableAdapter = null;
            this.tableAdapterManager.LadingTableAdapter = null;
            this.tableAdapterManager.Local_SuppliersTableAdapter = null;
            this.tableAdapterManager.ShipmentTableAdapter = null;
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoBridge.INdatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WcardIDTableAdapter = null;
            // 
            // BridgeIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 984);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BridgeIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ميزان الصادر";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BridgeIN_FormClosing);
            this.Load += new System.EventHandler(this.BridgeOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2Menu.ResumeLayout(false);
            this.panel2Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wCard1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNdataset)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5CardInfo.ResumeLayout(false);
            this.panel5CardInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3wscreen;
        private System.Windows.Forms.Panel panel2Menu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6Cam;
        private System.Windows.Forms.Panel panel5CardInfo;
        private System.Windows.Forms.Label ladingIDLabel1;
        private System.Windows.Forms.Label f_weightLabel1;
        private System.Windows.Forms.Label s_weightLabel1;
        private System.Windows.Forms.Label net_WeightLabel1;
        private System.Windows.Forms.Label cust_NAMELabel1;
        private System.Windows.Forms.Label comm_NAMELabel1;
        private System.Windows.Forms.Label trailer_numberLabel1;
        private System.Windows.Forms.Label order_NumberLabel1;
        private System.Windows.Forms.Label driver_NameLabel1;
        private System.Windows.Forms.Label company_NameLabel1;
        private System.Windows.Forms.Label f_WdateLabel1;
        private System.Windows.Forms.Label s_WdateLabel1;
        private System.Windows.Forms.Label wCardIDLabel1;
        private System.Windows.Forms.Label statusLabel1;
        private System.Windows.Forms.Label lading_NotesLabel1;
        private System.Windows.Forms.Label qtyLabel1;
        private System.Windows.Forms.TextBox weight_NotesTextBox;
        private System.Windows.Forms.Button button2saveSW;
        private System.Windows.Forms.Button button1saveFW;
        private System.Windows.Forms.TextBox shrinktxtbx;
        private INdataset iNdataset;
        private System.Windows.Forms.BindingSource wCard1BindingSource;
        private INdatasetTableAdapters.WCard1TableAdapter wCard1TableAdapter;
        private System.Windows.Forms.LinkLabel truck_numberLinkLabel;
        private INdatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox truck_TypeComboBox;
    }
}