using LoBridge.Inbound;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using LoBridge.Common;
namespace LoBridge
{

    public partial class Home : Form
    {
        string uname;
        string urole = "1";
        bool rlog = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        //[DllImportAttribute("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[DllImportAttribute("user32.dll")]
        //public static extern bool ReleaseCapture();
        public Home(string usern, string role)
        {
            uname = usern;
            urole = role;
            InitializeComponent();

            //}
            //  this.DoubleBuffered = true;
            // this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }
        private int tolerance = 20;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            base.WndProc(ref m);
        //            var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
        //            if (sizeGripRectangle.Contains(hitPoint))
        //                m.Result = new IntPtr(HTBOTTOMRIGHT);
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);
        //    var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

        //    sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

        //    region.Exclude(sizeGripRectangle);
        //   // this.panel1.Region = region;
        //    this.Invalidate();
        //}
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
        //    e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

        //    base.OnPaint(e);
        //    ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);

        //    //Graphics g = this.CreateGraphics();
        //    //double fw = this.Width; // form width
        //    //double tw = g.MeasureString(this.Text.Trim(), this.Font).Width; // text width
        //    //double rp = (fw - tw) / 2;
        //    //int tt = Convert.ToInt32(rp);
        //    //string st = " ";
        //    //st = st.PadRight(tt / 3);
        //    //this.Text = st + this.Text.Trim();

        //}

