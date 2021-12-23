using System;
using System.Collections.Generic;
using System.Linq;
using Part15Task3;

namespace Part18Task4
{
    // Создайте Dictionary, содержащий пары значений  - имя продукта и цена продукта (класс Product).
    // - Перебрать и распечатать пары значений.
    // - Перебрать и распечатать набор из имен продуктов.
    // - Перебрать и распечатать значения продуктов.
    // - Для каждого перебора создать свой метод.
    
    public class Task
    {
        private static void Main(string[] args)
        {
            Product product1 = new Item("Milk", 5.3, new DateTime(2021, 11, 16), new DateTime(2021, 12, 16));
            Product product2 = new Item("Bread", 1.3, new DateTime(2021, 12, 1), new DateTime(2021, 12, 14));
            Product product3 = new Item("Cheese", 2.3, new DateTime(2021, 11, 21), new DateTime(2021, 12, 20));
            Product product4 = new Batch("Sugar", 1500.0, 1, new DateTime(2021, 12, 14), new DateTime(2023, 12, 14));
            Product product5 = new Batch("Wheat flour", 4020.0, 4, new DateTime(2021, 12, 14), new DateTime(2022, 06, 14));
            Product product6 = new Batch("Vitamin B12", 45000.0, 1, new DateTime(2021, 12, 14), new DateTime(2031, 12, 14));
            
            Dictionary<string, double> dictionaryOfProducts = new()
            {
                { product1.Name, product1.Price},
                { product2.Name, product2.Price},
                { product3.Name, product3.Price},
                { product4.Name, product4.Price},
                { product5.Name, product5.Price},
                { product6.Name, product6.Price}
            };

            PrintInfo1(dictionaryOfProducts);
            PrintInfo2(dictionaryOfProducts);
            PrintInfo3(dictionaryOfProducts);
        }

        private static void PrintInfo1(Dictionary<string, double> dictionaryOfProducts)
        {
            foreach (var product in dictionaryOfProducts)
            {
                Console.WriteLine(product);
            }
        }

        private static void PrintInfo2(Dictionary<string, double> dictionaryOfProducts)
        {
            foreach (var product in dictionaryOfProducts)
            {
                Console.WriteLine($"{product.Key}");
            }
        }

        private static void PrintInfo3(Dictionary<string, double> dictionaryOfProducts)
        {
            var selectedProducts = from product in dictionaryOfProducts
                where product.Value > 300
                select product;

            foreach (var product in selectedProducts)
            {
                Console.WriteLine(product);
            }
        }
    }
}