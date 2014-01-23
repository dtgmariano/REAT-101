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
    public partial class TaskForm : Form
    {
        //string _patientName, _patientId, _patientYearOfBirth, 
        //        _patientGender, _patientSide, _trialId, 
        //        _trialCategory, _trialTask, _trialTimer;
        User user;
        Task task;

        public TaskForm(User _user)
        {
            InitializeComponent();
            user = _user;
            Load();
        }

        private void Load()
        {
            try
            {
                foreach (var category in Enum.GetValues(typeof(Options.Category)))
                {
                    cbCategory.Items.Add(category);
                }

                cbSentence.DataSource = new BindingSource(Options.Sentences, null);
                cbSentence.DisplayMember = "Value";
                cbSentence.ValueMember = "Key";

                cbTimer.DataSource = new BindingSource(Options.Timers, null);
                cbTimer.DisplayMember = "Value";
                cbSentence.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int _id = Convert.ToInt32(tbID.Text);
                string _sentence = cbSentence.Text;
                Options.Category _category = (Options.Category)cbCategory.SelectedItem;
                cbTimer.SelectedText.ToString();
                //Options.Timers _timer = Options.Timers(cbTimer.SelectedItem);

                //task = new Task(_category, _timer, _sentence);

                //TrialForm processLogForm = new TrialForm(user, task);
               // processLogForm.Show();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

    }
}
