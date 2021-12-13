using System;

namespace Part15Task3
{
    public class Product
    {
        private string name;
        private double price;
        private DateTime dateOfProduction;
        private DateTime bestBeforeDate;
        private bool isExpired;
        
        public Product()
        {
        }
        
        public virtual void printInfo()
        {
        }

        public virtual void compareDates()
        {
            if (bestBeforeDate < DateTime.Today)
            {
                Console.WriteLine("Product is not expired");
            }
            
            if (bestBeforeDate >= DateTime.Today)
            {
                Console.WriteLine("Product is expired");
                isExpired = true;
            }
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

        public DateTime DateOfProduction
        {
            get => dateOfProduction;
            set => dateOfProduction = value;
        }

        public DateTime BestBeforeDate
        {
            get => bestBeforeDate;
            set => bestBeforeDate = value;
        }

        public bool IsExpired
        {
            get => isExpired;
            set => isExpired = value;
        }
    }
}