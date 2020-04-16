using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _959A_MahmoudAndEhabAndTheEvenOddGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "Mahmoud" : "Ehab");
            Console.ReadLine();
        }
    }
}
