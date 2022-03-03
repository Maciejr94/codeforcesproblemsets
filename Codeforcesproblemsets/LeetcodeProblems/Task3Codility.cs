using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class Task3Codility
    {
        public static int Task3CodilityFunc(int N)
        {
            bool negative = false;
            if (N < 0)
            {
                negative = true;
                N *= -1;
            }

            string NtoString = N.ToString();

            var foundedFive = new List<int>();
            for (int i = 0; i < NtoString.Length; i++)
                if (NtoString[i] == '5')
                    foundedFive.Add(i);

            List<int> resultArray = new List<int>();
            
            for (int i = 0; i < foundedFive.Count; i++)
            {
                string temp = NtoString;
                temp = temp.Remove(foundedFive[i], 1);
                resultArray.Add(int.Parse(temp));
            }

            int max = 0;
            if(negative)
                max = resultArray.Min(x => x) * -1;
            else
                max = resultArray.Max(x => x);
           
                return max;
        }
    }
}
