using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class LetterCombinationsOfAPhoneNumber
    {
        public static IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (digits == null || digits.Length == 0)
                return result;
            
            string[] letterArray = new string[] {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            backtracking(0, digits, "", letterArray, result);

            return result;
        }

        private static void backtracking(int id, string digits, string path, string[] lettersArray, List<string> result)
        {
            if(id == digits.Length)
            {
                result.Add(path);
                return;
            }

            string letters = lettersArray[digits[id] - '0'];
            for(int i = 0; i < letters.Length; i++)
            {
                path += letters[i];
                backtracking(id + 1, digits, path, lettersArray, result);
                path = path.Remove(path.Length - 1, 1);
            }
        }
    }
}
