using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ValidPalindromeII
    {
        public static bool ValidPalindrome(string s)
        { 
            int left = 0;
            int right = s.Length - 1;

            while(left < right)
            {
                if (s[left] != s[right])
                    return checkPalindorm(s, left + 1, right) || checkPalindorm(s, left, right - 1);

                left++;
                right--;
            }

            return true;
        }

        public static bool checkPalindorm(string s, int i, int j)
        {
            while(i < j)
            {
                if (s[i] != s[j])
                    return false;

                i++;
                j--;
            }
            return true;
        }
    }
}
