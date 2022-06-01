using AbstractAndInterface.InterfaceDemo.Interface;
using System;

namespace AbstractAndInterface.InterfaceDemo.NormalClasses
{
    public class SportCar : IEngine, IColor
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
