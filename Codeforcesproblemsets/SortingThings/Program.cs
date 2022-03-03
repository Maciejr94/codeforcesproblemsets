using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingThings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = CreateList();
            Console.WriteLine("Random numbers");
            foreach (var v in list)
                Console.Write(v + " ");
            Console.WriteLine();

            #region MergeSort
            Console.WriteLine("MergeSort");
            MergeSort ms = new MergeSort();
            foreach(var g in ms.doSort(list))
                Console.Write(g + " ");
            #endregion
            Console.WriteLine();
            #region QuickSort
            Console.WriteLine("QuickSort");
            QuickSort qs = new QuickSort(list);
            qs.doSort(0, list.Count - 1);
            foreach (var q in qs.printlist2())
                Console.Write(q + " ");
            #endregion
            Console.WriteLine();
            #region BubbleSort
            Console.WriteLine("BubbleSort");
            BubbleSort bs = new BubbleSort(list);
            foreach (var b in bs.doSort())
                Console.Write(b + " ");
            #endregion




            Console.ReadLine();
        }


        //creating random unsroted list with integer number
        static public List<int> CreateList()
        {
            List<int> unsorted = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 18; i++)
                unsorted.Add(random.Next(0, 100));

            return unsorted;
        }
    }
}
