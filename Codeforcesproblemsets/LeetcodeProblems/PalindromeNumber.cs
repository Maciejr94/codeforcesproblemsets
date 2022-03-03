using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            string result = x.ToString();
            int length = result.Length - 1;
            for(int i = 0; i < length; i++)
            {
                if (result[i] != result[length])
                    return false;

                length--;
            }

            return true;


            // # Without using string solution
            //
            ////all negetive integer are not palindrome
            //if (x < 0)
            //{
            //    return false;
            //}
            //long sum = 0;
            //long n = x;
            //while (x > 0)
            //{
            //    sum = (sum * 10) + (x % 10);
            //    x = x / 10;
            //}

            //return n == sum;
        }

    }

    
}
