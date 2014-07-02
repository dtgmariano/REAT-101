using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing();

namespace Virtual_Keypad
{
    public static class KeypadProcessor
    {
        public static int calculateTask(string _sentence, Dictionary<string,Point> _keysCoordinates)
        {
            int score = 0;
            Dictionary<String, int> weightOfTheKeys = processWeights(_keysCoordinates);

            foreach(char c in _sentence)
            {
                score += weightOfTheKeys[c.ToString()];
            }

            score = 0;

            return score;
        }

        public List<string> convertSentence(string _sentence)
        {
            List<string> task = new List<string>();
            
            foreach(char c in _sentence)
            {
                if(!c.ToString().Equals(" "))
                {
                    task.Add(c.ToString());
                }
                else
                {
                    task.Add("space");
                }
            }

            return task;
        }

        public static Dictionary<String, int> processWeights(Dictionary<string,Point> _keysCoordinates)
        {
            Dictionary<String, int> weightOfTheKeys = new Dictionary<string, int>();

            foreach(KeyValuePair<string, Point> data in _keysCoordinates)
            {
                weightOfTheKeys.Add(data.Key, calculateKeyWeight(data.Value));
            }

            return weightOfTheKeys;
        }

        public static int calculateKeyWeight(Point _coordinate)
        {
            return (_coordinate.X + _coordinate.Y);
        }

        

    }
}
