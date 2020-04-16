using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1220A_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            int n = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();

            int a = 0;
            int b = 0;
            for (int i = 0; i < n; i++){
                if (word[i].Equals('n'))
                    a++;
                else if (word[i].Equals('z'))
                    b++;
            }

            for(int i = 0; i < a; i++)
                result += "1 ";
            for (int i = 0; i < b; i++)
                result += "0 ";
            
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
