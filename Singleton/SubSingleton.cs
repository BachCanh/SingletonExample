using System;

namespace SingletonExample
{
    public class SubSingleton : Singleton
    {
        public SubSingleton()
        {
            Console.WriteLine("SubSingleton constructor called");
        }
    }
}
