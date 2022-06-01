using OverloadingAndOverriding.Models;
using System;

namespace OverloadingAndOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Overloading And Overriding ===");

            Console.Write("--Animal--");
            Animal animal = new Animal();
            animal.Eat();

            Console.Write("--Lion--");
            Lion lion = new Lion();
            lion.Eat();

            Console.Write("--Deer--");
            Deer deer = new Deer();
            deer.Eat();
            deer.Eat("Blue");

            Console.ReadLine();
        }
    }
}
