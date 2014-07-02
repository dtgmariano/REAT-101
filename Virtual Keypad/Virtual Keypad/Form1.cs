using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Virtual_Keypad
{
    public partial class Form1 : Form
    {
        Dictionary<string, Point> keyCoordinates;

        public Form1()
        {
            InitializeComponent();

            keyCoordinates = new Dictionary<string, Point>();

            keyCoordinates.Add("A", new Point(0, 0));
            keyCoordinates.Add("B", new Point(0, 1));
            keyCoordinates.Add("C", new Point(0, 2));
            keyCoordinates.Add("D", new Point(0, 3));
            keyCoordinates.Add("E", new Point(0, 4));

            keyCoordinates.Add("F", new Point(1, 0));
            keyCoordinates.Add("G", new Point(1, 1));
            keyCoordinates.Add("H", new Point(1, 2));
            keyCoordinates.Add("I", new Point(1, 3));
            keyCoordinates.Add("J", new Point(1, 4));

            keyCoordinates.Add("K", new Point(2, 0));
            keyCoordinates.Add("L", new Point(2, 1));
            keyCoordinates.Add("M", new Point(2, 2));
            keyCoordinates.Add("N", new Point(2, 3));
            keyCoordinates.Add("O", new Point(2, 4));

            keyCoordinates.Add("P", new Point(3, 0));
            keyCoordinates.Add("Q", new Point(3, 1));
            keyCoordinates.Add("R", new Point(3, 2));
            keyCoordinates.Add("S", new Point(3, 3));
            keyCoordinates.Add("backspace", new Point(3, 4));

            keyCoordinates.Add("T", new Point(4, 0));
            keyCoordinates.Add("U", new Point(4, 1));
            keyCoordinates.Add("V", new Point(4, 2));
            keyCoordinates.Add("X", new Point(4, 3));
            keyCoordinates.Add("space", new Point(4, 4));

            keyCoordinates.Add("Z", new Point(5, 0));
            keyCoordinates.Add("Y", new Point(5, 1));
            keyCoordinates.Add("W", new Point(5, 2));
            keyCoordinates.Add("speak", new Point(5, 3));
            keyCoordinates.Add("quit", new Point(5, 4));
        }

        private void btGenerateKeypad_Click(object sender, EventArgs e)
        {
            //List<TextBox> ltb = new List<TextBox>();
            //int ntb = Convert.ToInt32(nudColumns.Value) * Convert.ToInt32(nudRows.Value);
            
            //for(int i = 0; i<ntb; i++)
            //{
            //    ltb.Add(new System.Windows.Forms.TextBox());
                
            //    ltb[i].Location = new System.Drawing.Point(350, 60);
            //    ltb[i].Name = i.ToString();
            //    ltb[i].Size = new System.Drawing.Size(500, 20);
            //    ltb[i].TabIndex = 4;
            //    ltb[i].Text = "Teste" + i;
            //    ltb[i].Visible = true;
            //}

            int score = KeypadProcessor.calculateTask(tbSentence.Text, keyCoordinates);

            rtbOutput.AppendText(tbSentence.Text + " " + score);
        }
    }
}
