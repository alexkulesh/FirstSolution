using System;
using System.Runtime.Serialization;

namespace Part15Task3
{
    public class Batch : Product
    {   
        private int quantity;
        private DateTime dateOfProduction;
        private DateTime bestBeforeDate;
        
        public Batch(string name, double price, int quantity, DateTime dateOfProduction,
            DateTime bestBeforeDate)
        {
            Name = name;
            Price = price;
            this.quantity = quantity;
            this.dateOfProduction = dateOfProduction;
            this.bestBeforeDate = bestBeforeDate;
        }
        
        public override void printInfo()
        {
            Console.WriteLine($"{Name} info: price - {Price}; quantity - {quantity} ; date of production - {dateOfProduction};" +
                              $" best before - {bestBeforeDate}");
        }
        
        public override void compareDates()
        {
            if (bestBeforeDate > DateTime.Today)
            {
                Console.WriteLine("Batch is not expired");
            }
            
            if (bestBeforeDate <= DateTime.Today)
            {
                Console.WriteLine("Batch is expired");
                IsExpired = true;
            }
        }
    }
}