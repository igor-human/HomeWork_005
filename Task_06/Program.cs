using System;
using System.Text;

// Індексатори (перевизначення).

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            DerivedClass instance = new DerivedClass();
            BaseClass instance1 = instance;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(instance1[i]);
            }

            DerivedClass instance2 = new DerivedClass();
            instance2.Search("One!");
            // Delay.
            Console.ReadKey();
        }
    }
}
