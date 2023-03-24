using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDesignPatterns.CreationalPatterns;

namespace TheDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetSingletonObject();
            singleton.Print();
            Singleton singleton1 = Singleton.GetSingletonObject();
            singleton1.Print();
            Singleton singleton2 = Singleton.GetSingletonObject();
            singleton2.Print();
            Console.Read();
        }
    }
}
