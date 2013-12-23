using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edith_Stats_App
{
    public class Trial
    {
        public List<Info> information;

        public int sizeInfo;
        public double duration;
        public int numberOfCLicks;

        public string charactersPressed;
        public int numCharactersPressed;
        public int numWrongKeysPressed;
        public double accuracy, error;

        public Trial(System.IO.StreamReader _log, string _testSequence)
        {
            this.information = retrievesInfo(_log);
            this.sizeInfo = this.information.Count();
            this.duration = getDurationInMilliseconds(information[0], information[sizeInfo - 1]);
            this.numberOfCLicks = this.sizeInfo - 1; //disregards trigger click (1st click)
            this.charactersPressed = getCharPressed(this.information);
            this.numCharactersPressed = this.charactersPressed.Length;
            this.numWrongKeysPressed = this.numCharactersPressed - _testSequence.Length;
            this.accuracy = 100.0 * (double)(this.numCharactersPressed - this.numWrongKeysPressed) / (double)this.numCharactersPressed;
            this.error = 100.0 * (double)(this.numWrongKeysPressed) / (double)this.numCharactersPressed;
        }

        private double getDurationInMilliseconds(Info firstInfo, Info lastInfo)
        {
            TimeSpan duration = lastInfo.datetime.Subtract(firstInfo.datetime);
            return duration.TotalMilliseconds;
        }

        private List<Info> retrievesInfo(System.IO.StreamReader log)
        {
            List<Info> information = new List<Info>();

            while (!log.EndOfStream)
                information.Add(new Info(log.ReadLine()));

            return information;
        }

        private string getCharPressed(List<Info> _information)
        {
            string keysSelected = "";

            //for (int i = 1; i < sizeInfo; i++)
            //{
            //    if (_information[i].action == Action.Options.ActionKeySelectedFirstKeyboard
            //        && _information[i].action != _information[i - 1].action)
            //    {
            //        keysSelected += _information[i].actionDetail;
            //    }
            //}

            foreach (Info info in _information)
            {
                if (info.action == Action.Options.ActionKeySelectedFirstKeyboard && info.actionDetail!="None")
                    keysSelected += info.actionDetail;
            }
            return keysSelected;
        }

        private int calculateErrors(List<Info> _information)
        {
            int errorsCount = 0;


            _information[0].action = Action.Options.ActionBackspaceSelectedFirstKeyboard
        }

    }
}
