using System;

namespace Part16Task1
{
    public abstract class Bird : Animal
    {
        protected string name;

        protected Bird(string name)
        {
            this.name = name;
        }

        public virtual void Fly(string name)
        {
            Console.WriteLine($"{name} is flying");
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}