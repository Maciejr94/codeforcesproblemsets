using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ExcelSheetColumnNumber
    {
        public static int TitleToNumber(string columnTitle)
        {
            int result = 0;
            foreach (char c in columnTitle)
            {
                int d = c - 'A' + 1;
                result = 26 * result + d;
            }

            return result;
        }

        
        
    }
}
