using System;

namespace Part16Task1
{
    public class Chicken : Bird
    {
        public Chicken() : base("Chicken")
        {
        }

        public override void Fly(string name)
        {
            base.Fly(name);
            Console.WriteLine("But not so far");
        }
    }
}