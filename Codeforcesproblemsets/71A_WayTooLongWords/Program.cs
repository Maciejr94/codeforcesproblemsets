using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71A_WayTooLongWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
                list.Add(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                if(list[i].Length > 10)
                {
                    list[i] = list[i].First().ToString() + (list[i].Length - 2) + list[i].Last().ToString();
                }
            }


            foreach (string s in list)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
