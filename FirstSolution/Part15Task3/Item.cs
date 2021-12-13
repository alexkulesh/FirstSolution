using System;

namespace Part15Task3
{
    public class Item : Product
    {   
        private DateTime dateOfProduction;
        private DateTime bestBeforeDate;
        
        public Item(string name, double price, DateTime dateOfProduction,
            DateTime bestBeforeDate)
        {
            Price = price;
            Name = name;
            this.dateOfProduction = dateOfProduction;
            this.bestBeforeDate = bestBeforeDate;
        }

        public override void printInfo()
        {
            Console.WriteLine($"{Name} info: price - {Price}; date of production - {dateOfProduction};" +
                              $" best before - {bestBeforeDate}");
        }

        public override void compareDates()
        {
            if (bestBeforeDate > DateTime.Today)
            {
                Console.WriteLine("Item is not expired");
            }
            
            if (bestBeforeDate <= DateTime.Today)
            {
                Console.WriteLine("Item is expired");
                IsExpired = true;
            }
        }
    }
}