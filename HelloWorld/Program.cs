using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            // Gather Input
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine();

            // String Interpolation
            Console.WriteLine($"Hello {name}");

            Console.WriteLine();

            // String Concatenation
            Console.WriteLine("Hello {0}", name);
        }
    }
}
