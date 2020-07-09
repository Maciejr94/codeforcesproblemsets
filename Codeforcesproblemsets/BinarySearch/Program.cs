using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("I - for iteration, R - for recursive");
            string whichVersion = Console.ReadLine();
            Console.WriteLine("Array:");
            int[] array = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            Console.WriteLine("Looking value:");
            int x = int.Parse(Console.ReadLine());

            if (whichVersion.ToLower().Equals("i"))
                result = BinarySearchIterative(array, x);
                
            if (whichVersion.ToLower().Equals("r"))
                result = BinarySearchRecursive(array, x, 0, array.Length - 1);
                
            if (result > 0)
                Console.WriteLine("The searching value exists in given array.");
            else
                Console.WriteLine("The searching value does not exists in given array.");
            
            Console.ReadLine();
        }

        //interacja
        static int BinarySearchIterative(int []array, int x)
        {
            int l = 0;
            int r = array.Length - 1;
            while (l <= r)
            {
                int M = l + (r - l) / 2;
                if (array[M] == x)
                    return 1;
                if (array[M] > x)
                    r = M - 1;
                if (array[M] < x)
                    l = M + 1;
            }
            return -1;
        }

        //rekurencja
        static int BinarySearchRecursive(int []array,int x, int l,int r)
        {
            if (l > r)
                return -1;

            int M = l + (r - l) / 2;
            if (array[M] == x)
                return 1;
            if (array[M] > x)
                return BinarySearchRecursive(array, x, l, r - 1);
            if (array[M] < x)
                return BinarySearchRecursive(array, x, l + 1, r);

            return -1;
        }
    }
}
