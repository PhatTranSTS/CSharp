using AbstractAndInterface.InterfaceDemo.Interface;
using System;

namespace AbstractAndInterface.InterfaceDemo.NormalClasses
{
    public class ADatabase : IDatabase
    {
        public void ShowDatabaseName()
        {
            Console.WriteLine("Connecting to A database...");
        }
    }
}
