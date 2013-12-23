using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edith_Stats_App
{
    public static class Action
    {
        public enum Options
        {
            ActionBackspaceSelectedFirstKeyboard,
            ActionColumnSelectedFirstKeyboard,
            ActionKeySelectedFirstKeyboard,
            ActionLeftSelectedFirstKeyboard,
            ActionRightSelectedFirstKeyboard,
            ActionSpaceSelectedFirstKeyboard

        }

        public static readonly Dictionary<Options, string> OptionsTypes = new Dictionary<Options, string>()
        {
            {Options.ActionBackspaceSelectedFirstKeyboard,"Backspace"},
            {Options.ActionColumnSelectedFirstKeyboard,"Column"},
            {Options.ActionKeySelectedFirstKeyboard,"Key"},
            {Options.ActionLeftSelectedFirstKeyboard,"Left"},
            {Options.ActionRightSelectedFirstKeyboard,"Right"},
            {Options.ActionSpaceSelectedFirstKeyboard,"Space"}
        };
    }
}

,