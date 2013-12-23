using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edith_Stats_App
{
    public class Info
    {
        public DateTime datetime;
        public Action.Options action;
        public string actionDetail;

        public Info(string line)
        {
            int year, month, day, hour, min, sec, mils;
            year = Convert.ToInt32(line.Substring(0, 4));
            month = Convert.ToInt32(line.Substring(5, 2));
            day = Convert.ToInt32(line.Substring(8, 2));
            hour = Convert.ToInt32(line.Substring(11, 2));
            min = Convert.ToInt32(line.Substring(14, 2));
            sec = Convert.ToInt32(line.Substring(17, 2));
            mils = Convert.ToInt32(line.Substring(20, 3));
            this.datetime = new DateTime(year, month, day, hour, min, sec, mils);

            #region set action and actionDetail
            switch (line[30])
            {
                case 'B':
                {
                    this.action = Action.Options.ActionBackspaceSelectedFirstKeyboard;
                    this.actionDetail = line.Substring(61, line.Length - 61);
                    break;
                }
                case 'C':
                {
                    this.action = Action.Options.ActionColumnSelectedFirstKeyboard;
                    this.actionDetail = line.Substring(58, line.Length - 58);
                    break;
                }
                case 'K':
                {
                    this.action = Action.Options.ActionKeySelectedFirstKeyboard;
                    this.actionDetail = line.Substring(61, line.Length - 61);
                    break;
                }
                case 'L':
                {
                    this.action = Action.Options.ActionLeftSelectedFirstKeyboard;
                    this.actionDetail = line.Substring(32, line.Length - 32);
                    break;
                }
                case 'R':
                {
                    this.action = Action.Options.ActionRightSelectedFirstKeyboard;
                    this.actionDetail = line.Substring(33, line.Length - 33);
                    break;
                }
                case 'S':
                {
                    this.action = Action.Options.ActionSpaceSelectedFirstKeyboard;
                    this.actionDetail = line.Substring(57, line.Length - 57);
                    break;
                }
            }
            #endregion

        }
    }
}
