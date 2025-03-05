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
            this.InComingViewPanel = new NSpanel.NPanel();
            this.IncomingMenuPanel1 = new System.Windows.Forms.Panel();
            this.btn_ladingprts = new System.Windows.Forms.Button();
            this.btnladeditadv = new System.Windows.Forms.Button();
            this.btnLocalSuppliers = new System.Windows.Forms.Button();
            this.inm_AdvancedEditbutton9 = new System.Windows.Forms.Button();
            this.inm_INshiftRptBtn8 = new System.Windows.Forms.Button();
            this.inm_summaryreportBtn7 = new System.Windows.Forms.Button();
            this.inm_listshipsbutton6 = new System.Windows.Forms.Button();
            this.inm_listInCardsbutton5 = new System.Windows.Forms.Button();
            this.inm_incardbutton4 = new System.Windows.Forms.Button();
            this.inm_releasebutton3 = new System.Windows.Forms.Button();
            this.inm_shipmentbutton2 = new System.Windows.Forms.Button();
            this.inm_suplierbutton1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.OutMenupanel2 = new System.Windows.Forms.Panel();
            this.om_ReportingoutBtn = new System.Windows.Forms.Button();
            this.om_listContractbutton13 = new System.Windows.Forms.Button();
            this.om_listLoadingCbutton13 = new System.Windows.Forms.Button();
            this.om_BillLadingMenubutton4 = new System.Windows.Forms.Button();
            this.om_LoadingMenubutton5 = new System.Windows.Forms.Button();
            this.om_OrderMenubutton6 = new System.Windows.Forms.Button();
            this.om_ContractsMenubutton7 = new System.Windows.Forms.Button();
            this.om_CustomersMenubutton8 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menumax = new System.Windows.Forms.Button();
            this.menumin = new System.Windows.Forms.Button();
            this.reportViewpanel1 = new NSpanel.NPanel();
            this.reportMenupanel2 = new System.Windows.Forms.Panel();
            this.button10sumIn = new System.Windows.Forms.Button();
            this.button11dailyIn = new System.Windows.Forms.Button();
            this.buttondailyout = new System.Windows.Forms.Button();
            this.reportingbutton12 = new System.Windows.Forms.Button();
            this.Wsemmarybutton13 = new System.Windows.Forms.Button();
            this.weightViewpanel1 = new NSpanel.NPanel();
            this.WeightMenupanel3 = new System.Windows.Forms.Panel();
            this.StopWscreenBtn = new System.Windows.Forms.Button();
            this.listOutMenubutton1 = new System.Windows.Forms.Button();
            this.ListWINMenubutton1 = new System.Windows.Forms.Button();
            this.WeightOutMenubutton2 = new System.Windows.Forms.Button();
            this.WeightINMenubutton3 = new System.Windows.Forms.Button();
            this.commViewpanel1 = new NSpanel.NPanel();
            this.commMenupanel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.newCommbutton5 = new System.Windows.Forms.Button();
            this.transViewpanel1 = new NSpanel.NPanel();
            this.transMenupanel3 = new System.Windows.Forms.Panel();
            this.btnTruckTypes = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.newDriverbutton8 = new System.Windows.Forms.Button();
            this.newTruckbutton9 = new System.Windows.Forms.Button();
            this.userViewpanel1 = new System.Windows.Forms.Panel();
            this.userMenupanel3 = new System.Windows.Forms.Panel();
            this.refreshPerm = new System.Windows.Forms.Button();
            this.logOutbutton13 = new System.Windows.Forms.Button();
            this.changePassbutton14 = new System.Windows.Forms.Button();
            this.btn_perm = new System.Windows.Forms.Button();
            this.emailSettingbutton15 = new System.Windows.Forms.Button();
            this.addNewUer = new System.Windows.Forms.Button();
            this.userProfilebutton16 = new System.Windows.Forms.Button();
            this.SysViewpanel4 = new NSpanel.NPanel();
            this.SysSettingMenupanel5 = new System.Windows.Forms.Panel();
            this.settingsbutton25 = new System.Windows.Forms.Button();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.lobsys = new MetroFramework.Controls.MetroTabPage();
            this.OutboundPage = new MetroFramework.Controls.MetroTabPage();
            this.OutGoingViewPanel = new NSpanel.NPanel();
            this.InboundPage = new MetroFramework.Controls.MetroTabPage();
            this.ReportsPage = new MetroFramework.Controls.MetroTabPage();
            this.WBridgePage = new MetroFramework.Controls.MetroTabPage();
            this.CatPage = new MetroFramework.Controls.MetroTabPage();
            this.TransPage = new MetroFramework.Controls.MetroTabPage();
            this.UserSettingsPage = new MetroFramework.Controls.MetroTabPage();
            this.SySettingsPage = new MetroFramework.Controls.MetroTabPage();
            this.CamPage = new MetroFramework.Controls.MetroTabPage();
            this.campanel1 = new NSpanel.NPanel();
            this.camMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.camSettingBtn = new System.Windows.Forms.Button();
            this.cam_NameComboBox = new System.Windows.Forms.ComboBox();
            this.cameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dLWSDataSet = new LoBridge.DLWSDataSet();
            this.mealSCamBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cameraTableAdapter = new LoBridge.DLWSDataSetTableAdapters.CameraTableAdapter();
            this.IncomingMenuPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.OutMenupanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.reportMenupanel2.SuspendLayout();
            this.WeightMenupanel3.SuspendLayout();
            this.commMenupanel3.SuspendLayout();
            this.transMenupanel3.SuspendLayout();
            this.userMenupanel3.SuspendLayout();
            this.SysSettingMenupanel5.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.OutboundPage.SuspendLayout();
            this.InboundPage.SuspendLayout();
            this.ReportsPage.SuspendLayout();
            this.WBridgePage.SuspendLayout();
            this.CatPage.SuspendLayout();
            this.TransPage.SuspendLayout();
            this.UserSettingsPage.SuspendLayout();
            this.SySettingsPage.SuspendLayout();
            this.CamPage.SuspendLayout();
            this.camMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InComingViewPanel
            // 
            this.InComingViewPanel.AutoScroll = true;
            this.InComingViewPanel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.InComingViewPanel.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.InComingViewPanel.BackgroundImage = global::LoBridge.Properties.Resources.Logistics;
            this.InComingViewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InComingViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InComingViewPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InComingViewPanel.Location = new System.Drawing.Point(0, 6);
            this.InComingViewPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.InComingViewPanel.Name = "InComingViewPanel";
            this.InComingViewPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InComingViewPanel.Size = new System.Drawing.Size(1555, 942);
            this.InComingViewPanel.TabIndex = 1;
            // 
            // IncomingMenuPanel1
            // 
            this.IncomingMenuPanel1.BackColor = System.Drawing.Color.CadetBlue;
            this.IncomingMenuPanel1.BackgroundImage = global::LoBridge.Properties.Resources.LogisticsMenu1;
            this.IncomingMenuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IncomingMenuPanel1.Controls.Add(this.btn_ladingprts);
            this.IncomingMenuPanel1.Controls.Add(this.btnladeditadv);
            this.IncomingMenuPanel1.Controls.Add(this.btnLocalSuppliers);
            this.IncomingMenuPanel1.Controls.Add(this.inm_AdvancedEditbutton9);
            this.IncomingMenuPanel1.Controls.Add(this.inm_INshiftRptBtn8);
            this.IncomingMenuPanel1.Controls.Add(this.inm_summaryreportBtn7);
            this.IncomingMenuPanel1.Controls.Add(this.inm_listshipsbutton6);
            this.IncomingMenuPanel1.Controls.Add(this.inm_listInCardsbutton5);
            this.IncomingMenuPanel1.Controls.Add(this.inm_incardbutton4);
            this.IncomingMenuPanel1.Controls.Add(this.inm_releasebutton3);
            this.IncomingMenuPanel1.Controls.Add(this.inm_shipmentbutton2);
            this.IncomingMenuPanel1.Controls.Add(this.inm_suplierbutton1);
            this.IncomingMenuPanel1.Controls.Add(this.panel4);
            this.IncomingMenuPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.IncomingMenuPanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomingMenuPanel1.Location = new System.Drawing.Point(1555, 6);
            this.IncomingMenuPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.IncomingMenuPanel1.MaximumSize = new System.Drawing.Size(226, 1200);
            this.IncomingMenuPanel1.Name = "IncomingMenuPanel1";
            this.IncomingMenuPanel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.IncomingMenuPanel1.Size = new System.Drawing.Size(200, 942);
            this.IncomingMenuPanel1.TabIndex = 5;
            // 
            // btn_ladingprts
            // 
            this.btn_ladingprts.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ladingprts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ladingprts.CausesValidation = false;
            this.btn_ladingprts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ladingprts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ladingprts.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_ladingprts.FlatAppearance.BorderSize = 0;
            this.btn_ladingprts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ladingprts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ladingprts.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_ladingprts.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_ladingprts.Image = ((System.Drawing.Image)(resources.GetObject("btn_ladingprts.Image")));
            this.btn_ladingprts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ladingprts.Location = new System.Drawing.Point(0, 600);
            this.btn_ladingprts.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ladingprts.Name = "btn_ladingprts";
            this.btn_ladingprts.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btn_ladingprts.Size = new System.Drawing.Size(200, 50);
            this.btn_ladingprts.TabIndex = 18;
            this.btn_ladingprts.Text = "اماكن التحميل";
            this.btn_ladingprts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ladingprts.UseVisualStyleBackColor = false;
            this.btn_ladingprts.Click += new System.EventHandler(this.btn_ladingprts_Click);
            // 
            // btnladeditadv
            // 
            this.btnladeditadv.BackColor = System.Drawing.Color.DarkGray;
            this.btnladeditadv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnladeditadv.CausesValidation = false;
            this.btnladeditadv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnladeditadv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnladeditadv.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnladeditadv.FlatAppearance.BorderSize = 0;
            this.btnladeditadv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnladeditadv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnladeditadv.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnladeditadv.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnladeditadv.Image = ((System.Drawing.Image)(resources.GetObject("btnladeditadv.Image")));
            this.btnladeditadv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnladeditadv.Location = new System.Drawing.Point(0, 550);
            this.btnladeditadv.Margin = new System.Windows.Forms.Padding(0);
            this.btnladeditadv.Name = "btnladeditadv";
            this.btnladeditadv.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btnladeditadv.Size = new System.Drawing.Size(200, 50);
            this.btnladeditadv.TabIndex = 17;
            this.btnladeditadv.Text = "تعديل متقدم للكارت";
            this.btnladeditadv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnladeditadv.UseVisualStyleBackColor = false;
            this.btnladeditadv.Visible = false;
            this.btnladeditadv.Click += new System.EventHandler(this.btnladeditadv_Click);
            // 
            // btnLocalSuppliers
            // 
            this.btnLocalSuppliers.BackColor = System.Drawing.Color.DarkGray;
            this.btnLocalSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalSuppliers.CausesValidation = false;
            this.btnLocalSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocalSuppliers.Enabled = false;
            this.btnLocalSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnLocalSuppliers.FlatAppearance.BorderSize = 0;
            this.btnLocalSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLocalSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLocalSuppliers.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLocalSuppliers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLocalSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalSuppliers.Image")));
            this.btnLocalSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocalSuppliers.Location = new System.Drawing.Point(0, 500);
            this.btnLocalSuppliers.Margin = new System.Windows.Forms.Padding(0);
            this.btnLocalSuppliers.Name = "btnLocalSuppliers";
            this.btnLocalSuppliers.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btnLocalSuppliers.Size = new System.Drawing.Size(200, 50);
            this.btnLocalSuppliers.TabIndex = 16;
            this.btnLocalSuppliers.Text = "قائمة المستوردين";
            this.btnLocalSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalSuppliers.UseVisualStyleBackColor = false;
            this.btnLocalSuppliers.Click += new System.EventHandler(this.btnLocalSuppliers_Click);
            // 
            // inm_AdvancedEditbutton9
            // 
            this.inm_AdvancedEditbutton9.BackColor = System.Drawing.Color.DarkGray;
            this.inm_AdvancedEditbutton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inm_AdvancedEditbutton9.CausesValidation = false;
            this.inm_AdvancedEditbutton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inm_AdvancedEditbutton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.inm_AdvancedEditbutton9.Enabled = false;
            this.inm_AdvancedEditbutton9.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.inm_AdvancedEditbutton9.FlatAppearance.BorderSize = 0;
            this.inm_AdvancedEditbutton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.inm_AdvancedEditbutton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.inm_AdvancedEditbutton9.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.inm_AdvancedEditbutton9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inm_AdvancedEditbutton9.Image = ((System.Drawing.Image)(resources.GetObject("inm_AdvancedEditbutton9.Image")));
            this.inm_AdvancedEditbutton9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inm_AdvancedEditbutton9.Location = new System.Drawing.Point(0, 450);
            this.inm_AdvancedEditbutton9.Margin = new System.Windows.Forms.Padding(0);
            this.inm_AdvancedEditbutton9.Name = "inm_AdvancedEditbutton9";
            this.inm_AdvancedEditbutton9.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.inm_AdvancedEditbutton9.Size = new System.Drawing.Size(200, 50);
            this.inm_AdvancedEditbutton9.TabIndex = 9;
            this.inm_AdvancedEditbutton9.Text = "تعديل متقدم";
            this.inm_AdvancedEditbutton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inm_AdvancedEditbutton9.UseVisualStyleBackColor = false;
            this.inm_AdvancedEditbutton9.Click += new System.EventHandler(this.AdvancedEditbutton15_Click);
            // 
            // inm_INshiftRptBtn8
            // 
            this.inm_INshiftRptBtn8.BackColor = System.Drawing.Color.DarkGray;
            this.inm_INshiftRptBtn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inm_INshiftRptBtn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inm_INshiftRptBtn8.Dock = System.Windows.Forms.DockStyle.Top;
            this.inm_INshiftRptBtn8.Enabled = false;
            this.inm_INshiftRptBtn8.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.inm_INshiftRptBtn8.FlatAppearance.BorderSize = 0;
            this.inm_INshiftRptBtn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.inm_INshiftRptBtn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.inm_INshiftRptBtn8.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.inm_INshiftRptBtn8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inm_INshiftRptBtn8.Image = ((System.Drawing.Image)(resources.GetObject("inm_INshiftRptBtn8.Image")));
            this.inm_INshiftRptBtn8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inm_INshiftRptBtn8.Location = new System.Drawing.Point(0, 400);
            this.inm_INshiftRptBtn8.Margin = new System.Windows.Forms.Padding(0);
            this.inm_INshiftRptBtn8.Name = "inm_INshiftRptBtn8";
            this.inm_INshiftRptBtn8.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.inm_INshiftRptBtn8.Size = new System.Drawing.Size(200, 50);
            this.inm_INshiftRptBtn8.TabIndex = 8;
            this.inm_INshiftRptBtn8.Text = "تقرير الوارد الاجمالي";
            this.inm_INshiftRptBtn8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inm_INshiftRptBtn8.UseVisualStyleBackColor = false;
            this.inm_INshiftRptBtn8.Click += new System.EventHandler(this.INshiftRptBtn_Click);
            // 
            // inm_summaryreportBtn7
            // 
            this.inm_summaryreportBtn7.BackColor = System.Drawing.Color.DarkGray;
            this.inm_summaryreportBtn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inm_summaryreportBtn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inm_summaryreportBtn7.Dock = System.Windows.Forms.DockStyle.Top;
            this.inm_summaryreportBtn7.Enabled = false;
            this.inm_summaryreportBtn7.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.inm_summaryreportBtn7.FlatAppearance.BorderSize = 0;
            this.inm_summaryreportBtn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.inm_summaryreportBtn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.inm_summaryreportBtn7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.inm_summaryreportBtn7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inm_summaryreportBtn7.Image = ((System.Drawing.Image)(resources.GetObject("inm_summaryreportBtn7.Image")));
            this.inm_summaryreportBtn7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inm_summaryreportBtn7.Location = new System.Drawing.Point(0, 350);
            this.inm_summaryreportBtn7.Margin = new System.Windows.Forms.Padding(0);
            this.inm_summaryreportBtn7.Name = "inm_summaryreportBtn7";
            this.inm_summaryreportBtn7.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.inm_summaryreportBtn7.Size = new System.Drawing.Size(200, 50);
            this.inm_summaryreportBtn7.TabIndex = 7;
            this.inm_summaryreportBtn7.Text = "تقرير الوارد اليومي";
            this.inm_summaryreportBtn7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inm_summaryreportBtn7.UseVisualStyleBackColor = false;
            this.inm_summaryreportBtn7.Click += new System.EventHandler(this.ShiftBtn_Click);
            // 
            // inm_listshipsbutton6
            // 
            this.inm_listshipsbutton6.BackColor = System.Drawing.Color.DarkGray;
            this.inm_listshipsbutton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inm_listshipsbutton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inm_listshipsbutton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.inm_listshipsbutton6.Enabled = false;
            this.inm_listshipsbutton6.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.inm_listshipsbutton6.FlatAppearance.BorderSize = 0;
            this.inm_listshipsbutton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.inm_listshipsbutton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.inm_listshipsbutton6.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.inm_listshipsbutton6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inm_listshipsbutton6.Image = ((System.Drawing.Image)(resources.GetObject("inm_listshipsbutton6.Image")));
            this.inm_listshipsbutton6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inm_listshipsbutton6.Location = new System.Drawing.Point(0, 300);
            this.inm_listshipsbutton6.Margin = new System.Windows.Forms.Padding(0);
            this.inm_listshipsbutton6.Name = "inm_listshipsbutton6";
            this.inm_listshipsbutton6.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.inm_listshipsbutton6.Size = new System.Drawing.Size(200, 50);
            this.inm_listshipsbutton6.TabIndex = 6;
            this.inm_listshipsbutton6.Text = "عرض الشحنات";
            this.inm_listshipsbutton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inm_listshipsbutton6.UseVisualStyleBackColor = false;
            this.inm_listshipsbutton6.Click += new System.EventHandler(this.listshipsbutton13_Click);
            // 
            // inm_listInCardsbutton5
            // 
            this.inm_listInCardsbutton5.BackColor = System.Drawing.Color.DarkGray;
            this.inm_listInCardsbutton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inm_listInCardsbutton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inm_listInCardsbutton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.inm_listInCardsbutton5.Enabled = false;
            this.inm_listInCardsbutton5.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.inm_listInCardsbutton5.FlatAppearance.BorderSize = 0;
            this.inm_listInCardsbutton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.inm_listInCardsbutton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.inm_listInCardsbutton5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.inm_listInCardsbutton5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inm_listInCardsbutton5.Image = ((System.Drawing.Image)(resources.GetObject("inm_listInCardsbutton5.Image")));
            this.inm_listInCardsbutton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inm_listInCardsbutton5.Location = new System.Drawing.Point(0, 250);
            this.inm_listInCardsbutton5.Margin = new System.Windows.Forms.Padding(0);
            this.inm_listInCardsbutton5.Name = "inm_listInCardsbutton5";
            this.inm_listInCardsbutton5.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.inm_listInCardsbutton5.Size = new System.Drawing.Size(200, 50);
            this.inm_listInCardsbutton5.TabIndex = 5;
            this.inm_listInCardsbutton5.Text = "عرض كروت الاستلام";
            this.inm_listInCardsbutton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inm_listInCardsbutton5.UseVisualStyleBackColor = false;
            this.inm_listInCardsbutton5.Click += new System.EventHandler(this.listInCardsbutton13_Click);
            // 
            // inm_incardbutton4
            // 
            this.inm_incardbutton4.BackColor = System.Drawing.Color.DarkGray;
            this.inm_incardbutton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inm_incardbutton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inm_incardbutton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.inm_incardbutton4.Enabled = false;
            this.inm_incardbutton4.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.inm_incardbutton4.FlatAppearance.BorderSize = 0;
            this.inm_incardbutton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.inm_incardbutton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.inm_incardbutton4.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.inm_incardbutton4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inm_incardbutton4.Image = ((System.Drawing.Image)(resources.GetObject("inm_incardbutton4.Image")));
            this.inm_incardbutton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inm_incardbutton4.Location = new System.Drawing.Point(0, 200);
            this.inm_incardbutton4.Margin = new System.Windows.Forms.Padding(0);
            this.inm_incardbutton4.Name = "inm_incardbutton4";
            this.inm_incardbutton4.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.inm_incardbutton4.Size = new System.Drawing.Size(200, 50);
            this.inm_incardbutton4.TabIndex = 3;
            this.inm_incardbutton4.Text = "انشاء كارت استلام";
            this.inm_incardbutton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inm_incardbutton4.UseVisualStyleBackColor = false;
            this.inm_incardbutton4.Click += new System.EventHandler(this.rcardbutton4_Click);
            // 
            // inm_releasebutton3
            // 
            this.inm_releasebutton3.BackColor = System.Drawing.Color.DarkGray;
            this.inm_releasebutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inm_releasebutton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inm_releasebutton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.inm_releasebutton3.Enabled = false;
            this.inm_releasebutton3.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.inm_releasebutton3.FlatAppearance.BorderSize = 0;
            this.inm_releasebutton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.inm_releasebutton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.inm_releasebutton3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.inm_releasebutton3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inm_releasebutton3.Image = ((System.Drawing.Image)(resources.GetObject("inm_releasebutton3.Image")));
            this.inm_releasebutton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inm_releasebutton3.Location = new System.Drawing.Point(0, 150);
            this.inm_releasebutton3.Margin = new System.Windows.Forms.Padding(0);
            this.inm_releasebutton3.Name = "inm_releasebutton3";
            this.inm_releasebutton3.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.inm_releasebutton3.Size = new System.Drawing.Size(200, 50);
            this.inm_releasebutton3.TabIndex = 2;
            this.inm_releasebutton3.Text = "الافراج الجمركي";
            this.inm_releasebutton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inm_releasebutton3.UseVisualStyleBackColor = false;
            this.inm_releasebutton3.Click += new System.EventHandler(this.releasebutton3_Click);
            // 
            // inm_shipmentbutton2
            // 
            this.inm_shipmentbutton2.BackColor = System.Drawing.Color.DarkGray;
            this.inm_shipmentbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inm_shipmentbutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inm_shipmentbutton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.inm_shipmentbutton2.Enabled = false;
            this.inm_shipmentbutton2.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.inm_shipmentbutton2.FlatAppearance.BorderSize = 0;
            this.inm_shipmentbutton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.inm_shipmentbutton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.inm_shipmentbutton2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.inm_shipmentbutton2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inm_shipmentbutton2.Image = ((System.Drawing.Image)(resources.GetObject("inm_shipmentbutton2.Image")));
            this.inm_shipmentbutton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inm_shipmentbutton2.Location = new System.Drawing.Point(0, 100);
            this.inm_shipmentbutton2.Margin = new System.Windows.Forms.Padding(0);
            this.inm_shipmentbutton2.Name = "inm_shipmentbutton2";
            this.inm_shipmentbutton2.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.inm_shipmentbutton2.Size = new System.Drawing.Size(200, 50);
            this.inm_shipmentbutton2.TabIndex = 1;
            this.inm_shipmentbutton2.Text = "شحنة جديدة";
            this.inm_shipmentbutton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inm_shipmentbutton2.UseVisualStyleBackColor = false;
            this.inm_shipmentbutton2.Click += new System.EventHandler(this.shipmentbutton2_Click);
            // 
            // inm_suplierbutton1
            // 
            this.inm_suplierbutton1.BackColor = System.Drawing.Color.DarkGray;
            this.inm_suplierbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inm_suplierbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inm_suplierbutton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.inm_suplierbutton1.Enabled = false;
            this.inm_suplierbutton1.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.inm_suplierbutton1.FlatAppearance.BorderSize = 0;
            this.inm_suplierbutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.inm_suplierbutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.inm_suplierbutton1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.inm_suplierbutton1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inm_suplierbutton1.Image = ((System.Drawing.Image)(resources.GetObject("inm_suplierbutton1.Image")));
            this.inm_suplierbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inm_suplierbutton1.Location = new System.Drawing.Point(0, 50);
            this.inm_suplierbutton1.Margin = new System.Windows.Forms.Padding(0);
            this.inm_suplierbutton1.Name = "inm_suplierbutton1";
            this.inm_suplierbutton1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.inm_suplierbutton1.Size = new System.Drawing.Size(200, 50);
            this.inm_suplierbutton1.TabIndex = 0;
            this.inm_suplierbutton1.Text = "الموردين";
            this.inm_suplierbutton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inm_suplierbutton1.UseVisualStyleBackColor = false;
            this.inm_suplierbutton1.Click += new System.EventHandler(this.suplierbutton1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 44);
            this.panel4.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::LoBridge.Properties.Resources.scroll_left_icon;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(156, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 44);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::LoBridge.Properties.Resources.scroll_right_icon;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Dock = System.Windows.Forms.DockStyle.Left;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 44);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // OutMenupanel2
            // 
            this.OutMenupanel2.BackColor = System.Drawing.Color.Transparent;
            this.OutMenupanel2.BackgroundImage = global::LoBridge.Properties.Resources.LogisticsMenu1;
            this.OutMenupanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OutMenupanel2.Controls.Add(this.om_ReportingoutBtn);
            this.OutMenupanel2.Controls.Add(this.om_listContractbutton13);
            this.OutMenupanel2.Controls.Add(this.om_listLoadingCbutton13);
            this.OutMenupanel2.Controls.Add(this.om_BillLadingMenubutton4);
            this.OutMenupanel2.Controls.Add(this.om_LoadingMenubutton5);
            this.OutMenupanel2.Controls.Add(this.om_OrderMenubutton6);
            this.OutMenupanel2.Controls.Add(this.om_ContractsMenubutton7);
            this.OutMenupanel2.Controls.Add(this.om_CustomersMenubutton8);
            this.OutMenupanel2.Controls.Add(this.panel3);
            this.OutMenupanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.OutMenupanel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.OutMenupanel2.Location = new System.Drawing.Point(1555, 6);
            this.OutMenupanel2.Margin = new System.Windows.Forms.Padding(0);
            this.OutMenupanel2.MaximumSize = new System.Drawing.Size(226, 1200);
            this.OutMenupanel2.Name = "OutMenupanel2";
            this.OutMenupanel2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.OutMenupanel2.Size = new System.Drawing.Size(200, 942);
            this.OutMenupanel2.TabIndex = 7;
            this.OutMenupanel2.MouseEnter += new System.EventHandler(this.OutMenupanel2_MouseEnter);
            this.OutMenupanel2.MouseLeave += new System.EventHandler(this.OutMenupanel2_MouseLeave);
            // 
            // om_ReportingoutBtn
            // 
            this.om_ReportingoutBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.om_ReportingoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.om_ReportingoutBtn.CausesValidation = false;
            this.om_ReportingoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.om_ReportingoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.om_ReportingoutBtn.Enabled = false;
            this.om_ReportingoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.om_ReportingoutBtn.FlatAppearance.BorderSize = 0;
            this.om_ReportingoutBtn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.om_ReportingoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.om_ReportingoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.om_ReportingoutBtn.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.om_ReportingoutBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.om_ReportingoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("om_ReportingoutBtn.Image")));
            this.om_ReportingoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.om_ReportingoutBtn.Location = new System.Drawing.Point(0, 400);
            this.om_ReportingoutBtn.Margin = new System.Windows.Forms.Padding(10);
            this.om_ReportingoutBtn.Name = "om_ReportingoutBtn";
            this.om_ReportingoutBtn.Size = new System.Drawing.Size(200, 50);
            this.om_ReportingoutBtn.TabIndex = 13;
            this.om_ReportingoutBtn.Text = "تقرير الصادر اليومي";
            this.om_ReportingoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.om_ReportingoutBtn.UseVisualStyleBackColor = false;
            this.om_ReportingoutBtn.Click += new System.EventHandler(this.ReportingoutBtn_Click);
            this.om_ReportingoutBtn.MouseEnter += new System.EventHandler(this.om_CustomersMenubutton8_MouseEnter);
            // 
            // om_listContractbutton13
            // 
            this.om_listContractbutton13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.om_listContractbutton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.om_listContractbutton13.CausesValidation = false;
            this.om_listContractbutton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.om_listContractbutton13.Dock = System.Windows.Forms.DockStyle.Top;
            this.om_listContractbutton13.Enabled = false;
            this.om_listContractbutton13.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.om_listContractbutton13.FlatAppearance.BorderSize = 0;
            this.om_listContractbutton13.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.om_listContractbutton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.om_listContractbutton13.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.om_listContractbutton13.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.om_listContractbutton13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.om_listContractbutton13.Image = ((System.Drawing.Image)(resources.GetObject("om_listContractbutton13.Image")));
            this.om_listContractbutton13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.om_listContractbutton13.Location = new System.Drawing.Point(0, 350);
            this.om_listContractbutton13.Margin = new System.Windows.Forms.Padding(10);
            this.om_listContractbutton13.Name = "om_listContractbutton13";
            this.om_listContractbutton13.Size = new System.Drawing.Size(200, 50);
            this.om_listContractbutton13.TabIndex = 12;
            this.om_listContractbutton13.Text = "استعراض العقود";
            this.om_listContractbutton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.om_listContractbutton13.UseVisualStyleBackColor = false;
            this.om_listContractbutton13.Click += new System.EventHandler(this.listContractbutton13_Click);
            this.om_listContractbutton13.MouseEnter += new System.EventHandler(this.om_CustomersMenubutton8_MouseEnter);
            // 
            // om_listLoadingCbutton13
            // 
            this.om_listLoadingCbutton13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.om_listLoadingCbutton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.om_listLoadingCbutton13.CausesValidation = false;
            this.om_listLoadingCbutton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.om_listLoadingCbutton13.Dock = System.Windows.Forms.DockStyle.Top;
            this.om_listLoadingCbutton13.Enabled = false;
            this.om_listLoadingCbutton13.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.om_listLoadingCbutton13.FlatAppearance.BorderSize = 0;
            this.om_listLoadingCbutton13.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.om_listLoadingCbutton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.om_listLoadingCbutton13.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.om_listLoadingCbutton13.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.om_listLoadingCbutton13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.om_listLoadingCbutton13.Image = ((System.Drawing.Image)(resources.GetObject("om_listLoadingCbutton13.Image")));
            this.om_listLoadingCbutton13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.om_listLoadingCbutton13.Location = new System.Drawing.Point(0, 300);
            this.om_listLoadingCbutton13.Margin = new System.Windows.Forms.Padding(10);
            this.om_listLoadingCbutton13.Name = "om_listLoadingCbutton13";
            this.om_listLoadingCbutton13.Size = new System.Drawing.Size(200, 50);
            this.om_listLoadingCbutton13.TabIndex = 11;
            this.om_listLoadingCbutton13.Text = "عرض كروت التحميل";
            this.om_listLoadingCbutton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.om_listLoadingCbutton13.UseVisualStyleBackColor = false;
            this.om_listLoadingCbutton13.Click += new System.EventHandler(this.listLoadingCbutton13_Click);
            this.om_listLoadingCbutton13.MouseEnter += new System.EventHandler(this.om_CustomersMenubutton8_MouseEnter);
            // 
            // om_BillLadingMenubutton4
            // 
            this.om_BillLadingMenubutton4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.om_BillLadingMenubutton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.om_BillLadingMenubutton4.CausesValidation = false;
            this.om_BillLadingMenubutton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.om_BillLadingMenubutton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.om_BillLadingMenubutton4.Enabled = false;
            this.om_BillLadingMenubutton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.om_BillLadingMenubutton4.FlatAppearance.BorderSize = 0;
            this.om_BillLadingMenubutton4.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.om_BillLadingMenubutton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.om_BillLadingMenubutton4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.om_BillLadingMenubutton4.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.om_BillLadingMenubutton4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.om_BillLadingMenubutton4.Image = ((System.Drawing.Image)(resources.GetObject("om_BillLadingMenubutton4.Image")));
            this.om_BillLadingMenubutton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.om_BillLadingMenubutton4.Location = new System.Drawing.Point(0, 250);
            this.om_BillLadingMenubutton4.Margin = new System.Windows.Forms.Padding(10);
            this.om_BillLadingMenubutton4.Name = "om_BillLadingMenubutton4";
            this.om_BillLadingMenubutton4.Size = new System.Drawing.Size(200, 50);
            this.om_BillLadingMenubutton4.TabIndex = 6;
            this.om_BillLadingMenubutton4.Text = "طباعة بوليصة شحن";
            this.om_BillLadingMenubutton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.om_BillLadingMenubutton4.UseVisualStyleBackColor = false;
            this.om_BillLadingMenubutton4.Click += new System.EventHandler(this.BillLadingMenubutton4_Click);
            this.om_BillLadingMenubutton4.MouseEnter += new System.EventHandler(this.om_CustomersMenubutton8_MouseEnter);
            // 
            // om_LoadingMenubutton5
            // 
            this.om_LoadingMenubutton5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.om_LoadingMenubutton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.om_LoadingMenubutton5.CausesValidation = false;
            this.om_LoadingMenubutton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.om_LoadingMenubutton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.om_LoadingMenubutton5.Enabled = false;
            this.om_LoadingMenubutton5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.om_LoadingMenubutton5.FlatAppearance.BorderSize = 0;
            this.om_LoadingMenubutton5.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.om_LoadingMenubutton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.om_LoadingMenubutton5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.om_LoadingMenubutton5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.om_LoadingMenubutton5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.om_LoadingMenubutton5.Image = ((System.Drawing.Image)(resources.GetObject("om_LoadingMenubutton5.Image")));
            this.om_LoadingMenubutton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.om_LoadingMenubutton5.Location = new System.Drawing.Point(0, 200);
            this.om_LoadingMenubutton5.Margin = new System.Windows.Forms.Padding(10);
            this.om_LoadingMenubutton5.Name = "om_LoadingMenubutton5";
            this.om_LoadingMenubutton5.Size = new System.Drawing.Size(200, 50);
            this.om_LoadingMenubutton5.TabIndex = 3;
            this.om_LoadingMenubutton5.Text = "تسجيل كارت تحميل";
            this.om_LoadingMenubutton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.om_LoadingMenubutton5.UseVisualStyleBackColor = false;
            this.om_LoadingMenubutton5.Click += new System.EventHandler(this.LoadingMenubutton5_Click);
            this.om_LoadingMenubutton5.MouseEnter += new System.EventHandler(this.om_CustomersMenubutton8_MouseEnter);
            // 
            // om_OrderMenubutton6
            // 
            this.om_OrderMenubutton6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.om_OrderMenubutton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.om_OrderMenubutton6.CausesValidation = false;
            this.om_OrderMenubutton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.om_OrderMenubutton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.om_OrderMenubutton6.Enabled = false;
            this.om_OrderMenubutton6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.om_OrderMenubutton6.FlatAppearance.BorderSize = 0;
            this.om_OrderMenubutton6.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.om_OrderMenubutton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.om_OrderMenubutton6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.om_OrderMenubutton6.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.om_OrderMenubutton6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.om_OrderMenubutton6.Image = ((System.Drawing.Image)(resources.GetObject("om_OrderMenubutton6.Image")));
            this.om_OrderMenubutton6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.om_OrderMenubutton6.Location = new System.Drawing.Point(0, 150);
            this.om_OrderMenubutton6.Margin = new System.Windows.Forms.Padding(10);
            this.om_OrderMenubutton6.Name = "om_OrderMenubutton6";
            this.om_OrderMenubutton6.Size = new System.Drawing.Size(200, 50);
            this.om_OrderMenubutton6.TabIndex = 2;
            this.om_OrderMenubutton6.Text = "تسجيل امر توريد";
            this.om_OrderMenubutton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.om_OrderMenubutton6.UseVisualStyleBackColor = false;
            this.om_OrderMenubutton6.Click += new System.EventHandler(this.OrderMenubutton6_Click);
            this.om_OrderMenubutton6.MouseEnter += new System.EventHandler(this.om_CustomersMenubutton8_MouseEnter);
            // 
            // om_ContractsMenubutton7
            // 
            this.om_ContractsMenubutton7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.om_ContractsMenubutton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.om_ContractsMenubutton7.CausesValidation = false;
            this.om_ContractsMenubutton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.om_ContractsMenubutton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.om_ContractsMenubutton7.Enabled = false;
            this.om_ContractsMenubutton7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.om_ContractsMenubutton7.FlatAppearance.BorderSize = 0;
            this.om_ContractsMenubutton7.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.om_ContractsMenubutton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.om_ContractsMenubutton7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.om_ContractsMenubutton7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.om_ContractsMenubutton7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.om_ContractsMenubutton7.Image = ((System.Drawing.Image)(resources.GetObject("om_ContractsMenubutton7.Image")));
            this.om_ContractsMenubutton7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.om_ContractsMenubutton7.Location = new System.Drawing.Point(0, 100);
            this.om_ContractsMenubutton7.Margin = new System.Windows.Forms.Padding(10);
            this.om_ContractsMenubutton7.Name = "om_ContractsMenubutton7";
            this.om_ContractsMenubutton7.Size = new System.Drawing.Size(200, 50);
            this.om_ContractsMenubutton7.TabIndex = 1;
            this.om_ContractsMenubutton7.Text = "تسجيل عقد";
            this.om_ContractsMenubutton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.om_ContractsMenubutton7.UseVisualStyleBackColor = false;
            this.om_ContractsMenubutton7.Click += new System.EventHandler(this.ContrractsMenubutton7_Click);
            this.om_ContractsMenubutton7.MouseEnter += new System.EventHandler(this.om_CustomersMenubutton8_MouseEnter);
            // 
            // om_CustomersMenubutton8
            // 
            this.om_CustomersMenubutton8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.om_CustomersMenubutton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.om_CustomersMenubutton8.CausesValidation = false;
            this.om_CustomersMenubutton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.om_CustomersMenubutton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.om_CustomersMenubutton8.Enabled = false;
            this.om_CustomersMenubutton8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.om_CustomersMenubutton8.FlatAppearance.BorderSize = 0;
            this.om_CustomersMenubutton8.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.om_CustomersMenubutton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.om_CustomersMenubutton8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.om_CustomersMenubutton8.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.om_CustomersMenubutton8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.om_CustomersMenubutton8.Image = ((System.Drawing.Image)(resources.GetObject("om_CustomersMenubutton8.Image")));
            this.om_CustomersMenubutton8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.om_CustomersMenubutton8.Location = new System.Drawing.Point(0, 50);
            this.om_CustomersMenubutton8.Margin = new System.Windows.Forms.Padding(10);
            this.om_CustomersMenubutton8.Name = "om_CustomersMenubutton8";
            this.om_CustomersMenubutton8.Padding = new System.Windows.Forms.Padding(5);
            this.om_CustomersMenubutton8.Size = new System.Drawing.Size(200, 50);
            this.om_CustomersMenubutton8.TabIndex = 0;
            this.om_CustomersMenubutton8.Text = "العملاء";
            this.om_CustomersMenubutton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.om_CustomersMenubutton8.UseVisualStyleBackColor = false;
            this.om_CustomersMenubutton8.Click += new System.EventHandler(this.CustomersMenubutton8_Click);
            this.om_CustomersMenubutton8.MouseEnter += new System.EventHandler(this.om_CustomersMenubutton8_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menumax);
            this.panel3.Controls.Add(this.menumin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 44);
            this.panel3.TabIndex = 14;
            // 
            // menumax
            // 
            this.menumax.BackColor = System.Drawing.Color.Transparent;
            this.menumax.BackgroundImage = global::LoBridge.Properties.Resources.scroll_left_icon;
            this.menumax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menumax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menumax.Dock = System.Windows.Forms.DockStyle.Right;
            this.menumax.FlatAppearance.BorderSize = 0;
            this.menumax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menumax.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menumax.Location = new System.Drawing.Point(156, 0);
            this.menumax.Margin = new System.Windows.Forms.Padding(0);
            this.menumax.Name = "menumax";
            this.menumax.Size = new System.Drawing.Size(44, 44);
            this.menumax.TabIndex = 1;
            this.menumax.UseVisualStyleBackColor = false;
            this.menumax.Visible = false;
            this.menumax.Click += new System.EventHandler(this.menumax_Click);
            // 
            // menumin
            // 
            this.menumin.BackColor = System.Drawing.Color.Transparent;
            this.menumin.BackgroundImage = global::LoBridge.Properties.Resources.scroll_right_icon;
            this.menumin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menumin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menumin.Dock = System.Windows.Forms.DockStyle.Left;
            this.menumin.FlatAppearance.BorderSize = 0;
            this.menumin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menumin.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menumin.Location = new System.Drawing.Point(0, 0);
            this.menumin.Margin = new System.Windows.Forms.Padding(0);
            this.menumin.Name = "menumin";
            this.menumin.Size = new System.Drawing.Size(44, 44);
            this.menumin.TabIndex = 0;
            this.menumin.UseVisualStyleBackColor = false;
            this.menumin.Click += new System.EventHandler(this.menumin_Click);
            // 
            // reportViewpanel1
            // 
            this.reportViewpanel1.AutoScroll = true;
            this.reportViewpanel1.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.reportViewpanel1.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.reportViewpanel1.BackgroundImage = global::LoBridge.Properties.Resources.Logistics;
            this.reportViewpanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportViewpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewpanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewpanel1.Location = new System.Drawing.Point(0, 6);
            this.reportViewpanel1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewpanel1.Name = "reportViewpanel1";
            this.reportViewpanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportViewpanel1.Size = new System.Drawing.Size(1529, 942);
            this.reportViewpanel1.TabIndex = 8;
            // 
            // reportMenupanel2
            // 
            this.reportMenupanel2.BackColor = System.Drawing.Color.CadetBlue;
            this.reportMenupanel2.BackgroundImage = global::LoBridge.Properties.Resources.LogisticsMenu1;
            this.reportMenupanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportMenupanel2.Controls.Add(this.button10sumIn);
            this.reportMenupanel2.Controls.Add(this.button11dailyIn);
            this.reportMenupanel2.Controls.Add(this.buttondailyout);
            this.reportMenupanel2.Controls.Add(this.reportingbutton12);
            this.reportMenupanel2.Controls.Add(this.Wsemmarybutton13);
            this.reportMenupanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.reportMenupanel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportMenupanel2.Location = new System.Drawing.Point(1529, 6);
            this.reportMenupanel2.Margin = new System.Windows.Forms.Padding(0);
            this.reportMenupanel2.MaximumSize = new System.Drawing.Size(226, 1200);
            this.reportMenupanel2.Name = "reportMenupanel2";
            this.reportMenupanel2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.reportMenupanel2.Size = new System.Drawing.Size(226, 942);
            this.reportMenupanel2.TabIndex = 9;
            // 
            // button10sumIn
            // 
            this.button10sumIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button10sumIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10sumIn.BackgroundImage")));
            this.button10sumIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10sumIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10sumIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10sumIn.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.button10sumIn.FlatAppearance.BorderSize = 0;
            this.button10sumIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button10sumIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button10sumIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10sumIn.ForeColor = System.Drawing.Color.White;
            this.button10sumIn.Image = ((System.Drawing.Image)(resources.GetObject("button10sumIn.Image")));
            this.button10sumIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10sumIn.Location = new System.Drawing.Point(0, 214);
            this.button10sumIn.Margin = new System.Windows.Forms.Padding(0);
            this.button10sumIn.Name = "button10sumIn";
            this.button10sumIn.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.button10sumIn.Size = new System.Drawing.Size(226, 54);
            this.button10sumIn.TabIndex = 16;
            this.button10sumIn.Text = "تقرير الوارد الاجمالي";
            this.button10sumIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10sumIn.UseVisualStyleBackColor = false;
            this.button10sumIn.Click += new System.EventHandler(this.button10sumIn_Click);
            // 
            // button11dailyIn
            // 
            this.button11dailyIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button11dailyIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11dailyIn.BackgroundImage")));
            this.button11dailyIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11dailyIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11dailyIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11dailyIn.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.button11dailyIn.FlatAppearance.BorderSize = 0;
            this.button11dailyIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button11dailyIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button11dailyIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11dailyIn.ForeColor = System.Drawing.Color.White;
            this.button11dailyIn.Image = ((System.Drawing.Image)(resources.GetObject("button11dailyIn.Image")));
            this.button11dailyIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11dailyIn.Location = new System.Drawing.Point(0, 160);
            this.button11dailyIn.Margin = new System.Windows.Forms.Padding(0);
            this.button11dailyIn.Name = "button11dailyIn";
            this.button11dailyIn.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.button11dailyIn.Size = new System.Drawing.Size(226, 54);
            this.button11dailyIn.TabIndex = 15;
            this.button11dailyIn.Text = "تقرير الوارد اليومي";
            this.button11dailyIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11dailyIn.UseVisualStyleBackColor = false;
            this.button11dailyIn.Click += new System.EventHandler(this.button11dailyIn_Click);
            // 
            // buttondailyout
            // 
            this.buttondailyout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondailyout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttondailyout.BackgroundImage")));
            this.buttondailyout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondailyout.CausesValidation = false;
            this.buttondailyout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondailyout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttondailyout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttondailyout.FlatAppearance.BorderSize = 0;
            this.buttondailyout.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttondailyout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttondailyout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.buttondailyout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondailyout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondailyout.ForeColor = System.Drawing.Color.White;
            this.buttondailyout.Image = ((System.Drawing.Image)(resources.GetObject("buttondailyout.Image")));
            this.buttondailyout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttondailyout.Location = new System.Drawing.Point(0, 106);
            this.buttondailyout.Margin = new System.Windows.Forms.Padding(0);
            this.buttondailyout.Name = "buttondailyout";
            this.buttondailyout.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.buttondailyout.Size = new System.Drawing.Size(226, 54);
            this.buttondailyout.TabIndex = 14;
            this.buttondailyout.Text = "تقرير الصادر اليومي";
            this.buttondailyout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondailyout.UseVisualStyleBackColor = false;
            this.buttondailyout.Click += new System.EventHandler(this.buttondailyout_Click);
            // 
            // reportingbutton12
            // 
            this.reportingbutton12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportingbutton12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportingbutton12.BackgroundImage")));
            this.reportingbutton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportingbutton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportingbutton12.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportingbutton12.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.reportingbutton12.FlatAppearance.BorderSize = 0;
            this.reportingbutton12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.reportingbutton12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.reportingbutton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportingbutton12.ForeColor = System.Drawing.Color.White;
            this.reportingbutton12.Image = ((System.Drawing.Image)(resources.GetObject("reportingbutton12.Image")));
            this.reportingbutton12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportingbutton12.Location = new System.Drawing.Point(0, 56);
            this.reportingbutton12.Margin = new System.Windows.Forms.Padding(0);
            this.reportingbutton12.Name = "reportingbutton12";
            this.reportingbutton12.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.reportingbutton12.Size = new System.Drawing.Size(226, 50);
            this.reportingbutton12.TabIndex = 6;
            this.reportingbutton12.Text = "تقارير العقود";
            this.reportingbutton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportingbutton12.UseVisualStyleBackColor = false;
            this.reportingbutton12.Visible = false;
            this.reportingbutton12.Click += new System.EventHandler(this.reportingbutton12_Click);
            // 
            // Wsemmarybutton13
            // 
            this.Wsemmarybutton13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Wsemmarybutton13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Wsemmarybutton13.BackgroundImage")));
            this.Wsemmarybutton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Wsemmarybutton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wsemmarybutton13.Dock = System.Windows.Forms.DockStyle.Top;
            this.Wsemmarybutton13.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.Wsemmarybutton13.FlatAppearance.BorderSize = 0;
            this.Wsemmarybutton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.Wsemmarybutton13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Wsemmarybutton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wsemmarybutton13.ForeColor = System.Drawing.Color.White;
            this.Wsemmarybutton13.Image = ((System.Drawing.Image)(resources.GetObject("Wsemmarybutton13.Image")));
            this.Wsemmarybutton13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Wsemmarybutton13.Location = new System.Drawing.Point(0, 6);
            this.Wsemmarybutton13.Margin = new System.Windows.Forms.Padding(0);
            this.Wsemmarybutton13.Name = "Wsemmarybutton13";
            this.Wsemmarybutton13.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.Wsemmarybutton13.Size = new System.Drawing.Size(226, 50);
            this.Wsemmarybutton13.TabIndex = 5;
            this.Wsemmarybutton13.Text = "ملخص الميزان";
            this.Wsemmarybutton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wsemmarybutton13.UseVisualStyleBackColor = false;
            this.Wsemmarybutton13.Visible = false;
            this.Wsemmarybutton13.Click += new System.EventHandler(this.Wsemmarybutton13_Click);
            // 
            // weightViewpanel1
            // 
            this.weightViewpanel1.AutoScroll = true;
            this.weightViewpanel1.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.weightViewpanel1.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.weightViewpanel1.BackgroundImage = global::LoBridge.Properties.Resources.Logistics;
            this.weightViewpanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weightViewpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightViewpanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightViewpanel1.Location = new System.Drawing.Point(0, 6);
            this.weightViewpanel1.Margin = new System.Windows.Forms.Padding(0);
            this.weightViewpanel1.Name = "weightViewpanel1";
            this.weightViewpanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.weightViewpanel1.Size = new System.Drawing.Size(1529, 942);
            this.weightViewpanel1.TabIndex = 12;
            // 
            // WeightMenupanel3
            // 
            this.WeightMenupanel3.BackColor = System.Drawing.Color.CadetBlue;
            this.WeightMenupanel3.BackgroundImage = global::LoBridge.Properties.Resources.LogisticsMenu1;
            this.WeightMenupanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WeightMenupanel3.Controls.Add(this.StopWscreenBtn);
            this.WeightMenupanel3.Controls.Add(this.listOutMenubutton1);
            this.WeightMenupanel3.Controls.Add(this.ListWINMenubutton1);
            this.WeightMenupanel3.Controls.Add(this.WeightOutMenubutton2);
            this.WeightMenupanel3.Controls.Add(this.WeightINMenubutton3);
            this.WeightMenupanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.WeightMenupanel3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.WeightMenupanel3.Location = new System.Drawing.Point(1529, 6);
            this.WeightMenupanel3.Margin = new System.Windows.Forms.Padding(0);
            this.WeightMenupanel3.MaximumSize = new System.Drawing.Size(226, 1200);
            this.WeightMenupanel3.Name = "WeightMenupanel3";
            this.WeightMenupanel3.Size = new System.Drawing.Size(226, 942);
            this.WeightMenupanel3.TabIndex = 11;
            // 
            // StopWscreenBtn
            // 
            this.StopWscreenBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StopWscreenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopWscreenBtn.BackgroundImage")));
            this.StopWscreenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopWscreenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopWscreenBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StopWscreenBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.StopWscreenBtn.FlatAppearance.BorderSize = 2;
            this.StopWscreenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.StopWscreenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.StopWscreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopWscreenBtn.ForeColor = System.Drawing.Color.White;
            this.StopWscreenBtn.Location = new System.Drawing.Point(0, 272);
            this.StopWscreenBtn.Margin = new System.Windows.Forms.Padding(0);
            this.StopWscreenBtn.Name = "StopWscreenBtn";
            this.StopWscreenBtn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.StopWscreenBtn.Size = new System.Drawing.Size(226, 68);
            this.StopWscreenBtn.TabIndex = 7;
            this.StopWscreenBtn.Text = "ايقاف/تشغيل الميزان";
            this.StopWscreenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StopWscreenBtn.UseVisualStyleBackColor = false;
            this.StopWscreenBtn.Click += new System.EventHandler(this.StopWscreenBtn_Click);
            // 
            // listOutMenubutton1
            // 
            this.listOutMenubutton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listOutMenubutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listOutMenubutton1.BackgroundImage")));
            this.listOutMenubutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listOutMenubutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listOutMenubutton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listOutMenubutton1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.listOutMenubutton1.FlatAppearance.BorderSize = 2;
            this.listOutMenubutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.listOutMenubutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.listOutMenubutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listOutMenubutton1.ForeColor = System.Drawing.Color.White;
            this.listOutMenubutton1.Location = new System.Drawing.Point(0, 204);
            this.listOutMenubutton1.Margin = new System.Windows.Forms.Padding(0);
            this.listOutMenubutton1.Name = "listOutMenubutton1";
            this.listOutMenubutton1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.listOutMenubutton1.Size = new System.Drawing.Size(226, 68);
            this.listOutMenubutton1.TabIndex = 5;
            this.listOutMenubutton1.Text = "عرض كروت التحميل";
            this.listOutMenubutton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listOutMenubutton1.UseVisualStyleBackColor = false;
            this.listOutMenubutton1.Click += new System.EventHandler(this.listOutMenubutton1_Click);
            // 
            // ListWINMenubutton1
            // 
            this.ListWINMenubutton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListWINMenubutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListWINMenubutton1.BackgroundImage")));
            this.ListWINMenubutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListWINMenubutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListWINMenubutton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListWINMenubutton1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.ListWINMenubutton1.FlatAppearance.BorderSize = 2;
            this.ListWINMenubutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.ListWINMenubutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.ListWINMenubutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListWINMenubutton1.ForeColor = System.Drawing.Color.White;
            this.ListWINMenubutton1.Location = new System.Drawing.Point(0, 136);
            this.ListWINMenubutton1.Margin = new System.Windows.Forms.Padding(0);
            this.ListWINMenubutton1.Name = "ListWINMenubutton1";
            this.ListWINMenubutton1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.ListWINMenubutton1.Size = new System.Drawing.Size(226, 68);
            this.ListWINMenubutton1.TabIndex = 2;
            this.ListWINMenubutton1.Text = "عرض كروت الاستلام";
            this.ListWINMenubutton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListWINMenubutton1.UseVisualStyleBackColor = false;
            this.ListWINMenubutton1.Click += new System.EventHandler(this.ListWINMenubutton1_Click);
            // 
            // WeightOutMenubutton2
            // 
            this.WeightOutMenubutton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WeightOutMenubutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WeightOutMenubutton2.BackgroundImage")));
            this.WeightOutMenubutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WeightOutMenubutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WeightOutMenubutton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.WeightOutMenubutton2.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.WeightOutMenubutton2.FlatAppearance.BorderSize = 2;
            this.WeightOutMenubutton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.WeightOutMenubutton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.WeightOutMenubutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeightOutMenubutton2.ForeColor = System.Drawing.Color.White;
            this.WeightOutMenubutton2.Location = new System.Drawing.Point(0, 68);
            this.WeightOutMenubutton2.Margin = new System.Windows.Forms.Padding(0);
            this.WeightOutMenubutton2.Name = "WeightOutMenubutton2";
            this.WeightOutMenubutton2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.WeightOutMenubutton2.Size = new System.Drawing.Size(226, 68);
            this.WeightOutMenubutton2.TabIndex = 1;
            this.WeightOutMenubutton2.Text = "وزن صادر";
            this.WeightOutMenubutton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WeightOutMenubutton2.UseVisualStyleBackColor = false;
            this.WeightOutMenubutton2.Click += new System.EventHandler(this.WeightOutMenubutton2_Click);
            // 
            // WeightINMenubutton3
            // 
            this.WeightINMenubutton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WeightINMenubutton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WeightINMenubutton3.BackgroundImage")));
            this.WeightINMenubutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WeightINMenubutton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WeightINMenubutton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.WeightINMenubutton3.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.WeightINMenubutton3.FlatAppearance.BorderSize = 2;
            this.WeightINMenubutton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.WeightINMenubutton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.WeightINMenubutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeightINMenubutton3.ForeColor = System.Drawing.Color.White;
            this.WeightINMenubutton3.Location = new System.Drawing.Point(0, 0);
            this.WeightINMenubutton3.Margin = new System.Windows.Forms.Padding(0);
            this.WeightINMenubutton3.Name = "WeightINMenubutton3";
            this.WeightINMenubutton3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.WeightINMenubutton3.Size = new System.Drawing.Size(226, 68);
            this.WeightINMenubutton3.TabIndex = 0;
            this.WeightINMenubutton3.Text = "وزن وارد";
            this.WeightINMenubutton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WeightINMenubutton3.UseVisualStyleBackColor = false;
            this.WeightINMenubutton3.Click += new System.EventHandler(this.WeightINMenubutton3_Click);
            // 
            // commViewpanel1
            // 
            this.commViewpanel1.BackgroundImage = global::LoBridge.Properties.Resources.Logistics;
            this.commViewpanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commViewpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commViewpanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commViewpanel1.Location = new System.Drawing.Point(0, 6);
            this.commViewpanel1.Margin = new System.Windows.Forms.Padding(0);
            this.commViewpanel1.Name = "commViewpanel1";
            this.commViewpanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.commViewpanel1.Size = new System.Drawing.Size(1529, 942);
            this.commViewpanel1.TabIndex = 12;
            // 
            // commMenupanel3
            // 
            this.commMenupanel3.BackColor = System.Drawing.Color.CadetBlue;
            this.commMenupanel3.BackgroundImage = global::LoBridge.Properties.Resources.LogisticsMenu1;
            this.commMenupanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commMenupanel3.Controls.Add(this.button1);
            this.commMenupanel3.Controls.Add(this.button2);
            this.commMenupanel3.Controls.Add(this.button3);
            this.commMenupanel3.Controls.Add(this.newCommbutton5);
            this.commMenupanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.commMenupanel3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.commMenupanel3.Location = new System.Drawing.Point(1529, 6);
            this.commMenupanel3.Margin = new System.Windows.Forms.Padding(0);
            this.commMenupanel3.MaximumSize = new System.Drawing.Size(226, 1200);
            this.commMenupanel3.Name = "commMenupanel3";
            this.commMenupanel3.Padding = new System.Windows.Forms.Padding(6);
            this.commMenupanel3.Size = new System.Drawing.Size(226, 942);
            this.commMenupanel3.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(-1, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "عرض اوزان التحميل";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(-1, 118);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "عرض اوزان الاستلام";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(-2, 68);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 50);
            this.button3.TabIndex = 1;
            this.button3.Text = "وزن تحميل";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // newCommbutton5
            // 
            this.newCommbutton5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newCommbutton5.BackgroundImage = global::LoBridge.Properties.Resources.Blue_button;
            this.newCommbutton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newCommbutton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCommbutton5.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.newCommbutton5.FlatAppearance.BorderSize = 2;
            this.newCommbutton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.newCommbutton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.newCommbutton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCommbutton5.ForeColor = System.Drawing.Color.White;
            this.newCommbutton5.Location = new System.Drawing.Point(-1, 18);
            this.newCommbutton5.Margin = new System.Windows.Forms.Padding(0);
            this.newCommbutton5.Name = "newCommbutton5";
            this.newCommbutton5.Size = new System.Drawing.Size(226, 59);
            this.newCommbutton5.TabIndex = 0;
            this.newCommbutton5.Text = "الاصناف";
            this.newCommbutton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newCommbutton5.UseVisualStyleBackColor = false;
            this.newCommbutton5.Click += new System.EventHandler(this.newCommbutton5_Click);
            // 
            // transViewpanel1
            // 
            this.transViewpanel1.BackgroundImage = global::LoBridge.Properties.Resources.Logistics;
            this.transViewpanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transViewpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transViewpanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transViewpanel1.Location = new System.Drawing.Point(0, 6);
            this.transViewpanel1.Margin = new System.Windows.Forms.Padding(0);
            this.transViewpanel1.Name = "transViewpanel1";
            this.transViewpanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transViewpanel1.Size = new System.Drawing.Size(1529, 942);
            this.transViewpanel1.TabIndex = 14;
            // 
            // transMenupanel3
            // 
            this.transMenupanel3.BackColor = System.Drawing.Color.CadetBlue;
            this.transMenupanel3.BackgroundImage = global::LoBridge.Properties.Resources.LogisticsMenu1;
            this.transMenupanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transMenupanel3.Controls.Add(this.btnTruckTypes);
            this.transMenupanel3.Controls.Add(this.button5);
            this.transMenupanel3.Controls.Add(this.button7);
            this.transMenupanel3.Controls.Add(this.newDriverbutton8);
            this.transMenupanel3.Controls.Add(this.newTruckbutton9);
            this.transMenupanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.transMenupanel3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.transMenupanel3.Location = new System.Drawing.Point(1529, 6);
            this.transMenupanel3.Margin = new System.Windows.Forms.Padding(0);
            this.transMenupanel3.MaximumSize = new System.Drawing.Size(226, 1200);
            this.transMenupanel3.Name = "transMenupanel3";
            this.transMenupanel3.Size = new System.Drawing.Size(226, 942);
            this.transMenupanel3.TabIndex = 15;
            // 
            // btnTruckTypes
            // 
            this.btnTruckTypes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTruckTypes.BackgroundImage = global::LoBridge.Properties.Resources.Blue_button;
            this.btnTruckTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTruckTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTruckTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTruckTypes.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnTruckTypes.FlatAppearance.BorderSize = 2;
            this.btnTruckTypes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTruckTypes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTruckTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruckTypes.ForeColor = System.Drawing.Color.White;
            this.btnTruckTypes.Location = new System.Drawing.Point(0, 196);
            this.btnTruckTypes.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.btnTruckTypes.Name = "btnTruckTypes";
            this.btnTruckTypes.Size = new System.Drawing.Size(226, 49);
            this.btnTruckTypes.TabIndex = 6;
            this.btnTruckTypes.Text = "انواع الشاحنات";
            this.btnTruckTypes.UseVisualStyleBackColor = false;
            this.btnTruckTypes.Click += new System.EventHandler(this.btnTruckTypes_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(0, 147);
            this.button5.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(226, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "عرض اوزان التحميل";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(0, 98);
            this.button7.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(226, 49);
            this.button7.TabIndex = 2;
            this.button7.Text = "تسجيل شركة نقل";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            // 
            // newDriverbutton8
            // 
            this.newDriverbutton8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newDriverbutton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newDriverbutton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.newDriverbutton8.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.newDriverbutton8.FlatAppearance.BorderSize = 2;
            this.newDriverbutton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.newDriverbutton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.newDriverbutton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newDriverbutton8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newDriverbutton8.Location = new System.Drawing.Point(0, 49);
            this.newDriverbutton8.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.newDriverbutton8.Name = "newDriverbutton8";
            this.newDriverbutton8.Size = new System.Drawing.Size(226, 49);
            this.newDriverbutton8.TabIndex = 1;
            this.newDriverbutton8.Text = "تسجيل سائق";
            this.newDriverbutton8.UseVisualStyleBackColor = false;
            this.newDriverbutton8.Visible = false;
            // 
            // newTruckbutton9
            // 
            this.newTruckbutton9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newTruckbutton9.BackgroundImage = global::LoBridge.Properties.Resources.Blue_button;
            this.newTruckbutton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newTruckbutton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newTruckbutton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.newTruckbutton9.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.newTruckbutton9.FlatAppearance.BorderSize = 2;
            this.newTruckbutton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.newTruckbutton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.newTruckbutton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTruckbutton9.ForeColor = System.Drawing.Color.White;
            this.newTruckbutton9.Location = new System.Drawing.Point(0, 0);
            this.newTruckbutton9.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.newTruckbutton9.Name = "newTruckbutton9";
            this.newTruckbutton9.Size = new System.Drawing.Size(226, 49);
            this.newTruckbutton9.TabIndex = 0;
            this.newTruckbutton9.Text = "تسجيل";
            this.newTruckbutton9.UseVisualStyleBackColor = false;
            this.newTruckbutton9.Click += new System.EventHandler(this.newTruckbutton9_Click);
            // 
            // userViewpanel1
            // 
            this.userViewpanel1.BackgroundImage = global::LoBridge.Properties.Resources.Logistics;
            this.userViewpanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userViewpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userViewpanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userViewpanel1.Location = new System.Drawing.Point(0, 6);
            this.userViewpanel1.Margin = new System.Windows.Forms.Padding(0);
            this.userViewpanel1.Name = "userViewpanel1";
            this.userViewpanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userViewpanel1.Size = new System.Drawing.Size(1529, 942);
            this.userViewpanel1.TabIndex = 8;
            // 
            // userMenupanel3
            // 
            this.userMenupanel3.BackColor = System.Drawing.Color.CadetBlue;
            this.userMenupanel3.BackgroundImage = global::LoBridge.Properties.Resources.LogisticsMenu1;
            this.userMenupanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userMenupanel3.Controls.Add(this.refreshPerm);
            this.userMenupanel3.Controls.Add(this.logOutbutton13);
            this.userMenupanel3.Controls.Add(this.changePassbutton14);
            this.userMenupanel3.Controls.Add(this.btn_perm);
            this.userMenupanel3.Controls.Add(this.emailSettingbutton15);
            this.userMenupanel3.Controls.Add(this.addNewUer);
            this.userMenupanel3.Controls.Add(this.userProfilebutton16);
            this.userMenupanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.userMenupanel3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.userMenupanel3.Location = new System.Drawing.Point(1529, 6);
            this.userMenupanel3.Margin = new System.Windows.Forms.Padding(0);
            this.userMenupanel3.MaximumSize = new System.Drawing.Size(226, 1200);
            this.userMenupanel3.Name = "userMenupanel3";
            this.userMenupanel3.Size = new System.Drawing.Size(226, 942);
            this.userMenupanel3.TabIndex = 9;
            // 
            // refreshPerm
            // 
            this.refreshPerm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshPerm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshPerm.BackgroundImage")));
            this.refreshPerm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshPerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshPerm.Dock = System.Windows.Forms.DockStyle.Top;
            this.refreshPerm.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.refreshPerm.FlatAppearance.BorderSize = 2;
            this.refreshPerm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.refreshPerm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshPerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshPerm.ForeColor = System.Drawing.Color.White;
            this.refreshPerm.Location = new System.Drawing.Point(0, 330);
            this.refreshPerm.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.refreshPerm.Name = "refreshPerm";
            this.refreshPerm.Size = new System.Drawing.Size(226, 55);
            this.refreshPerm.TabIndex = 7;
            this.refreshPerm.Text = "تحديث الصلاحيات";
            this.refreshPerm.UseVisualStyleBackColor = false;
            this.refreshPerm.Click += new System.EventHandler(this.refreshPerm_Click);
            // 
            // logOutbutton13
            // 
            this.logOutbutton13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOutbutton13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logOutbutton13.BackgroundImage")));
            this.logOutbutton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutbutton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutbutton13.Dock = System.Windows.Forms.DockStyle.Top;
            this.logOutbutton13.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.logOutbutton13.FlatAppearance.BorderSize = 2;
            this.logOutbutton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.logOutbutton13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.logOutbutton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutbutton13.ForeColor = System.Drawing.Color.White;
            this.logOutbutton13.Location = new System.Drawing.Point(0, 275);
            this.logOutbutton13.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.logOutbutton13.Name = "logOutbutton13";
            this.logOutbutton13.Size = new System.Drawing.Size(226, 55);
            this.logOutbutton13.TabIndex = 3;
            this.logOutbutton13.Text = "تسجيل خروج";
            this.logOutbutton13.UseVisualStyleBackColor = false;
            this.logOutbutton13.Click += new System.EventHandler(this.LogOutbutton13_Click);
            // 
            // changePassbutton14
            // 
            this.changePassbutton14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePassbutton14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changePassbutton14.BackgroundImage")));
            this.changePassbutton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changePassbutton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassbutton14.Dock = System.Windows.Forms.DockStyle.Top;
            this.changePassbutton14.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.changePassbutton14.FlatAppearance.BorderSize = 2;
            this.changePassbutton14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.changePassbutton14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.changePassbutton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassbutton14.ForeColor = System.Drawing.Color.White;
            this.changePassbutton14.Location = new System.Drawing.Point(0, 220);
            this.changePassbutton14.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.changePassbutton14.Name = "changePassbutton14";
            this.changePassbutton14.Size = new System.Drawing.Size(226, 55);
            this.changePassbutton14.TabIndex = 2;
            this.changePassbutton14.Text = "تغير كلمة المرور";
            this.changePassbutton14.UseVisualStyleBackColor = false;
            this.changePassbutton14.Visible = false;
            // 
            // btn_perm
            // 
            this.btn_perm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_perm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_perm.BackgroundImage")));
            this.btn_perm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_perm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_perm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_perm.Enabled = false;
            this.btn_perm.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btn_perm.FlatAppearance.BorderSize = 2;
            this.btn_perm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_perm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_perm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perm.ForeColor = System.Drawing.Color.White;
            this.btn_perm.Location = new System.Drawing.Point(0, 165);
            this.btn_perm.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.btn_perm.Name = "btn_perm";
            this.btn_perm.Size = new System.Drawing.Size(226, 55);
            this.btn_perm.TabIndex = 8;
            this.btn_perm.Text = "الصلاحيات";
            this.btn_perm.UseVisualStyleBackColor = false;
            this.btn_perm.Click += new System.EventHandler(this.btn_perm_Click);
            // 
            // emailSettingbutton15
            // 
            this.emailSettingbutton15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailSettingbutton15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailSettingbutton15.BackgroundImage")));
            this.emailSettingbutton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emailSettingbutton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailSettingbutton15.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailSettingbutton15.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.emailSettingbutton15.FlatAppearance.BorderSize = 2;
            this.emailSettingbutton15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.emailSettingbutton15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.emailSettingbutton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailSettingbutton15.ForeColor = System.Drawing.Color.White;
            this.emailSettingbutton15.Location = new System.Drawing.Point(0, 110);
            this.emailSettingbutton15.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.emailSettingbutton15.Name = "emailSettingbutton15";
            this.emailSettingbutton15.Size = new System.Drawing.Size(226, 55);
            this.emailSettingbutton15.TabIndex = 1;
            this.emailSettingbutton15.Text = "اعدادت الايميل";
            this.emailSettingbutton15.UseVisualStyleBackColor = false;
            this.emailSettingbutton15.Visible = false;
            // 
            // addNewUer
            // 
            this.addNewUer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewUer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewUer.BackgroundImage")));
            this.addNewUer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewUer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewUer.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNewUer.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.addNewUer.FlatAppearance.BorderSize = 2;
            this.addNewUer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.addNewUer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.addNewUer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewUer.ForeColor = System.Drawing.Color.White;
            this.addNewUer.Location = new System.Drawing.Point(0, 55);
            this.addNewUer.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.addNewUer.Name = "addNewUer";
            this.addNewUer.Size = new System.Drawing.Size(226, 55);
            this.addNewUer.TabIndex = 6;
            this.addNewUer.Text = "المستخدمين";
            this.addNewUer.UseVisualStyleBackColor = false;
            this.addNewUer.Click += new System.EventHandler(this.addNewUer_Click);
            // 
            // userProfilebutton16
            // 
            this.userProfilebutton16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userProfilebutton16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userProfilebutton16.BackgroundImage")));
            this.userProfilebutton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userProfilebutton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userProfilebutton16.Dock = System.Windows.Forms.DockStyle.Top;
            this.userProfilebutton16.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.userProfilebutton16.FlatAppearance.BorderSize = 2;
            this.userProfilebutton16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.userProfilebutton16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.userProfilebutton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userProfilebutton16.ForeColor = System.Drawing.Color.White;
            this.userProfilebutton16.Location = new System.Drawing.Point(0, 0);
            this.userProfilebutton16.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.userProfilebutton16.Name = "userProfilebutton16";
            this.userProfilebutton16.Size = new System.Drawing.Size(226, 55);
            this.userProfilebutton16.TabIndex = 0;
            this.userProfilebutton16.Text = "بيانات المستخدم";
            this.userProfilebutton16.UseVisualStyleBackColor = false;
            this.userProfilebutton16.Click += new System.EventHandler(this.userProfilebutton16_Click);
            // 
            // SysViewpanel4
            // 
            this.SysViewpanel4.BackgroundImage = global::LoBridge.Properties.Resources.Logistics;
            this.SysViewpanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SysViewpanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SysViewpanel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysViewpanel4.Location = new System.Drawing.Point(0, 6);
            this.SysViewpanel4.Margin = new System.Windows.Forms.Padding(0);
            this.SysViewpanel4.Name = "SysViewpanel4";
            this.SysViewpanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SysViewpanel4.Size = new System.Drawing.Size(1529, 942);
            this.SysViewpanel4.TabIndex = 8;
            // 
            // SysSettingMenupanel5
            // 
            this.SysSettingMenupanel5.BackColor = System.Drawing.Color.CadetBlue;
            this.SysSettingMenupanel5.BackgroundImage = global::LoBridge.Properties.Resources.LogisticsMenu1;
            this.SysSettingMenupanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SysSettingMenupanel5.Controls.Add(this.settingsbutton25);
            this.SysSettingMenupanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.SysSettingMenupanel5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysSettingMenupanel5.Location = new System.Drawing.Point(1529, 6);
            this.SysSettingMenupanel5.Margin = new System.Windows.Forms.Padding(0);
            this.SysSettingMenupanel5.MaximumSize = new System.Drawing.Size(226, 1132);
            this.SysSettingMenupanel5.MinimumSize = new System.Drawing.Size(226, 1132);
            this.SysSettingMenupanel5.Name = "SysSettingMenupanel5";
            this.SysSettingMenupanel5.Size = new System.Drawing.Size(226, 1132);
            this.SysSettingMenupanel5.TabIndex = 9;
            // 
            // settingsbutton25
            // 
            this.settingsbutton25.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsbutton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsbutton25.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsbutton25.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.settingsbutton25.FlatAppearance.BorderSize = 2;
            this.settingsbutton25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.settingsbutton25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.settingsbutton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbutton25.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.settingsbutton25.Location = new System.Drawing.Point(0, 0);
            this.settingsbutton25.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.settingsbutton25.Name = "settingsbutton25";
            this.settingsbutton25.Size = new System.Drawing.Size(226, 49);
            this.settingsbutton25.TabIndex = 0;
            this.settingsbutton25.Text = "الاعدادت";
            this.settingsbutton25.UseVisualStyleBackColor = false;
            this.settingsbutton25.Click += new System.EventHandler(this.settingsbutton25_Click);
            // 
            // MainTab
            // 
            this.MainTab.CausesValidation = false;
            this.MainTab.Controls.Add(this.lobsys);
            this.MainTab.Controls.Add(this.OutboundPage);
            this.MainTab.Controls.Add(this.InboundPage);
            this.MainTab.Controls.Add(this.ReportsPage);
            this.MainTab.Controls.Add(this.WBridgePage);
            this.MainTab.Controls.Add(this.CatPage);
            this.MainTab.Controls.Add(this.TransPage);
            this.MainTab.Controls.Add(this.UserSettingsPage);
            this.MainTab.Controls.Add(this.SySettingsPage);
            this.MainTab.Controls.Add(this.CamPage);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTab.HotTrack = true;
            this.MainTab.ImageList = this.imageList1;
            this.MainTab.ItemSize = new System.Drawing.Size(60, 30);
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Margin = new System.Windows.Forms.Padding(0);
            this.MainTab.Name = "MainTab";
            this.MainTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainTab.RightToLeftLayout = true;
            this.MainTab.SelectedIndex = 7;
            this.MainTab.Size = new System.Drawing.Size(1763, 986);
            this.MainTab.TabIndex = 0;
            this.MainTab.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MainTab_Selecting_1);
            // 
            // lobsys
            // 
            this.lobsys.BackColor = System.Drawing.Color.Transparent;
            this.lobsys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lobsys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lobsys.ForeColor = System.Drawing.Color.White;
            this.lobsys.HorizontalScrollbarBarColor = true;
            this.lobsys.HorizontalScrollbarSize = 1;
            this.lobsys.Location = new System.Drawing.Point(4, 34);
            this.lobsys.Margin = new System.Windows.Forms.Padding(4);
            this.lobsys.Name = "lobsys";
            this.lobsys.Size = new System.Drawing.Size(1755, 948);
            this.lobsys.Style = MetroFramework.MetroColorStyle.Silver;
            this.lobsys.TabIndex = 0;
            this.lobsys.Text = "       LoBridge System            ";
            this.lobsys.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lobsys.VerticalScrollbarBarColor = true;
            this.lobsys.VerticalScrollbarSize = 0;
            // 
            // OutboundPage
            // 
            this.OutboundPage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.OutboundPage.BackgroundImage = global::LoBridge.Properties.Resources.Logistics;
            this.OutboundPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OutboundPage.CausesValidation = false;
            this.OutboundPage.Controls.Add(this.OutGoingViewPanel);
            this.OutboundPage.Controls.Add(this.OutMenupanel2);
            this.OutboundPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutboundPage.HorizontalScrollbarBarColor = true;
            this.OutboundPage.HorizontalScrollbarSize = 6;
            this.OutboundPage.ImageIndex = 10;
            this.OutboundPage.Location = new System.Drawing.Point(4, 34);
            this.OutboundPage.Margin = new System.Windows.Forms.Padding(0);
            this.OutboundPage.Name = "OutboundPage";
            this.OutboundPage.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.OutboundPage.Size = new System.Drawing.Size(1755, 948);
            this.OutboundPage.Style = MetroFramework.MetroColorStyle.Blue;
            this.OutboundPage.TabIndex = 2;
            this.OutboundPage.Text = "الصادر";
            this.OutboundPage.VerticalScrollbarBarColor = true;
            this.OutboundPage.VerticalScrollbarSize = 6;
            // 
            // OutGoingViewPanel
            // 
            this.OutGoingViewPanel.AutoScroll = true;
            this.OutGoingViewPanel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.OutGoingViewPanel.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.OutGoingViewPanel.AutoSize = true;
            this.OutGoingViewPanel.BackgroundImage = global::LoBridge.Properties.Resources.Logistics;
            this.OutGoingViewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OutGoingViewPanel.CausesValidation = false;
            this.OutGoingViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutGoingViewPanel.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutGoingViewPanel.Location = new System.Drawing.Point(0, 6);
            this.OutGoingViewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.OutGoingViewPanel.Name = "OutGoingViewPanel";
            this.OutGoingViewPanel.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.OutGoingViewPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutGoingViewPanel.Size = new System.Drawing.Size(1555, 942);
            this.OutGoingViewPanel.TabIndex = 6;
            this.OutGoingViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OutGoingViewPanel_Paint);
            this.OutGoingViewPanel.MouseEnter += new System.EventHandler(this.OutGoingViewPanel_MouseEnter);
            // 
            // InboundPage
            // 
            this.InboundPage.AutoScroll = true;
            this.InboundPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InboundPage.Controls.Add(this.InComingViewPanel);
            this.InboundPage.Controls.Add(this.IncomingMenuPanel1);
            this.InboundPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InboundPage.HorizontalScrollbar = true;
            this.InboundPage.HorizontalScrollbarBarColor = true;
            this.InboundPage.HorizontalScrollbarHighlightOnWheel = true;
            this.InboundPage.HorizontalScrollbarSize = 1;
            this.InboundPage.ImageIndex = 3;
            this.InboundPage.Location = new System.Drawing.Point(4, 34);
            this.InboundPage.Margin = new System.Windows.Forms.Padding(4);
            this.InboundPage.Name = "InboundPage";
            this.InboundPage.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.InboundPage.Size = new System.Drawing.Size(1755, 948);
            this.InboundPage.Style = MetroFramework.MetroColorStyle.Silver;
            this.InboundPage.TabIndex = 1;
            this.InboundPage.Text = "     الوارد   ";
            this.InboundPage.VerticalScrollbar = true;
            this.InboundPage.VerticalScrollbarBarColor = true;
            this.InboundPage.VerticalScrollbarHighlightOnWheel = true;
            this.InboundPage.VerticalScrollbarSize = 6;
            // 
            // ReportsPage
            // 
            this.ReportsPage.AutoScroll = true;
            this.ReportsPage.Controls.Add(this.reportViewpanel1);
            this.ReportsPage.Controls.Add(this.reportMenupanel2);
            this.ReportsPage.HorizontalScrollbar = true;
            this.ReportsPage.HorizontalScrollbarBarColor = true;
            this.ReportsPage.HorizontalScrollbarHighlightOnWheel = true;
            this.ReportsPage.HorizontalScrollbarSize = 1;
            this.ReportsPage.ImageIndex = 6;
            this.ReportsPage.Location = new System.Drawing.Point(4, 34);
            this.ReportsPage.Margin = new System.Windows.Forms.Padding(4);
            this.ReportsPage.Name = "ReportsPage";
            this.ReportsPage.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.ReportsPage.Size = new System.Drawing.Size(1755, 948);
            this.ReportsPage.TabIndex = 3;
            this.ReportsPage.Text = "التقارير";
            this.ReportsPage.VerticalScrollbar = true;
            this.ReportsPage.VerticalScrollbarBarColor = true;
            this.ReportsPage.VerticalScrollbarSize = 0;
            // 
            // WBridgePage
            // 
            this.WBridgePage.AutoScroll = true;
            this.WBridgePage.Controls.Add(this.weightViewpanel1);
            this.WBridgePage.Controls.Add(this.WeightMenupanel3);
            this.WBridgePage.HorizontalScrollbar = true;
            this.WBridgePage.HorizontalScrollbarBarColor = true;
            this.WBridgePage.HorizontalScrollbarSize = 1;
            this.WBridgePage.ImageIndex = 9;
            this.WBridgePage.Location = new System.Drawing.Point(4, 34);
            this.WBridgePage.Margin = new System.Windows.Forms.Padding(4);
            this.WBridgePage.Name = "WBridgePage";
            this.WBridgePage.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.WBridgePage.Size = new System.Drawing.Size(1755, 948);
            this.WBridgePage.TabIndex = 4;
            this.WBridgePage.Text = "الميزان   ";
            this.WBridgePage.VerticalScrollbar = true;
            this.WBridgePage.VerticalScrollbarBarColor = true;
            this.WBridgePage.VerticalScrollbarSize = 0;
            // 
            // CatPage
            // 
            this.CatPage.AutoScroll = true;
            this.CatPage.Controls.Add(this.commViewpanel1);
            this.CatPage.Controls.Add(this.commMenupanel3);
            this.CatPage.HorizontalScrollbar = true;
            this.CatPage.HorizontalScrollbarBarColor = true;
            this.CatPage.HorizontalScrollbarSize = 1;
            this.CatPage.ImageIndex = 7;
            this.CatPage.Location = new System.Drawing.Point(4, 34);
            this.CatPage.Margin = new System.Windows.Forms.Padding(4);
            this.CatPage.Name = "CatPage";
            this.CatPage.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.CatPage.Size = new System.Drawing.Size(1755, 948);
            this.CatPage.TabIndex = 5;
            this.CatPage.Text = "الاصناف   ";
            this.CatPage.VerticalScrollbar = true;
            this.CatPage.VerticalScrollbarBarColor = true;
            this.CatPage.VerticalScrollbarSize = 0;
            // 
            // TransPage
            // 
            this.TransPage.AutoScroll = true;
            this.TransPage.Controls.Add(this.transViewpanel1);
            this.TransPage.Controls.Add(this.transMenupanel3);
            this.TransPage.HorizontalScrollbar = true;
            this.TransPage.HorizontalScrollbarBarColor = true;
            this.TransPage.HorizontalScrollbarSize = 1;
            this.TransPage.ImageIndex = 2;
            this.TransPage.Location = new System.Drawing.Point(4, 34);
            this.TransPage.Margin = new System.Windows.Forms.Padding(4);
            this.TransPage.Name = "TransPage";
            this.TransPage.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.TransPage.Size = new System.Drawing.Size(1755, 948);
            this.TransPage.TabIndex = 6;
            this.TransPage.Text = "ادارة النقل    ";
            this.TransPage.VerticalScrollbar = true;
            this.TransPage.VerticalScrollbarBarColor = true;
            this.TransPage.VerticalScrollbarSize = 0;
            // 
            // UserSettingsPage
            // 
            this.UserSettingsPage.AutoScroll = true;
            this.UserSettingsPage.BackColor = System.Drawing.Color.Maroon;
            this.UserSettingsPage.Controls.Add(this.userViewpanel1);
            this.UserSettingsPage.Controls.Add(this.userMenupanel3);
            this.UserSettingsPage.HorizontalScrollbar = true;
            this.UserSettingsPage.HorizontalScrollbarBarColor = true;
            this.UserSettingsPage.HorizontalScrollbarSize = 1;
            this.UserSettingsPage.ImageIndex = 5;
            this.UserSettingsPage.Location = new System.Drawing.Point(4, 34);
            this.UserSettingsPage.Margin = new System.Windows.Forms.Padding(4);
            this.UserSettingsPage.Name = "UserSettingsPage";
            this.UserSettingsPage.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.UserSettingsPage.Size = new System.Drawing.Size(1755, 948);
            this.UserSettingsPage.Style = MetroFramework.MetroColorStyle.White;
            this.UserSettingsPage.TabIndex = 7;
            this.UserSettingsPage.Text = "   اعدادات المستخدم     ";
            this.UserSettingsPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserSettingsPage.VerticalScrollbar = true;
            this.UserSettingsPage.VerticalScrollbarBarColor = true;
            this.UserSettingsPage.VerticalScrollbarSize = 0;
            // 
            // SySettingsPage
            // 
            this.SySettingsPage.AutoScroll = true;
            this.SySettingsPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SySettingsPage.Controls.Add(this.SysViewpanel4);
            this.SySettingsPage.Controls.Add(this.SysSettingMenupanel5);
            this.SySettingsPage.HorizontalScrollbar = true;
            this.SySettingsPage.HorizontalScrollbarBarColor = true;
            this.SySettingsPage.HorizontalScrollbarSize = 1;
            this.SySettingsPage.ImageIndex = 4;
            this.SySettingsPage.Location = new System.Drawing.Point(4, 34);
            this.SySettingsPage.Margin = new System.Windows.Forms.Padding(4);
            this.SySettingsPage.Name = "SySettingsPage";
            this.SySettingsPage.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.SySettingsPage.Size = new System.Drawing.Size(1755, 948);
            this.SySettingsPage.TabIndex = 8;
            this.SySettingsPage.Text = "   اعدادت النظام     ";
            this.SySettingsPage.VerticalScrollbar = true;
            this.SySettingsPage.VerticalScrollbarBarColor = true;
            this.SySettingsPage.VerticalScrollbarSize = 0;
            // 
            // CamPage
            // 
            this.CamPage.AutoScroll = true;
            this.CamPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CamPage.Controls.Add(this.campanel1);
            this.CamPage.Controls.Add(this.camMenu);
            this.CamPage.HorizontalScrollbar = true;
            this.CamPage.HorizontalScrollbarBarColor = true;
            this.CamPage.HorizontalScrollbarHighlightOnWheel = true;
            this.CamPage.HorizontalScrollbarSize = 6;
            this.CamPage.Location = new System.Drawing.Point(4, 34);
            this.CamPage.Margin = new System.Windows.Forms.Padding(4);
            this.CamPage.Name = "CamPage";
            this.CamPage.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.CamPage.Size = new System.Drawing.Size(1755, 948);
            this.CamPage.TabIndex = 9;
            this.CamPage.Text = "   المراقبة   ";
            this.CamPage.VerticalScrollbar = true;
            this.CamPage.VerticalScrollbarBarColor = true;
            this.CamPage.VerticalScrollbarSize = 6;
            // 
            // campanel1
            // 
            this.campanel1.AutoSize = true;
            this.campanel1.BackgroundImage = global::LoBridge.Properties.Resources.Logistics;
            this.campanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.campanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campanel1.Location = new System.Drawing.Point(0, 6);
            this.campanel1.Margin = new System.Windows.Forms.Padding(0);
            this.campanel1.Name = "campanel1";
            this.campanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.campanel1.Size = new System.Drawing.Size(1529, 942);
            this.campanel1.TabIndex = 10;
            this.campanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.campanel1_Paint);
            // 
            // camMenu
            // 
            this.camMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.camMenu.BackgroundImage = global::LoBridge.Properties.Resources.LogisticsMenu1;
            this.camMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.camMenu.Controls.Add(this.button4);
            this.camMenu.Controls.Add(this.camSettingBtn);
            this.camMenu.Controls.Add(this.cam_NameComboBox);
            this.camMenu.Controls.Add(this.mealSCamBtn);
            this.camMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.camMenu.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camMenu.Location = new System.Drawing.Point(1529, 6);
            this.camMenu.Margin = new System.Windows.Forms.Padding(0);
            this.camMenu.MaximumSize = new System.Drawing.Size(226, 1132);
            this.camMenu.MinimumSize = new System.Drawing.Size(226, 875);
            this.camMenu.Name = "camMenu";
            this.camMenu.Size = new System.Drawing.Size(226, 942);
            this.camMenu.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(0, 138);
            this.button4.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 49);
            this.button4.TabIndex = 8;
            this.button4.Text = "تحديث القائمة";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // camSettingBtn
            // 
            this.camSettingBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.camSettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.camSettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.camSettingBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.camSettingBtn.FlatAppearance.BorderSize = 2;
            this.camSettingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.camSettingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.camSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.camSettingBtn.ForeColor = System.Drawing.Color.Blue;
            this.camSettingBtn.Location = new System.Drawing.Point(0, 89);
            this.camSettingBtn.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.camSettingBtn.Name = "camSettingBtn";
            this.camSettingBtn.Size = new System.Drawing.Size(226, 49);
            this.camSettingBtn.TabIndex = 6;
            this.camSettingBtn.Text = "اعدادات المراقبة";
            this.camSettingBtn.UseVisualStyleBackColor = false;
            this.camSettingBtn.Click += new System.EventHandler(this.siteCambutton15_Click);
            // 
            // cam_NameComboBox
            // 
            this.cam_NameComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.cam_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cameraBindingSource, "Cam_Name", true));
            this.cam_NameComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cam_NameComboBox.ForeColor = System.Drawing.Color.Blue;
            this.cam_NameComboBox.FormattingEnabled = true;
            this.cam_NameComboBox.Location = new System.Drawing.Point(0, 49);
            this.cam_NameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cam_NameComboBox.Name = "cam_NameComboBox";
            this.cam_NameComboBox.Size = new System.Drawing.Size(226, 40);
            this.cam_NameComboBox.TabIndex = 7;
            this.cam_NameComboBox.SelectedIndexChanged += new System.EventHandler(this.cam_NameComboBox_SelectedIndexChanged);
            this.cam_NameComboBox.Click += new System.EventHandler(this.cam_NameComboBox_Click);
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
            // mealSCamBtn
            // 
            this.mealSCamBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mealSCamBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mealSCamBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mealSCamBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.mealSCamBtn.FlatAppearance.BorderSize = 2;
            this.mealSCamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.mealSCamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.mealSCamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mealSCamBtn.ForeColor = System.Drawing.Color.Blue;
            this.mealSCamBtn.Location = new System.Drawing.Point(0, 0);
            this.mealSCamBtn.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.mealSCamBtn.Name = "mealSCamBtn";
            this.mealSCamBtn.Size = new System.Drawing.Size(226, 49);
            this.mealSCamBtn.TabIndex = 4;
            this.mealSCamBtn.Text = "عرض الكاميرات";
            this.mealSCamBtn.UseVisualStyleBackColor = false;
            this.mealSCamBtn.Click += new System.EventHandler(this.mealSCamBtn_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.MainTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1763, 986);
            this.panel1.TabIndex = 8;
            // 
            // cameraTableAdapter
            // 
            this.cameraTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1775, 998);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MinimumSize = new System.Drawing.Size(796, 786);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إدارة اللوجستيات و الموازين - Lobridge V6.0.3";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.IncomingMenuPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.OutMenupanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.reportMenupanel2.ResumeLayout(false);
            this.WeightMenupanel3.ResumeLayout(false);
            this.commMenupanel3.ResumeLayout(false);
            this.transMenupanel3.ResumeLayout(false);
            this.userMenupanel3.ResumeLayout(false);
            this.SysSettingMenupanel5.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.OutboundPage.ResumeLayout(false);
            this.OutboundPage.PerformLayout();
            this.InboundPage.ResumeLayout(false);
            this.ReportsPage.ResumeLayout(false);
            this.WBridgePage.ResumeLayout(false);
            this.CatPage.ResumeLayout(false);
            this.TransPage.ResumeLayout(false);
            this.UserSettingsPage.ResumeLayout(false);
            this.SySettingsPage.ResumeLayout(false);
            this.CamPage.ResumeLayout(false);
            this.CamPage.PerformLayout();
            this.camMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLWSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel IncomingMenuPanel1;
        private System.Windows.Forms.Button inm_suplierbutton1;
        private System.Windows.Forms.Button inm_incardbutton4;
        private System.Windows.Forms.Button inm_releasebutton3;
        private System.Windows.Forms.Button inm_shipmentbutton2;
        private System.Windows.Forms.Panel OutMenupanel2;
        private System.Windows.Forms.Button om_BillLadingMenubutton4;
        private System.Windows.Forms.Button om_LoadingMenubutton5;
        private System.Windows.Forms.Button om_OrderMenubutton6;
        private System.Windows.Forms.Button om_ContractsMenubutton7;
        private System.Windows.Forms.Button om_CustomersMenubutton8;
        private System.Windows.Forms.Panel reportMenupanel2;
        private System.Windows.Forms.Panel WeightMenupanel3;
        private System.Windows.Forms.Button listOutMenubutton1;
        private System.Windows.Forms.Button ListWINMenubutton1;
        private System.Windows.Forms.Button WeightOutMenubutton2;
        private System.Windows.Forms.Button WeightINMenubutton3;
        private System.Windows.Forms.Panel commMenupanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button newCommbutton5;
        private System.Windows.Forms.Panel transMenupanel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button newDriverbutton8;
        private System.Windows.Forms.Button newTruckbutton9;
        private System.Windows.Forms.Panel userViewpanel1;
        private System.Windows.Forms.Panel userMenupanel3;
        private System.Windows.Forms.Button addNewUer;
        private System.Windows.Forms.Button logOutbutton13;
        private System.Windows.Forms.Button changePassbutton14;
        private System.Windows.Forms.Button emailSettingbutton15;
        private System.Windows.Forms.Button userProfilebutton16;
        private System.Windows.Forms.Panel SysSettingMenupanel5;
        private System.Windows.Forms.Button settingsbutton25;
        private System.Windows.Forms.Button om_listLoadingCbutton13;
        private System.Windows.Forms.Button StopWscreenBtn;
        private System.Windows.Forms.Button inm_listInCardsbutton5;
        private System.Windows.Forms.Button Wsemmarybutton13;
        private System.Windows.Forms.Button inm_listshipsbutton6;
        private System.Windows.Forms.Button om_listContractbutton13;
        private System.Windows.Forms.Button reportingbutton12;
        //private DevExpress.XtraTab.XtraTabControl MainTab;
        private System.Windows.Forms.TabControl MainTab;
        // private MetroFramework.Controls.MetroTabControl MainTab;
        private MetroFramework.Controls.MetroTabPage lobsys;
        private MetroFramework.Controls.MetroTabPage InboundPage;
        private MetroFramework.Controls.MetroTabPage ReportsPage;
        private MetroFramework.Controls.MetroTabPage WBridgePage;
        private MetroFramework.Controls.MetroTabPage CatPage;
        private MetroFramework.Controls.MetroTabPage TransPage;
        private MetroFramework.Controls.MetroTabPage UserSettingsPage;
        private MetroFramework.Controls.MetroTabPage SySettingsPage;
        private MetroFramework.Controls.MetroTabPage CamPage;
        private NSpanel.NPanel campanel1;
        private System.Windows.Forms.Panel camMenu;
        private System.Windows.Forms.Button camSettingBtn;
        private System.Windows.Forms.Button mealSCamBtn;
        private System.Windows.Forms.Button inm_summaryreportBtn7;
        private System.Windows.Forms.Button om_ReportingoutBtn;
        private System.Windows.Forms.Button inm_INshiftRptBtn8;
        private System.Windows.Forms.Button inm_AdvancedEditbutton9;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroTabPage OutboundPage;
        private DLWSDataSet dLWSDataSet;
        private System.Windows.Forms.BindingSource cameraBindingSource;
        private DLWSDataSetTableAdapters.CameraTableAdapter cameraTableAdapter;
        private System.Windows.Forms.ComboBox cam_NameComboBox;
        private System.Windows.Forms.Button button4;
        private NSpanel.NPanel OutGoingViewPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private NSpanel.NPanel reportViewpanel1;
        private NSpanel.NPanel commViewpanel1;
        private NSpanel.NPanel transViewpanel1;
        private NSpanel.NPanel SysViewpanel4;
        private NSpanel.NPanel weightViewpanel1;
        private NSpanel.NPanel InComingViewPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button menumax;
        private System.Windows.Forms.Button menumin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button refreshPerm;
        private System.Windows.Forms.Button buttondailyout;
        private System.Windows.Forms.Button button10sumIn;
        private System.Windows.Forms.Button button11dailyIn;
        private System.Windows.Forms.Button btnLocalSuppliers;
        private System.Windows.Forms.Button btnladeditadv;
        private System.Windows.Forms.Button btn_perm;
        private System.Windows.Forms.Button btn_ladingprts;
        private System.Windows.Forms.Button btnTruckTypes;
    }
}