using System;

namespace Part16Task3
{
    public class Person : IHuman, IPerson
    {
        void IPerson.Move(string name)
        {
            Console.WriteLine($"{name} moves somewhere");
        }
    }
}