using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1B_Spreadsheets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            List<string> result = new List<string>();
            for (int i = 0; i < n; i++)
                list.Add(Console.ReadLine());

            foreach(string s in list)
            {
                char[] c = s.ToCharArray();
                if(s.IndexOf('R') == 0 && s.IndexOf('C') > 1 && char.IsDigit(s[1]))
                {
                    int x = s.IndexOf('C');
                    string a = string.Empty;
                    for (int b = x + 1; b < c.Length; b++)
                        a += c[b];

                    int v = int.Parse(a);
                    string cnvResult = string.Empty;
                    while(v > 0)
                    {
                        cnvResult = (char)('A' + ( v - 1) % 26) + cnvResult;
                        v = (v - 1) / 26;
                    }
            
                    int y = s.IndexOf('R');
                    for (int b = y + 1; b < x; b++)
                        cnvResult += c[b];

                    result.Add(cnvResult);
                }
                else {
                    string t = string.Empty;
                    string cnvResult = "R";
                    foreach (char cz in s.ToCharArray())
                        if (char.IsDigit(cz))
                            cnvResult += cz;
                        else
                            t += cz;

                    cnvResult += "C";
                    int num = 0;
                    for (int m = 0; m < t.Length; m++)
                        num = num * 26 + (t[m] - 'A' + 1);

                    cnvResult += num;
                    result.Add(cnvResult);
                }
            }


            foreach (string s in result)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
