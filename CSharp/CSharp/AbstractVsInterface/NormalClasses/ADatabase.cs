using CSharp.AbstractVsInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.AbstractVsInterface.NormalClasses
{
    public class ADatabase : IDatabase
    {
        public void ShowDatabaseName()
        {
            Console.WriteLine("Connecting to A database...");
        }
    }
}
