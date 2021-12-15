using System;

namespace Part15Task3
{
    public class Product
    {
        private string name;
        private double price;
        private bool isExpired;
        
        public virtual void printInfo()
        {
        }

        public virtual void compareDates()
        {
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
        
        public bool IsExpired
        {
            get => isExpired;
            set => isExpired = value;
        }
    }
}