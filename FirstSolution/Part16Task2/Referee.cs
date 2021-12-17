using System;

namespace Part16Task2
{
    public class Referee : Person
    {
        public Referee(string name) : base(name)
        {
            Name = name;
            Console.WriteLine($"Сегодня арбитром будет {Name}");
        }

        public void Whistle()
        {
            Console.WriteLine($"Арбитр {Name} свистит");
        }
    }
}