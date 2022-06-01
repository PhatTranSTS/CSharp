using AbstractAndInterface.InterfaceDemo.Interface;
using System;

namespace AbstractAndInterface.InterfaceDemo.NormalClasses
{
    public class Fruit : IColor
    {
        public string Name { get; set; }
        public void showColor(string colorName)
        {
            Console.WriteLine($"Fruit color: {colorName}");
        }
    }
}
