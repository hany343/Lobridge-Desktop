using System;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace DWS
{
    public partial class LoadingWCard : Form
    {
        private SerialPort _serialPort;         //<-- declares a SerialPort Variable to be used throughout the form
        private const int BaudRate = 9600;      //<-- BaudRate Constant. 9600 seems to be the scale-units default value
        string wh = "";
        int weight = 0;
        private string Wtype = "in";
        string username = "";

        public LoadingWCard(string uname, string wtype)
        {
            Wtype = wtype;
            username = uname;
            InitializeComponent();

        }
        
        private void SaveButtonClick(object sender, EventArgs e)
        {
            sweightbox.Enabled = true;
            weigher_nameTextBox.Text = username;
            if (sweightbox.Text.Length > 1)
            {
                TimeOut_label12.Text = DateTime.Now.ToString("hh:mm tt");
                sweightbox.Enabled = false;
                PrintCardBtn.Enabled = true;
            }
            this.Validate();
            this.loadingCardBindingSource.EndEdit();
            try
            {
                
                this.tableAdapterManager.UpdateAll(this.wdbDataSet);
                firstweightbox.Enabled = false;
                MessageBox.Show("تم حفظ البيانات بنجاح");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error Code WCard 88");
            }

        }

        private void WCardIn_Load(object sender, EventArgs e)
        {
            int lAstWcardID = 0;
            weigher_nameTextBox.Text = username;
            try
            {
                new_sport();
                WCard_IDLabel.Text = lAstWcardID + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error weight port");
            }

            TimeInLabel.Text = DateTime.Now.ToString("hh:mm tt");
            dateLabel1.Text = System.DateTime.Today.ToShortDateString(); //ToString("yyyy-MM-dd");
        }
        
        public void loadfill()
        {
            if (RCard_IDbox.Text.Length > 0)
            {
                SaveBtn.Enabled = true;
                try
                {
                    this.loadingCardTableAdapter.FillByloadcard(this.wdbDataSet.LoadingCard, int.Parse(RCard_IDbox.Text.ToString()));
                    RCard_IDbox.BackColor = System.Drawing.Color.White;
                    
                }
                catch (Exception ex)
                {
                    RCard_IDbox.BackColor = System.Drawing.Color.Red;

                    MessageBox.Show(" رقم كارت الاستلام غير موجود");
                }
                
                if (firstweightbox.Text.Length < 2)
                {

                    firstweightbox.Enabled = true;
                    sweightbox.Enabled = false;
                   
                    weigher_nameTextBox.Text = username;

                }
                else if (firstweightbox.Text.Length >= 2 && sweightbox.Text.Length < 2)
                {
                    weigher_nameTextBox.Text = username;
                    TimeOut_label12.Text = DateTime.Now.ToShortTimeString();
                    sweightbox.Enabled = true;
                    firstweightbox.Enabled = false;
                }
                else if (firstweightbox.Text.Length >= 2 && sweightbox.Text.Length >= 2)
                {
                    try
                    {

                        int fweightvalue = int.Parse(firstweightbox.Text);
                        int sweightvalue = int.Parse(sweightbox.Text);
                        int netw = sweightvalue - fweightvalue;// float.Parse(weight_netTextBox.Text.ToString()); //int.Parse(firstweightbox.Text) - int.Parse(sweightbox.Text);


                        float qty = float.Parse(qTYTextBox.Text);
                        qty = qty * 1000;
                        float qdif = qty - Math.Abs(netw);
                        if (qdif < 0)
                        {
                            label4.Text = "زيادة";
                            shrink.BackColor = System.Drawing.Color.Red;
                            //  this.shrinklabel.
                        }
                        else
                        {
                            label4.Text = "العجز";
                            shrink.BackColor = System.Drawing.Color.White;
                        }

                        Math.Abs(qdif);
                        shrink.Text = qdif + "   KG";
                       // weight_netTextBox.Text = Math.Abs(netw) + "";
                    }
                    catch (Exception ec)
                    {

                    }

                    firstweightbox.Enabled = false;
                    sweightbox.Enabled = false;
                    PrintCardBtn.Enabled = true;
                    SaveBtn.Enabled = false;
                }
            }
        }
        private void boxfirstweight_TextChanged(object sender, EventArgs e)
        {
            //if (firstweightbox.Text.Length >= 2 && firstweightbox.Text != "0")
            //{
                
            //    SaveBtn.Enabled = true;
            //    boxpakcount.Enabled = true;
            //    boxstackbar.Enabled = true;
            //}
            //else
            //{
            //    SaveBtn.Enabled = false;
            //    boxpakcount.Enabled = false;
            //    boxstackbar.Enabled = false;
            //}
        }

        private void Boxsecweight_TextChanged(object sender, EventArgs e)
        {
            //if (sweightbox.Text.Length > 0)
            //{
            //    try
            //    {

            //        float netw = float.Parse(weight_netTextBox.Text.ToString()); //int.Parse(firstweightbox.Text) - int.Parse(sweightbox.Text);
            //        Math.Abs(netw);

            //        float qty = float.Parse(qTYTextBox.Text);
            //        qty = qty * 1000;
            //        float qdif = qty - netw;
            //        Math.Abs(qdif);
            //        shrink.Text = qdif + "   KG";
            //        weight_netTextBox.Text = netw + "";
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Close();
                new_sport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RCard_IDbox.Text.Length > 0)
            {
                try
                {
                    Print_Wcard f1 = new Print_Wcard(int.Parse(RCard_IDbox.Text.ToString()),"in");
                    f1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("أدخل رقم الكارت");
            }
        }

        private void RCard_IDbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                loadfill();
            }
        }

        private void firstweightbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sweightbox.Text.Length < 2)
            {
                try
                {

                    firstweightbox.Text = int.Parse(Boxweight.Text.Trim().ToString()) + "";
                    TimeInLabel.Text = DateTime.Now.ToShortTimeString();
                    dateLabel1.Text = System.DateTime.Today.ToShortDateString(); //ToString("yyyy-MM-dd");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "  حاول مرة اخري");
                }
            }
        }

        private void sweightbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (firstweightbox.Text.Length > 2)
            {
                try
                {
                    TimeOut_label12.Text = DateTime.Now.ToShortTimeString();

                    sweightbox.Text = int.Parse(Boxweight.Text.Trim().ToString()) + "";
                    try
                    {
                        int fweightvalue = int.Parse(firstweightbox.Text);
                        int sweightvalue = int.Parse(sweightbox.Text);
                        int netw = sweightvalue - fweightvalue;// float.Parse(weight_netTextBox.Text.ToString()); //int.Parse(firstweightbox.Text) - int.Parse(sweightbox.Text);
                        
                       
                        float qty = float.Parse(qTYTextBox.Text);
                        qty = qty * 1000;
                        float qdif = qty - Math.Abs(netw);
                        if (qdif < 0)
                        {
                            label4.Text = "زيادة";
                            shrink.BackColor = System.Drawing.Color.Red;
                            //  this.shrinklabel.
                        }
                        else
                        {
                            label4.Text = "العجز";
                            shrink.BackColor = System.Drawing.Color.White;
                        }

                        Math.Abs(qdif);
                        shrink.Text = qdif + "   KG";
                        weight_netTextBox.Text = Math.Abs(netw) + "";


                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.Message + " Error in weight");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "  حاول مرة اخري");
                }
            }
        }

    
    private delegate void Closure();
    //serial port get data
    private void SerialPortOnDataReceived(object sender, SerialDataReceivedEventArgs serialDataReceivedEventArgs)
    {
        if (InvokeRequired)     //<-- Makes sure the function is invoked to work properly in the UI-Thread
            BeginInvoke(new Closure(() => { SerialPortOnDataReceived(sender, serialDataReceivedEventArgs); }));     //<-- Function invokes itself
        else
        {
            int dataLength = _serialPort.BytesToRead;
            byte[] data = new byte[dataLength];
            int nbrDataRead = _serialPort.Read(data, 0, dataLength);
            if (nbrDataRead == 0)
                return;
            string str = System.Text.Encoding.UTF8.GetString(data);
            wh += str.ToString();
                Boxweight.Text = str.ToString() + "";
                if (wh.ToString().Contains("\r\n"))
            {
                if (wh.Length > 42)
                {
                    try
                    {
                        weight = int.Parse(wh.Substring(6, 9).Trim());
                        Boxweight.Text = weight + "";
                        Boxweight.BackColor = System.Drawing.Color.White;
                    }
                    catch (Exception e)
                    {
                        // MessageBox.Show("invalid weight");
                        Boxweight.BackColor = System.Drawing.Color.Red;
                        
                    }
                }
                wh = "";
            }
        }

    }
        public void new_sport()
        {
            try
            {
                _serialPort.Close();
            }
            catch (Exception ex)
            {

            }
            string co = "COM" + SporttextBox1.Text;
            _serialPort = new SerialPort(co, BaudRate, Parity.None, 8, StopBits.One);       //<-- Creates new SerialPort using the name selected in the combobox
            _serialPort.DataReceived += SerialPortOnDataReceived;       //<-- this event happens everytime when new data is received by the ComPort
            _serialPort.Open();     //<-- make the comport listen
                                    // MessageBox.Show("Com Connected");
        }
        private void WCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { 
            _serialPort.Close();
        }
            catch (Exception ex)
            {

            }
        }

        
    }
}

