using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseOOPS
{
    internal class Zebra:Animal
    {
        int NumberofLegs { get; set; } = 4;
        string Color { get; set; } = "blue";

        public void Eat()
        {
            Console.WriteLine("Zebra is eating");
        }
    }
}
