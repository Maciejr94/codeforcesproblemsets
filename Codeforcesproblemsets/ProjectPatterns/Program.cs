using ProjectPatterns.CreativePattern;
using System;
using System.Threading;

namespace ProjectPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region SINGLETON TEST
            Singleton.getInstance().Main();
            SingletonLock.getInstance("ABC").Main();
            #endregion SINGLETON TEST

            new FactoryMethod().Main();

            Console.ReadLine();
        }
    }
}
