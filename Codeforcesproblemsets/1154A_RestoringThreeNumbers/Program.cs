using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1154A_RestoringThreeNumbers
{
    // x1 = a + b , x2 = a + c , x3 = b + c , x4 = a + b + c
    // c = x4 - x1 , b = x4 - x2 , a = x4 - x3

    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(), i => int.Parse(i));
            Array.Sort(input);

            Console.WriteLine($"{input[3] - input[0]} {input[3] - input[1]} {input[3] - input[2]}");
            Console.ReadLine();
        }
    }
}
