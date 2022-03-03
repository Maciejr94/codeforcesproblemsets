using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102948D_Firewood
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nab = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            int count = 0;
            do
            {
                if(count % 2 == 0)
                    nab[0] = nab[0] - GCD(nab[0], nab[2]);
                else
                    nab[0] = nab[0] - GCD(nab[0], nab[1]);

                count++;
            }
            while (nab[0] > 0);

            Console.WriteLine(count % 2 == 0 ? "1" : "0");
            Console.ReadLine();
        }

        static int GCD(int a, int b)
        {
            while(b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
