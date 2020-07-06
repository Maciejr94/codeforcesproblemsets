using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _158A_NextRound
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] nk = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            int[] results = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            Console.WriteLine(results.Count( i => i >= results[nk[1] - 1] && i != 0 ));

            Console.ReadLine();
        }
    }
}
