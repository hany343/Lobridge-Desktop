using System.Web.UI.WebControls;
//using System.Windows.Forms;

namespace LoBridge
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.cameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dLWSDataSet = new LoBridge.DLWSDataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cameraTableAdapter = new LoBridge.DLWSDataSetTableAdapters.CameraTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.outboundMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةعميلجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالعملاءالحاليينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عقدجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listcontractsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.امرتوريدجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعراضاوامرالتوريدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outcardsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انشاءكارتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listoutcardsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حالةالتحميلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bladingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboundMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierspMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.موردجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعراضالموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.شحنةجديدةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعراضالشحناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.افراججديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعراضالافراجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incardsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.كارتجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعراضالكروتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقريرالواردالاجماليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرالصادرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الصادراليوميToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرالعقودToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريراوامرالتوريدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرالعملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرالواردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقريرالوارداليوميToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرالشحناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرالافراجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرالموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WbridgesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اusersettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بياناتالمستخدمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newuserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemsettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraBindingSource
            // 
            this.cameraBindingSource.DataMember = "Camera";
            this.cameraBindingSource.DataSource = this.dLWSDataSet;
            // 
            // dLWSDataSet
            // 
            this.dLWSDataSet.CaseSensitive = true;
            this.dLWSDataSet.DataSetName = "DLWSDataSet";
            this.dLWSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Outicon.png");
            this.imageList1.Images.SetKeyName(1, "Logout-256.png");
            this.imageList1.Images.SetKeyName(2, "Truck-icon.png");
            this.imageList1.Images.SetKeyName(3, "inicon1.png");
            this.imageList1.Images.SetKeyName(4, "settings-icon.png");
            this.imageList1.Images.SetKeyName(5, "users.png");
            this.imageList1.Images.SetKeyName(6, "report.png");
            this.imageList1.Images.SetKeyName(7, "new-cat-icon.png");
            this.imageList1.Images.SetKeyName(8, "bar-code-icon.png");
            this.imageList1.Images.SetKeyName(9, "scale.png");
            this.imageList1.Images.SetKeyName(10, "outbox-icon.png");
            // 
            // cameraTableAdapter
            // 
            this.cameraTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outboundMenuItem,
            this.inboundMenuItem,
            this.reportsMenuItem,
            this.productsMenuItem,
            this.transMenuItem,
            this.WbridgesMenuItem,
            this.settingsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1004, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // outboundMenuItem
            // 
            this.outboundMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersMenuItem,
            this.contractsMenuItem,
            this.ordersMenuItem,
            this.outcardsMenuItem,
            this.bladingMenuItem});
            this.outboundMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.outboundMenuItem.Image = global::LoBridge.Properties.Resources.Add_icon1;
            this.outboundMenuItem.Name = "outboundMenuItem";
            this.outboundMenuItem.Size = new System.Drawing.Size(83, 33);
            this.outboundMenuItem.Text = "الصادر";
            // 
            // customersMenuItem
            // 
            this.customersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةعميلجديدToolStripMenuItem,
            this.عرضالعملاءالحاليينToolStripMenuItem});
            this.customersMenuItem.Name = "customersMenuItem";
            this.customersMenuItem.Size = new System.Drawing.Size(170, 34);
            this.customersMenuItem.Text = "العملاء";
            this.customersMenuItem.Click += new System.EventHandler(this.customersMenuItem_Click);
            // 
            // اضافةعميلجديدToolStripMenuItem
            // 
            this.اضافةعميلجديدToolStripMenuItem.Name = "اضافةعميلجديدToolStripMenuItem";
            this.اضافةعميلجديدToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.اضافةعميلجديدToolStripMenuItem.Text = "عميل جديد";
            this.اضافةعميلجديدToolStripMenuItem.Click += new System.EventHandler(this.CustomersMenubutton8_Click);
            // 
            // عرضالعملاءالحاليينToolStripMenuItem
            // 
            this.عرضالعملاءالحاليينToolStripMenuItem.Name = "عرضالعملاءالحاليينToolStripMenuItem";
            this.عرضالعملاءالحاليينToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.عرضالعملاءالحاليينToolStripMenuItem.Text = "استعراض العملاء";
            // 
            // contractsMenuItem
            // 
            this.contractsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عقدجديدToolStripMenuItem,
            this.listcontractsMenuItem});
            this.contractsMenuItem.Name = "contractsMenuItem";
            this.contractsMenuItem.Size = new System.Drawing.Size(170, 34);
            this.contractsMenuItem.Text = "العقود";
            // 
            // عقدجديدToolStripMenuItem
            // 
            this.عقدجديدToolStripMenuItem.Name = "عقدجديدToolStripMenuItem";
            this.عقدجديدToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.عقدجديدToolStripMenuItem.Text = "عقد جديد";
            this.عقدجديدToolStripMenuItem.Click += new System.EventHandler(this.ContrractsMenubutton7_Click);
            // 
            // listcontractsMenuItem
            // 
            this.listcontractsMenuItem.Name = "listcontractsMenuItem";
            this.listcontractsMenuItem.Size = new System.Drawing.Size(182, 34);
            this.listcontractsMenuItem.Text = "استعراض العقود";
            this.listcontractsMenuItem.Click += new System.EventHandler(this.listContractbutton13_Click);
            // 
            // ordersMenuItem
            // 
            this.ordersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.امرتوريدجديدToolStripMenuItem,
            this.استعراضاوامرالتوريدToolStripMenuItem});
            this.ordersMenuItem.Name = "ordersMenuItem";
            this.ordersMenuItem.Size = new System.Drawing.Size(170, 34);
            this.ordersMenuItem.Text = "اوامر التوريد";
            // 
            // امرتوريدجديدToolStripMenuItem
            // 
            this.امرتوريدجديدToolStripMenuItem.Name = "امرتوريدجديدToolStripMenuItem";
            this.امرتوريدجديدToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.امرتوريدجديدToolStripMenuItem.Text = "امر توريد جديد";
            this.امرتوريدجديدToolStripMenuItem.Click += new System.EventHandler(this.OrderMenubutton6_Click);
            // 
            // استعراضاوامرالتوريدToolStripMenuItem
            // 
            this.استعراضاوامرالتوريدToolStripMenuItem.Name = "استعراضاوامرالتوريدToolStripMenuItem";
            this.استعراضاوامرالتوريدToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.استعراضاوامرالتوريدToolStripMenuItem.Text = "استعراض اوامر التوريد";
            // 
            // outcardsMenuItem
            // 
            this.outcardsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.انشاءكارتToolStripMenuItem,
            this.listoutcardsMenuItem,
            this.حالةالتحميلToolStripMenuItem});
            this.outcardsMenuItem.Name = "outcardsMenuItem";
            this.outcardsMenuItem.Size = new System.Drawing.Size(170, 34);
            this.outcardsMenuItem.Text = "كروت التحميل";
            // 
            // انشاءكارتToolStripMenuItem
            // 
            this.انشاءكارتToolStripMenuItem.Name = "انشاءكارتToolStripMenuItem";
            this.انشاءكارتToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.انشاءكارتToolStripMenuItem.Text = "انشاء كارت";
            this.انشاءكارتToolStripMenuItem.Click += new System.EventHandler(this.LoadingMenubutton5_Click);
            // 
            // listoutcardsMenuItem
            // 
            this.listoutcardsMenuItem.Name = "listoutcardsMenuItem";
            this.listoutcardsMenuItem.Size = new System.Drawing.Size(193, 34);
            this.listoutcardsMenuItem.Text = "استعراض الكروت";
            this.listoutcardsMenuItem.Click += new System.EventHandler(this.listLoadingCbutton13_Click);
            // 
            // حالةالتحميلToolStripMenuItem
            // 
            this.حالةالتحميلToolStripMenuItem.Name = "حالةالتحميلToolStripMenuItem";
            this.حالةالتحميلToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.حالةالتحميلToolStripMenuItem.Text = "حالة التحميل";
            // 
            // bladingMenuItem
            // 
            this.bladingMenuItem.Name = "bladingMenuItem";
            this.bladingMenuItem.Size = new System.Drawing.Size(170, 34);
            this.bladingMenuItem.Text = "بوليصة الشحن";
            this.bladingMenuItem.Click += new System.EventHandler(this.BillLadingMenubutton4_Click);
            // 
            // inboundMenuItem
            // 
            this.inboundMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierspMenuItem,
            this.shipsMenuItem,
            this.releasesMenuItem,
            this.incardsMenuItem});
            this.inboundMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.inboundMenuItem.Name = "inboundMenuItem";
            this.inboundMenuItem.Size = new System.Drawing.Size(60, 33);
            this.inboundMenuItem.Text = "الوارد";
            // 
            // supplierspMenuItem
            // 
            this.supplierspMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.موردجديدToolStripMenuItem,
            this.استعراضالموردينToolStripMenuItem});
            this.supplierspMenuItem.Name = "supplierspMenuItem";
            this.supplierspMenuItem.Size = new System.Drawing.Size(172, 34);
            this.supplierspMenuItem.Text = "الموردين";
            // 
            // موردجديدToolStripMenuItem
            // 
            this.موردجديدToolStripMenuItem.Name = "موردجديدToolStripMenuItem";
            this.موردجديدToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.موردجديدToolStripMenuItem.Text = "مورد جديد";
            this.موردجديدToolStripMenuItem.Click += new System.EventHandler(this.suplierbutton1_Click);
            // 
            // استعراضالموردينToolStripMenuItem
            // 
            this.استعراضالموردينToolStripMenuItem.Name = "استعراضالموردينToolStripMenuItem";
            this.استعراضالموردينToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.استعراضالموردينToolStripMenuItem.Text = "استعراض الموردين";
            // 
            // shipsMenuItem
            // 
            this.shipsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.شحنةجديدةToolStripMenuItem,
            this.استعراضالشحناتToolStripMenuItem});
            this.shipsMenuItem.Name = "shipsMenuItem";
            this.shipsMenuItem.Size = new System.Drawing.Size(172, 34);
            this.shipsMenuItem.Text = "الشحنات";
            // 
            // شحنةجديدةToolStripMenuItem
            // 
            this.شحنةجديدةToolStripMenuItem.Name = "شحنةجديدةToolStripMenuItem";
            this.شحنةجديدةToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.شحنةجديدةToolStripMenuItem.Text = "شحنة جديدة";
            this.شحنةجديدةToolStripMenuItem.Click += new System.EventHandler(this.shipmentbutton2_Click);
            // 
            // استعراضالشحناتToolStripMenuItem
            // 
            this.استعراضالشحناتToolStripMenuItem.Name = "استعراضالشحناتToolStripMenuItem";
            this.استعراضالشحناتToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.استعراضالشحناتToolStripMenuItem.Text = "استعراض الشحنات";
            // 
            // releasesMenuItem
            // 
            this.releasesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.افراججديدToolStripMenuItem,
            this.استعراضالافراجاتToolStripMenuItem});
            this.releasesMenuItem.Name = "releasesMenuItem";
            this.releasesMenuItem.Size = new System.Drawing.Size(172, 34);
            this.releasesMenuItem.Text = "الافراجات";
            // 
            // افراججديدToolStripMenuItem
            // 
            this.افراججديدToolStripMenuItem.Name = "افراججديدToolStripMenuItem";
            this.افراججديدToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.افراججديدToolStripMenuItem.Text = "افراج جديد";
            this.افراججديدToolStripMenuItem.Click += new System.EventHandler(this.releasebutton3_Click);
            // 
            // استعراضالافراجاتToolStripMenuItem
            // 
            this.استعراضالافراجاتToolStripMenuItem.Name = "استعراضالافراجاتToolStripMenuItem";
            this.استعراضالافراجاتToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.استعراضالافراجاتToolStripMenuItem.Text = "استعراض الافراجات";
            // 
            // incardsMenuItem
            // 
            this.incardsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.كارتجديدToolStripMenuItem,
            this.استعراضالكروتToolStripMenuItem1});
            this.incardsMenuItem.Name = "incardsMenuItem";
            this.incardsMenuItem.Size = new System.Drawing.Size(172, 34);
            this.incardsMenuItem.Text = "كروت الاستلام";
            // 
            // كارتجديدToolStripMenuItem
            // 
            this.كارتجديدToolStripMenuItem.Name = "كارتجديدToolStripMenuItem";
            this.كارتجديدToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.كارتجديدToolStripMenuItem.Text = "كارت جديد";
            this.كارتجديدToolStripMenuItem.Click += new System.EventHandler(this.rcardbutton4_Click);
            // 
            // استعراضالكروتToolStripMenuItem1
            // 
            this.استعراضالكروتToolStripMenuItem1.Name = "استعراضالكروتToolStripMenuItem1";
            this.استعراضالكروتToolStripMenuItem1.Size = new System.Drawing.Size(193, 34);
            this.استعراضالكروتToolStripMenuItem1.Text = "استعراض الكروت";
            this.استعراضالكروتToolStripMenuItem1.Click += new System.EventHandler(this.listInCardsbutton13_Click);
            // 
            // reportsMenuItem
            // 
            this.reportsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.reportsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تقريرالواردالاجماليToolStripMenuItem,
            this.تقاريرالصادرToolStripMenuItem,
            this.تقاريرالواردToolStripMenuItem});
            this.reportsMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.reportsMenuItem.Name = "reportsMenuItem";
            this.reportsMenuItem.Size = new System.Drawing.Size(68, 33);
            this.reportsMenuItem.Text = "التقارير";
            // 
            // تقريرالواردالاجماليToolStripMenuItem
            // 
            this.تقريرالواردالاجماليToolStripMenuItem.Name = "تقريرالواردالاجماليToolStripMenuItem";
            this.تقريرالواردالاجماليToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.تقريرالواردالاجماليToolStripMenuItem.Text = "تقرير الوارد الاجمالي";
            this.تقريرالواردالاجماليToolStripMenuItem.Click += new System.EventHandler(this.INshiftRptBtn_Click);
            // 
            // تقاريرالصادرToolStripMenuItem
            // 
            this.تقاريرالصادرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الصادراليوميToolStripMenuItem,
            this.تقاريرالعقودToolStripMenuItem,
            this.تقاريراوامرالتوريدToolStripMenuItem,
            this.تقاريرالعملاءToolStripMenuItem});
            this.تقاريرالصادرToolStripMenuItem.Name = "تقاريرالصادرToolStripMenuItem";
            this.تقاريرالصادرToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.تقاريرالصادرToolStripMenuItem.Text = "تقارير الصادر";
            // 
            // الصادراليوميToolStripMenuItem
            // 
            this.الصادراليوميToolStripMenuItem.Name = "الصادراليوميToolStripMenuItem";
            this.الصادراليوميToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.الصادراليوميToolStripMenuItem.Text = "الصادر اليومي";
            this.الصادراليوميToolStripMenuItem.Click += new System.EventHandler(this.buttondailyout_Click);
            // 
            // تقاريرالعقودToolStripMenuItem
            // 
            this.تقاريرالعقودToolStripMenuItem.Name = "تقاريرالعقودToolStripMenuItem";
            this.تقاريرالعقودToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.تقاريرالعقودToolStripMenuItem.Text = "تقارير العقود";
            // 
            // تقاريراوامرالتوريدToolStripMenuItem
            // 
            this.تقاريراوامرالتوريدToolStripMenuItem.Name = "تقاريراوامرالتوريدToolStripMenuItem";
            this.تقاريراوامرالتوريدToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.تقاريراوامرالتوريدToolStripMenuItem.Text = "تقارير اوامر التوريد";
            // 
            // تقاريرالعملاءToolStripMenuItem
            // 
            this.تقاريرالعملاءToolStripMenuItem.Name = "تقاريرالعملاءToolStripMenuItem";
            this.تقاريرالعملاءToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.تقاريرالعملاءToolStripMenuItem.Text = "تقارير العملاء";
            // 
            // تقاريرالواردToolStripMenuItem
            // 
            this.تقاريرالواردToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تقريرالوارداليوميToolStripMenuItem,
            this.تقاريرالشحناتToolStripMenuItem,
            this.تقاريرالافراجاتToolStripMenuItem,
            this.تقاريرالموردينToolStripMenuItem});
            this.تقاريرالواردToolStripMenuItem.Name = "تقاريرالواردToolStripMenuItem";
            this.تقاريرالواردToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.تقاريرالواردToolStripMenuItem.Text = "تقارير الوارد";
            // 
            // تقريرالوارداليوميToolStripMenuItem
            // 
            this.تقريرالوارداليوميToolStripMenuItem.Name = "تقريرالوارداليوميToolStripMenuItem";
            this.تقريرالوارداليوميToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.تقريرالوارداليوميToolStripMenuItem.Text = "تقرير الوارد اليومي";
            this.تقريرالوارداليوميToolStripMenuItem.Click += new System.EventHandler(this.button11dailyIn_Click);
            // 
            // تقاريرالشحناتToolStripMenuItem
            // 
            this.تقاريرالشحناتToolStripMenuItem.Name = "تقاريرالشحناتToolStripMenuItem";
            this.تقاريرالشحناتToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.تقاريرالشحناتToolStripMenuItem.Text = "تقارير الشحنات";
            // 
            // تقاريرالافراجاتToolStripMenuItem
            // 
            this.تقاريرالافراجاتToolStripMenuItem.Name = "تقاريرالافراجاتToolStripMenuItem";
            this.تقاريرالافراجاتToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.تقاريرالافراجاتToolStripMenuItem.Text = "تقارير الافراجات";
            // 
            // تقاريرالموردينToolStripMenuItem
            // 
            this.تقاريرالموردينToolStripMenuItem.Name = "تقاريرالموردينToolStripMenuItem";
            this.تقاريرالموردينToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.تقاريرالموردينToolStripMenuItem.Text = "تقارير الموردين";
            // 
            // productsMenuItem
            // 
            this.productsMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.productsMenuItem.Name = "productsMenuItem";
            this.productsMenuItem.Size = new System.Drawing.Size(76, 33);
            this.productsMenuItem.Text = "الاصناف";
            this.productsMenuItem.Click += new System.EventHandler(this.newCommbutton5_Click);
            // 
            // transMenuItem
            // 
            this.transMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.transMenuItem.Name = "transMenuItem";
            this.transMenuItem.Size = new System.Drawing.Size(51, 33);
            this.transMenuItem.Text = "النقل";
            this.transMenuItem.Click += new System.EventHandler(this.newTruckbutton9_Click);
            // 
            // WbridgesMenuItem
            // 
            this.WbridgesMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.WbridgesMenuItem.Name = "WbridgesMenuItem";
            this.WbridgesMenuItem.Size = new System.Drawing.Size(67, 33);
            this.WbridgesMenuItem.Text = "الميزان";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اusersettingsMenuItem,
            this.systemsettingsMenuItem});
            this.settingsMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(78, 33);
            this.settingsMenuItem.Text = "الاعدادت";
            // 
            // اusersettingsMenuItem
            // 
            this.اusersettingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بياناتالمستخدمToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.newuserMenuItem});
            this.اusersettingsMenuItem.Name = "اusersettingsMenuItem";
            this.اusersettingsMenuItem.Size = new System.Drawing.Size(188, 34);
            this.اusersettingsMenuItem.Text = "اعدادات المستخدم";
            // 
            // بياناتالمستخدمToolStripMenuItem
            // 
            this.بياناتالمستخدمToolStripMenuItem.Name = "بياناتالمستخدمToolStripMenuItem";
            this.بياناتالمستخدمToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.بياناتالمستخدمToolStripMenuItem.Text = "بيانات المستخدم";
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.تعديلToolStripMenuItem.Text = "تعديل البيانات";
            // 
            // newuserMenuItem
            // 
            this.newuserMenuItem.Name = "newuserMenuItem";
            this.newuserMenuItem.Size = new System.Drawing.Size(197, 34);
            this.newuserMenuItem.Text = "اضافة مستخدم جديد";
            // 
            // systemsettingsMenuItem
            // 
            this.systemsettingsMenuItem.Name = "systemsettingsMenuItem";
            this.systemsettingsMenuItem.Size = new System.Drawing.Size(188, 34);
            this.systemsettingsMenuItem.Text = "اعدادات النظام";
            this.systemsettingsMenuItem.Click += new System.EventHandler(this.settingsbutton25_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1004, 749);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MinimumSize = new System.Drawing.Size(640, 638);
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " نظام ادارة اللوجستيات و الموازين - Lobridge Pro1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private DLWSDataSet dLWSDataSet;
        private System.Windows.Forms.BindingSource cameraBindingSource;
        private DLWSDataSetTableAdapters.CameraTableAdapter cameraTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem outboundMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةعميلجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالعملاءالحاليينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عقدجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listcontractsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem امرتوريدجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعراضاوامرالتوريدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outcardsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انشاءكارتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listoutcardsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حالةالتحميلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bladingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboundMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WbridgesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقريرالواردالاجماليToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierspMenuItem;
        private System.Windows.Forms.ToolStripMenuItem موردجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعراضالموردينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem شحنةجديدةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعراضالشحناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releasesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem افراججديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعراضالافراجاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incardsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem كارتجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعراضالكروتToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem اusersettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بياناتالمستخدمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newuserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemsettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرالصادرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرالواردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الصادراليوميToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرالعقودToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريراوامرالتوريدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرالعملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقريرالوارداليوميToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرالشحناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرالافراجاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرالموردينToolStripMenuItem;
    }
}