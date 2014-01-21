using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log_Processor
{
    public class Trial
    {
        public List<Info> informationContent; //each log's information
        public User user;
        public Task task;

        public DateTime startTime, endTime;

        public int numberOfClicks;
        public List<double> reactionTime;
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
            int count = 0;
            double reaction = 0.0;

            reactionTime = new List<double>();

            for (int i = 1; i < informationContent.Count(); i++)
            {
                if (informationContent[i].action == Options.Actions.ActionKeySelectedFirstKeyboard)
                {
                    if(task.sentence[count].Equals(informationContent[i].actionDetail[0])) //Case is correct
                    {
                        count++;
                        reaction = (returnTaskDurationInMilliseconds(informationContent[i - 1], informationContent[i]) % task.timer);
                        Console.WriteLine("Correct Character!" + informationContent[i].actionDetail[0] + " Reaction Time:" + reaction + " ms");
                        reactionTime.Add(reaction);
                        hitsCounter++;
                    }
                    else //case is wrong
                    {
                        Console.WriteLine("Wrong Character: Key");
                        errorsCounter++;
                    }
                }
                else if(informationContent[i].action == Options.Actions.ActionSpaceSelectedFirstKeyboard)
                {
                    if (task.sentence[count].Equals(informationContent[i].actionDetail[0])) //Case is correct
                    {
                        count++;
                        reaction = (returnTaskDurationInMilliseconds(informationContent[i - 1], informationContent[i]) % task.timer);
                        Console.WriteLine("Correct Character!" + informationContent[i].actionDetail[0] + " Reaction Time:" + reaction + " ms");
                        reactionTime.Add(reaction);
                        hitsCounter++;
                    }
                    else //case is wrong
                    {
                        Console.WriteLine("Wrong Character: Space");
                        errorsCounter++;
                    }
                }
            }
        }

        public void ProcessTrial2()
        {
            int count = 0;
            double reaction = 0.0;
            bool begin = false;
            reactionTime = new List<double>();

            for (int i = 0; i < informationContent.Count(); i++)
            {
                
                if (informationContent[i].action == Options.Actions.ActionSpeechSelectedFirstKeyboard)
                {
                    if (!begin)
                    {
                        startTime = informationContent[i].datetime;
                        begin = true;
                    }
                    else if (count >= task.sentence.Count() - 1)
                    {
                        endTime = informationContent[i].datetime;
                        begin = false;
                        hitsCounter++;
                    }
                    else
                    {
                        errorsCounter++;
                    }
                }
                else if (informationContent[i].action == Options.Actions.ActionColumnSelectedFirstKeyboard && begin)
                {
                    if (informationContent[i - 1].action == Options.Actions.ActionColumnSelectedFirstKeyboard)
                    {
                        Console.WriteLine("Wrong Column Pressed!");
                        //errorsCounter++;
                    }
                }


                //else if(informationContent[i].action == Options.Actions.ActionColumnSelectedFirstKeyboard && begin)
                //{
                //    if (informationContent[i - 1].action == Options.Actions.ActionColumnSelectedFirstKeyboard)
                //    {
                //        Console.WriteLine("Wrong Column Pressed!");
                //        errorsCounter++;
                //    }
                //    else if (informationContent[i+1].action == Options.Actions.ActionKeySelectedFirstKeyboard)
                //    {
                //        Console.WriteLine("Wrong Column, before Wrong Character Pressed!");
                //        errorsCounter++;
                //    }

                //    else
                //    {
                //        Console.WriteLine("Correct Column Pressed!");
                //        hitsCounter++;
                //    }
                //}


                else if (informationContent[i].action == Options.Actions.ActionKeySelectedFirstKeyboard && begin)
                {
                    if (task.sentence[count].Equals(informationContent[i].actionDetail[0])) //Case is correct
                    {
                        count++;
                        reaction = (returnTaskDurationInMilliseconds(informationContent[i - 1], informationContent[i]) % task.timer);
                        Console.WriteLine("Correct Character!" + informationContent[i].actionDetail[0] + " Reaction Time:" + reaction + " ms");
                        reactionTime.Add(reaction);
                        hitsCounter++;
                    }
                    else //case is wrong
                    {
                        Console.WriteLine("Wrong Character: Key");
                        errorsCounter++;
                    }
                }
                else if (informationContent[i].action == Options.Actions.ActionSpaceSelectedFirstKeyboard && begin)
                {
                    if (task.sentence[count].Equals(informationContent[i].actionDetail[0])) //Case is correct
                    {
                        count++;
                        reaction = (returnTaskDurationInMilliseconds(informationContent[i - 1], informationContent[i]) % task.timer);
                        Console.WriteLine("Correct Character!" + informationContent[i].actionDetail[0] + " Reaction Time:" + reaction + " ms");
                        reactionTime.Add(reaction);
                        hitsCounter++;
                    }
                    else //case is wrong
                    {
                        Console.WriteLine("Wrong Character: Space");
                        errorsCounter++;
                    }
                }
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

    }
}
