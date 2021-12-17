using System;

namespace Part16Task1
{
    public class Penguin : Bird, ISwimable
    {
        public Penguin() : base("Penguin")
        {
            
        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming");
        }

        public override void Fly(string name)
        {
            Console.WriteLine($"{name} cannot fly");
        }
    }
}