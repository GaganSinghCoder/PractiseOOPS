using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseOOPS
{
    internal class Animal
    {
        int NumberofLegs { get; set; } = 4;
        string Color { get; set; } = "blue";

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
}
