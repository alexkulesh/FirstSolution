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
            List<Product> products = new()
            {
                new Item("Milk", 5.3, new DateTime(2021, 11, 16), new DateTime(2021, 12, 16)),
                new Item("Bread", 1.3, new DateTime(2021, 12, 1), new DateTime(2021, 12, 14)),
                new Item("Cheese", 2.3, new DateTime(2021, 11, 21), new DateTime(2021, 12, 20)),
                new Batch("Sugar", 1500.0, 1, new DateTime(2021, 12, 14), new DateTime(2023, 12, 14)),
                new Batch("Wheat flour", 4020.0, 4, new DateTime(2021, 12, 14), new DateTime(2022, 06, 14)),
                new Batch("Vitamin B12", 45000.0, 1, new DateTime(2021, 12, 14), new DateTime(2031, 12, 14))
            };

            Dictionary<string, double> dictionaryOfProducts = new()
            {
                {products[0].Name, products[0].Price},
                {products[1].Name, products[1].Price},
                {products[2].Name, products[2].Price},
                {products[3].Name, products[3].Price},
                {products[4].Name, products[4].Price},
                {products[5].Name, products[5].Price}
            };

            PrintInfo1(dictionaryOfProducts);
            PrintInfo2(dictionaryOfProducts);
            PrintInfo3(dictionaryOfProducts);
        }

        private static void PrintInfo1(Dictionary<string, double> dictionaryOfProducts)
        {
            foreach (var i in dictionaryOfProducts)
            {
                Console.WriteLine(i);
            }
        }

        private static void PrintInfo2(Dictionary<string, double> dictionaryOfProducts)
        {
            foreach (var i in dictionaryOfProducts)
            {
                Console.WriteLine($"{i.Key}");
            }
        }

        private static void PrintInfo3(Dictionary<string, double> dictionaryOfProducts)
        {
            var selectedProducts = from product in dictionaryOfProducts
                where product.Value > 300
                select product;

            foreach (var i in selectedProducts)
            {
                Console.WriteLine(i);
            }
        }
    }
}