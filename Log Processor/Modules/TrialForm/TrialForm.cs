using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

using Category = Log_Processor.Options.Category;
using Laterality = Log_Processor.Options.Laterality;
using Gender = Log_Processor.Options.Gender;

namespace Log_Processor
{
    public partial class TrialForm : Form
    {
        Task myTask;
        string _taskSentence;

        List<Trial> myTrials;
        List<User> myUsers;

        int numUsers = 1;
        List<int> timers;

        System.IO.StreamReader log;

        public TrialForm()
        {
            InitializeComponent();
        }

        private void processTSMI_Click(object sender, EventArgs e)
        {
            processLog();
        }

        private void processLog()
        {
            try
            {
                myUsers = new List<User>();

                for (int i = 0; i < numUsers; i++)
                {
                    openFileDialog.Title = "Enter with the user.txt file!";
                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        log = new System.IO.StreamReader(openFileDialog.FileName);
                        myUsers.Add(new User(Convert.ToInt32(log.ReadLine()),
                            log.ReadLine(),
                            (Gender)Enum.Parse(typeof(Gender), log.ReadLine(), true),
                            (Laterality)Enum.Parse(typeof(Laterality), log.ReadLine(), true),
                            Convert.ToInt32(log.ReadLine())));
                        log.Close();
                    }
                }

                _taskSentence = "GAZETA PUBLICA HOJE BREVE NOTA DE FAXINA NA QUERMESSE";
                timers = new List<int>() { 1000, 700, 400 };
                myTrials = new List<Trial>();

                foreach(User u in myUsers)
                {
                    foreach (Category c in Enum.GetValues(typeof(Category)))
                    {
                        foreach (int t in timers)
                        {
                            myTask = new Task(_taskSentence, c, t);
                            openFileDialog.Title = "User: " + u.ID + " Category: " + c.ToString() + " Timer: " + t + " ms";
                            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                log = new System.IO.StreamReader(openFileDialog.FileName);
                                myTrials.Add(new Trial(log, myTask, u));
                                log.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

        }

        private void saveTSMI_Click(object sender, EventArgs e)
        {
            saveDataToExcel();
        }

        private void saveDataToExcel()
        {
            try
            {
                object misValue = System.Reflection.Missing.Value;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet ws_user1, ws_user2, ws_user3, ws_user4, 
                    ws_user5, ws_user6, ws_user7, ws_user8, ws_avg;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkBook.Worksheets.Add(misValue, misValue, misValue, misValue);
                xlWorkBook.Worksheets.Add(misValue, misValue, misValue, misValue);
                xlWorkBook.Worksheets.Add(misValue, misValue, misValue, misValue);
                xlWorkBook.Worksheets.Add(misValue, misValue, misValue, misValue);
                xlWorkBook.Worksheets.Add(misValue, misValue, misValue, misValue);
                xlWorkBook.Worksheets.Add(misValue, misValue, misValue, misValue);
     
                ws_user1 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                ws_user2 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
                ws_user3 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);
                ws_user4 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(4);
                ws_user5 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(5);
                ws_user6 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(6);
                ws_user7 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(7);
                ws_user8 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(8);
                ws_avg = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(9);
      

                List<Excel.Worksheet> ws_userList = new List<Excel.Worksheet>() {ws_user1, ws_user2, ws_user3, ws_user4, ws_user5, ws_user6, ws_user7, ws_user8};

                double[] avgduration = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] avgnclicks = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] avgaccuracy = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] avgrtavg = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                int icu;

                if (myUsers.Count() <= ws_userList.Count())
                {
                    for (icu = 0; icu < myUsers.Count(); icu++)
                    {
                        //ws_userList[icu].Name = myTrials;
                        ws_userList[icu].Cells[1, 1] = "Dispositivo";
                        ws_userList[icu].Cells[1, 2] = "Tempo de varredura (ms)";
                        ws_userList[icu].Cells[1, 3] = "Duração (s)";
                        ws_userList[icu].Cells[1, 4] = "Número de clicks";
                        ws_userList[icu].Cells[1, 5] = "Accuracy";
                        ws_userList[icu].Cells[1, 6] = "Tempo de reação (Média)";

                        for (int ict = 0; ict < 9; ict++)
                        {
                            int tadj = (9 * icu) + ict;
                            ws_userList[icu].Name = myTrials[tadj].user.ID.ToString();
                            ws_userList[icu].Cells[ict + 2, 1] = myTrials[tadj].task.category.ToString();
                            ws_userList[icu].Cells[ict + 2, 2] = myTrials[tadj].task.timer;
                            ws_userList[icu].Cells[ict + 2, 3] = myTrials[tadj].duration;
                            ws_userList[icu].Cells[ict + 2, 4] = myTrials[tadj].numberOfClicks;
                            ws_userList[icu].Cells[ict + 2, 5] = myTrials[tadj].accuracyRate;
                            ws_userList[icu].Cells[ict + 2, 6] = myTrials[tadj].rtList.Average();
                            avgduration[ict] += myTrials[tadj].duration;
                            avgnclicks[ict] += myTrials[tadj].numberOfClicks;
                            avgaccuracy[ict] += myTrials[tadj].accuracyRate;
                            avgrtavg[ict] += myTrials[tadj].rtList.Average();
                        }

                        #region Duration time Chart
                        Excel.Range chartRange;
                        Excel.ChartObjects xlCharts = (Excel.ChartObjects)ws_userList[icu].ChartObjects(Type.Missing);
                        Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(200, 200, 300, 200);
                        Excel.Chart chartPage = myChart.Chart;
                        //chartPage.T = "Duration time";

                        chartRange = ws_userList[icu].get_Range("B2", "D10");
                        chartPage.SetSourceData(chartRange, misValue);
                        chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

                        Excel.Series s1a = (Excel.Series)chartPage.SeriesCollection(1);
                        Excel.Series s1b = (Excel.Series)chartPage.SeriesCollection(2);
                        Excel.Series s1c = (Excel.Series)chartPage.SeriesCollection(3);
                        s1a.Name = "Accelerometer on hand";
                        s1a.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[2, 2], ws_userList[icu].Cells[4, 2]];
                        s1a.Values = ws_userList[icu].Range[ws_userList[icu].Cells[2, 3], ws_userList[icu].Cells[4, 3]];
                        s1b.Name = "Mouse";
                        s1b.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[5, 2], ws_userList[icu].Cells[7, 2]];
                        s1b.Values = ws_userList[icu].Range[ws_userList[icu].Cells[5, 3], ws_userList[icu].Cells[7, 3]];
                        s1c.Name = "Accelerometer on shoulder";
                        s1c.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[8, 2], ws_userList[icu].Cells[10, 2]];
                        s1c.Values = ws_userList[icu].Range[ws_userList[icu].Cells[8, 3], ws_userList[icu].Cells[10, 3]];
                        #endregion

