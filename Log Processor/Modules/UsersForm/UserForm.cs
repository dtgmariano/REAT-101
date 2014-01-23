using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace Log_Processor
{
    public partial class UserForm : Form
    {
        User newUser;

        public UserForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach (var laterality in Enum.GetValues(typeof(Options.Laterality)))
            {
                cbLaterality.Items.Add(laterality);
            }

            foreach (var gender in Enum.GetValues(typeof(Options.Gender)))
            {
                cbGender.Items.Add(gender);
            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            
            try
            {
                int _id = Convert.ToInt32(tbPatientId.Text);
                string _name = tbPacientName.Text;
                Options.Gender _gender = (Options.Gender)cbGender.SelectedItem;
                Options.Laterality _laterality = (Options.Laterality)cbLaterality.SelectedItem;
                int _yearOfBirth = Convert.ToInt32(numPatientYB.Value);
                newUser = new User(_id, _name, _gender, _laterality, _yearOfBirth);

                TaskForm trialForm = new TaskForm(newUser);
                trialForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

        }

    }
}
