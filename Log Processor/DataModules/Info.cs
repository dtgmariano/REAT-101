using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log_Processor
{
    public class Info
    {
        public DateTime datetime;
        public Options.Actions action;
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
            this.actionDetail = "";

            #region set action and actionDetail
            switch (line[30])
            {
                case 'B':
                    {
                        this.action = Options.Actions.ActionBackspaceSelectedFirstKeyboard;
                        this.actionDetail = line.Substring(61, line.Length - 61);
                        break;
                    }
                case 'C':
                    {
                        this.action = Options.Actions.ActionColumnSelectedFirstKeyboard;
                        this.actionDetail = line.Substring(64, line.Length - 64);
                        break;
                    }
                case 'D':
                    {
                        this.action = Options.Actions.ActionDownSelectedFirstKeyboard;
                        break;
                    }
                case 'E':
                    {
                        this.action = Options.Actions.ActionEndSelectedFirstKeyboard;
                        break;
                    }
                case 'H':
                    {
                        this.action = Options.Actions.ActionHomeSelectedFirstKeyboard;
                        break;
                    }
                case 'K':
                    {
                        this.action = Options.Actions.ActionKeySelectedFirstKeyboard;
                        this.actionDetail = line.Substring(61, line.Length - 61);
                        break;
                    }
                case 'L':
                    {
                        this.action = Options.Actions.ActionLeftSelectedFirstKeyboard;
                        break;
                    }
                case 'P':
                    {
                        switch(line[34])
                        {
                            case 'D':
                                {
                                    this.action = Options.Actions.ActionPageDownSelectedFirstKeyboard;
                                    break;
                                }
                            case 'U':
                                {
                                    this.action = Options.Actions.ActionPageUpSelectedFirstKeyboard;
                                    break;
                                }
                        }
                        break;
                    }
                case 'R':
                    {
                        switch(line[31])
                        {
                            case 'e':
                                {
                                    this.action = Options.Actions.ActionReturnSelectedFirstKeyboard;
                                    break;
                                }
                            case 'i':
                                {
                                    this.action = Options.Actions.ActionRightSelectedFirstKeyboard;
                                    break;
                                }
                        }
                        break;
                    }
                case 'S':
                    {
                        switch(line[32])
                        {
                            case 'v':
                                {
                                    this.action = Options.Actions.ActionSaveSelectedFirstKeyboard;
                                    break;
                                }
                            case 'a':
                                {
                                    this.action = Options.Actions.ActionSpaceSelectedFirstKeyboard;
                                    this.actionDetail = " ";
                                    break;
                                }
                            case 'e':
                                {
                                    this.action = Options.Actions.ActionSpeechSelectedFirstKeyboard;
                                    this.actionDetail = "";
                                    break;
                                }
                        }
                        break;
                    }
                case 'U':
                    {
                        this.action = Options.Actions.ActionUpSelectedFirstKeyboard;
                        break;
                    }
            }
            #endregion

        }
    }
}
