using System;
using System.Collections.Generic;
using System.Text;

namespace TryoutPatterns
{
    class Gym
    {
        private readonly List<Person> list = new List<Person>();

        public void Add(Person person)
        {
            this.list.Add(person);
        }

        public void Train()
        {
            Console.WriteLine("We are train people");
            foreach (var p in list)
                p.Count--;
        }
    }
}
