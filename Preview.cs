using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;

using System.Runtime.InteropServices;

namespace LoBridge
{
    /// <summary>
    /// Form1 ��ժҪ˵����
    /// </summary>
    public class PreviewCamera : System.Windows.Forms.Form
    {
        string dvip;
        string uname;
        string pass;

        private uint iLastErr = 0;
        private Int32 m_lUserID = -1;
        private Int32 m_lUserID2 = -1;
        private bool m_bInitSDK = false;
        private bool m_bRecord = false;
        private bool m_bTalk = false;
        private Int32 m_lRealHandle = -1;
        private int lVoiceComHandle = -1;
        private string str;

        CHCNetSDK.REALDATACALLBACK RealData = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg;
        public System.Windows.Forms.PictureBox RealPlayWnd;
        /*private Button PtzGet;
        private Button PtzSet;*/
        private Label label19;
        /*private ComboBox comboBox1;
        private TextBox textBoxPanPos;
        private TextBox textBoxTiltPos;
        private TextBox textBoxZoomPos;*/
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox cam_IPTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Panel panel1;
        private Button button1;
        private Button ExitBtn;
        private IContainer components;

        //private GroupBox groupBox1;

        public PreviewCamera(
        string dvip1,
        string uname1,
        string pass1)
        {
            //
            // Windows ���������֧���������
            //
            dvip= dvip1;
            uname= uname1;
            pass= pass1;

            InitializeComponent();
            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            else
            {
                //����SDK��־ To save the SDK log
                CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
            }
            //
            // TODO: �� InitializeComponent ���ú�����κι��캯������
            //
        }

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (m_lRealHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
            }
            if (m_lUserID >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID);
            }
            if (m_bInitSDK == true)
            {
                CHCNetSDK.NET_DVR_Cleanup();
            }
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���
        /// <summary>
        /// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
        /// �˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label cam_IPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewCamera));
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.RealPlayWnd = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            cam_IPLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cam_IPLabel
            // 
            resources.ApplyResources(cam_IPLabel, "cam_IPLabel");
            cam_IPLabel.Name = "cam_IPLabel";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(usernameLabel, "usernameLabel");
            usernameLabel.Name = "usernameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.Name = "passwordLabel";
            // 
            // RealPlayWnd
            // 
            this.RealPlayWnd.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.RealPlayWnd, "RealPlayWnd");
            this.RealPlayWnd.Name = "RealPlayWnd";
            this.RealPlayWnd.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.RealPlayWnd);
            this.panel1.Name = "panel1";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitBtn.BackgroundImage = global::LoBridge.Properties.Resources.exit;
            resources.ApplyResources(this.ExitBtn, "ExitBtn");
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            // 
            // PreviewCamera
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreviewCamera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Preview_Load);
            this.Shown += new System.EventHandler(this.PreviewCamera_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// Ӧ�ó��������ڵ㡣
        /// </summary>
        //[STAThread]
        //static void Main() 
        //{
        //	Application.Run(new PreviewCamera());
        //}

        public void blogin()
        {

            //if (m_lRealHandle >= 0)
            //{
            //    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
            //}
            //if (m_lUserID >= 0)
            //{
            //    CHCNetSDK.NET_DVR_Logout(m_lUserID);
            //}
            //if (m_bInitSDK == true)
            //{
            //    CHCNetSDK.NET_DVR_Cleanup();
            //}
            // MessageBox.Show("loging");
            if (m_lUserID < 0)
            {
                string DVRIPAddress = dvip; //�豸IP��ַ��������
                Int16 DVRPortNumber = 8000;// Int16.Parse(8000+"");//�豸����˿ں�
                string DVRUserName = uname;//�豸��¼�û���
                string DVRPassword = pass;//�豸��¼����

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                //��¼�豸 Login the device
                m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                
                if (m_lUserID < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //��¼ʧ�ܣ���������
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                  //  MessageBox.Show("pre");
                    bpreview();
                    // btnLogin.Text = "Logout";
                }

            }
            else
            {
                //ע����¼ Logout the device
                if (m_lRealHandle >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Logout failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                m_lUserID = -1;
                // btnLogin.Text = "Login";
            }

            return;
        }

        public void bpreview()
        {
            if (m_lUserID < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();

                lpPreviewInfo.hPlayWnd = RealPlayWnd.Handle;

                //Ԥ������
                lpPreviewInfo.lChannel = Int16.Parse(1 + "");//Ԥte�����豸ͨ��
                lpPreviewInfo.dwStreamType = 0;//�������ͣ�0-��������1-��������2-����3��3-����4���Դ�����
                lpPreviewInfo.dwLinkMode = 0;//���ӷ�ʽ��0- TCP��ʽ��1- UDP��ʽ��2- �ಥ��ʽ��3- RTP��ʽ��4-RTP/RTSP��5-RSTP/HTTP 
                lpPreviewInfo.bBlocked = true; //0- ������ȡ����1- ����ȡ��
                lpPreviewInfo.dwDisplayBufNum = 1; //���ſⲥ�Ż�������󻺳�֡��
                lpPreviewInfo.byProtoType = 0;
                lpPreviewInfo.byPreviewMode = 0;


                if (RealData == null)
                {
                    RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);//Ԥ��ʵʱ���ص�����
                }

                IntPtr pUser = new IntPtr();//�û�����

                //��Ԥ�� Start live view 
                m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);

                //m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID2, ref lpPreviewInfo2, null/*RealData*/, pUser); //22222
                if (m_lRealHandle < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr; //Ԥ��ʧ�ܣ���������
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    //Ԥ���ɹ�
                    // btnPreview.Text = "Stop Live View";
                }
            }
            else
            {
                //ֹͣԤ�� Stop live view 
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                m_lRealHandle = -1;

            }
            return;
        }
        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
            if (dwBufSize > 0)
            {
                byte[] sData = new byte[dwBufSize];
                Marshal.Copy(pBuffer, sData, 0, (Int32)dwBufSize);

                string str = "ʵʱ������.ps";
                FileStream fs = new FileStream(str, FileMode.Create);
                int iLen = (int)dwBufSize;
                fs.Write(sData, 0, iLen);
                fs.Close();
            }
        }

        private void btnBMP_Click(object sender, EventArgs e)
        {
            string sBmpPicFileName;
            //ͼƬ����·�����ļ��� the path and file name to save
            sBmpPicFileName = "BMP_test.bmp";

            //BMPץͼ Capture a BMP picture
            if (!CHCNetSDK.NET_DVR_CapturePicture(m_lRealHandle, sBmpPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CapturePicture failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }
            else
            {
                str = "Successful to capture the BMP file and the saved file is " + sBmpPicFileName;
                MessageBox.Show(str);
            }
            return;
        }

        private void btnJPEG_Click(object sender, EventArgs e)
        {
            string sJpegPicFileName;
            //ͼƬ����·�����ļ��� the path and file name to save
            sJpegPicFileName = @"D:\WCam\ " + Properties.Settings.Default.WBridge + " " + Properties.Settings.Default.SHOT + ".jpg";
            //Properties.Settings.Default.
            //MessageBox.Show(System.DateTime.Now.ToString() + "  " + System.DateTime.Now.ToShortDateString());
            int lChannel = 0;//Int16.Parse(textBoxChannel.Text); //ͨ���� Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //ͼ������ Image quality
            lpJpegPara.wPicSize = 0xff; //ץͼ�ֱ��� Picture size: 2- 4CIF��0xff- Auto(ʹ�õ�ǰ�����ֱ���)��ץͼ�ֱ�����Ҫ�豸֧�֣�����ȡֵ��ο�SDK�ĵ�

            //JPEGץͼ Capture a JPEG picture
            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }
            else
            {
                str = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName;
                MessageBox.Show(str);
            }
            return;
        }
        public void CaptureW(string type, string id, string shot)
        {
            string sJpegPicFileName = "";
            if (type == "INW")
            {
                if (shot == "F")
                {
                    //ͼƬ����·�����ļ��� the path and file name to save
                    sJpegPicFileName = @"D:\WCam\Incoming\ " + Properties.Settings.Default.WBridge + " " + id + shot + ".jpg";
                }
                if (shot == "S")
                {
                    //ͼƬ����·�����ļ��� the path and file name to save
                    sJpegPicFileName = @"D:\WCam\Incoming\ " + Properties.Settings.Default.WBridge + " " + id + shot + ".jpg";
                }
            }
            else if (type == "OUTW")
            {
                if (shot == "F")
                {
                    //ͼƬ����·�����ļ��� the path and file name to save
                    sJpegPicFileName = @"D:\WCam\OutGoing\ " + Properties.Settings.Default.WBridge + " " + id + shot + ".jpg";
                }
                if (shot == "S")
                {
                    //ͼƬ����·�����ļ��� the path and file name to save
                    sJpegPicFileName = @"D:\WCam\OutGoing\ " + Properties.Settings.Default.WBridge + " " + id + shot + ".jpg";
                }
            }
            else
            {

            }  //Properties.Settings.Default.
            //MessageBox.Show(System.DateTime.Now.ToString() + "  " + System.DateTime.Now.ToShortDateString());
            int lChannel = 1;// Int16.Parse(textBoxChannel.Text); //ͨ���� Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //ͼ������ Image quality
            lpJpegPara.wPicSize = 0xff; //ץͼ�ֱ��� Picture size: 2- 4CIF��0xff- Auto(ʹ�õ�ǰ�����ֱ���)��ץͼ�ֱ�����Ҫ�豸֧�֣�����ȡֵ��ο�SDK�ĵ�

            //JPEGץͼ Capture a JPEG picture
            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                //MessageBox.Show(str);
                return;
            }
            else
            {
                str = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName;
                //MessageBox.Show(str);
            }
            return;
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            //¼�񱣴�·�����ļ��� the path and file name to save
            string sVideoFileName;
            sVideoFileName = "Record_test.mp4";

            if (m_bRecord == false)
            {
                //ǿ��I֡ Make a I frame
                int lChannel = 0;// Int16.Parse(textBoxChannel.Text); //ͨ���� Channel number
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID, lChannel);

                //��ʼ¼�� Start recording
                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle, sVideoFileName))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_SaveRealData failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    // btnRecord.Text = "Stop Record";
                    m_bRecord = true;
                }
            }
            else
            {
                //ֹͣ¼�� Stop recording
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    str = "Successful to stop recording and the saved file is " + sVideoFileName;
                    MessageBox.Show(str);
                    //  btnRecord.Text = "Start Record";
                    m_bRecord = false;
                }
            }

            return;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //ֹͣԤ�� Stop live view 
            if (m_lRealHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
                m_lRealHandle = -1;
            }

            //ע����¼ Logout the device
            if (m_lUserID >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID);
                m_lUserID = -1;
            }

            CHCNetSDK.NET_DVR_Cleanup();

            Application.Exit();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            //int areacode = Properties.Settings.Default.areacam;
            //this.Dock = DockStyle.Fill;
            //if (areacode >= 0)
            //{

            //    // TODO: This line of code loads data into the 'dLWSDataSet.Camera' table. You can move, or remove it, as needed.
            //   // this.cameraTableAdapter.FillBy(this.dLWSDataSet.Camera, areacode);

            //}
            //else
            //{
            //    MessageBox.Show("Define area code");
            //}
        }


        private void PreSet_Click(object sender, EventArgs e)
        {
            //PreSet dlg = new PreSet();
            //dlg.m_lUserID = m_lUserID;
            //dlg.m_lChannel = 1;
            //dlg.m_lRealHandle = m_lRealHandle;
            //dlg.ShowDialog();

        }

        private void PreviewCamera_Shown(object sender, EventArgs e)
        {

            try
            {
                    blogin();
                
                
            }
            catch (Exception ex)
            {

            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
