using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _705A_Hulk
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "I hate", "I love" };
            string[] caps = { " that", " it" };
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    result += words[0];
                else
                    result += words[1];

                if (i == n - 1)
                    result += caps[1];
                else
                    result += caps[0];

                result += " ";
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
