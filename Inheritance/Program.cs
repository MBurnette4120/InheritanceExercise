using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird myCardinal = new Bird();
            myCardinal.Name = "Cardinal";
            myCardinal.Feathers = true;
            myCardinal.Fly = true;
            myCardinal.EatsFood = true;
            myCardinal.Color = "red";
            myCardinal.BeakSize = "short";

            Console.WriteLine($"The {myCardinal.Name} outside my house is {myCardinal.Color} and has a {myCardinal.BeakSize} beak.");
            if (myCardinal.Fly && myCardinal.EatsFood)
            {
                Console.WriteLine($"The {myCardinal.Name} can fly and eats worms.");
            }


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Reptile myAlligator = new Reptile();
            myAlligator.Name = "Alligator";
            myAlligator.Moves = true;
            myAlligator.HairorScales = "Scales";
            myAlligator.Arms = 2;
            myAlligator.Legs = 2;
            myAlligator.ColdBlooded = true;
            myAlligator.Color = "green";
            myAlligator.Carnivorous = true;
            myAlligator.Food = "Carnivore";

            Console.WriteLine($"I have a pet {myAlligator.Name}.");
            Console.WriteLine($"My {myAlligator.Name} has {myAlligator.Legs} legs and {myAlligator.Arms} arms.");
            Console.WriteLine($"My {myAlligator.Name} is {myAlligator.Food} and has {myAlligator.HairorScales}.");

            if (myAlligator.ColdBlooded)
            {
                Console.WriteLine($"{myAlligator.Name}'s are coldblooded.");
            }










        }


    }

}
