using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102948C_WhiteFang
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "Yes";
            int[] rc = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            List<string> words = new List<string>();
            for(int i = 0; i< rc[0]; i++)
            {
                words.Add(Console.ReadLine());
            }

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].IndexOf('P') != -1 && i > 0)
                {
                    if(words[i - 1][words[i].IndexOf('P')].Equals('W'))
                    {
                        result = "No";
                        break;
                    }
                    
                }
                if (words[i].IndexOf('P') != -1 && i < words.Count - 1)
                {
                    if(words[i + 1][words[i].IndexOf('P')].Equals('W')){
                        result = "No";
                        break;
                    }
                    
                }
                if (words[i].IndexOf('P') != -1 && words[i].IndexOf('P') > 0)
                {
                    if (words[i][words[i].IndexOf('P') - 1].Equals('W'))
                    {
                        result = "No";
                        break;
                    }
                    
                }
                if (words[i].IndexOf('P') != -1 && words[i].IndexOf('P') < words[i].Length - 1)
                {
                    if(words[i][words[i].IndexOf('P') + 1].Equals('W'))
                    {
                        result = "No";
                        break;
                    }
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
