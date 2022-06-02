using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class BoatsToSavePeople
    {
        public static int NumRescueBoats(int[] people, int limit)
        {
            people = people.OrderBy(x => x).ToArray();
            int result = 0;
            int i = 0;
            int j = people.Length - 1;

            while(i <= j)
            {
                result++;
                if (people[i] + people[j] <= limit)
                    i++;
                j--;
            }

            return result;

        }
    }
}
