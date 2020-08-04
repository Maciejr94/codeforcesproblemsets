using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10A_PowerConsumptionCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pt = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            int[] l = new int[100]; 
            int[] r = new int[100];
            int result = 0;
            for(int i = 0; i < pt[0]; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
                l[i] = temp[0];
                r[i] = temp[1];

                result += (r[i] - l[i]) * pt[1];
                if (i > 0)
                {
                    if (l[i] - r[i-1] > pt[4])
                    {
                        result += pt[4] * pt[1];
                        int t = l[i] - r[i - 1] - pt[4];
                        if (t > pt[5])
                        {
                            result += pt[5] * pt[2];
                            result += (t - pt[5]) * pt[3];
                        }
                        else
                            result += t * pt[2];
                    }
                    else
                        result += (l[i] - r[i-1]) * pt[1];
                }

            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
