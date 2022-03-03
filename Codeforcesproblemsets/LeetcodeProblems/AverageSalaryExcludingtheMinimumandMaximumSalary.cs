using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class AverageSalaryExcludingtheMinimumandMaximumSalary
    {
        //salary = [4000,3000,1000,2000]
        //Output: 2500.00000
        public static double Average(int[] salary)
        {
            int MaxSalary = int.MinValue;
            int MinSalary = int.MaxValue;
            int result = 0;

            for(int i = 0; i < salary.Length; i++)
            {
                result += salary[i];
                if (salary[i] > MaxSalary)
                    MaxSalary = salary[i];
                if (salary[i] < MinSalary)
                    MinSalary = salary[i];
            }

            return (double)(result - MaxSalary - MinSalary) / (salary.Length - 2);
        }
    }
}
