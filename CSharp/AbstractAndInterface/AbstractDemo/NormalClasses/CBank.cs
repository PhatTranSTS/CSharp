using AbstractAndInterface.AbstractDemo.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface.AbstractDemo.NormalClasses
{
    public class CBank : Bank
    {
        public CBank(double amount)
        {
            this.balance = amount;
        }

        public override void CashWithDraw(double amount)
        {
            Console.WriteLine("--CBank service--");

            if (amount > this.balance)
            {
                Console.WriteLine("Insufficient funds in bank account");
                return;
            }

            Console.WriteLine($"Withdrawing Cash: {amount}");
            Console.WriteLine($"Remaining Balance: {this.balance - amount}");
        }

        public void CashWithDraw(double amount, bool isByPass)
        {
            if(!isByPass)
            {
                CashWithDraw(amount);
                return;
            }

            Console.WriteLine("--CBank service--");

            Console.WriteLine($"Withdrawing Cash: {amount}");
            Console.WriteLine($"Remaining Balance: {this.balance - amount}");
        }
    }
}
