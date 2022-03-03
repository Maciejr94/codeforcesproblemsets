using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102948A_SpiciestSnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());       
            float winnerValue = 1000.0F;
            string winnerName = String.Empty;
            
            for (int i = 0; i < n; i++)
            {
                string[] entries = Console.ReadLine().Split(' ');
                if (float.Parse(entries[1], CultureInfo.InvariantCulture.NumberFormat) < winnerValue)
                {
                    winnerValue = float.Parse(entries[1], CultureInfo.InvariantCulture.NumberFormat);
                    winnerName = entries[0];
                }

            }
                
            Console.WriteLine(winnerName);
            Console.ReadLine();
        }
    }
}
