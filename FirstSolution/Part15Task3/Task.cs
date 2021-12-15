using System;

namespace Part15Task3
{   
    // Полную структуру классов и их взаимосвязь продумать самостоятельно. Исходные данные база (массив)
    // из n товаров задать непосредственно в коде (захардкодить).
    // Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре,
    // а также определить, соответствует ли она сроку годности на текущую дату.
    // Создать производные классы:
    // Продукт (название, цена, дата производства, срок годности),
    // Партия (название, цена, количество шт, дата производства, срок годности), Комплект
    // (названия, цена, перечень продуктов) со своими методами вывода информации на экран, и
    // определения соответствия сроку годности. Создать базу (массив) из n товаров, вывести
    // полную информацию из базы на экран, а также организовать поиск просроченного
    // товара (на момент текущей даты).
    
    public class Task3
    {
        private static void Main(string[] args)
        {
            Product[] products =
            {
                new Item("Milk", 5.3,  new DateTime(2021, 11, 16), new DateTime(2021, 12, 16) ),
                new Item("Bread", 1.3,  new DateTime(2021, 12, 1), new DateTime(2021, 12, 14) ),
                new Item("Cheese", 2.3,  new DateTime(2021, 11, 21), new DateTime(2021, 12, 20) ),
                new Batch("Sugar", 1500.0,  1, new DateTime(2021, 12, 14), new DateTime(2023, 12, 14)),
                new Batch("Wheat flour", 4020.0,  4, new DateTime(2021, 12, 14), new DateTime(2022, 06, 14)),
                new Batch("Vitamin B12", 45000.0,  1, new DateTime(2021, 12, 14), new DateTime(2031, 12, 14)),
                new Set("PC set", 3540.65, new Item[]
                {
                    new Item("Screen", 660.40,new DateTime(2021, 8, 20), new DateTime(2031, 12, 20)), 
                    new Item("System block", 2430.40,new DateTime(2021, 8, 20), new DateTime(2031, 12, 20)),
                    new Item("Mouse", 105.10,new DateTime(2021, 8, 20), new DateTime(2031, 12, 20)),
                    new Item("Keyboard", 150.30,new DateTime(2021, 8, 20), new DateTime(2031, 12, 20)),
                })
            };

            for (int i = 0; i < products.Length; i++)
            {
                products[i].printInfo();
                products[i].compareDates();
            } 
        }
    }
}