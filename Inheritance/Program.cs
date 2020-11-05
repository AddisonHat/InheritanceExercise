using System;
using System.Net.Cache;

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

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird articuno = new Bird()
            {
                Name = "Articuno",
                Age = 1000,
                Legs = 2,
                HasBackbone = true,
                IsWarmBlooded = false,
                HasFeathers = true,
                Wings = 2,
                Type = "Ice",





            };

            Console.WriteLine($"{articuno.Name} is an {articuno.Type } pokemon that is {articuno.Age} years old and has {articuno.Legs} legs and {articuno.Wings} wings");
            Console.WriteLine($"is {articuno.Name} a vertebrate, warm blooded and has feathers?  {articuno.HasBackbone} {articuno.IsWarmBlooded} {articuno.HasFeathers}");
            Console.WriteLine();



            Reptile dragon = new Reptile()
            {
                Name = "Eragon",
                Age = 500,
                Legs = 4,
                HasBackbone = true,
                IsColdBlooded = true,
                HasScales = true,
                Enviroment = "Mountains",
                Defense = "Breathes Fire",
            };

            Console.WriteLine($"{dragon.Name} is {dragon.Age} years old it has {dragon.Legs} and {dragon.Defense} it lives in the {dragon.Enviroment}");
            Console.WriteLine($"is {dragon.Name} cold blooded also does {dragon.Name} have scales and a backbone  {dragon.IsColdBlooded}  {dragon.HasScales}  {dragon.HasBackbone}");





        }
    }
}
