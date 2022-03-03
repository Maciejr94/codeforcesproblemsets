using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectPatterns.CreativePattern
{
    public class Singleton
    {
       
        private static Singleton singleton;
        private Singleton()
        {
            
        }

        public static Singleton getInstance()
        {
            if(singleton == null)
            {
               
                singleton = new Singleton();
            }
            
            return singleton;
        }

        public void Main()
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();
            if (s1 == s2)
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            else
                Console.WriteLine("Singleton failed, variables contain different instances.");
        }
    }

    public class SingletonLock
    {
        private static SingletonLock singleton;
        private static readonly object _lock = new object();
        public string Value { get; set; }
        private SingletonLock()
        {

        }
        public static SingletonLock getInstance(string value)
        {
            if (singleton == null)
            {
                lock (_lock)
                {
                    if (singleton == null)
                    {
                        singleton = new SingletonLock();
                        singleton.Value = value;
                    }
                }
               // singleton = new SingletonLock();
            }
            return singleton;
        }

        public void Main()
        {
            Thread proccess1 = new Thread(() =>
            {
                SingletonLock singleton = SingletonLock.getInstance("FOO");
                Console.WriteLine(singleton.Value);
            });
            Thread proccess2 = new Thread(() =>
            {
                SingletonLock singleton = SingletonLock.getInstance("BOO");
                Console.WriteLine(singleton.Value);
            });

            proccess1.Start();
            proccess2.Start();

            proccess1.Join();
            proccess2.Join();
        }
    }
}

