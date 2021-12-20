using System;

namespace Part16Task2
{
    public abstract class Person
    {
        private string name;

        protected Person(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}