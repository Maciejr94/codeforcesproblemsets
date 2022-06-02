using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    // checking odd length palindromic sub-string and even length palindromic sub-string
    // s = "aba"  ==> countPalindroms("aba", 0, 0) => "a" && countPalindroms("aba", 0, 0 + 1) => "ab"
    // in method after checking expand checking to left-1 && right +1
    // like s = "aaa"  ==> i=1 => "a" then "aaa", both palindrom              | countPalindroms("aaa", 1, 1)
    // lie s = "aaaa" ==> i=1 => "aa" then "aaaa", both palindrom             | countPalindroms("aaaa", 1, 1+1)

    public static class PalindromicSubstrings
    {

        public static int CountSubstrings(string s)
        {
            int result = 0;
            for(int i = 0; i < s.Length; i++)
            {
                result += countPalindroms(s, i, i);
                result += countPalindroms(s, i, i + 1);

            }

            return result;
        }
    
        private static int countPalindroms(string s, int left, int right)
        {
            int count = 0;
            while(left >= 0 && right < s.Length && s[left] == s[right])
            {
                count++;
                left--;
                right++;
            }

            return count;
        }
        private static bool isPalindrom(string word)
        {
            int length = word.Length - 1;
            for(int i = 0; i < length; i++)
            {
                if (word[i] != word[length])
                    return false;

                length--;
            }
            return true;
        }
    }
}
