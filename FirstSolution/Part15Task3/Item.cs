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
                Console.WriteLine($"{Name} is not expired");
            }
            
            if (bestBeforeDate <= DateTime.Today)
            {
                Console.WriteLine($"{Name} is expired");
                IsExpired = true;
            }
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
    }
}