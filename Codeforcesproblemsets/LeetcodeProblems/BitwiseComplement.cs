using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class BitwiseComplement
    {
        public static int BitwiseComplementFunc(int n)
        {
            string binary = Convert.ToString(n, 2);
            Console.WriteLine(binary);
            var a = binary.ToCharArray();
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == '0')
                    a[i] = '1';
                else
                    a[i] = '0';
            }


            return Convert.ToInt32(new string(a), 2);
        }
    }
}
