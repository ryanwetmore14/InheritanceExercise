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

            Bird bluejay = new Bird()
            {
                Name = "BlueJay",
                Age = 150,
                Legs = 2,
                HasFeathers = true,
                HasTwoEyes = true,
                Wings = 2,
                Type = "Radioactive"

            };

            Console.WriteLine($"a {bluejay.Name} is a beautiful bird who is {bluejay.Age} years old, who also has {bluejay.Wings} wings and {bluejay.Legs} legs.");
            Console.WriteLine($"Is {bluejay.Name} a bird who has feathers and has two eyes? {bluejay.HasFeathers} and {bluejay.HasTwoEyes}");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */


            Reptile godzilla = new Reptile()
            {
                Name = "Godzilla",
                Age = 1000,
                Legs = 2,
                HasScales = true,
                IsColdBlooded = true,

            };


            Console.WriteLine($"{godzilla.Name} Is a mythical creature who is {godzilla.Age} years old, if you were wondering if this reptile has" +
                $" scales and is cold blooded both these fact are {godzilla.HasScales}");
            Console.WriteLine();
        }
    }
}
