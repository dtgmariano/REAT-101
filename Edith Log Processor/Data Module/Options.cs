using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log_Processor
{
    public static class Options
    {
        public enum Actions
        {
            /*directional buttons*/
            ActionColumnSelectedFirstKeyboard,
            ActionKeySelectedFirstKeyboard,

            ActionHomeSelectedFirstKeyboard,
            ActionEndSelectedFirstKeyboard,
            ActionSaveSelectedFirstKeyboard,

            ActionBackspaceSelectedFirstKeyboard,
            ActionSpaceSelectedFirstKeyboard,
            ActionPageUpSelectedFirstKeyboard,
            ActionPageDownSelectedFirstKeyboard,

            /*directional buttons*/
            ActionLeftSelectedFirstKeyboard,
            ActionRightSelectedFirstKeyboard,
            ActionUpSelectedFirstKeyboard,
            ActionDownSelectedFirstKeyboard,

            ActionReturnSelectedFirstKeyboard,
            ActionSpeechSelectedFirstKeyboard
        }

        public enum Category
        {
            AccelerometerHandConfiguration, //Accelerometer positioned at the hand
            MouseConfiguration,
            AccelerometerShoulderConfiguration  //Accelerometer positioned at the shoulder
        }

        public enum Gender
        {
            Feminino,
            Masculino
        }

        public enum Laterality
        {
            Direita,
            Esquerda
        }


        public static readonly Dictionary<int, string> Sentences = new Dictionary<int, string>()
        {
            {1, "GAZETA PUBLICA HOJE BREVE NOTA DE FAXINA NA QUERMESSE"}
        };

        public static readonly Dictionary<int, string> Timers = new Dictionary<int, string>()
        {
            {1000, "1000 ms"},
            {700, "700 ms"},
            {400, "400 ms"}
            
        };



        //public static readonly Dictionary<Options, string> OptionsTypes = new Dictionary<Options, string>()
        //{
        //    {Options.ActionBackspaceSelectedFirstKeyboard,"Backspace"},
        //    {Options.ActionColumnSelectedFirstKeyboard,"Column"},
        //    {Options.ActionKeySelectedFirstKeyboard,"Key"},
        //    {Options.ActionLeftSelectedFirstKeyboard,"Left"},
        //    {Options.ActionRightSelectedFirstKeyboard,"Right"},
        //    {Options.ActionSpaceSelectedFirstKeyboard,"Space"}
        //};
    }
}