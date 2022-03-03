using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class RomantoInteger
    {
        public static int RomanToInt(string s)
        {

            Dictionary<string, int> dict = new Dictionary<string, int>();
            int result = 0;

            dict.Add("I", 1);
            dict.Add("V", 5);
            dict.Add("X", 10);
            dict.Add("L", 50);
            dict.Add("C", 100);
            dict.Add("D", 500);
            dict.Add("M", 1000);
            dict.Add("IV", 4);
            dict.Add("IX", 9);
            dict.Add("XL", 40);
            dict.Add("XC", 90);
            dict.Add("CD", 400);
            dict.Add("CM", 900);

            for (int i = 0; i < s.Length; i++)
                if ((s[i] == 'I' || s[i] == 'X' || s[i] == 'C') && i < s.Length - 1 && dict.ContainsKey(s.Substring(i, 2)))
                    result += dict[s.Substring(i++, 2)];
                else
                    result += dict[s[i].ToString()];

            return result;




            // #################################################################
            // sposób z odejmowaniem
            // #################################################################


            //int result = 0;
            //var romanCharsNum = new Dictionary<char, int>()
            //{
            //    { 'I', 1 },
            //    { 'V', 5 },
            //    { 'X', 10 },
            //    { 'L', 50 },
            //    { 'C', 100 },
            //    { 'D', 500 },
            //    { 'M', 1000 },
            //};

            //for (int i = 0; i < s.Length - 1; i++)
            //{
            //    if (romanCharsNum[s[i]] >= romanCharsNum[s[i + 1]])
            //        result += romanCharsNum[s[i]];
            //    else
            //        result -= romanCharsNum[s[i]];
            //}
            //result += romanCharsNum[s[s.Length - 1]];

            //return result;
        }
    }
}
