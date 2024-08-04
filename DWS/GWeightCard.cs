using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DWS
{
    public partial class GWeightCard : Form
    {
        string weigher = "";

        public GWeightCard(string wname)
        {
            weigher = wname;
           
            InitializeComponent();
           
        }

        private void GWeightCard_Load(object sender, EventArgs e)
        {
           
            new_sport();
            iN_OUTTextBox.Text = "وارد";


            //string text = this.citybox.Text;
            string[] suggestions = new string[] {"الإسكندرية","الدقهلية","الغربية","كفر الزيات","الإسماعيلية","أسوان","أسيوط","الأقصر","الغردقة","دمنهور","بني سويف","بورسعيد","الطور","الجيزة","المنصورة","دمياط","سوهاج",
                "السويس","الزقازيق","العريش","طنطا","الفيوم","القاهرة","بنها","قنا","كفر الشيخ","مرسى مطروح","شبين الكوم","المنيا"};

            this.citybox.AutoCompleteCustomSource.Clear();
            this.citybox.AutoCompleteCustomSource.AddRange(suggestions);

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                iN_OUTTextBox.Text = "وارد";
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                iN_OUTTextBox.Text = "صادر";
            }
            else
            {
                checkBox2.Checked = true;
            }
        }
        private delegate void Closure();
        string wh = "";
        int weight = 0;
        private SerialPort _serialPort;         //<-- declares a SerialPort Variable to be used throughout the form
        private const int BaudRate = 9600;
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
                try
                {
                    _serialPort.Close();
                }
                catch (Exception ex)
                {

                }
                string co = "COM" + SporttextBox1.Text;
                _serialPort = new SerialPort(co, 9600, Parity.None, 8, StopBits.One);       //<-- Creates new SerialPort using the name selected in the combobox
                _serialPort.DataReceived += SerialPortOnDataReceived;       //<-- this event happens everytime when new data is received by the ComPort
                _serialPort.Open();     //<-- make the comport listen
                                        // MessageBox.Show("Com Connected");
            }
            catch (Exception ex)
            {
               //MessageBox.Show("Com not Connected");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int lstwcrdid = 0;
            button1.Enabled = false;
            enableBoxs();
            
            try
            {
                lstwcrdid = int.Parse(this.gWCardTableAdapter.LastGWcard().ToString());
                this.gWCardTableAdapter.FillBy(this.wdbDataSet.GWCard, 0);
                 weigher_nameTextBox.Text = weigher;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message+"e1");
            }
            lstwcrdid++;
            if (checkBox1.Checked == true)
            {
                iN_OUTTextBox.Text = "وارد";
            }
            else
            {
                iN_OUTTextBox.Text = "صادر";
            }
            sweightbox.Text = "0";
            boxpakcount.Text = "0";
            WCard_IDBox.Text = lstwcrdid + "";
            weigher_nameTextBox.Text = weigher;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
        }
        public void enableBoxs()
        {
            CommTypebox.Enabled = true;
            tRUCK_IDTextBox.Enabled = true;
            tRAILERTextBox.Enabled = true;
            wCNotesTextBox.Enabled = true;
            dRIVER_NAMETextBox.Enabled = true;
            firstweightbox.Enabled = true;
            boxstackbar.Enabled = true;
            boxpakcount.Enabled = true;
            Sup_ClientName.Enabled = true;
            citybox.Enabled = true;
        }
        public void disablefields()
        {
            sweightbox.Enabled = false;
            CommTypebox.Enabled = false;
            tRUCK_IDTextBox.Enabled = false;
            tRAILERTextBox.Enabled = false;
            wCNotesTextBox.Enabled = false;
            dRIVER_NAMETextBox.Enabled = false;
            firstweightbox.Enabled = false;
            boxstackbar.Enabled = false;
            boxpakcount.Enabled = false;
            Sup_ClientName.Enabled = false;
            citybox.Enabled = false;
            SaveBtn.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
        }
        private void firstweightbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sweightbox.Text.Length < 2)
            {
                try
                {

                    firstweightbox.Text = int.Parse(Boxweight.Text.Trim().ToString()) + "";
                    TimeInLabel.Text = DateTime.Now.ToShortTimeString();
                    dateLabel1.Text = System.DateTime.Today.ToShortDateString();//ToString("yyyy-MM-dd");

                    firstweightbox.Enabled = false;
                    SaveBtn.Enabled = true;
                   // sweightbox.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "  حاول مرة اخري");
                }
            }
        }
       
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if (sweightbox.Text.Length > 1)
            {
                TimeOut_label12.Text = DateTime.Now.ToShortTimeString();
                this.gWCardTableAdapter.UpdateQuery1(TimeOut_label12.Text, int.Parse(sweightbox.Text), int.Parse(boxpakcount.Text), boxstackbar.Text, wCNotesTextBox.Text,weigher_nameTextBox.Text,wcd,wcd);
               
                disablefields();
            }
            else
            {
                try
                {
                    //MessageBox.Show( " " + WCard_IDBox.Text.Trim().ToString());
                    int wgc = int.Parse(WCard_IDBox.Text.Trim().ToString());
                    //MessageBox.Show(wgc+" "+ WCard_IDBox.Text.Trim().ToString());
                    this.gWCardTableAdapter.InsertQuery1(CommTypebox.Text+"", dateLabel1.Text + "", TimeInLabel.Text + "", TimeOut_label12.Text + "", int.Parse(firstweightbox.Text), int.Parse(sweightbox.Text), iN_OUTTextBox.Text + "",
                        int.Parse(boxpakcount.Text), boxstackbar.Text + "", wCNotesTextBox.Text + "", "NO", weigher_nameTextBox.Text + "", dRIVER_NAMETextBox.Text + "", tRUCK_IDTextBox.Text + "", tRAILERTextBox.Text + "", Sup_ClientName.Text + "", citybox.Text + "", wgc);
                    disablefields();
                    MessageBox.Show("تم الحفظ  بنجاح");
}
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Error Code WCard 198");
                }
            }
        }

        private void sweightbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (firstweightbox.Text.Length > 2)
            {
                weigher_nameTextBox.Text = weigher + "";
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                try
                {
                    TimeOut_label12.Text = DateTime.Now.ToShortTimeString();
                    sweightbox.Text = int.Parse(Boxweight.Text.Trim().ToString()) + "";
                    try
                    {
                        int netw = int.Parse(firstweightbox.Text) - int.Parse(sweightbox.Text);
                        Math.Abs(netw);
                        weight_netTextBox.Text = netw + "";

                        firstweightbox.ReadOnly = true;
                        sweightbox.ReadOnly = true;

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
        SecondWeight sw;
        int wcd = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            sw = new SecondWeight();
            sw.FormClosing += new FormClosingEventHandler(formclosing);
            
            sw.ShowDialog();

            this.gWCardTableAdapter.FillBy(wdbDataSet.GWCard, wcd);
            WCard_IDBox.Text = "" + wcd;
            firstweightbox.Enabled = false;
            sweightbox.Enabled = true;
            SaveBtn.Enabled = true;
           
        }
        private void formclosing(object sender, EventArgs e)
        {
            wcd = sw.wcidnumber;

         }

        private void PrintCardBtn_Click(object sender, EventArgs e)
        {
            int gwc = 0;

                try
                {
                gwc = int.Parse(WCard_IDBox.Text.ToString());

               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            if (WCard_IDBox.Text.ToString().Length > 0)
            {
                Print_Wcard f1 = new Print_Wcard(gwc, "g");
                f1.Show();
            }
        }

        private void GWeightCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                _serialPort.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void sweightbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
