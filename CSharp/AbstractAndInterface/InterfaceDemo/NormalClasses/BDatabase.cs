using AbstractAndInterface.InterfaceDemo.Interface;
using System;

namespace AbstractAndInterface.InterfaceDemo.NormalClasses
{
    public class BDatabase : IDatabase
    {
        public void ShowDatabaseName()
        {
            Console.WriteLine("Connecting to B database...");
        }
    }
}
