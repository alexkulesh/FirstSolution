using System;

namespace Part16Task2
{
    public class GoalKeeper : Person, IPlayer
    {
        public GoalKeeper(string name) : base(name)
        {
            Name = name;
            Console.WriteLine($"Сегодня играет вратарь {Name}");
        }
        
        public void CatchBall()
        {
            Console.WriteLine($"вратарь {Name} берет мяч в руки");
        }

        public void MissBall()
        {
            Console.WriteLine("ГОООЛ!");
        }

        public void Pass(FieldPlayer player)
        {
            Console.WriteLine($"{Name} отдал пас {player.Name}-у");
        }
        
        public void PickBooking()
        {
            Console.WriteLine($"игрок {Name} получает желтую карточку");
        }
    }
}