using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50A_DominoPiling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            Console.WriteLine( (nk[0]*nk[1]) / 2);
            Console.ReadLine();
        }
    }
}
