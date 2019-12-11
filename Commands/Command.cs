using System;

namespace TryoutPatterns
{
    abstract class Command : ICommand
    {
        public virtual string Name { get; set; }

        public void Act()
        {
            InternalLogic();
        }

        protected virtual void InternalLogic()
        {
            Console.WriteLine("Base command");
        }
    }

}
