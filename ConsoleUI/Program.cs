using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {          

            #region Animals

            // Create a list of Vehicle called vehicles

            var animals = new List<Animal>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var JimmyL = new Lion() {Name = "JimmyL" };   // changes default value
            var MikeyG = new Gorilla() {Name = "MikeyG", NumberOfLegs = 2};
            Animal TonyAL = new Lion() {Name = "TonyAL"};
            Animal RonnyAG = new Gorilla() {Name = "RonnyAG"};


            // Add the 4 vehicles to the list

            animals.Add(JimmyL);
            animals.Add(MikeyG);    
            animals.Add(TonyAL);
            animals.Add(RonnyAG);
            

             // Using a foreach loop iterate over each of the properties

            foreach(var animal in animals)
            {
                Console.WriteLine($"Animal name: {animal.Name}, number of legs: {animal.NumberOfLegs}, number of eyes: {animal.NumberOfEyes}, lives on land: {animal.LivesOnLand.ToString().ToLower()}");
                // animal.MakesSound();     
                // animal.EatsFood();
            }


            // Call each of the drive methods for one car and one motorcycle

            Console.Write("Jimmy L goes ");
            JimmyL.MakesSound();
            Console.Write("Mikey G goes ");
            MikeyG.MakesSound();
            

            #endregion            
            Console.ReadLine();
        }
    }
}
