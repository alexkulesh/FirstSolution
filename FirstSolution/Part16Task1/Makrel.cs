using System;

namespace Part16Task1
{
    public class Makrel : Fish
    {
        private string species;
        private string color;

        public string Species
        {
            get => species;
            set => species = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Color
        {
            get => color;
            set => color = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}