using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; //for Dllimport

namespace MouseWithAccelerometer
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
        bool btConnectIsPressed = false;
        bool controlIsEnabled = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (btConnectIsPressed == false)
            {
                try
                {
                    mySerialPort.PortName = "COM3";
                    mySerialPort.BaudRate = 9600;
                    mySerialPort.Open();
                    btConnectIsPressed = true;
                    btConnect.Text = "Disconnect";

                    rtbInfo.AppendText("Connection was initiated!\n");
                    rtbInfo.AppendText("PortName" + mySerialPort.PortName.ToString() + "\n");
                    rtbInfo.AppendText("BaudRate" + mySerialPort.BaudRate.ToString() + "\n");
                    rtbInfo.AppendText("Port is open:" + mySerialPort.IsOpen.ToString() + "\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                try
                {
                    mySerialPort.Close();
                    btConnectIsPressed = false;
                    btConnect.Text = "Connect";

                    rtbInfo.AppendText("\nConnection was terminated!\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            
        }

        private void mySerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = mySerialPort.ReadExisting();
            

            this.Invoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {
            rtbInfo.AppendText(RxString);
            this.Invoke(new EventHandler(ProcessClick));
        }

        private void ProcessClick(object sender, EventArgs e)
        {
            if (cbMouseControl.CheckState == CheckState.Checked)
                DoMouseClick();
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

    }
}
