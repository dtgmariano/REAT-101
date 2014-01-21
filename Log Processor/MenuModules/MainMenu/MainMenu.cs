using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Log_Processor
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openLogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btNewTrial_Click(object sender, EventArgs e)
        {
            try
            {
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
    }
}
