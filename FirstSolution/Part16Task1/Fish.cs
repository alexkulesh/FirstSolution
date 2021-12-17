using System;

namespace Part16Task1
{
    public abstract class Fish : Animal, ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("fish is swimming");
        }
    }
}