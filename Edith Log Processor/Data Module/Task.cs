using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log_Processor
{
    public class Task
    {
        //public int ID;
        public Options.Category category;
        public int timer; //timer configured at the EDITH in milisseconds
        public string sentence;

        public Task(string _sentence, Options.Category _category, int _taskTimer)
        {
            category = _category;
            timer = _taskTimer;
            sentence = _sentence;
        }
    
    }
}
