using System;

namespace SingletonExample
{
    public class Singleton
    {
        private static Singleton _instance;

        protected Singleton()
        {
            Console.WriteLine("Singleton constructor called");
        }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
