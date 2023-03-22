using System;
namespace OOP
{
    public class ChildClass: ParentClass
    {
        public int cNum;
        protected int pNum;
        public ChildClass()
        {
            this.cNum = 5;
            this.pNum = 15;
            base.pNum = 10;
            Console.WriteLine("pNum value in child " + this.pNum);
            Console.WriteLine("pNum value in parent " + base.pNum);
            
            
        }
    }
}

