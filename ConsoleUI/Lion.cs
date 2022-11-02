﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /* 
            * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
            * Provide the implementations for the abstract methods
            * Only in the Motorcycle class will you override the virtual drive method
           */

    public class Lion : Animal
    {
        public Lion()
        {           
        }

        public bool HasFur = true;
        public override void MakesSound()
        {
            Console.WriteLine("rawrrr");
        }

        public override void EatsFood()
        {
            base.EatsFood();
        }
    }
}
