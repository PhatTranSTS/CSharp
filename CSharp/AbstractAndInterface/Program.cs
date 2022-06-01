using AbstractAndInterface.AbstractDemo;
using AbstractAndInterface.InterfaceDemo;
using System;

namespace AbstractAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDemoProcess abstractDemoProcess = new AbstractDemoProcess();
            abstractDemoProcess.RunExample();

            Console.WriteLine();

            InterfaceDemoProcess interfaceDemoProcess = new InterfaceDemoProcess();
            interfaceDemoProcess.RunCommonExample();
            interfaceDemoProcess.RunDIExample();

            Console.ReadLine();
        }
    }
}
