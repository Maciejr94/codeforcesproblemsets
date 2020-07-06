using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231A_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int n = int.Parse(Console.ReadLine());
            //var str = Console.ReadLine().Split(' ');
            List<string> list = new List<string>();
            for(int i = 0; i < n; i++)
                list.Add(Console.ReadLine().Replace(" ",""));


            foreach(string s in list)
            {
                int semiResult = 0;
                foreach(char c in s)
                    semiResult += c - '0';
                
                if (semiResult >= 2)
                    result++;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
