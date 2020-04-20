using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1223A_CME
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 2) Console.WriteLine("2");
                else if (n % 2 == 1) Console.WriteLine("1");
                else if (n % 2 == 0 && n > 2) Console.WriteLine("0");
            }
        }
    }
}
