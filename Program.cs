using System;
using System.Collections.Generic;

namespace TryoutPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Gym gym = new Gym();

            var commands = new Dictionary<ConsoleKey, ICommand>
            {
                [ConsoleKey.Spacebar] = new ShoutCommand { Name = "Oronut' v console"},
                [ConsoleKey.Enter] = new PrintMessageCommand(),
                [ConsoleKey.Tab] = new TrainPeopleCommand(gym),
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
