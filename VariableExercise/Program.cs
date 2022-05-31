using System;

namespace VariableExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName;     //Declaration
            dogName = "Chinu";  //Initialization

            int dogAge = 3;      // Declaration & Initializing

            char firstInitalOfMyDog = 'C';

            bool isHungry = true;

            double myDogWeight = 33.3;   //decimals

            decimal dogHeight = 10.5m;  //ends with m


            Console.WriteLine($"My Dog's name is {dogName} and his initial is {firstInitalOfMyDog}. " +
                $"He is {dogAge} years old.");
            Console.WriteLine($"He is hungry {isHungry}.");
            Console.WriteLine($"My dog weight is {myDogWeight} lbs," +
                $"his height is {dogHeight}");

        }
     }
}



