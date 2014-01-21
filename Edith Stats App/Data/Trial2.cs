using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edith_Stats_App
{
    public class Trial2
{
        public List<Info> informationContent;
        public List<int> reactionTime;

        public int taskSize;

        public string patientId, 
                      patientName, 
                      patientGender, 
                      patientLaterality, 
                      patientYearOfBirth, 
                      trialId, 
                      trialCateogry, 
                      trialTask, 
                      trialSpeed;

        public int numberOfClicks, 
                   errorsCounter, 
                   taskDuration, 
                   taskSize, 
                   accuracyRate;

        public double taskScore; //number of points to execute a specific task

        

        public Trial2(System.IO.StreamReader _log, string _trialTestSequence)
        {
            informationContent = retrievesInfo(_log);
        }


        private List<Info> retrievesInfo(System.IO.StreamReader log)
        {
            List<Info> information = new List<Info>();

            while (!log.EndOfStream)
                information.Add(new Info(log.ReadLine()));

            return information;
        }

    }
}
