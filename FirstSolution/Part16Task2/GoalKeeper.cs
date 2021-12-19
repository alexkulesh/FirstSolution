using System;

namespace Part16Task2
{
    public class GoalKeeper : Person, IPlayer
    {
        public GoalKeeper(string name) : base(name)
        {
            Name = name;
            Console.WriteLine($"Today goalkeeper {Name} is playing");
        }
        
        public void CatchBall()
        {
            Console.WriteLine($"Goalkeeper {Name} takes ball in his hands");
        }

        public void MissBall()
        {
            Console.WriteLine("Goal!!!!");
        }

        public void Pass(FieldPlayer player)
        {
            Console.WriteLine($"{Name} passes ball to {player.Name}");
        }
        
        public void PickBooking()
        {
            Console.WriteLine($"Player {Name} gets yellow card");
        }
    }
}