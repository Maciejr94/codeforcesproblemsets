using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102948E_FoodAllocationI
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = -1;
            List<int[]> data = new List<int[]>();
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
                data.Add(Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray());

            List<List<List<int>>> combinations = new List<List<List<int>>>();
            List<List<List<int>>> newCombinations = new List<List<List<int>>>();

            int index = 0;
            for (int i = 0; i < data[0].Length; i++)
            {
                List<List<int>> temp = new List<List<int>>();
                List<int> temp2 = new List<int>();
                temp2.Add(data[0][i]);
                temp2.Add(i);
                temp.Add(temp2);
                combinations.Add(temp);
            }

            index++;
            while (index < data.Count)
            {
                

                List<int> nextData = data[index].ToList();
                newCombinations = new List<List<List<int>>>();
                for (int i = 0; i < combinations.Count; i++)
                {
                    for (int j = 0; j < nextData.Count; j++)
                    {
                        List<List<int>> newTemp = new List<List<int>>();
                        newTemp.AddRange(combinations[i]);
                        var temp = newTemp.Select(s => s[1]).Distinct();
                        if (temp.All(x => x != j))
                        {
                            List<int> tple = new List<int>();
                            tple.Add(nextData[j]);
                            tple.Add(j);
                            newTemp.Add(tple);
                            newCombinations.Add(newTemp);
                        }
                    }
                }
                
                combinations = newCombinations;
                
                index++;
            }

            foreach (var a in combinations)
            {
                int sum = a.Select(x => x[0]).Sum();
                if (sum > result)
                    result = sum;
            }



            Console.WriteLine(result);
            Console.ReadLine();
        }

        
    }
}