        private bool CheckOpened(string fname)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == fname)
                {
                    return true;
                }
            }
            return false;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        //private void btnMaximizar_Click(object sender, EventArgs e)
        //{
        //    lx = this.Location.X;
        //    ly = this.Location.Y;
        //    sw = this.Size.Width;
        //    sh = this.Size.Height;
        //    btnMaximizar.Visible = false;
        //    btnRestaurar.Visible = true;
        //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        //    //this.WindowState = FormWindowState.Maximized;

        //}

        //private void btnRestaurar_Click(object sender, EventArgs e)
        //{
        //    btnMaximizar.Visible = true;
        //    btnRestaurar.Visible = false;
        //    this.Size = new Size(sw, sh);
        //    this.Location = new Point(lx, ly);

        //}

        //private void btnMinimizar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}
        DataTable permdt = new DataTable();
        private void Home_Load(object sender, EventArgs e)
        {

            MainTab.SelectedIndex = 1;

            
            try
            {
                DataQuery dq = new DataQuery();
                string perm_query = "select * from user_perm where id=" + urole + "";
                permdt = dq.GetDataTable(perm_query);


            }
            catch (Exception ex)
            {
                MessageBox.Show("error fetching permissions ," + ex);
            }

            if (permdt != null)
            {
                if (permdt.Rows[0]["page_outgoing"].ToString() != "1")
                {
                    ((Control)this.OutboundPage).Enabled = false;
                }
                else
                {
                    om_CustomersMenubutton8.Enabled = ifone(permdt.Rows[0]["om_Customers"].ToString());
                    om_ContractsMenubutton7.Enabled = ifone(permdt.Rows[0]["om_Contracts"].ToString());
                    om_OrderMenubutton6.Enabled = ifone(permdt.Rows[0]["om_Order"].ToString());
                    om_LoadingMenubutton5.Enabled = ifone(permdt.Rows[0]["om_Loading"].ToString());
                    om_BillLadingMenubutton4.Enabled = ifone(permdt.Rows[0]["om_BillLading"].ToString());
                    om_listLoadingCbutton13.Enabled = ifone(permdt.Rows[0]["om_listLoading"].ToString());
                    om_listContractbutton13.Enabled = ifone(permdt.Rows[0]["om_listContract"].ToString());
                    om_ReportingoutBtn.Enabled = ifone(permdt.Rows[0]["om_Reportingout"].ToString());
                }
                if (permdt.Rows[0]["page_incoming"].ToString() != "1")
                {
                    ((Control)this.InboundPage).Enabled = false;
                }
                else
                {

                    inm_suplierbutton1.Enabled = ifone(permdt.Rows[0]["inm_suplier"].ToString());
                    inm_shipmentbutton2.Enabled = ifone(permdt.Rows[0]["inm_shipment"].ToString());
                    inm_releasebutton3.Enabled = ifone(permdt.Rows[0]["inm_release"].ToString());
                    inm_incardbutton4.Enabled = ifone(permdt.Rows[0]["inm_incard"].ToString());
                    inm_listInCardsbutton5.Enabled = ifone(permdt.Rows[0]["inm_listInCards"].ToString());
                    inm_listshipsbutton6.Enabled = ifone(permdt.Rows[0]["inm_listships"].ToString());
                    inm_INshiftRptBtn8.Enabled = ifone(permdt.Rows[0]["inm_INshiftRpt"].ToString());
                    inm_summaryreportBtn7.Enabled = ifone(permdt.Rows[0]["inm_summaryreport"].ToString());
                    inm_AdvancedEditbutton9.Enabled = ifone(permdt.Rows[0]["inm_AdvancedEdit"].ToString());
                    btnLocalSuppliers.Enabled= ifone(permdt.Rows[0]["Local_Suppliers"].ToString());
                    btnladeditadv.Visible = ifone(permdt.Rows[0]["btnladeditadv"].ToString());
                }
                if (permdt.Rows[0]["page_reports"].ToString() != "1")
                {
                    ((Control)this.ReportsPage).Enabled = false;
                }
                else
                {

                }
                if (permdt.Rows[0]["page_weight"].ToString() != "1")
                {
                    ((Control)this.WBridgePage).Enabled = false;
                }
                else
                {

                }
                if (permdt.Rows[0]["page_commodity"].ToString() != "1")
                {
                    ((Control)this.CatPage).Enabled = false;
                }
                else
                {

                }
                if (permdt.Rows[0]["page_transport"].ToString() != "1")
                {
                    //MainTab.TabPages.Remove(TransPage);
                    ((Control)this.TransPage).Enabled = false;
                }
                else
                {

                }
                if (permdt.Rows[0]["page_usettings"].ToString() != "1")
                {
                    ((Control)this.UserSettingsPage).Enabled = false;
                }
                else
                {
                    // __user_add
                    addNewUer.Enabled = ifone(permdt.Rows[0]["__user_add"].ToString());
                    btn_perm.Enabled = ifone(permdt.Rows[0]["__user_add"].ToString());
                }
                if (permdt.Rows[0]["page_ssettings"].ToString() != "1")
                {
                    ((Control)this.SySettingsPage).Enabled = false;
                }
                if (permdt.Rows[0]["page_cam"].ToString() != "1")
                {
                    ((Control)this.CamPage).Enabled = false;

                }
                else
                {
                    camSettingBtn.Enabled = ifone(permdt.Rows[0]["__cam_settings"].ToString());
                }


                // this.label1.Text = " (" + uname + ") " + this.label1.Text;
                this.Text = this.Text + " (" + uname + ") ";
            }

        }

        string drawString = "Connected";
        System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
        AppSetting setting = new AppSetting();
        bool draw = true;
        bool gr = true;
        string last = "s";
        private void check_conn(Object myObject, EventArgs myEventArgs)
        {

            try
            {
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillRectangle(myBrush, new Rectangle(5, 30, 120, 20));

                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
                System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);
                float x = 5.0F;
                float y = 30.0F;
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
                drawFont.Dispose();
                drawBrush.Dispose();
                formGraphics.Dispose();


                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send("192.168.1.180");
                if (gr)
                {

                    if (last == "d")
                    {
                        myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    }
                    else
                    {
                        myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
                    }
                    gr = false;
                }
                else
                {
                    if (last == "d")
                    {
                        myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    }
                    else
                    {
                        myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    }
                    gr = true;
                }
                if (reply.Status == IPStatus.Success)
                {
                    if (last == "d")
                    {
                        drawString = "Connected";

                        last = "s";
                        draw = true;
                    }
                    else
                    {
                        draw = false;
                    }


                }
                else
                {
                    if (last == "s")
                    {
                        drawString = "Disconnected";
                        last = "d";
                        draw = true;
                    }
                    else
                    {
                        draw = false;
                    }
                    timer1.Stop();
                    DBConnect dbc = new DBConnect();
                    dbc.ShowDialog();
                    timer1.Start();
                }


            }
            catch (Exception ex)
            {

            }
        }
        //bool closeold = false;
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dr = MessageBox.Show("تاكيد الخروج من البرنامج", "", MessageBoxButtons.OKCancel);



            if (dr.ToString() == "Cancel")
            {
                //  timer1.Start();
                e.Cancel = true;
            }
            else
            {
                if (rlog == true)
                {

                    cam_NameComboBox.DataBindings.Clear();
                    Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                    foreach (Form thisForm in forms)
                    {

                        //thisForm.Dispose();
                        if (thisForm.Name == "Login")
                        {
                            thisForm.Show();
                        }
                    }
                }
                else
                {
                    cam_NameComboBox.DataBindings.Clear();
                    Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                    foreach (Form thisForm in forms)
                    {

                        //thisForm.Dispose();
                        if (thisForm.Name != "Home")
                        {
                            thisForm.Close();

                        }
                    }
                    // Application.Exit();
                }

            }

        }
        //Login login = new Login();
        private void LogOutbutton13_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("تاكيد الخروج من البرنامج", "", MessageBoxButtons.OKCancel);
            rlog = true;
            //if (dr.ToString() == "Cancel")
            //{
            //    //  timer1.Start();

            //}
            //else
            //{

            //        // Application.Restart();

            this.Close();
            //}
        }

        int lasttabindex = 1;
        private bool ifone(string onet)
        {
            if (onet == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Form getOpenedForm(Form Oform)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == Oform.Text)
                {
                    return frm;
                }
            }
            return Oform;
        }

        private void DisplayInForm(Form form)
        {
            if (InComingViewPanel.Controls.Count > 0)
            {
                InComingViewPanel.Controls.RemoveAt(0);
            }
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Right;
            form.TopLevel = false;
            if (form.Width < InComingViewPanel.Width - 10)
            {
                form.Width = InComingViewPanel.Width - 10;
            }
            if (!CheckOpened(form.Text))
            {
                form.Show();
                InComingViewPanel.Controls.Add(form);
            }
            else
            {
                InComingViewPanel.Controls.Add(getOpenedForm(form));
                //iNShipment.Show();
            }
        }

        //------------------ Display Incoming Forms -------------------//
        private void btnLocalSuppliers_Click(object sender, EventArgs e)
        {
            Local_Suppliers lcSupplier = new Local_Suppliers();
            DisplayInForm(lcSupplier);
            foreach (Control c in IncomingMenuPanel1.Controls)
            {
                c.BackColor = Color.White;
            }
            inm_suplierbutton1.BackColor = Color.Gray;
        }

        private void suplierbutton1_Click(object sender, EventArgs e)
        {
            INSupplier iNSupplier = new INSupplier(permdt);
            DisplayInForm(iNSupplier);
            foreach (Control c in IncomingMenuPanel1.Controls)
            {
                c.BackColor = Color.White;
            }
            inm_suplierbutton1.BackColor = Color.Gray;
        }
        private void shipmentbutton2_Click(object sender, EventArgs e)
        {
            INShipment iNShipment = new INShipment(permdt);
            DisplayInForm(iNShipment);
            foreach (Control c in IncomingMenuPanel1.Controls)
            {
                c.BackColor = Color.White;
            }
            inm_shipmentbutton2.BackColor = Color.Gray;
        }

        private void releasebutton3_Click(object sender, EventArgs e)
        {
            INRelease iNRelease = new INRelease();
            DisplayInForm(iNRelease);
            foreach (Control c in IncomingMenuPanel1.Controls)
            {
                c.BackColor = Color.White;
            }
            inm_releasebutton3.BackColor = Color.Gray;
        }

        private void rcardbutton4_Click(object sender, EventArgs e)
        {
            InboardCard inboardCard = new InboardCard(permdt);
            DisplayInForm(inboardCard);
            foreach (Control c in IncomingMenuPanel1.Controls)
            {
                c.BackColor = Color.White;
            }
            inm_incardbutton4.BackColor = Color.Gray;
        }
        private void listInCardsbutton13_Click(object sender, EventArgs e)
        {
            ListInCards listInCards = new ListInCards(permdt);
            DisplayInForm(listInCards);
            foreach (Control c in IncomingMenuPanel1.Controls)
            {
                c.BackColor = Color.White;
            }
            inm_listInCardsbutton5.BackColor = Color.Gray;
        }

        private void listshipsbutton13_Click(object sender, EventArgs e)
        {
            INListShips ships = new INListShips(permdt);
            DisplayInForm(ships);
            foreach (Control c in IncomingMenuPanel1.Controls)
            {
                c.BackColor = Color.White;
            }
            inm_listshipsbutton6.BackColor = Color.Gray;
        }

        private void ShiftBtn_Click(object sender, EventArgs e)
        {
            INSHiftViewer iNSHiftViewer = new INSHiftViewer();
            DisplayInForm(iNSHiftViewer);
            foreach (Control c in IncomingMenuPanel1.Controls)
            {
                c.BackColor = Color.White;
            }
            inm_summaryreportBtn7.BackColor = Color.Gray;
        }
        private void INshiftRptBtn_Click(object sender, EventArgs e)
        {
            INReportingViewer iNReportingViewer = new INReportingViewer();
            DisplayInForm(iNReportingViewer);
            foreach (Control c in IncomingMenuPanel1.Controls)
            {
                c.BackColor = Color.White;
            }
            inm_INshiftRptBtn8.BackColor = Color.Gray;

        }

        private void AdvancedEditbutton15_Click(object sender, EventArgs e)
        {
            InAdvEditing editing = new InAdvEditing();
            DisplayInForm(editing);
            foreach (Control c in IncomingMenuPanel1.Controls)
            {
                c.BackColor = Color.White;
            }
            inm_AdvancedEditbutton9.BackColor = Color.Gray;

        }

        //------------------ Display Outgoing Forms -------------------//
        private void DisplayOutForm(Form form)
        {
            if (OutGoingViewPanel.Controls.Count > 0)
            {
                OutGoingViewPanel.Controls.RemoveAt(0);
            }
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Right;
            if (form.Width < OutGoingViewPanel.Width - 10)
            {
                form.Width = OutGoingViewPanel.Width - 10;
            }
            //if (form.Text== "OUTLadingView")
            //{
            //    form.Dock = DockStyle.Fill;
            //}
            //else
            //{
            //    form.Dock = DockStyle.Right;
            //}

            form.TopLevel = false;

            if (!CheckOpened(form.Text))
            {
                form.Show();
                OutGoingViewPanel.Controls.Add(form);

            }
            else
            {
                OutGoingViewPanel.Controls.Add(getOpenedForm(form));
                //iNShipment.Show();
            }
        }

        private void CustomersMenubutton8_Click(object sender, EventArgs e)
        {
            DisplayOutForm(new OUTCustomer(permdt));
            foreach (Control c in OutMenupanel2.Controls)
            {
                c.BackColor = Color.White;


            }

            om_CustomersMenubutton8.BackColor = Color.Gray;
        }

        private void ContrractsMenubutton7_Click(object sender, EventArgs e)
        {
            //OUTContract oUTContract = new OUTContract();
            DisplayOutForm(new OUTContract(0, permdt));

            foreach (Control c in OutMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            om_ContractsMenubutton7.BackColor = Color.Gray;
        }

        private void OrderMenubutton6_Click(object sender, EventArgs e)
        {
            //OUTOrder oUTOrder = new OUTOrder();
            DisplayOutForm(new OUTOrder());
            foreach (Control c in OutMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            om_OrderMenubutton6.BackColor = Color.Gray;
        }

        private void LoadingMenubutton5_Click(object sender, EventArgs e)
        {
            // OUTLoadingCard ouTLoadingCard = new OUTLoadingCard();
            DisplayOutForm(new OUTLoadingCard(permdt));
            foreach (Control c in OutMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            om_LoadingMenubutton5.BackColor = Color.Gray;
        }

        private void BillLadingMenubutton4_Click(object sender, EventArgs e)
        {
            OutPrint_BLading print_Ladingcard = new OutPrint_BLading(0, permdt);
            //print_Ladingcard.ShowDialog();
            DisplayOutForm(print_Ladingcard);
            foreach (Control c in OutMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            om_BillLadingMenubutton4.BackColor = Color.Gray;
        }


        private void listLoadingCbutton13_Click(object sender, EventArgs e)
        {
            OUTLadingView ladingView = new OUTLadingView(permdt);
            DisplayOutForm(ladingView);
            foreach (Control c in OutMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            om_listLoadingCbutton13.BackColor = Color.Gray;
        }

        private void listContractbutton13_Click(object sender, EventArgs e)
        {
            OUTContractView contractView = new OUTContractView(permdt);
            DisplayOutForm(contractView);
            foreach (Control c in OutMenupanel2.Controls)
            {
                c.BackColor = Color.White; ;
            }
            om_listContractbutton13.BackColor = Color.Gray;

        }

        private void ReportingoutBtn_Click(object sender, EventArgs e)
        {
            OutDailyreport reporting = new OutDailyreport();
            DisplayOutForm(reporting);
            foreach (Control c in OutMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            om_ReportingoutBtn.BackColor = Color.Gray;
        }

        //------------------ Display Reports Forms -------------------//
        private void DisplayRptForm(Form form)
        {
            if (reportViewpanel1.Controls.Count > 0)
            {
                reportViewpanel1.Controls.RemoveAt(0);
            }

            if (form.Width < reportViewpanel1.Width - 10)
            {
                form.Width = reportViewpanel1.Width - 10;
            }

            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Right;
            form.TopLevel = false;

            if (!CheckOpened(form.Text))
            {

                form.Show();
                reportViewpanel1.Controls.Add(form);

            }
            else
            {
                reportViewpanel1.Controls.Add(getOpenedForm(form));
                //iNShipment.Show();
            }
        }


        private void Wsemmarybutton13_Click(object sender, EventArgs e)
        {
            OutDailyreport reporting = new OutDailyreport();
            DisplayRptForm(reporting);
            foreach (Control c in reportMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            Wsemmarybutton13.BackColor = Color.Gray;
        }

        private void reportingbutton12_Click(object sender, EventArgs e)
        {

            OutDailyreport reporting = new OutDailyreport();
            DisplayRptForm(reporting);
            foreach (Control c in reportMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            reportingbutton12.BackColor = Color.Gray;
        }

        //------------------ Display weight Forms -------------------//
        private void DisplayWeightForm(Form form)
        {
            if (weightViewpanel1.Controls.Count > 0)
            {
                weightViewpanel1.Controls.RemoveAt(0);
            }
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Right;
            if (form.Width < weightViewpanel1.Width - 10)
            {
                form.Width = weightViewpanel1.Width - 10;
            }
            form.TopLevel = false;

            if (!CheckOpened(form.Text))
            {
                form.Show();
                weightViewpanel1.Controls.Add(form);

            }
            else
            {
                weightViewpanel1.Controls.Add(getOpenedForm(form));

            }
        }


        private void WeightINMenubutton3_Click(object sender, EventArgs e)
        {
            INWCard iNWCard = new INWCard();
            DisplayWeightForm(iNWCard);
            foreach (Control c in WeightMenupanel3.Controls)
            {
                c.BackColor = Color.White;
            }
            WeightINMenubutton3.BackColor = Color.Gray;
        }

        private void WeightOutMenubutton2_Click(object sender, EventArgs e)
        {
            OutWCard outWCard = new OutWCard();
            DisplayWeightForm(outWCard);
            foreach (Control c in WeightMenupanel3.Controls)
            {
                c.BackColor = Color.White;
            }
            WeightOutMenubutton2.BackColor = Color.Gray;
        }


        private void listOutMenubutton1_Click(object sender, EventArgs e)
        {
            OUTLadingView ladingView = new OUTLadingView(permdt);
            DisplayWeightForm(ladingView);
            foreach (Control c in WeightMenupanel3.Controls)
            {
                c.BackColor = Color.White;
            }
            listOutMenubutton1.BackColor = Color.Gray;
        }


        private void ListWINMenubutton1_Click(object sender, EventArgs e)
        {
            ListInCards listInCards = new ListInCards(permdt);
            DisplayWeightForm(listInCards);
            foreach (Control c in WeightMenupanel3.Controls)
            {
                c.BackColor = Color.White;
            }
            ListWINMenubutton1.BackColor = Color.Gray;
        }

        //------------------ Display Commodity Forms -------------------//
        private void DisplaycommForm(Form form)
        {
            if (commViewpanel1.Controls.Count > 0)
            {
                commViewpanel1.Controls.RemoveAt(0);
            }
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Right;
            if (form.Width < commViewpanel1.Width - 10)
            {
                form.Width = commViewpanel1.Width - 10;
            }
            form.TopLevel = false;

            if (!CheckOpened(form.Text))
            {
                form.Show();
                commViewpanel1.Controls.Add(form);

            }
            else
            {
                commViewpanel1.Controls.Add(getOpenedForm(form));
                //iNShipment.Show();
            }
        }
        private void newCommbutton5_Click(object sender, EventArgs e)
        {
            Commodity commodity = new Commodity(permdt);
            DisplaycommForm(commodity);
        }


        //------------------ Display Commodity Forms -------------------//
        private void DisplayTransForm(Form form)
        {
            if (transViewpanel1.Controls.Count > 0)
            {
                transViewpanel1.Controls.RemoveAt(0);
            }
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Right;
            if (form.Width < transViewpanel1.Width - 10)
            {
                form.Width = transViewpanel1.Width - 10;
            }
            form.TopLevel = false;

            if (!CheckOpened(form.Text))
            {
                form.Show();
                transViewpanel1.Controls.Add(form);

            }
            else
            {
                transViewpanel1.Controls.Add(getOpenedForm(form));
                //iNShipment.Show();
            }
        }
        private void newTruckbutton9_Click(object sender, EventArgs e)
        {
            //Transport trans = new Transport();
            DisplayTransForm(new Transport(permdt));
            foreach (Control c in transMenupanel3.Controls)
            {
                c.BackColor = Color.White;
            }
            newTruckbutton9.BackColor = Color.Gray;
        }

        //------------------ Display Commodity Forms -------------------//
        private void DisplayuserForm(Form form)
        {
            if (userViewpanel1.Controls.Count > 0)
            {
                userViewpanel1.Controls.RemoveAt(0);
            }
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Right;
            form.TopLevel = false;

            if (!CheckOpened(form.Text))
            {
                form.Show();
                userViewpanel1.Controls.Add(form);

            }
            else
            {
                userViewpanel1.Controls.Add(getOpenedForm(form));
                //iNShipment.Show();
            }
        }
        private void userProfilebutton16_Click(object sender, EventArgs e)
        {
            userSettings userSettings = new userSettings();
            DisplayuserForm(userSettings);
        }

        private void btn_perm_Click(object sender, EventArgs e)
        {
            UsersPerm usersPerm = new UsersPerm();
            DisplayuserForm(usersPerm);
        }
        private void addNewUer_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            DisplayuserForm(users);
        }


        //------------------ Display Commodity Forms -------------------//
        private void DisplaySysSettingsForm(Form form)
        {
            if (SysViewpanel4.Controls.Count > 0)
            {
                SysViewpanel4.Controls.RemoveAt(0);
            }
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Right;
            form.TopLevel = false;

            if (!CheckOpened(form.Text))
            {
                form.Show();
                SysViewpanel4.Controls.Add(form);

            }
            else
            {
                SysViewpanel4.Controls.Add(getOpenedForm(form));
                //iNShipment.Show();
            }
        }

        private void settingsbutton25_Click(object sender, EventArgs e)
        {
            SysSettingsForm sysSettingsForm = new SysSettingsForm();
            DisplaySysSettingsForm(sysSettingsForm);
        }

        private void StopWscreenBtn_Click(object sender, EventArgs e)
        {
            //screen.stopW();
        }

        private void MainTab_Selecting_1(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                MainTab.SelectedIndex = lasttabindex;
            }
            else
            {
                lasttabindex = MainTab.SelectedIndex;
            }
        }


        //------------------ Display Cam Forms -------------------//
        private void DisplayCamForm(Form form)
        {
            if (campanel1.Controls.Count > 0)
            {
                campanel1.Controls.RemoveAt(0);
            }
            //form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            if (form.Width < campanel1.Width - 10)
            {
                form.Width = campanel1.Width - 10;
            }
            form.TopLevel = false;

            form.Show();
            campanel1.Controls.Add(form);


        }


        private void mealSCamBtn_Click(object sender, EventArgs e)
        {

            int cindex = Properties.Settings.Default.areacam;

            if (cindex > -1 && this.dLWSDataSet.Camera.Rows.Count > 0)
            {
                try
                {
                    PreviewCamera pcam = new PreviewCamera(this.dLWSDataSet.Camera[cindex][2].ToString().Trim(),
                            this.dLWSDataSet.Camera[cindex][3].ToString().Trim()
                                , this.dLWSDataSet.Camera[cindex][4].ToString().Trim());
                    DisplayCamForm(pcam);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void campanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siteCambutton15_Click(object sender, EventArgs e)
        {
            Cams cams = new Cams();
            cams.ShowDialog();
        }

        private void cam_NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cam_NameComboBox.SelectedIndex >= 0)
            {
                try
                {
                    Properties.Settings.Default.areacam = cam_NameComboBox.SelectedIndex;
                    // MessageBox.Show("Cam number : " + cam_NameComboBox.SelectedIndex);
                    //Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "er1");
                }
            }

        }

        private void cam_NameComboBox_Click(object sender, EventArgs e)
        {

            if (cam_NameComboBox.Items.Count < 1)
            {
                // TODO: This line of code loads data into the 'dLWSDataSet.Camera' table. You can move, or remove it, as needed.
                this.cameraTableAdapter.Fill(this.dLWSDataSet.Camera);
                if (this.dLWSDataSet.Camera.Rows.Count > 0)
                {
                    for (int i = 0; i < dLWSDataSet.Camera.Rows.Count; i++)
                    {
                        cam_NameComboBox.Items.Insert(i, this.dLWSDataSet.Camera[i][1]);

                    }
                    cam_NameComboBox.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("لا يوجد كاميرات مسجلة");
                }
            }
        }

        //private void label1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}

        private void OutMenupanel2_MouseEnter(object sender, EventArgs e)
        {
            //   OutMenupanel2.Width = 180;
        }

        private void OutMenupanel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void OutGoingViewPanel_MouseEnter(object sender, EventArgs e)
        {
            //  
        }

        private void om_CustomersMenubutton8_MouseEnter(object sender, EventArgs e)
        {
            //   OutMenupanel2.Width = 180;
        }

        private void menumin_Click(object sender, EventArgs e)
        {
            OutMenupanel2.Width = 30;
            menumax.Visible = true;
            menumin.Visible = false;
        }

        private void menumax_Click(object sender, EventArgs e)
        {
            OutMenupanel2.Width = 180;
            menumax.Visible = false;
            menumin.Visible = true;
        }

        private void refreshPerm_Click(object sender, EventArgs e)
        {
            try
            {
                DataQuery dq = new DataQuery();
                string perm_query = "select * from user_perm where id=" + urole + "";
                permdt = dq.GetDataTable(perm_query);


            }
            catch (Exception ex)
            {
                MessageBox.Show("error fetching permissions ," + ex);
            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            IncomingMenuPanel1.Width = 30;
            button6.Visible = true;
            button8.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            IncomingMenuPanel1.Width = 180;
            button6.Visible = false;
            button8.Visible = true;
        }

        private void buttondailyout_Click(object sender, EventArgs e)
        {
            OutDailyreport reporting = new OutDailyreport();
            DisplayRptForm(reporting);
            foreach (Control c in reportMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            buttondailyout.BackColor = Color.Gray;
        }

        private void button11dailyIn_Click(object sender, EventArgs e)
        {

            INSHiftViewer iNSHiftViewer = new INSHiftViewer();
            DisplayRptForm(iNSHiftViewer);
            foreach (Control c in reportMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            button11dailyIn.BackColor = Color.Gray;


        }

        private void button10sumIn_Click(object sender, EventArgs e)
        {
            INReportingViewer iNReportingViewer = new INReportingViewer();
            DisplayRptForm(iNReportingViewer);
            foreach (Control c in reportMenupanel2.Controls)
            {
                c.BackColor = Color.White;
            }
            button10sumIn.BackColor = Color.Gray;

        }

        private void btnladeditadv_Click(object sender, EventArgs e)
        {
            INladAdvEdit nladAdvEdit = new INladAdvEdit();
            nladAdvEdit.ShowDialog();
        }

        private void btn_ladingprts_Click(object sender, EventArgs e)
        {
            Lading_Ports lading_Ports = new Lading_Ports();
            lading_Ports.ShowDialog();
        }

        private void OutGoingViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dLWSDataSet.Camera' table. You can move, or remove it, as needed.
            this.cameraTableAdapter.Fill(this.dLWSDataSet.Camera);
            cam_NameComboBox.Items.Clear();
            for (int i = 0; i < dLWSDataSet.Camera.Rows.Count; i++)
            {
                cam_NameComboBox.Items.Insert(i, this.dLWSDataSet.Camera[i][1]);

            }
        }

        //private void xtraTabControl1_Selecting(object sender, DevExpress.XtraTab.TabPageCancelEventArgs e)
        //{
        //    if (e.PageIndex == 0)
        //    {
        //        MainTab.SelectedTabPageIndex = lasttabindex;
        //    } else
        //    {
        //        lasttabindex = MainTab.SelectedTabPageIndex;
        //    }
        //}
    }
}
