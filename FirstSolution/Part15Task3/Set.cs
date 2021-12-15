using System;

namespace Part15Task3
{
    public class Set : Product
    {
        private Item[] items;

        public Set(string name, double price, Item[] items)
        {
            Name = name;
            Price = price;
            this.items = items;
        }

        public override void printInfo()
        {
            Console.WriteLine($"{Name} info: price - {Price}");

            if (items.Length >= 1)
            {   
                Console.WriteLine("Set includes:");
                
                for (int i = 0; i < items.Length; i++)
                {
                    items[i].printInfo();
                }
            }
            else
            {
                Console.WriteLine("Set is empty");
            }
        }
        
        public override void compareDates()
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].BestBeforeDate > DateTime.Today)
                {
                    Console.WriteLine($"{items[i].Name} is not expired");
                }
                
                if (items[i].BestBeforeDate <= DateTime.Today)
                {
                    Console.WriteLine($"{items[i].Name} is expired");
                    IsExpired = true;
                }
            }
        }
    }
}    