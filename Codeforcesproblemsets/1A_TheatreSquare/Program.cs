using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal [] nums = Console.ReadLine().Split().Select(i => decimal.Parse(i)).ToArray();
            Console.WriteLine(Math.Ceiling(nums[0] / nums[2]) * Math.Ceiling(nums[1] / nums[2]));
            Console.ReadLine();

        }
    }
}
