using System;
namespace OOP
{
    public class Task
    {
        public string name;
        public bool isComplete;

        public Task(string name)
        {
            this.name = name;
            this.isComplete = false;
        }

        public void markAsComplete()
        {
            this.isComplete = true;
        }

        public void markAsIncomplete()
        {
            this.isComplete = false;
        }
        
    }
}

