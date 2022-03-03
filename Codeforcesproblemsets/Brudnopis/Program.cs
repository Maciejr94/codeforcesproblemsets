﻿using System;
using System.Collections.Generic;
using test1;

namespace Brudnopis
{

    #region interface, abstract inheriting
    abstract class Animal
    {
        public string stringValue()
        {
            return "aBcD";
        }
        public abstract void animalSound();

        public abstract int someValue();

        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    interface IFirstInterface
    {
        public void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myMethod(); // interface method
    }

    class DemoClass : Animal, IFirstInterface, ISecondInterface
    {
        public override int someValue()
        {
            return 1;
        }
        public override void animalSound()
        {
            throw new NotImplementedException();
        }

        void IFirstInterface.myMethod()
        {
            throw new NotImplementedException();
        }

        void ISecondInterface.myMethod()
        {
            throw new NotImplementedException();
        }
    }

    #endregion


    #region delegaty
    delegate int ChangeNumber(int i);
    #endregion


    #region virutal methods
    public class Car
    {
        public virtual void Start()
        {
            Console.WriteLine("Car started.");
        }
    }
    public class FastCar : Car
    {
        public override void Start()
        {
            Console.WriteLine("FastCar started.");
        }
    }

    #endregion virutal methods

    
    class Program
    {
        #region delegaty
        static int number = 5;
        public static int AddNumber(int i)
        {
            number += i;
            return number;
        }
        public static int MultiplyNumber(int i)
        {
            number *= i;
            return number;
        }
        public static int GetNumber()
        {
            return number;
        }
        #endregion delegaty

        static void Main(string[] args)
        {
            string s = "Hello World";
            s.StringToPrint();
            User u = new User("John", "Travolta", 45);
            u.LogInfo();
        }

    }
        public static class LogExtension {
            public static void StringToPrint(this string value) {
                Console.WriteLine(value);
            }
            public static void LogInfo(this User user) {
                Console.WriteLine($"New user {user.FirstName}");
            }
        }
      
   }


namespace test1 {
    public class Parent
    {

        // Declaring member as protected internal
        protected internal int valueeee;
        private protected int value3;
        public void ParentTest()
        {
            Parent p = new Parent();
            p.valueeee = 5;
            p.value3 = 3;
        }
    }
}

namespace test2
{
    public class ABC: Parent
    {
        public void ABCTest()
        {
            value3 = 3;
            valueeee = 5;
        }
    }
}
//List<int> lista = new List<int>();
//lista.Add(1);
//lista.Add(2);
//lista.Add(3);
//lista.Add(4);

//Dictionary<int, int> dict = new Dictionary<int, int>();
//dict.Add(5, 5);
//dict.Add(2, 2);
//dict.Add(7, 7);
//dict.Add(1, 1);
//dict.Add(3, 3);

//Console.WriteLine(dict[6]);
//Console.WriteLine(lista[1]);


////ChangeNumber cn;
////ChangeNumber cn1 = new ChangeNumber(AddNumber);
////ChangeNumber cn2 = new ChangeNumber(MultiplyNumber);
////cn = cn1;
////cn += cn2;
////cn(5);
////Console.WriteLine("Wartość liczby: {0}", GetNumber());
////Console.WriteLine("Hello World!");

////Car car = new Car();
////car.Start(); //'Car started.'
////Car carFastCar = new FastCar();  
////carFastCar.Start();//'FastCar started.'