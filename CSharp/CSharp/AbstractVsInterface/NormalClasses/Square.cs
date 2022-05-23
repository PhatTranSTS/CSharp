using CSharp.AbstractVsInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.AbstractVsInterface.NormalClasses
{
    public class Square : IPolygon
    {
        public void calculateArea(int a, int b)
        {
            int area = a * b;
            Console.WriteLine("Area of Square: " + area);
        }
    }
}
