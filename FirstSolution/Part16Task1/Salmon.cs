using System;

namespace Part16Task1
{
    public class Salmon : Fish
    {   
        private string species;
        private double length;

        public string Species
        {
            get => species;
            set => species = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double Length
        {
            get => length;
            set => length = value;
        }
    }
}