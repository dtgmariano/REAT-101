using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log_Processor
{
    public class Task
    {
        //public int ID;
        public Options.TrialCategory category;
        public int timer; //timer configured at the EDITH in milisseconds
        public string sentence;

        public Task(Options.TrialCategory _category, int _taskTimer, string _sentence)
        {
            category = _category;
            timer = _taskTimer;
            sentence = _sentence;
        }
    
    }
}
