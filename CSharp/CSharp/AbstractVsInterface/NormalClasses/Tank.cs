using CSharp.AbstractVsInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.AbstractVsInterface.NormalClasses
{
    public class Tank : IWeapon, IEngine, IColor
    {
        public string Name { get; set; }
        public void shoot()
        {
            Console.WriteLine("Kaboom....");
        }

        public void showColor(string colorName)
        {
            Console.WriteLine($"Tank Color: {colorName}");
        }

        public void showEnginePower(int powerNumber)
        {
            Console.WriteLine($"Tank Engine Power: {powerNumber}");
        }

        public void showWeaponPower(int powerNumber)
        {
            Console.WriteLine($"Tank Weapon Power: {powerNumber}");
        }
    }
}
