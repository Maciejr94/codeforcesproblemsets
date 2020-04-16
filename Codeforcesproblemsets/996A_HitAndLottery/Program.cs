using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _996A_HitAndLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            while (n > 0)
            {
                if(n >= 100)
                {
                    n -= 100;
                    result++;
                }
                else if (n >= 20)
                {
                    n -= 20;
                    result++;
                }
                else if (n >= 10)
                {
                    n -= 10;
                    result++;
                }
                else if (n >= 5)
                {
                    n -= 5;
                    result++;
                }
                else if (n >= 1)
                {
                    n -= 1;
                    result++;
                }

            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
