using System;
using System.Collections.Generic;
using System.Linq;
using Part15Task3;

namespace Part18Task3
{
    // Создать коллекцию, содержащую объекты Product. Написать метод,
    // который перебирает элементы коллекции и проверяет цену продуктов.
    // Если цена продукта больше 300 рублей, продукт перемещается в другую коллекцию.
    // Необходимо вывести минимальное значение продукта из полученной коллекции.

    public class Task
    {
        private static void Main(string[] args)
        {
            List<Product> products = new()
            {
                new Item("Milk", 5.3, new DateTime(2021, 11, 16), new DateTime(2021, 12, 16)),
                new Item("Bread", 1.3, new DateTime(2021, 12, 1), new DateTime(2021, 12, 14)),
                new Item("Cheese", 2.3, new DateTime(2021, 11, 21), new DateTime(2021, 12, 20)),
                new Batch("Sugar", 1500.0, 1, new DateTime(2021, 12, 14), new DateTime(2023, 12, 14)),
                new Batch("Wheat flour", 4020.0, 4, new DateTime(2021, 12, 14), new DateTime(2022, 06, 14)),
                new Batch("Vitamin B12", 45000.0, 1, new DateTime(2021, 12, 14), new DateTime(2031, 12, 14)),
                new Set("PC set", 3540.65, new Item[]
                {
                    new Item("Screen", 660.40, new DateTime(2021, 8, 20), new DateTime(2031, 12, 20)),
                    new Item("System block", 2430.40, new DateTime(2021, 8, 20), new DateTime(2031, 12, 20)),
                    new Item("Mouse", 105.10, new DateTime(2021, 8, 20), new DateTime(2031, 12, 20)),
                    new Item("Keyboard", 150.30, new DateTime(2021, 8, 20), new DateTime(2031, 12, 20)),
                })
            };

            var selectedProducts = from product in products
                where product.Price > 300
                select product;

            foreach (var product in selectedProducts)
            {
                Console.WriteLine($"{product.Name} - {product.Price}");
            }

            double minPrice = products.Min(u => u.Price);
            Console.WriteLine(minPrice);
        }
    }
}