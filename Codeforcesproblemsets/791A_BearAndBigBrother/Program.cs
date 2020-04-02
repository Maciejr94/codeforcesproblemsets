using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _791A_BearAndBigBrother
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int i = 0;
            string[] tokens = Console.ReadLine().Split();
            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            while (a <= b)
            {
                i++;
                a *= 3;
                b *= 2;
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
