using System;

namespace Part16Task3
{
    public interface IHuman
    {
        public void Move(string name)
        {
            Console.WriteLine($"{name} moves right");
        }
    }
}