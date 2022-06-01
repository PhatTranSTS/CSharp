using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex1: Need define value of a for ref
            //int a;
            ////int a = 9;
            //Console.WriteLine($"Previous Value of a: {a}");
            //RefMethod(ref a);
            //Console.WriteLine($"Current Value of a: {a}");

            // Ex3:
            int b;
            OutMethod(out b);
            Console.WriteLine($"Current Value of b: {b}");

            Console.ReadLine();
        }

        public static void OutMethod(out int b)
        {
            b = 11;
        }

        public static void RefMethod(ref int a)
        {
            a = 10;
        }

        //Ex2: Ref cannot overload
        //public static void RefMethod(out int a)
        //{
        //    a = 10;
        //}
    }
}
