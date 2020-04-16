using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1097A_GennadyAndACardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "NO";
            var input = Console.ReadLine().ToCharArray();
            string[] tokens = Console.ReadLine().Split();
            for(int i = 0; i< tokens.Length; i++)
            {
                if (tokens[i][0].Equals(input[0]) || tokens[i][1].Equals(input[1]))
                {
                    result = "YES";
                    break;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
