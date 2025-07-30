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

            Bird pigeon = new Bird();
            pigeon.Species = "Pigeon";
            pigeon.Location = "Urban areas";
            pigeon.Pest = "Is a pest";
            pigeon.Endangered = "Not endangered";
            pigeon.CanFly = "Can fly";
            pigeon.FeatherColor = "Gray";
            pigeon.BeakType = "Short and stout";
            pigeon.NestType = "Nests in buildings and trees";

            Console.WriteLine($"Species: {pigeon.Species}");
            Console.WriteLine($"Location: {pigeon.Location}");
            Console.WriteLine($"Pest: {pigeon.Pest}");
            Console.WriteLine($"Endangered: {pigeon.Endangered}");
            Console.WriteLine($"Can Fly: {pigeon.CanFly}");
            Console.WriteLine($"Feather Color: {pigeon.FeatherColor}");
            Console.WriteLine($"Beak Type: {pigeon.BeakType}");
            Console.WriteLine($"Nest Type: {pigeon.NestType}");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile snake = new Reptile();
            snake.Species = "Snake";
            snake.Location = "Forests and deserts";
            snake.Pest = "Is a pest";
            snake.Endangered = "Some species endangered";
            snake.IsVenomous = "Some are venomous";
            snake.ScaleType = "Hard Scales";
            snake.IsTailRegenerating = "Does not regenerate tail";
            snake.HasLegs = "No legs";

            Console.WriteLine($"Species: {snake.Species}");
            Console.WriteLine($"Location: {snake.Location}");
            Console.WriteLine($"Pest: {snake.Pest}");
            Console.WriteLine($"Endangered: {snake.Endangered}");
            Console.WriteLine($"Is Venomous: {snake.IsVenomous}");
            Console.WriteLine($"Scale Type: {snake.ScaleType}");
            Console.WriteLine($"Is Tail Regenerating: {snake.IsTailRegenerating}");
            Console.WriteLine($"Has legs: {snake.HasLegs}");

        }
    }
}
