using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Edith_Stats_App
{
    public partial class Form1 : Form
    {
        Trial trial;

        int trialId;
        string testSequence;
        bool hasAutoComplete;

        public Form1()
        {
            InitializeComponent();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    rtbInfo.Clear();
                    System.IO.StreamReader sr = new
                       System.IO.StreamReader(openFileDialog.FileName);

                    //testSequence = "UM PEQUENO JABUTI XERETA VIU DEZ CEGONHAS FELIZES";

                    testSequence = "UMPEQUENOJABUTIXERETAVIUDEZCEGONHASFELIZES";
                    hasAutoComplete = true;

                    trial = new Trial(sr, testSequence);
                    rtbInfo.AppendText(testSequence + "\n");
                    rtbInfo.AppendText(trial.charactersPressed + "\n");

                    foreach (Info info in trial.information)
                    {
                        rtbInfo.AppendText(info.datetime.ToString() + " " + info.action.ToString() + " " + info.actionDetail.ToString() + "\n");
                    }

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet1, xlWorkSheet2, xlWorkSheet3;

                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                
                xlWorkSheet1 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet2 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
                xlWorkSheet3 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);

                #region Resume Sheet

                xlWorkSheet1.Name = "Resume";
                xlWorkSheet1.Cells[1, 1] = "Duration (ms)";
                xlWorkSheet1.Cells[2, 1] = "Number of clicks";
                xlWorkSheet1.Cells[3, 1] = "Number of chars pressed";
                xlWorkSheet1.Cells[4, 1] = "Number of wrong chars pressed";
                xlWorkSheet1.Cells[5, 1] = "Accuracy(%)";
                xlWorkSheet1.Cells[6, 1] = "Error(%)";


                xlWorkSheet1.Cells[1, 2] = trial.duration;
                xlWorkSheet1.Cells[2, 2] = trial.numberOfCLicks;
                xlWorkSheet1.Cells[3, 2] = trial.numCharactersPressed;
                xlWorkSheet1.Cells[4, 2] = trial.numWrongKeysPressed;
                xlWorkSheet1.Cells[5, 2] = trial.accuracy;
                xlWorkSheet1.Cells[6, 2] = trial.error;

                #endregion

                #region Actions

                xlWorkSheet2.Name = "Actions";
                xlWorkSheet2.Cells[1, 1] = "Date";
                xlWorkSheet2.Cells[1, 2] = "Hour";
                xlWorkSheet2.Cells[1, 3] = "Minute";
                xlWorkSheet2.Cells[1, 4] = "Seconds";
                xlWorkSheet2.Cells[1, 5] = "Millisecond";
                xlWorkSheet2.Cells[1, 6] = "Action";
                xlWorkSheet2.Cells[1, 7] = "Action Detail";

                for (int i = 0; i < trial.information.Count(); i++)
                {
                    xlWorkSheet2.Cells[(i + 2), 1] = trial.information[i].datetime.Date;
                    xlWorkSheet2.Cells[(i + 2), 2] = trial.information[i].datetime.Hour;
                    xlWorkSheet2.Cells[(i + 2), 3] = trial.information[i].datetime.Minute;
                    xlWorkSheet2.Cells[(i + 2), 4] = trial.information[i].datetime.Second;
                    xlWorkSheet2.Cells[(i + 2), 5] = trial.information[i].datetime.Millisecond;
                    xlWorkSheet2.Cells[(i + 2), 6] = trial.information[i].action;
                    xlWorkSheet2.Cells[(i + 2), 7] = trial.information[i].actionDetail;
                }

                #endregion

                #region KeysPressed
                xlWorkSheet3.Name = "KeysPressed";
                xlWorkSheet3.Cells[1, 1] = "Date";
                xlWorkSheet3.Cells[1, 2] = "Hour";
                xlWorkSheet3.Cells[1, 3] = "Minute";
                xlWorkSheet3.Cells[1, 4] = "Seconds";
                xlWorkSheet3.Cells[1, 5] = "Millisecond";
                xlWorkSheet3.Cells[1, 6] = "Action";
                xlWorkSheet3.Cells[1, 7] = "Action Detail";


                int idx = 2;
                foreach(Info info in trial.information)
                {
                    if (info.action == Action.Options.ActionKeySelectedFirstKeyboard)
                    {
                        xlWorkSheet3.Cells[idx, 1] = info.datetime.Date;
                        xlWorkSheet3.Cells[idx, 2] = info.datetime.Hour;
                        xlWorkSheet3.Cells[idx, 3] = info.datetime.Minute;
                        xlWorkSheet3.Cells[idx, 4] = info.datetime.Second;
                        xlWorkSheet3.Cells[idx, 5] = info.datetime.Millisecond;
                        xlWorkSheet3.Cells[idx, 6] = info.action;
                        xlWorkSheet3.Cells[idx, 7] = info.actionDetail;
                        idx++;
                    }
                }
                #endregion

                xlWorkBook.SaveAs("stats", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                liberarObjetos(xlWorkSheet1);
                liberarObjetos(xlWorkSheet2);
                liberarObjetos(xlWorkSheet3);
                liberarObjetos(xlWorkBook);
                liberarObjetos(xlApp);

                MessageBox.Show("O arquivo Excel foi criado com sucesso. Você pode encontrá-lo em : " + "stats.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

        }

        private void liberarObjetos(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Ocorreu um erro durante a liberação do objeto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Duration(ms): " + trial.duration
                            + "\nNumber of clicks: " + trial.numberOfCLicks
                            + "\nNumber of keys pressed: " + trial.numCharactersPressed
                            + "\nNumber of wrong keys pressed: " + trial.numWrongKeysPressed
                            + "\nAccuracy: " + trial.accuracy
                            + "\nError: " + trial.error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
        
        
    }
}
