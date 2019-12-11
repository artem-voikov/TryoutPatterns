using System;

namespace TryoutPatterns
{
    class ShoutCommand : Command
    {
        protected override void InternalLogic()
        {
            Console.WriteLine("Hello!");
        }
    }

}
