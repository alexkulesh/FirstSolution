using System;

namespace Part15Task3
{
    public class Product : IComparable
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

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            Product product = obj as Product;

            if (product != null)
                return this.price.CompareTo(product.price);
            else
                throw new ArgumentException("Object is not Product");
        }
    }
}