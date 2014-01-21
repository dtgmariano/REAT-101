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
    public partial class TrialMenu : Form
    {
        User myUser;
        string sentence;
        Options.TrialCategory category;
        Task myTask;
        Trial myTrial;

        int[] timer = new int[] { 1000, 700, 400 };
        System.IO.StreamReader log;

        public TrialMenu()
        {
            InitializeComponent();
            processTSMI.Enabled = false;
        }

        private void settingsTSMI_Click(object sender, EventArgs e)
        {
            try
            {
                sentence = "GAZETA PUBLICA HOJE BREVE NOTA DE FAXINA NA QUERMESSE";
                category = Options.TrialCategory.MouseConfiguration;

                int userid = 1001;
                string name = "John Doe";
                Options.Gender gender = Options.Gender.Masculino;
                Options.Laterality laterality = Options.Laterality.Direita;
                int yearOfBirth = 1970;

                myUser = new User(userid, name, gender, laterality, yearOfBirth);
                processTSMI.Enabled = true;

                MessageBox.Show("It is on!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void processTSMI_Click(object sender, EventArgs e)
        {
            for (int session = 0; session < 3; session++)
            {
                try
                {
                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        log = new System.IO.StreamReader(openFileDialog.FileName);
                        myTask = new Task(category, timer[session], sentence);
                        myTrial = new Trial(log, myTask, myUser);
                        log.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }

                try
                {
                    rtbInfo.AppendText("\nSession: " + (session + 1)
                                  + "\nDuration(s): " + myTrial.duration
                                  + "\nNumber of Clicks: " + myTrial.numberOfClicks
                                  + "\nHits: " + myTrial.hitsCounter
                                  + "\nErrors: " + myTrial.errorsCounter
                                  + "\nAccuracy: " + myTrial.accuracyRate
                                  + "\nReactionTimeAverage: " + myTrial.reactionTime.Average()
                                  );

                    MessageBox.Show("Session: " + (session + 1)
                                  + "\nDuration(s): " + myTrial.duration
                                  + "\nNumber of Clicks: " + myTrial.numberOfClicks
                                  + "\nHits: " + myTrial.hitsCounter
                                  + "\nErrors: " + myTrial.errorsCounter
                                  + "\nAccuracy: " + myTrial.accuracyRate
                                  + "\nReactionTimeAverage: " + myTrial.reactionTime.Average()
                                  );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }

        }

        
    }
}
