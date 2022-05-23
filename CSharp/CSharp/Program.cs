using CSharp.AbstractVsInterface;
using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example Abstract Vs Interface
            AbstractVsInterfaceProcess abstractVsInterfaceProcess = new AbstractVsInterfaceProcess();
            abstractVsInterfaceProcess.RunExampleAbstractClasses();
            abstractVsInterfaceProcess.RunExampleInterface();
        }
    }
}
