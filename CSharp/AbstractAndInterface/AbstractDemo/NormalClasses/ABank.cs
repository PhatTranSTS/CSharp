using AbstractAndInterface.AbstractDemo.AbstractClasses;
using System;

namespace AbstractAndInterface.AbstractDemo.NormalClasses
{
    public class ABank : Bank
    {
        public ABank(double amount)
        {
            this.balance = amount;
        }
        public override void CashWithDraw(double amount)
        {
            Console.WriteLine("--ABank service--");

            if (amount > this.balance)
            {
                Console.WriteLine("Insufficient funds in bank account");
                return;
            }

            var remainingBalance = this.balance - amount;
            var minRemainingBalance = 50000;
            if (remainingBalance < minRemainingBalance)
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
