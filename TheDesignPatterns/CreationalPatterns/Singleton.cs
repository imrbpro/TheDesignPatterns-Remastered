using System;

namespace TheDesignPatterns.CreationalPatterns
{
    class Singleton
    {
        public static Singleton _singletonObject;
        public static int ObjectCount = 0;
        private Singleton()
        {

        }
        public static Singleton GetSingletonObject()
        {
            if (_singletonObject == null)
            {
                _singletonObject = new Singleton();
                ObjectCount += 1;
            }
            return _singletonObject;
        }

        public void Print()
        {
            Console.WriteLine(" Object Created " + ObjectCount + " Times");
        }
    }
}
