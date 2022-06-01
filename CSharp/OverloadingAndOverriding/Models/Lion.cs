using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAndOverriding.Models
{
    public class Lion : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating....Meat!!");
        }
    }
}
