using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//f(n)=f(n-2)+f(n-1),f(1)=1 oraz f(2)=1.
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FiboRecursive(number));
            Console.WriteLine("inter" + FiboIterative(number));
            Console.ReadLine();
        }

        static int FiboRecursive(int num)
        {
            if (num == 2 || num == 1)
                return 1;
            return FiboRecursive(num - 2) + FiboRecursive(num - 1);
        }

        static int FiboIterative(int num)
        {
            int result = 1;
            int fib = 1;
            if (num == 2 || num == 1)
                return result;

            for(int i = 3; i <= num; i++)
            {
                int temp = fib;
                fib = result;
                result = temp + result;
            }
            return result;
        }
    }
}
