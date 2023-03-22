using System;
namespace OOP
{
    public class TaskApplication
    {
        Task[] tasks = {
            new Task("Go to the market"),
            new Task("Buy some vegtables"),
            new Task("Buy some fruits"),
            new Task("Return back to home")
        };

        public void displayTasks()
        {
            foreach(var task in this.tasks)
            {
                Console.WriteLine(task.name);
            }
        }
        public static void Main(String[] args)
        {
            Console.WriteLine(args[0]);
            Human rabin = new Human();
            rabin.name = "Rabin Acharya";
            rabin.race = "Aryan";
            rabin.setGender("male");
            rabin.walk();
            rabin.eat();
            rabin.doExercise();

            Bird sparrow;
            sparrow = new Bird();
            sparrow.name = "Sparrow";
            sparrow.walk();
            sparrow.eat();

           


            ChildClass c = new ChildClass();


        }
    }
}

