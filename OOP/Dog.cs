using System;
namespace OOP
{
    abstract public class Dog: Animal, Exerciseable
    {
        public Dog() : base("bird")
        {

        }
        public override void eat()
        {
            Console.WriteLine("Eating meat");
        }

        public void doExercise()
        {
            Console.WriteLine("Run.........");
        }

    }
}

