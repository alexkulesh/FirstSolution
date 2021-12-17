using System;

namespace Part16Task2
{
    public static class Simulator
    {
        public static void Move(string position, Ball ball) 
        {
            ball.Move(position);
        }

        public static void Move(string position, Ball ball, FieldPlayer player1, FieldPlayer player2)
        {
            Console.WriteLine($"мяч, {player1.Name}, {player2.Name} в {position}" );
        }
        
        public static void Move(string position, FieldPlayer player1)
        {
            player1.Move(position);
        }
    }
}