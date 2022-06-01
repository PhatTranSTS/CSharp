using AbstractAndInterface.InterfaceDemo.Interface;
using System;

namespace AbstractAndInterface.InterfaceDemo.NormalClasses
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
