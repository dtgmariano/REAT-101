using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edith_Stats_App
{
    public static class Options
    {
        public enum Actions
        {
            ActionBackspaceSelectedFirstKeyboard,
            ActionColumnSelectedFirstKeyboard,
            ActionEndSelectedFirstKeyboard,
            ActionHomeSelectedFirstKeyboard,
            ActionKeySelectedFirstKeyboard,
            ActionLeftSelectedFirstKeyboard,
            ActionPageDownSelectedFirstKeyboard,
            ActionPageUpSelectedFirstKeyboard,
            ActionReturnSelectedFirstKeyboard,
            ActionRightSelectedFirstKeyboard,
            ActionSaveSelectedFirstKeyboard,
            ActionSpaceSelectedFirstKeyboard,
            ActionSpeechSelectedFirstKeyboard
        }

        public enum TrialCategory
        {
            MouseConfiguration,
            AccelerometerHandConfiguration, //Accelerometer positioned at the hand
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

