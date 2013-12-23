using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edith_Stats_App
{
    public class Trial
    {
        public List<Info> informationContent;

        public bool isAutoComplete;
        public int informationSize;
        public double trialDuration;
        public int numberOfClicks;

        public string trialTestSequence;

        public int numCharactersPressed;
        public int numWrongKeysPressed;
        public double accuracy, error;

        public Trial(System.IO.StreamReader _log, string _trialTestSequence, bool _isAutoComplete)
        {
            this.informationContent = retrievesInfo(_log);
            this.trialTestSequence = _trialTestSequence;
            this.isAutoComplete = _isAutoComplete;
            this.informationSize = this.informationContent.Count() - 1;
            this.trialDuration = getDurationOfTrial(informationContent[0], informationContent[informationSize]);
            this.numberOfClicks = getNumberOfClicks();
            this.numCharactersPressed = getNumberOfCharactersPressed();
            this.numWrongKeysPressed = getNumberOfWrongCharactersPressed();
            this.accuracy = 100.0 * (double)(this.numCharactersPressed - this.numWrongKeysPressed) / (double)this.numCharactersPressed;
            this.error = 100.0 * (double)(this.numWrongKeysPressed) / (double)this.numCharactersPressed;
        }


        private List<Info> retrievesInfo(System.IO.StreamReader log)
        {
            List<Info> information = new List<Info>();

            while (!log.EndOfStream)
                information.Add(new Info(log.ReadLine()));

            return information;
        }

        private double getDurationOfTrial(Info firstInfo, Info lastInfo)
        {
            TimeSpan duration = lastInfo.datetime.Subtract(firstInfo.datetime);
            return duration.TotalMilliseconds;
        }

        private int getNumberOfClicks()
        {
            int numberOfClicks = 0;

            if (this.isAutoComplete)
            {
                for (int i = 1; i < informationSize + 1; i++)
                {
                    if (informationContent[i].datetime != informationContent[i - 1].datetime)
                    {
                        numberOfClicks++;
                    }
                    else
                    {
                        //do notting
                    }
                }
            }
            else
            {
                numberOfClicks = informationSize;
            }

            return numberOfClicks;
        }

        private int getNumberOfCharactersPressed()
        {
            int numberOfCharactersPressed = 0;

            if (this.isAutoComplete)
            {
                for (int i = 1; i < informationSize + 1; i++)
                {
                    if ((informationContent[i].action == Action.Options.ActionKeySelectedFirstKeyboard ||
                        informationContent[i].action == Action.Options.ActionSpaceSelectedFirstKeyboard) &&
                        (informationContent[i].actionDetail == "None"))
                    {
                        numberOfCharactersPressed++;
                    }
                    else
                    {
                        //do notting
                    }
                }
            }
            else
            {
                for (int i = 1; i < informationSize + 1; i++)
                {
                    if (informationContent[i].action == Action.Options.ActionKeySelectedFirstKeyboard ||
                        informationContent[i].action == Action.Options.ActionSpaceSelectedFirstKeyboard)
                    {
                        numberOfCharactersPressed++;
                    }
                    else
                    {
                        //do notting
                    }
                }
            }

            return numberOfCharactersPressed;
        }

        private int getNumberOfWrongCharactersPressed()
        {
            int numberOfWrongCharactersPressed = 0;

            for (int i = 1; i < informationSize + 1; i++)
            {
                if (informationContent[i].action == Action.Options.ActionBackspaceSelectedFirstKeyboard)
                {
                    numberOfWrongCharactersPressed++;
                }
                else
                {
                    //do notting
                }
            }
            return numberOfWrongCharactersPressed;
        }

    }
}
