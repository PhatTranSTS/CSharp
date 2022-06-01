using System;
using System.Text;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== String ====");
            string str = "Hello";
            string str2 = "Hello";
            string str3 = str;
            Console.WriteLine($"str == str2: {Object.ReferenceEquals(str, str2)}");
            Console.WriteLine($"str2 == str3: {Object.ReferenceEquals(str2, str3)}");
            Console.WriteLine($"str == str3: {Object.ReferenceEquals(str, str3)}");

            str += "World";
            Console.WriteLine("\n After add new string into str");
            Console.WriteLine($"str == str2: {Object.ReferenceEquals(str, str2)}");
            Console.WriteLine($"str2 == str3: {Object.ReferenceEquals(str2, str3)}");
            Console.WriteLine($"str == str3: {Object.ReferenceEquals(str, str3)}");

            Console.WriteLine("\n==== String Builder ====");
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.AppendLine(" World!");
            sb.Append("This is next line");
            sb.AppendLine("!!!");

            // AppendFormat
            int amount = 100;
            sb.AppendFormat($"Total amount: {amount:C1}");

            Console.WriteLine(sb);

            // Insert
            StringBuilder sb2 = new StringBuilder("Here is Example!!");
            sb2.Insert(8, "Insert Method of Stringbuilder ");
            Console.WriteLine(sb2);

            // Remove
            sb2.Remove(0, 8);
            Console.WriteLine(sb2);

            // Replace
            sb2.Replace("!!", "");
            Console.WriteLine(sb2);

            Console.ReadLine();
        }
    }
}
