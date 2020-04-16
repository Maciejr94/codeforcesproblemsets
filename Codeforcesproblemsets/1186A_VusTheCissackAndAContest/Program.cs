using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1186A_VusTheCissackAndAContest
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(), i => int.Parse(i));
            Console.WriteLine((input[1] >= input[0] && input[2] >= input[0]) ? "Yes" : "No");
            Console.ReadLine();
        }
    }
}
