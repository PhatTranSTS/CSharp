using AbstractAndInterface.InterfaceDemo.NormalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface.InterfaceDemo
{
    public class InterfaceDemoProcess
    {
        public void RunCommonExample()
        {
            Console.WriteLine("===== Common Example Interface =====");

            Console.WriteLine("--Fruit--");
            Fruit fruit = new Fruit();
            fruit.showColor("red");

            Console.WriteLine("--Car--");
            SportCar car = new SportCar();
            car.showEnginePower(1000);
            car.showColor("black");

            Console.WriteLine("--Tank--");
            Tank tank = new Tank();
            tank.showEnginePower(5000);
            tank.showColor("green");
            tank.showWeaponPower(2500);

            Console.WriteLine("===== Common Example Interface =====");
        }

        public void RunDIExample()
        {
            Console.WriteLine("===== DI Example Interface =====");

            ADatabase aDatabase = new ADatabase();
            BDatabase bDatabase = new BDatabase();

            DatabaseConnection databaseConnection = new DatabaseConnection(aDatabase);
            databaseConnection.ShowConnection();

            databaseConnection = new DatabaseConnection(bDatabase);
            databaseConnection.ShowConnection();

            Console.WriteLine("===== DI Example Interface =====");

        }
    }
}
