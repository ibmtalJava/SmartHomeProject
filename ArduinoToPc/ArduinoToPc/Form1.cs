using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace ArduinoToPc
{
    public partial class Form1 : Form
    {
        public ArduinoCommand ac;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ac= new ArduinoCommand();   
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {                         
                ac.setSerialPort(
                    System.Convert.ToInt32(portBautRate.Text)
                    , portName.Text
                );
                connectStatus.Text = "Connected.....";
                timer1.Enabled = true;
                timer1.Interval = 1000;
            }
            catch (Exception ex) {
                connectStatus.Text = "Connection Error...";
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                ac.serialPort.Close();
                connectStatus.Text = "Disconnected...";
            }
            catch (Exception ex)
            {
               
            }
            timer1.Enabled = false;

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                ac.send(modul.Text, action.Text, data1.Text, data2.Text, data3.Text);
            }
            catch (Exception ex)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
               gelenveri.Text=ac.serialPort.ReadExisting();
            }
            catch (Exception ex) { 
            
            }
        }
        public class LightData { 
            public int id { get; set; }
            public string code { get; set; }
            public string info { get; set; }
            public int status { get; set; }
        }
        public class ApiError { 
            public int code { get; set; }   
            public string context { get; set; }
            public string itemName { get; set; }

        }
        public class LightsApiData { 
            public Boolean success { get; set; }
            public ApiError[] errors { get; set; }
            public LightData[] data { get; set; }
          

        }
        public int lastLight=0;
        public LightsApiData lights;
        private void button1_Click(object sender, EventArgs e)
        {
 
 
        }

        private void lightsTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string url = "https://onlineshop.ibmtal.com/api/index.php?api=smartHomeLight_getAll";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStreem = response.GetResponseStream();
                    StreamReader reader = new StreamReader(receiveStreem);
                    string data = reader.ReadToEnd();
                    lights = JsonConvert.DeserializeObject<LightsApiData>(data);
                    if (lights.success) { 
                        lightsListBox.Items.Clear();
                        for (int i = 0; i < lights.data.Length; i++) { 
                            lightsListBox.Items.Add(lights.data[i].code+" -> "
                                +lights.data[i].status);    
                        } 
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        //smartLight apisinden gelen verileri arduinoya sıra ile gönderme
        private void lightArduinoSend_Tick(object sender, EventArgs e)
        {
            try
            {
                if(lights!=null)
                if (lights.data!=null)
                {
                    if (lastLight >= lights.data.Length) lastLight = 0;
                        if (ac.serialPort.IsOpen) ac.send(
                        "light" //arduino modülü
                        , lights.data[lastLight].code // action
                        , lights.data[lastLight].status.ToString() //data1 0 ise söndür 1 ise yak
                        , "0"//data2 ye gerek yok
                        , "0"//data3 e gerek yok

                    );
                    lastLight++;
                }
            }
            catch { }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ac.send(
                       "light" //arduino modülü
                       , "onkapi" // action
                       , "1" //data1 0 ise söndür 1 ise yak
                       , "0"//data2 ye gerek yok
                       , "0"//data3 e gerek yok

                   );
        }
    }
}
