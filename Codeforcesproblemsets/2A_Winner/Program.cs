using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2A_Winner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Dictionary<string, int> list = new Dictionary<string, int>();
            List<KeyValuePair<string, int>> step = new List<KeyValuePair<string, int>>();
            int max = int.MinValue;
            string winner = string.Empty;
            for(int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                var data = temp.Split(' ');
                string name = data[0];
                int points = int.Parse(data[1]);
                
                if (!list.ContainsKey(name)) list.Add(name, 0);
                list[name] += points;

                step.Add(new KeyValuePair<string, int>(name, list[name]));
            }

            foreach(var s in list)
                if (max < s.Value)
                    max = s.Value;

            

            foreach (var s in step)
                Console.WriteLine(s.Key + "|" + s.Value);
            Console.ReadLine();
        }
    }
}
