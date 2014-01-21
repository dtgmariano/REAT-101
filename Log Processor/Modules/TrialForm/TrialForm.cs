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
    public partial class TrialForm : Form
    {
        //string _patientName, _patientId, _patientYearOfBirth, 
        //        _patientGender, _patientSide, _trialId, 
        //        _trialCategory, _trialTask, _trialTimer;

        public TrialForm()
        {
            InitializeComponent();
        }

        public void LoadDataBase()
        {

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _patientName = tbPacientName.Text;
            //    _patientId = tbPatientId.Text;
            //    _patientYearOfBirth = numPatientYB.Value.ToString();
            //    _patientGender = cbPatientGender.Text;
            //    _patientSide = cbPatientSide.Text;
            //    _trialId = tbTrialId.Text;
            //    _trialCategory = cbTrialCategory.Text;
            //    _trialTask = tbTrialTask.Text;
            //    _trialTimer = tbTrialTimer.Text;


            //    MessageBox.Show("Dados do paciente:"
            //                + "\nNome: " + _patientName
            //                + "\nCódigo: " + _patientId
            //                + "\nAno de Nascimento: " + _patientYearOfBirth
            //                + "\nGênero: " + _patientGender
            //                + "\nLateralidade: " + _patientSide
            //                + "\n\nDados do experimento:"
            //                + "\nCódigo: " + _trialId
            //                + "\nCategoria: " + _trialCategory
            //                + "\nTarefa: " + _trialTask
            //                + "\nTempo de Varredura(ms): " + _trialTimer
            //                );
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro : " + ex.Message);
            //}
        }
    }
}
