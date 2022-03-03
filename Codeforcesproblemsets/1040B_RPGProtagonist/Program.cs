using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1040B_RPGProtagonist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> results = new List<int>();
            int t = int.Parse(Console.ReadLine());
            int index = 0;
            while(index < t)
            {
                int result = 0;
                List<int> pf = Console.ReadLine().Split().Select(i => int.Parse(i)).ToList();
                List<int> cntsw = Console.ReadLine().Split().Select(i => int.Parse(i)).ToList();
                List<int> sw = Console.ReadLine().Split().Select(i => int.Parse(i)).ToList();

                if(sw[0] > sw[1])
                {
                    int temp = sw[0];
                    sw[0] = sw[1];
                    sw[1] = temp;
                    temp = cntsw[0];
                    cntsw[0] = cntsw[1];
                    cntsw[1] = temp;
                }

                for(int i = 0; i <= Math.Min(cntsw[0], (pf[0]/sw[0])); i++)
                {
                    var w1 = Math.Min(cntsw[1], (pf[0] - (i * sw[0])) / sw[1]);
                    var s2 = Math.Min(cntsw[0] - i, pf[1] / sw[0]);
                    var w2 = Math.Min(cntsw[1] - w1, (pf[1] - (s2 * sw[0])) / sw[1]);
                    result = Math.Max(result, i + w1 + s2 + w2);
                }
                results.Add(result);
                index++;
            }

            foreach (var r in results)
                Console.WriteLine(r);

            Console.ReadLine();
        }
    }
}
