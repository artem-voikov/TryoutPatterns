using System;

namespace TryoutPatterns
{
    class PrintMessageCommand : ShoutCommand
    {
        protected override void InternalLogic()
        {
            Console.Write("Gimme some:");
            var message = Console.ReadLine();
            Console.WriteLine($"Here is the message: {message}");
        }
    }

}
