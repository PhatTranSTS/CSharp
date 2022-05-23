using CSharp.AbstractVsInterface.Abstract;
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
        }
    }
}
