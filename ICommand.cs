﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TryoutPatterns
{
    interface ICommand
    {
        void Act();
    }

    class Command : ICommand
    {
        public void Act()
        {
            InternalLogic();
        }

        protected virtual void InternalLogic()
        {
            Console.WriteLine("Base command");
        }
    }

    class Shout : Command
    {
        protected override void InternalLogic()
        {
            Console.WriteLine("Hello!");
        }
    }

    class PrintMessage : Shout
    {
        protected override void InternalLogic()
        {
            Console.Write("Gimme some:");
            var message = Console.ReadLine();
            Console.WriteLine($"Here is the message: {message}");
        }
    }
}