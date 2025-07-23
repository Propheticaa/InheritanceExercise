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
            pigeon.species = "Pigeon";
            pigeon.location = "Urban areas";
            pigeon.pest = "Is a pest";
            pigeon.endangered = "Not endangered";
            pigeon.canFly = "Can fly";
            pigeon.featherColor = "Gray";
            pigeon.beakType = "Short and stout";
            pigeon.nestType = "Nests in buildings and trees";

            Console.WriteLine($"Species: {pigeon.species}");
            Console.WriteLine($"Location: {pigeon.location}");
            Console.WriteLine($"Pest: {pigeon.pest}");
            Console.WriteLine($"Endangered: {pigeon.endangered}");
            Console.WriteLine($"Can Fly: {pigeon.canFly}");
            Console.WriteLine($"Feather Color: {pigeon.featherColor}");
            Console.WriteLine($"Beak Type: {pigeon.beakType}");
            Console.WriteLine($"Nest Type: {pigeon.nestType}");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile snake = new Reptile();
            snake.species = "Snake";
            snake.location = "Forests and deserts";
            snake.pest = "Is a pest";
            snake.endangered = "Some species endangered";
            snake.isVenomous = "Some are venomous";
            snake.scaleType = "Hard Scales";
            snake.isTailRegenerating = "Does not regenerate tail";
            snake.hasLegs = "No legs";

            Console.WriteLine($"Species: {snake.species}");
            Console.WriteLine($"Location: {snake.location}");
            Console.WriteLine($"Pest: {snake.pest}");
            Console.WriteLine($"Endangered: {snake.endangered}");
            Console.WriteLine($"Is Venomous: {snake.isVenomous}");
            Console.WriteLine($"Scale Type: {snake.scaleType}");
            Console.WriteLine($"Is Tail Regenerating: {snake.isTailRegenerating}");
            Console.WriteLine($"Has legs: {snake.hasLegs}");

        }
    }
}
