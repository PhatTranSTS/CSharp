using AbstractAndInterface.AbstractDemo.NormalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface.AbstractDemo
{
    public class AbstractDemoProcess
    {
        public void RunExample()
        {
            Console.WriteLine("===== Example Abstract =====");

            ABank aBank = new ABank(70000);
            aBank.CashWithDraw(30000);

            CBank cBank = new CBank(70000);
            cBank.CashWithDraw(30000);

            Console.Write("=== EX overload ===");
            cBank.CashWithDraw(30000, true);

            Console.WriteLine("===== End Example Abstract =====");
        }
    }
}
