using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseList
{
    public class Program
    {
        static LinkedList<int> linkedList = new LinkedList<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        static List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static string word = "vitamin";
        static string palindrom = "kayak";
        static void Main(string[] args)
        {
            //ReverseLinked();
            //Console.WriteLine();
            //ReverseList();
            //Console.WriteLine();
            //ReverseString();
            //Console.WriteLine();
            Console.Write(IsPalindrom(palindrom));
            


            Console.ReadKey();

        }

        static public void ReverseLinked()
        {
            var current = linkedList.First;
            while(current.Next!= null)
            {
                var next = current.Next;
                linkedList.Remove(next);
                linkedList.AddFirst(next.Value);            
            }
           
            foreach (int i in linkedList)
                Console.Write(i + " ");
        }

        static public void ReverseList()
        {
            for(int i = 0; i < list.Count - 1; i++)
            {
                int current = i + 1;
                var next = list[current];
                list.Remove(next);
                list.Insert(0, next);
            }
            foreach (int i in list)
                Console.Write(i + " ");
        }

        static void ReverseString()
        {
            char[] arr = word.ToCharArray();
            word = String.Empty;
            for(int i = arr.Length - 1; i >= 0; i--)
                word += arr[i];

            Console.Write(word);
        }

        static bool IsPalindrom(string word)
        {
            string wordToCheck = word.Replace(" ", "").ToLower();
            int length = wordToCheck.Length - 1;
            for(int i = 0; i < length; i++)
            {
                if (wordToCheck[i] != wordToCheck[length])
                    return false;

                length--;
            }

            return true;
        }

        static int Factorial(int x)
        {
            if (x == 0)
                return 1;
            return x * Factorial(x - 1);
        }
    }
}
