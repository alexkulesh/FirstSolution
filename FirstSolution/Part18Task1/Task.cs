using System;
using System.Collections.Generic;
using System.Linq;
using Part15Task3;

namespace Part18Task1
{
   
    // а) Создать динамический массив, содержащий объекты класса Product 
    // б) Распечатать его содержимое используя for each. 
    // в) Изменить цену одного продукта на 100. 
    // г) Удалить последний продукт. 
    // д) Распечатать его содержимое используя LINQ.
    // е) Получить массив содержащий продукты из коллекции тремя способами и вывести на консоль. 
    // ж) Удалить все продукты.
    
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

            foreach (var i in products)
            {
                i.printInfo();
            }

            foreach (var i in products)
            {
                i.Price += 100;
                i.printInfo();
            }

            products.RemoveAt(products.Count - 1);
            var printProducts = from product in products
                select new {product};
            
            foreach (var i in printProducts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Array 1");
            Product[] arrayOfProducts1 = new Product[products.Count];

            for (int i = 0; i < arrayOfProducts1.Length; i++)
            {
                arrayOfProducts1[i] = products[i];
                Console.WriteLine($"Name - {arrayOfProducts1[i].Name}; Price - {arrayOfProducts1[i].Price};");
            }

            Console.WriteLine("Array 2");
            var arrayOfProducts2 = (from product in products
                select product).ToArray();

            for (int i = 0; i < arrayOfProducts2.Count(); i++)
            {
                Console.WriteLine($"Name - {arrayOfProducts1[i].Name}; Price - {arrayOfProducts1[i].Price};");
            }

            var arrayOfProducts3 = products.ToArray();
            Console.WriteLine("Array 3");

            for (int i = 0; i < arrayOfProducts3.Length; i++)
            {
                Console.WriteLine($"Name - {arrayOfProducts3[i].Name}; Price - {arrayOfProducts3[i].Price};");
            }

            products.Clear();
        }
    }
}