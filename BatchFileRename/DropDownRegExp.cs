using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BatchFileRename
{
    class DropDownRegExp
    {
        public static readonly string None = WinFormsStrings.None;
        public static readonly string Lower = WinFormsStrings.Lower;
        public static readonly string Upper = WinFormsStrings.Upper;
        public static readonly string FirstCharTextUpper = WinFormsStrings.FirstCharTextUpper;
        public static readonly string FirstCharAllWordsUpper = WinFormsStrings.FirstCharAllWordsUpper;

        public static string[] Values
        {
            get
            {
                return new[]
                {
                    WinFormsStrings.None,
                    WinFormsStrings.Lower,
                    WinFormsStrings.Upper,
                    WinFormsStrings.FirstCharTextUpper,
                    WinFormsStrings.FirstCharAllWordsUpper
                };
            }
        }
    }
}
