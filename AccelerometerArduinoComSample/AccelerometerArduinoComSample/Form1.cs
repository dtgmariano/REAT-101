using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Mouse_Click_Sample
{

    public partial class Form1 : Form
    {
        int count;
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        string RxString;

        string xc;

        public Form1()
        {
            InitializeComponent(); 
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            count++;
            label1.Text = count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DoMouseClick();
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM6";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void DisplayText(object sender, EventArgs e)
        {
            //int ul1 = RxString.IndexOf('_');
            //int ul2 = RxString.LastIndexOf('_');
            //xc = (RxString.Substring(0,ul1));
            //coords[1] = Convert.ToInt32(RxString.Substring(ul1+1, ul2-ul1));
            //coords[2] = Convert.ToInt32(RxString.Substring(ul2 + 1, RxString.Length - ul2));
            //richTextBox1.AppendText(coords[0] + "\t" + coords[1] + "\t" + coords[2]);

            richTextBox1.AppendText(RxString);
            //richTextBox2.AppendText(xc);
        }


    }
}
