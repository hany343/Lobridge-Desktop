using System;
using System.IO.Ports;
using System.Windows.Forms;
namespace LoBridge
{
    public partial class WScreen : Form
    {

        private SerialPort _serialPort;         //<-- declares a SerialPort Variable to be used throughout the form
        private const int BaudRate = 9600;      //<-- BaudRate Constant. 9600 seems to be the scale-units default value
        string wh = "";
        public int weight = 0;


        public WScreen()
        {
            InitializeComponent();
        }

        private void checkserial(object sender, EventArgs e)
        {
            Screen1.ForeColor = System.Drawing.Color.Red;

            Screen1.Text = "Error";


        }
        private void WScreen_Load(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(checkserial);
            timer1.Start();


            if (Properties.Settings.Default.Urole <= 2)
            {
                Screen1.ReadOnly = false;
            }

            try
            {
                if (_serialPort != null)
                {
                    _serialPort.Close();
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                new_sport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " الميزان غير متصل ");
                // WConnected.Visible = false;
            }

        }
        bool stopped = false;
        public void stopW()
        {
            if (stopped)
            {

                try
                {
                    new_sport();
                    stopped = false;
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message + " الميزان غير متصل ");
                    // WConnected.Visible = false;
                }

            }
            else
            {
                try
                {
                    if (_serialPort != null)
                    {
                        _serialPort.Close();
                        stopped = true;
                        Screen1.Text = "متوقف!";
                    }
                }
                catch (Exception ex)
                {

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
                timer1.Stop();
                timer1.Start();
                Screen1.ForeColor = System.Drawing.Color.Green;
                int dataLength = _serialPort.BytesToRead;
                byte[] data = new byte[dataLength];
                int nbrDataRead = _serialPort.Read(data, 0, dataLength);
                if (nbrDataRead == 0)
                    return;
                string str = System.Text.Encoding.UTF8.GetString(data);
                wh += str.ToString();
                if (wh.ToString().Contains("\r\n"))
                {
                    if (wh.Length > 42)
                    {
                        // statusTextBox.BackColor = System.Drawing.Color.Red;
                        try
                        {
                            weight = int.Parse(wh.Substring(6, 9).Trim());
                            Screen1.Text = weight + "";
                            Screen1.BackColor = System.Drawing.Color.White;
                        }
                        catch (Exception e)
                        {
                            Screen1.BackColor = System.Drawing.Color.DarkRed;

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
                if (_serialPort != null)
                {
                    _serialPort.Close();
                }
            }
            catch (Exception ex)
            {

            }

            string co = Properties.Settings.Default.serialcom;// +  SporttextBox1.Text;
            _serialPort = new SerialPort(co, BaudRate, Parity.None, 8, StopBits.One);       //<-- Creates new SerialPort using the name selected in the combobox
            _serialPort.DataReceived += SerialPortOnDataReceived;       //<-- this event happens everytime when new data is received by the ComPort
            _serialPort.Open();     //<-- make the comport listen
                                    // MessageBox.Show("Com Connected");
                                    // WConnected.Visible = true;
        }

        private void WScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (_serialPort != null)
                {
                    _serialPort.Close();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void Screen1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                new_sport();
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message + " الميزان غير متصل ");
                // WConnected.Visible = false;
            }
        }

        private void WScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPort.Close();
        }

        private void Screen1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Properties.Settings.Default.Urole <= 2)
            {
                timer1.Interval = 10000;
                timer1.Stop();
            }
        }
    }
}
