namespace MouseWithAccelerometer
{
    partial class Form1
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.btConnect = new System.Windows.Forms.Button();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.cbMouseControl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(388, 229);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(12, 247);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // mySerialPort
            // 
            this.mySerialPort.PortName = "COM6";
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(406, 12);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(201, 229);
            this.rtbInfo.TabIndex = 2;
            this.rtbInfo.Text = "";
            // 
            // cbMouseControl
            // 
            this.cbMouseControl.AutoSize = true;
            this.cbMouseControl.Location = new System.Drawing.Point(406, 251);
            this.cbMouseControl.Name = "cbMouseControl";
            this.cbMouseControl.Size = new System.Drawing.Size(93, 17);
            this.cbMouseControl.TabIndex = 3;
            this.cbMouseControl.Text = "Mouse control";
            this.cbMouseControl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 281);
            this.Controls.Add(this.cbMouseControl);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button btConnect;
        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.CheckBox cbMouseControl;
    }
}

