using System;
namespace OOP
{
    public class Visitor
    {
        string name;
        string address;
        static int count = 0;

        public void enterIntoClass()
        {
            Visitor.count++;

        }

        public static void greeting()
        {
            Console.WriteLine("Namaste! ");
        }

        public void greetingToVisitor()
        {
            Console.WriteLine("Namaste! " + name);
        }

        public static void Mains()
        {
            Visitor visitor1 = new Visitor();
            visitor1.name = "Kapeel";
            visitor1.enterIntoClass();
            greeting();
            visitor1.greetingToVisitor();
            //Visitor.greeting();

            Console.WriteLine(visitor1.name);
            Console.WriteLine(Visitor.count);

            Visitor visitor2 = new Visitor();
            visitor2.name = "Bijay";
            visitor2.enterIntoClass();
            Visitor.greeting();

            Console.WriteLine(visitor2.name);
            Console.WriteLine(Visitor.count);
        }
    }

    
}

