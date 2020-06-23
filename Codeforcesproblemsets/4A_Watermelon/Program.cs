using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A_Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            if (q > 2 && q % 2 == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            
            Console.ReadLine();
        }
    }
}
