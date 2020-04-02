using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030A_InSearchOfAnEasyProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "EASY";
            int n = int.Parse(Console.ReadLine());
            string[] tokens = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(tokens[i]) == 1)
                    result = "HARD";
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
