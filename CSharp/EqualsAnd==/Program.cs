using System;

namespace EqualsAnd__
{
    class Program
    {
        static void Main(string[] args)
        {
            Object str = "Test";
            char[] str2 = {'T', 'e', 's', 't'};
            object str3 = new String(str2);

            Console.WriteLine($"Using Equality operator: {str == str2}");
            Console.WriteLine($"Using Equality operator: {str == str3}");

            Console.WriteLine($"Using equals() method: {str.Equals(str2)}");
            Console.WriteLine($"Using equals() method: {str.Equals(str3)}");

            string str4 = null;
            string str5 = "Test 2";

            Console.WriteLine($"Using Equality operator: {str4 == str5}");
            //Console.WriteLine($"Using equals() method: {str4.Equals(str5)}");

            Console.ReadLine();
        }
    }
}