                        #region Number of Clicks Chart
                        Excel.Range chartRange2;
                        Excel.ChartObjects xlCharts2 = (Excel.ChartObjects)ws_userList[icu].ChartObjects(Type.Missing);
                        Excel.ChartObject myChart2 = (Excel.ChartObject)xlCharts2.Add(500, 200, 300, 200);
                        Excel.Chart chartPage2 = myChart2.Chart;
                        //chartPage2.Name = "Number of Clicks";

                        chartRange2 = ws_userList[icu].get_Range("B2", "D10");
                        chartPage2.SetSourceData(chartRange2, misValue);
                        chartPage2.ChartType = Excel.XlChartType.xlColumnClustered;

                        Excel.Series s2a = (Excel.Series)chartPage2.SeriesCollection(1);
                        Excel.Series s2b = (Excel.Series)chartPage2.SeriesCollection(2);
                        Excel.Series s2c = (Excel.Series)chartPage2.SeriesCollection(3);
                        s2a.Name = "Accelerometer on hand";
                        s2a.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[2, 2], ws_userList[icu].Cells[4, 2]];
                        s2a.Values = ws_userList[icu].Range[ws_userList[icu].Cells[2, 4], ws_userList[icu].Cells[4, 4]];
                        s2b.Name = "Mouse";
                        s2b.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[5, 2], ws_userList[icu].Cells[7, 2]];
                        s2b.Values = ws_userList[icu].Range[ws_userList[icu].Cells[5, 4], ws_userList[icu].Cells[7, 4]];
                        s2c.Name = "Accelerometer on shoulder";
                        s2c.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[8, 2], ws_userList[icu].Cells[10, 2]];
                        s2c.Values = ws_userList[icu].Range[ws_userList[icu].Cells[8, 4], ws_userList[icu].Cells[10, 4]];
                        #endregion

                        #region Accuracy Chart
                        Excel.Range chartRange3;
                        Excel.ChartObjects xlCharts3 = (Excel.ChartObjects)ws_userList[icu].ChartObjects(Type.Missing);
                        Excel.ChartObject myChart3 = (Excel.ChartObject)xlCharts3.Add(200, 400, 300, 200);
                        Excel.Chart chartPage3 = myChart3.Chart;
                        //chartPage3.Name = "Accuracy";

                        chartRange3 = ws_userList[icu].get_Range("B2", "D10");
                        chartPage3.SetSourceData(chartRange3, misValue);
                        chartPage3.ChartType = Excel.XlChartType.xlColumnClustered;

                        Excel.Series ser3a = (Excel.Series)chartPage3.SeriesCollection(1);
                        Excel.Series ser3b = (Excel.Series)chartPage3.SeriesCollection(2);
                        Excel.Series ser3c = (Excel.Series)chartPage3.SeriesCollection(3);
                        ser3a.Name = "Accelerometer on hand";
                        ser3a.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[2, 2], ws_userList[icu].Cells[4, 2]];
                        ser3a.Values = ws_userList[icu].Range[ws_userList[icu].Cells[2, 5], ws_userList[icu].Cells[4, 5]];
                        ser3b.Name = "Mouse";
                        ser3b.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[5, 2], ws_userList[icu].Cells[7, 2]];
                        ser3b.Values = ws_userList[icu].Range[ws_userList[icu].Cells[5, 5], ws_userList[icu].Cells[7, 5]];
                        ser3c.Name = "Accelerometer on shoulder";
                        ser3c.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[8, 2], ws_userList[icu].Cells[10, 2]];
                        ser3c.Values = ws_userList[icu].Range[ws_userList[icu].Cells[8, 5], ws_userList[icu].Cells[10, 5]];
                        #endregion

                        #region Reaction Time Average Chart
                        Excel.Range chartRange4;
                        Excel.ChartObjects xlCharts4 = (Excel.ChartObjects)ws_userList[icu].ChartObjects(Type.Missing);
                        Excel.ChartObject myChart4 = (Excel.ChartObject)xlCharts4.Add(500, 400, 300, 200);
                        myChart4.Name = "test";
                        Excel.Chart chartPage4 = myChart4.Chart;

                        //chartPage4.Name = "Reaction Time Average";

                        chartRange4 = ws_userList[icu].get_Range("B2", "D10");
                        chartPage4.SetSourceData(chartRange4, misValue);
                        chartPage4.ChartType = Excel.XlChartType.xlColumnClustered;

                        Excel.Series ser4a = (Excel.Series)chartPage4.SeriesCollection(1);
                        Excel.Series ser4b = (Excel.Series)chartPage4.SeriesCollection(2);
                        Excel.Series ser4c = (Excel.Series)chartPage4.SeriesCollection(3);
                        ser4a.Name = "Accelerometer on hand";
                        ser4a.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[2, 2], ws_userList[icu].Cells[4, 2]];
                        ser4a.Values = ws_userList[icu].Range[ws_userList[icu].Cells[2, 6], ws_userList[icu].Cells[4, 6]];
                        ser4b.Name = "Mouse";
                        ser4b.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[5, 2], ws_userList[icu].Cells[7, 2]];
                        ser4b.Values = ws_userList[icu].Range[ws_userList[icu].Cells[5, 6], ws_userList[icu].Cells[7, 6]];
                        ser4c.Name = "Accelerometer on shoulder";
                        ser4c.XValues = ws_userList[icu].Range[ws_userList[icu].Cells[8, 2], ws_userList[icu].Cells[10, 2]];
                        ser4c.Values = ws_userList[icu].Range[ws_userList[icu].Cells[8, 6], ws_userList[icu].Cells[10, 6]];
                        #endregion
                    }
                }
                else
                {
                    MessageBox.Show(myUsers.Count() + " users and " + ws_userList.Count() + " excel sheets");
                }

                icu = ws_userList.Count() - 1;

                ws_userList[icu].Name = "Geral";
                ws_userList[icu].Cells[1, 1] = "Dispositivo";
                ws_userList[icu].Cells[1, 2] = "Tempo de varredura (ms)";
                ws_userList[icu].Cells[1, 3] = "Duração (s)";
                ws_userList[icu].Cells[1, 4] = "Número de clicks";
                ws_userList[icu].Cells[1, 5] = "Accuracy";
                ws_userList[icu].Cells[1, 6] = "Tempo de reação (Média)";

                for (int ict = 0; ict < 9; ict++)
                {
                    int tadj = (0 * icu) + ict;

                    ws_userList[icu].Cells[ict + 2, 3] = avgduration[ict] / numUsers;
                    ws_userList[icu].Cells[ict + 2, 4] = avgnclicks[ict] / numUsers;
                    ws_userList[icu].Cells[ict + 2, 5] = avgaccuracy[ict] / numUsers;
                    ws_userList[icu].Cells[ict + 2, 6] = avgrtavg[ict] / numUsers;
                }



                string fname = "test";

                xlWorkBook.SaveAs(fname, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                foreach (Excel.Worksheet ws in ws_userList)
                {
                    liberarObjetos(ws);
                }

                liberarObjetos(xlWorkBook);
                liberarObjetos(xlApp);

                MessageBox.Show("O arquivo Excel foi criado com sucesso. Você pode encontrá-lo em : " + fname + ".xml");
            

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

    }
}
