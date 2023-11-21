using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x = 10;

            string msg = "Der Wert ist " + x;

            Console.WriteLine(msg);
            Console.WriteLine("Der wert ist {0}", x);
            Console.WriteLine($"Der wert ist {x}");

            Test t1 = new Test();

            // t1.Property = "abc";
            
            t1.ProcessProperty();
        }
    }
}