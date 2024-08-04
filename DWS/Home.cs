using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

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
            //109, 191, 184
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(109, 191, 184);
                }
            }

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
                    outboundMenuItem.Enabled = false;
                }
                else
                {
                    customersMenuItem.Enabled = ifone(permdt.Rows[0]["om_Customers"].ToString());
                    contractsMenuItem.Enabled = ifone(permdt.Rows[0]["om_Contracts"].ToString());
                    ordersMenuItem.Enabled = ifone(permdt.Rows[0]["om_Order"].ToString());
                    outcardsMenuItem.Enabled = ifone(permdt.Rows[0]["om_Loading"].ToString());
                    bladingMenuItem.Enabled = ifone(permdt.Rows[0]["om_BillLading"].ToString());
                    listoutcardsMenuItem.Enabled = ifone(permdt.Rows[0]["om_listLoading"].ToString());
                    listcontractsMenuItem.Enabled = ifone(permdt.Rows[0]["om_listContract"].ToString());
                    //om_ReportingoutBtn.Enabled = ifone(permdt.Rows[0]["om_Reportingout"].ToString());
                }
                if (permdt.Rows[0]["page_incoming"].ToString() != "1")
                {
                    inboundMenuItem.Enabled = false;
                }
                else
                {

                    supplierspMenuItem.Enabled = ifone(permdt.Rows[0]["inm_suplier"].ToString());
                    shipsMenuItem.Enabled = ifone(permdt.Rows[0]["inm_shipment"].ToString());
                    releasesMenuItem.Enabled = ifone(permdt.Rows[0]["inm_release"].ToString());
                    incardsMenuItem.Enabled = ifone(permdt.Rows[0]["inm_incard"].ToString());
                    //inm_listInCardsbutton5.Enabled = ifone(permdt.Rows[0]["inm_listInCards"].ToString());
                    //inm_listshipsbutton6.Enabled = ifone(permdt.Rows[0]["inm_listships"].ToString());
                    //inm_INshiftRptBtn8.Enabled = ifone(permdt.Rows[0]["inm_INshiftRpt"].ToString());
                    //inm_summaryreportBtn7.Enabled = ifone(permdt.Rows[0]["inm_summaryreport"].ToString());
                    //inm_AdvancedEditbutton9.Enabled = ifone(permdt.Rows[0]["inm_AdvancedEdit"].ToString());

                }
                if (permdt.Rows[0]["page_reports"].ToString() != "1")
                {
                    releasesMenuItem.Enabled = false;
                }
                else
                {

                }
                if (permdt.Rows[0]["page_weight"].ToString() != "1")
                {
                    WbridgesMenuItem.Enabled = false;
                }
                else
                {

                }
                if (permdt.Rows[0]["page_commodity"].ToString() != "1")
                {
                    productsMenuItem.Enabled = false;
                }
                else
                {

                }
                if (permdt.Rows[0]["page_transport"].ToString() != "1")
                {
                    //MainTab.TabPages.Remove(TransPage);
                    transMenuItem.Enabled = false;
                }
                else
                {

                }
                if (permdt.Rows[0]["page_usettings"].ToString() != "1")
                {
                    newuserMenuItem.Enabled = false;
                }
                else
                {
                    // __user_add
                    //addNewUer.Enabled = ifone(permdt.Rows[0]["__user_add"].ToString());
                }
                if (permdt.Rows[0]["page_ssettings"].ToString() != "1")
                {
                    systemsettingsMenuItem.Enabled = false;
                }
                if (permdt.Rows[0]["page_cam"].ToString() != "1")
                {
                   // ((Control)this.CamPage).Enabled = false;

                }
                else
                {
                  // camSettingBtn.Enabled = ifone(permdt.Rows[0]["__cam_settings"].ToString());
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

                    //cam_NameComboBox.DataBindings.Clear();
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
                    //cam_NameComboBox.DataBindings.Clear();
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

        //private void DisplayForm(Form form)
        //{
        //    if (InComingViewPanel.Controls.Count > 0)
        //    {
        //        InComingViewPanel.Controls.RemoveAt(0);
        //    }
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    form.Dock = DockStyle.Right;
        //    form.TopLevel = false;
        //    if (form.Width < InComingViewPanel.Width - 10)
        //    {
        //        form.Width = InComingViewPanel.Width - 10;
        //    }
        //    if (!CheckOpened(form.Text))
        //    {
        //        form.Show();
        //        InComingViewPanel.Controls.Add(form);
        //    }
        //    else
        //    {
        //        InComingViewPanel.Controls.Add(getOpenedForm(form));
        //        //iNShipment.Show();
        //    }
        //}

        //------------------ Display Incoming Forms -------------------//

        private void suplierbutton1_Click(object sender, EventArgs e)
        {
            INSupplier iNSupplier = new INSupplier(permdt);
            DisplayForm(iNSupplier);
           
        }
        private void shipmentbutton2_Click(object sender, EventArgs e)
        {
            INShipment iNShipment = new INShipment(permdt);
            DisplayForm(iNShipment);
            
        }

        private void releasebutton3_Click(object sender, EventArgs e)
        {
            INRelease iNRelease = new INRelease();
            DisplayForm(iNRelease);
            
        }

        private void rcardbutton4_Click(object sender, EventArgs e)
        {
            InboardCard inboardCard = new InboardCard(permdt);
            DisplayForm(inboardCard);
            
        }
        private void listInCardsbutton13_Click(object sender, EventArgs e)
        {
            ListInCards listInCards = new ListInCards(permdt);
            DisplayForm(listInCards);
            
        }

        private void listshipsbutton13_Click(object sender, EventArgs e)
        {
            INListShips ships = new INListShips(permdt);
            DisplayForm(ships);
            
        }

        private void ShiftBtn_Click(object sender, EventArgs e)
        {
            INSHiftViewer iNSHiftViewer = new INSHiftViewer();
            DisplayForm(iNSHiftViewer);
            
        }
        private void INshiftRptBtn_Click(object sender, EventArgs e)
        {
            INReportingViewer iNReportingViewer = new INReportingViewer();
            DisplayForm(iNReportingViewer);
            

        }

        private void AdvancedEditbutton15_Click(object sender, EventArgs e)
        {
            InAdvEditing editing = new InAdvEditing();
            DisplayForm(editing);
            

        }
        Form cForm=null;
        //------------------ Display Outgoing Forms -------------------//
        private void DisplayForm(Form form)
        {
            form.TopLevel = false;

            if (cForm != null)
            {
                cForm.WindowState = FormWindowState.Minimized;
            }
            if (!CheckOpened(form.Text))
            {
                form.Show();
                form.MdiParent = this;
                //this.Controls.Add(form);
                //form.BringToFront();
                cForm = form;
            }
            else
            {
                getOpenedForm(form).WindowState = FormWindowState.Maximized;
                //mainPnl.Controls.Add(getOpenedForm(form));
            }
        }
       
        private void CustomersMenubutton8_Click(object sender, EventArgs e)
        {
            DisplayForm(new OUTCustomer(permdt));
            
        }

        private void ContrractsMenubutton7_Click(object sender, EventArgs e)
        {
            DisplayForm(new OUTContract(0, permdt));

        }

        private void OrderMenubutton6_Click(object sender, EventArgs e)
        {
            DisplayForm(new OUTOrder());
            
        }

        private void LoadingMenubutton5_Click(object sender, EventArgs e)
        {
            DisplayForm(new OUTLoadingCard(permdt));
            
        }

        private void BillLadingMenubutton4_Click(object sender, EventArgs e)
        {
            DisplayForm(new OutPrint_BLading(0, permdt));
            
        }


        private void listLoadingCbutton13_Click(object sender, EventArgs e)
        {
            OUTLadingView ladingView = new OUTLadingView(permdt);
            DisplayForm(ladingView);
            
        }

        private void listContractbutton13_Click(object sender, EventArgs e)
        {
            OUTContractView contractView = new OUTContractView(permdt);
            DisplayForm(contractView);
           

        }

        private void ReportingoutBtn_Click(object sender, EventArgs e)
        {
            OutDailyreport reporting = new OutDailyreport();
            DisplayForm(reporting);
           
        }

        //------------------ Display Reports Forms -------------------//
        

        private void Wsemmarybutton13_Click(object sender, EventArgs e)
        {
            OutDailyreport reporting = new OutDailyreport();
            DisplayForm(reporting);
            
        }

        private void reportingbutton12_Click(object sender, EventArgs e)
        {

            OutDailyreport reporting = new OutDailyreport();
            DisplayForm(reporting);
           
        }

        //------------------ Display weight Forms -------------------//
       


        private void WeightINMenubutton3_Click(object sender, EventArgs e)
        {
            INWCard iNWCard = new INWCard();
            DisplayForm(iNWCard);
            
        }

        private void WeightOutMenubutton2_Click(object sender, EventArgs e)
        {
            OutWCard outWCard = new OutWCard();
            DisplayForm(outWCard);
           
        }


        private void listOutMenubutton1_Click(object sender, EventArgs e)
        {
            OUTLadingView ladingView = new OUTLadingView(permdt);
            DisplayForm(ladingView);
           
        }


        private void ListWINMenubutton1_Click(object sender, EventArgs e)
        {
            ListInCards listInCards = new ListInCards(permdt);
            DisplayForm(listInCards);
            
        }

        //------------------ Display Commodity Forms -------------------//
      
        private void newCommbutton5_Click(object sender, EventArgs e)
        {
            Commodity commodity = new Commodity(permdt);
            DisplayForm(commodity);
        }


        //------------------ Display Commodity Forms -------------------//
       
        private void newTruckbutton9_Click(object sender, EventArgs e)
        {
            DisplayForm(new Transport(permdt));
            
        }

        //------------------ Display Commodity Forms -------------------//
       
        private void userProfilebutton16_Click(object sender, EventArgs e)
        {
            userSettings userSettings = new userSettings();
            DisplayForm(userSettings);
        }

        private void addNewUer_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            DisplayForm(users);
        }


        //------------------ Display Commodity Forms -------------------//
        

        private void settingsbutton25_Click(object sender, EventArgs e)
        {
            SysSettingsForm sysSettingsForm = new SysSettingsForm();
            DisplayForm(sysSettingsForm);
        }


        //------------------ Display Cam Forms -------------------//
      

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
                    DisplayForm(pcam);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        //private void siteCambutton15_Click(object sender, EventArgs e)
        //{
        //    Cams cams = new Cams();
        //    cams.ShowDialog();
        //}

        //private void cam_NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cam_NameComboBox.SelectedIndex >= 0)
        //    {
        //        try
        //        {
        //            Properties.Settings.Default.areacam = cam_NameComboBox.SelectedIndex;
        //            // MessageBox.Show("Cam number : " + cam_NameComboBox.SelectedIndex);
        //            //Properties.Settings.Default.Upgrade();
        //            Properties.Settings.Default.Save();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message + "er1");
        //        }
        //    }

        //}

        //private void cam_NameComboBox_Click(object sender, EventArgs e)
        //{

        //    if (cam_NameComboBox.Items.Count < 1)
        //    {
        //        // TODO: This line of code loads data into the 'dLWSDataSet.Camera' table. You can move, or remove it, as needed.
        //        this.cameraTableAdapter.Fill(this.dLWSDataSet.Camera);
        //        if (this.dLWSDataSet.Camera.Rows.Count > 0)
        //        {
        //            for (int i = 0; i < dLWSDataSet.Camera.Rows.Count; i++)
        //            {
        //                cam_NameComboBox.Items.Insert(i, this.dLWSDataSet.Camera[i][1]);

        //            }
        //            cam_NameComboBox.SelectedIndex = 0;
        //        }
        //        else
        //        {
        //            MessageBox.Show("لا يوجد كاميرات مسجلة");
        //        }
        //    }
        //}

        //private void label1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}



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


        private void buttondailyout_Click(object sender, EventArgs e)
        {
            OutDailyreport reporting = new OutDailyreport();
            DisplayForm(reporting);
           
        }

        private void customersMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button11dailyIn_Click(object sender, EventArgs e)
        {

            INSHiftViewer iNSHiftViewer = new INSHiftViewer();
            DisplayForm(iNSHiftViewer);
           

        }

        private void button10sumIn_Click(object sender, EventArgs e)
        {
            INReportingViewer iNReportingViewer = new INReportingViewer();
            DisplayForm(iNReportingViewer);

        }


        //private void button4_Click(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'dLWSDataSet.Camera' table. You can move, or remove it, as needed.
        //    this.cameraTableAdapter.Fill(this.dLWSDataSet.Camera);
        //    cam_NameComboBox.Items.Clear();
        //    for (int i = 0; i < dLWSDataSet.Camera.Rows.Count; i++)
        //    {
        //        cam_NameComboBox.Items.Insert(i, this.dLWSDataSet.Camera[i][1]);

        //    }
        //}

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
