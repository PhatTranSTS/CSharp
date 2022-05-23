using CSharp.AbstractVsInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.AbstractVsInterface.NormalClasses
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
