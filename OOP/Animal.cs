using System;
namespace OOP
{
    abstract public class Animal
    {
        public string name;
        private string gender;

        public Animal(string caller)
        {
            Console.WriteLine("I'm Animal constructor called by" + caller);
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public void printType(Animal obj)
        {
            Console.WriteLine(obj.GetType);
        }

        public void walk()
        {
            Console.WriteLine("Walking with 2 legs");
        }

        abstract public void eat();

        abstract public void dance();
    }
}

