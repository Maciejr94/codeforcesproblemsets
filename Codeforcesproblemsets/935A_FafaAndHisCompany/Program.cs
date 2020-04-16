using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _935A_FafaAndHisCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++)
                if ((n - i) % i == 0)
                    result++;

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
