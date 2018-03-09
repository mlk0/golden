using System;
using library;
using secundo;

namespace conApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var somethingEntered =   Console.ReadLine();

            var thing = new Thing();
            var result = thing.Get(2, 3);

            Console.WriteLine($"the result is {result}");
            var greeting = new Greeter();
            Console.WriteLine($"Greet {somethingEntered} with :  {greeting.Greet()}");
            
        }
    }
}
