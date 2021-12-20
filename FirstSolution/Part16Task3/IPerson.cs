using System;

namespace Part16Task3
{
    public interface IPerson
    {
        public void Move(string name)
        {
            Console.WriteLine($"{name} moves left");
        }
    }
}