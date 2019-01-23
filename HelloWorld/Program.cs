using System;
using HelloWorld.Lib;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Sean! Thanks for letting us \"pick\" on you");

            Console.WriteLine($"From the library: {LibraryStuff.Stuff()}");

            var greeter = new Greeter();

            greeter.Greet();
        }
    }
}
