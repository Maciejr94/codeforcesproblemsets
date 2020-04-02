using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _977A_WrongSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            string[] tokens = Console.ReadLine().Split();
            n = int.Parse(tokens[0]);
            k = int.Parse(tokens[1]);
            for(int i = 0; i <k; i++)
                if (n % 10 == 0)
                    n /= 10;
                else
                    n--;

            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
