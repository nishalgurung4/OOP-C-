using System;
namespace OOP
{
    public class Bird: Animal, Singable
    {
        public string gender;

        public Bird(): base("bird")
        {

        }

        //public Bird(string caller): base(caller)
        //{
        //    Console.WriteLine("Inside Bird constructor");
        //}
        public void walk()
        {
            Console.WriteLine("Walk with 2 legs and also fly with wings");
        }

        public override void eat()
        {
            Console.WriteLine("Eating grains");
        }

        public override void dance()
        {

        }

        public void sing()
        {

        }
    }
}

