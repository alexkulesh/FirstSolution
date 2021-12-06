using System;

namespace Part10Task11
{
    public class Task
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(EqualsNum(4));
        }

        private static bool EqualsNum(int num) => num == new Random().Next(1, 10);
    }
}