using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! " + DateTime.Now);
            string name;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);

            //alternate way to write using interpolation
            Console.WriteLine($"Welcome {name}");
        }
    }
}
