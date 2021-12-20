using System;

namespace Part16Task2
{
    public class Referee : Person
    {
        public Referee(string name) : base(name)
        {
            Name = name;
            Console.WriteLine($"{Name} will be referee today");
        }

        public void Whistle()
        {
            Console.WriteLine($"Referee {Name} whistles");
        }
    }
}