using System;
using System.Collections.Generic;
using System.Linq;
using Part15Task3;

namespace Part18Task5
{
    // На основе задания 4 необходимо написать преобразование Dictionary в List.
    // На основе задания 3 необходимо написать преобразование List в Dictionary.

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

            List<KeyValuePair<string, double>> dataList = dictionaryOfProducts.ToList();

            for (int i = 0; i < dataList.Count; i++)
            {
                Console.WriteLine(dataList[i]);
            }

            var newDictionary = dataList.Select((value, index) => new {value, index})
                .ToDictionary(pair => pair.index, pair => pair.value);

            foreach (var i in newDictionary)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }
        }
    }
}