using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /*
           * Create an abstract class called Vehicle
           * The vehicle class shall have three string properties Year, Make, and Model
           * Set the defaults to something generic in the Vehicle class
           * Vehicle shall have an abstract method called DriveAbstract with no implementation
           * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
           */

    public abstract class Animal
    {

        public string Name { get; set; } = "Animal";
        public int NumberOfLegs { get; set; } = 4;
        public int NumberOfEyes { get; set; } = 2;
        public bool LivesOnLand { get; set; } = true;

        public abstract void MakesSound();

        public virtual void EatsFood()
        {
            Console.WriteLine("munch munch");
        }


    }
}
