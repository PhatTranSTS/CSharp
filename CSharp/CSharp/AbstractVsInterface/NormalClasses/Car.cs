using CSharp.AbstractVsInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.AbstractVsInterface.NormalClasses
{
    public class Car : IEngine, IColor
    {
        public string Name { get; set; }
        public void showColor(string colorName)
        {
            Console.WriteLine($"Car color: {colorName}");
        }

        public void showEnginePower(int powerNumber)
        {
            Console.WriteLine($"Car power: {powerNumber}");
        }
    }
}
