using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Actions = Log_Processor.Options.Actions;

namespace Log_Processor
{
    public class Trial
    {
        public List<Info> informationContent; //each log's information
        public User user;
        public Task task;

        public DateTime startTime, endTime;

        public int numberOfClicks;
        public List<double> rtList;
        public IDictionary<double, int> rtDictionary;

        public double duration; //duration of the trial: duration between first and last information
        public double errorsCounter, hitsCounter;
        public double accuracyRate;
        public double score; //number of points to execute a specific task

        public Trial(System.IO.StreamReader _log, Task _task, User _user)
        {
            informationContent = returnInformationContent(_log);
            task = _task;
            user = _user;
            
            numberOfClicks = getNumberOfClicks(informationContent);
            duration = returnTaskDurationInSeconds(informationContent[0], informationContent[informationContent.Count - 1]);

            ProcessTrial();
            accuracyRate = (hitsCounter / (errorsCounter + hitsCounter)) * 100.0;
        }

        public void ProcessTrial()
        {
            try
            {
                int count = 0;
                double reaction = 0.0;

                rtList = new List<double>();

                for (int i = 1; i < informationContent.Count(); i++)
                {
                    if (count >= task.sentence.Length)
                    {
                        Console.WriteLine("AQUI");
                    }

                    if (informationContent[i].action == Actions.ActionKeySelectedFirstKeyboard && count < task.sentence.Length)
                    {
                        if(task.sentence[count].Equals(informationContent[i].actionDetail[0])) //Case is correct
                        {
                            count++;
                            reaction = (returnTaskDurationInMilliseconds(informationContent[i - 1], informationContent[i]) % task.timer);
                            rtList.Add(reaction);
                            hitsCounter++;
                        }
                    }
                    else if (informationContent[i].action == Actions.ActionSpaceSelectedFirstKeyboard && count < task.sentence.Length)
                    {
                        if (task.sentence[count].Equals(informationContent[i].actionDetail[0])) //Case is correct
                        {
                            count++;
                            reaction = (returnTaskDurationInMilliseconds(informationContent[i - 1], informationContent[i]) % task.timer);
                            rtList.Add(reaction);
                            hitsCounter++;
                        }
                    }
                    else if (informationContent[i].action == Actions.ActionBackspaceSelectedFirstKeyboard)
                    {
                        errorsCounter++;
                    }

                    else if (informationContent[i].action == Actions.ActionSpeechSelectedFirstKeyboard && count == (task.sentence.Length - 1))
                    {
                        reaction = (returnTaskDurationInMilliseconds(informationContent[i - 1], informationContent[i]) % task.timer);
                        rtList.Add(reaction);
                        hitsCounter++;
                    }

                }

                rtDictionary = frequencyOfReactionAtIntervals(rtList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        public void OldProcessTrial()
        {
            try
            {
                int count = 0;
                double reaction = 0.0;

                rtList = new List<double>();

                for (int i = 1; i < informationContent.Count(); i++)
                {
                    if (count >= task.sentence.Length)
                    {
                        Console.WriteLine("asda");
                    }
                    if (informationContent[i].action == Options.Actions.ActionKeySelectedFirstKeyboard && count < task.sentence.Length)
                    {
                        if (task.sentence[count].Equals(informationContent[i].actionDetail[0])) //Case is correct
                        {
                            count++;
                            reaction = (returnTaskDurationInMilliseconds(informationContent[i - 1], informationContent[i]) % task.timer);
                            //Console.WriteLine("Correct Character!" + informationContent[i].actionDetail[0] + " Reaction Time:" + reaction + " ms");
                            rtList.Add(reaction);
                            hitsCounter++;
                        }
                        else //case is wrong
                        {
                            //Console.WriteLine("Wrong Character: Key");
                            errorsCounter++;
                        }
                    }
                    else if (informationContent[i].action == Options.Actions.ActionSpaceSelectedFirstKeyboard && count < task.sentence.Length)
                    {
                        if (task.sentence[count].Equals(informationContent[i].actionDetail[0])) //Case is correct
                        {
                            count++;
                            reaction = (returnTaskDurationInMilliseconds(informationContent[i - 1], informationContent[i]) % task.timer);
                            //Console.WriteLine("Correct Character!" + informationContent[i].actionDetail[0] + " Reaction Time:" + reaction + " ms");
                            rtList.Add(reaction);
                            hitsCounter++;
                        }
                        else //case is wrong
                        {
                            //Console.WriteLine("Wrong Character: Space");
                            errorsCounter++;
                        }
                    }
                }

                rtDictionary = frequencyOfReactionAtIntervals(rtList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private List<Info> returnInformationContent(System.IO.StreamReader log)
        {
            List<Info> information = new List<Info>();

            while (!log.EndOfStream)
                information.Add(new Info(log.ReadLine()));

            return information;
        }

        private double returnTaskDurationInMilliseconds(Info _startInfo, Info _endInfo)
        {
            TimeSpan duration = _endInfo.datetime.Subtract(_startInfo.datetime);
            return duration.TotalMilliseconds;
        }

        private double returnTaskDurationInSeconds(Info _startInfo, Info _endInfo)
        {
            TimeSpan duration = _endInfo.datetime.Subtract(_startInfo.datetime);
            return (duration.TotalMilliseconds / 1000.0);
        }

        private int getNumberOfClicks(List<Info> _informationContent)
        {
            return _informationContent.Count;
        }

        private Dictionary<double, int> frequencyOfReaction(List<double> _reactionTime)
        {
            Dictionary<double, int> freqOfReaction = new Dictionary<double, int>();

            foreach (double value in _reactionTime)
            {
                // Add the word as a key if it's not already in the dictionary, and
                // initialize the count for that word to 1, otherwise just increment
                // the count for an existing word
               
                if (!freqOfReaction.ContainsKey(value))
                    freqOfReaction.Add(value, 1);
                else
                    freqOfReaction[value]++;
            }

            return freqOfReaction;
        }

        private Dictionary<double, int> frequencyOfReactionAtIntervals(List<double> _reactionTime)
        {
            Dictionary<double, int> freqOfReaction = new Dictionary<double, int>();
            int interval = 50;


            foreach (double value in _reactionTime)
            {
                // Add the word as a key if it's not already in the dictionary, and
                // initialize the count for that word to 1, otherwise just increment
                // the count for an existing word
                double valueadj = value - (value % interval);

                if (!freqOfReaction.ContainsKey(valueadj))
                    freqOfReaction.Add(valueadj, 1);
                else
                    freqOfReaction[valueadj]++;
            }
            
            return freqOfReaction;
        }
    }
}
