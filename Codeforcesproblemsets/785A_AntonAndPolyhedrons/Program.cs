using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _785A_AntonAndPolyhedrons
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            while (i < n)
            {
                string word = Console.ReadLine().ToLower();
                switch (word)
                {
                    case "tetrahedron":
                        result += 4;
                        break;
                    case "cube":
                        result += 6;
                        break;
                    case "octahedron":
                        result += 8;
                        break;
                    case "dodecahedron":
                        result += 12;
                        break;
                    case "icosahedron":
                        result += 20;
                        break;

                }
                i++;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
