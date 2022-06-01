using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAndOverriding.Models
{
    public class Deer : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eat....Grass!");
        }

        public void Eat(string grassName)
        {
            Console.WriteLine($"Eat....{grassName} Grass!");
        }
    }
}
