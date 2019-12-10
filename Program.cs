using System;
using System.Collections.Generic;

namespace TryoutPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var commands = new Dictionary<ConsoleKey, ICommand>
            {
                [ConsoleKey.Enter] = new Shout(),
                [ConsoleKey.LeftArrow] = new PrintMessage()
            };

            var isUndone = true;

            while(isUndone)
            {
                var key = Console.ReadKey().Key;
                if (!commands.ContainsKey(key))
                    break;
                var selectedCommand = commands[key];
                selectedCommand.Act();
            }
        }
    }
}
