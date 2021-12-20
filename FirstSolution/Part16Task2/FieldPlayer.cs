using System;

namespace Part16Task2
{
    public class FieldPlayer : Person, IPlayer
    {
        private int counter;
        public FieldPlayer(string name) : base(name)
        {
            Name = name;
            Console.WriteLine($"Today {Name} is playing");
        }

        public void Move(string position)
        {
            Console.WriteLine($"{Name} в {position}");
        }

        public void CatchBall()
        {   
            Console.WriteLine($"Player {Name} takes ball in his hands");
            Console.WriteLine("...and breaks the rules");
        }
        
        public void Pass(FieldPlayer player)
        {
            Console.WriteLine($"{Name} passes ball to {player.Name}-у");
        }

        public void KickOnGoal()
        {
            Console.WriteLine($"Player {Name} hits on a goal");
        }

        public void PickBooking()
        {
            counter++;
            if (counter == 1)
            {
                Console.WriteLine($"Player {Name} gets yellow card");
            }

            if (counter == 2)
            {
                Console.WriteLine($"Player {Name} gets red card");
            }
        }
    }
}