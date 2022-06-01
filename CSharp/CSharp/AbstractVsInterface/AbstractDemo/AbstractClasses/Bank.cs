using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.AbstractVsInterface.Abstract
{
    public abstract class Bank
    {
        public string name;
        protected double balance;

        public void ShowBalance()
        {
            Console.WriteLine($"Total Balance: {this.balance}");
        }

        public abstract void CashWithDraw(double amount);
    }
}
