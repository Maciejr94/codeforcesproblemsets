using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            OneLaneFizzBuzz();
            //FizzBuzz();
            Console.WriteLine("====================");
            RecursiveFizzBuzz(100);
            Console.ReadLine();
        }

        static void FizzBuzz()
        {
            Console.WriteLine("=========");
            for(int i = 1; i <= 100; i++)
                if (i % 5 == 0 && i % 3 == 0)
                    Console.WriteLine("FizzBuzz");
                else if(i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
        }

        static void OneLaneFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
                Console.WriteLine(i % 15 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString());
        }

        static void RecursiveFizzBuzz(int number)
        {
            if (number > 0)
            {
                RecursiveFizzBuzz(number - 1);
                Console.WriteLine(number % 5 == 0 && number % 3 == 0 ? "FizzBuzz" : number % 3 == 0 ? "Fizz" : number % 5 == 0 ? "Buzz" : number.ToString());
            }
        }
    }
}
