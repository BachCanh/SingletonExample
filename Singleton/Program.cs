using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Singleton Instance ----");
            var s1 = Singleton.Instance();

            Console.WriteLine("---- SubSingleton Instance ----");
            var s2 = new SubSingleton();  
        }
    }
}
