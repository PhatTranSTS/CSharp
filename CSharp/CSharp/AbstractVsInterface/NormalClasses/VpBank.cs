using CSharp.AbstractVsInterface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.AbstractVsInterface.NormalClasses
{
    public class VpBank : Bank
    {
        public VpBank(double amount)
        {
            this.balance = amount;
        }

        public override void CashWithDraw(double amount)
        {
            if(amount > this.balance)
            {
                Console.WriteLine("Insufficient funds in bank account");
                return;
            }

            Console.WriteLine($"Withdrawing Cash: {amount}");
            Console.WriteLine($"Remaining Balance: {this.balance - amount}");
        }
    }
}
