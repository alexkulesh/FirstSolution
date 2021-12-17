using System;

namespace Part16Task2
{
    public class FieldPlayer : Person, IPlayer
    {
        private int counter;
        public FieldPlayer(string name) : base(name)
        {
            Name = name;
            Console.WriteLine($"Сегодня играет {Name}");
        }

        public void Move(string position)
        {
            Console.WriteLine($"{Name} в {position}");
        }

        public void CatchBall()
        {   
            Console.WriteLine($"игрок {Name} берет мяч в руки");
            Console.WriteLine("...и нарушает правила");
        }
        
        public void Pass(FieldPlayer player)
        {
            Console.WriteLine($"{Name} отдал пас {player.Name}-у");
        }

        public void KickOnGoal()
        {
            Console.WriteLine($"игрок {Name} бьет по воротам");
        }

        public void PickBooking()
        {
            counter++;
            if (counter == 1)
            {
                Console.WriteLine($"игрок {Name} получает желтую карточку");
            }

            if (counter == 2)
            {
                Console.WriteLine($"игрок {Name} получает красную карточку");
            }
        }
    }
}