using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1400A_StringSimilarity
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            int n = int.Parse(Console.ReadLine());
            int index = 0;
            while (index < n)
            {
                int t = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                result.Add(new string(s[t - 1], t));
                index++;
            }

            foreach (var s in result)
                Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
