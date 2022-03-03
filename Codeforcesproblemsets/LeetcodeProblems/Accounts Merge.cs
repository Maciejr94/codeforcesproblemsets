using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public class Accounts_Merge
    {
        public static IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {

                for (int i = 0; i < accounts.Count; i++)
                {
                    accounts[i] = accounts[i].Distinct().ToList();
                }

                List<int> toRemove = new List<int>();
            List<IList<string>> result = new List<IList<string>>();
            for (int i = 0; i < accounts.Count; i++)
            {
                for (int j = i + 1; j < accounts.Count; j++)
                {
                    if (accounts[i][0] == accounts[j][0])
                    {

                        List<string> t = accounts[i].Skip(1).Concat(accounts[j].Skip(1)).ToList();

                        bool isUnique = t.Distinct().Count() == t.Count();
                        if (!isUnique)
                        {
                            toRemove.Add(i);
                            toRemove.Add(j);
                            t.Add(accounts[i][0]);
                            result.Add(t.Distinct().ToList());
                        }

                    }
                }
            }
            toRemove = toRemove.Distinct().ToList();
            toRemove.Reverse();
            foreach (var a in toRemove)
                accounts.RemoveAt(a);

            foreach (var a in accounts)
                result.Add(a);

            for (int i = 0; i < result.Count; i++)
            {
                result[i] = result[i].OrderBy(q => q, StringComparer.Ordinal).ToList();
            }

            
            return result;
        }
    }
}
