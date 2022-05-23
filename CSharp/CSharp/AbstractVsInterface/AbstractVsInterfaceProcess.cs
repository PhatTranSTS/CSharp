using CSharp.AbstractVsInterface.Abstract;
using CSharp.AbstractVsInterface.Interface;
using CSharp.AbstractVsInterface.NormalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.AbstractVsInterface
{
    public class AbstractVsInterfaceProcess
    {
        public void RunExampleAbstractClasses()
        {
            Console.WriteLine("===== Example Abstract =====");
            //Bank bank = new Bank(); // Cannot create a instance of an abstract

            Console.WriteLine("--VPBank--");
            VpBank vpBank = new VpBank(70000);
            vpBank.CashWithDraw(30000);

            Console.WriteLine("--AriBank--");
            AriBank ariBank = new AriBank(70000);
            ariBank.CashWithDraw(30000);
            Console.WriteLine("===== End Example Abstract =====");
        }

        public void RunExampleInterface()
        {
            Console.WriteLine("===== Example Interface =====");

            Console.WriteLine("--Square--");
            IPolygon square = new Square();
            square.calculateArea(10, 10);

            Console.WriteLine("--Car--");
            Car car = new Car();
            car.showEnginePower(1000);
            car.showColor("black");

            Console.WriteLine("--Tank--");
            Tank tank = new Tank();
            tank.showEnginePower(5000);
            tank.showColor("green");
            tank.showWeaponPower(2500);

            Console.WriteLine("--Fruit--");
            Fruit fruit = new Fruit();
            fruit.showColor("red");

            Console.WriteLine("===== End Example Interface =====");
        }
    }
}
