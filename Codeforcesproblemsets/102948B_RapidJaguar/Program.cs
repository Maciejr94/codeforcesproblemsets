using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102948B_RapidJaguar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            int[] a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            int sum = 0; int cant = -1;

            int j = 0;
            do
            {
                sum += a[j];
                j++;
                if (sum >= nk[1])
                {
                    Console.WriteLine(j);
                    break;
                }

            } while (j < a.Length);

            if (sum < nk[1])
                Console.WriteLine(cant);
            Console.ReadLine();
        }
    }
}
