using System;
namespace OOP
{
    sealed public class Human : Animal, Exerciseable, Singable
    {
        public string race;
        public Human(): base("human")
        {

        }
        //public Human(string caller): base(caller)
        //{
        //    Console.WriteLine("I'm Human constructor");
        //}

        public override void eat()
        {
            Console.WriteLine("Eating meat");
        }

        public override void dance()
        {
            
        }

        public void doExercise()
        {
            Console.WriteLine("Go to the gym");
            Console.WriteLine("Run in the trade mill");
            Console.WriteLine("Return");
        }

        public void sing()
        {

        }

    }
}

