using CSharp.AbstractVsInterface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.AbstractVsInterface.NormalClasses
{
    public class AriBank : Bank
    {
        public AriBank(double amount)
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

            var remainingBalance = this.balance - amount;
            var minRemainingBalance = 50000;
            if(remainingBalance < minRemainingBalance)
            {
                Console.WriteLine($"Account balance must be more than {minRemainingBalance}");
                Console.WriteLine($"Amount can be withdrawn: {this.balance - minRemainingBalance}");
                return;
            }

            Console.WriteLine($"Withdrawing Cash: {amount}");
            Console.WriteLine($"Remaining Balance: {this.balance - amount}");
        }
    }
}
