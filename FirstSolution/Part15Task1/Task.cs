using System;

namespace Part15Task1
{
    public class Task
    {
        // Создать класс, cо следующими свойствами: 
        // сlass Bus: Пункт назначения, Номер, Время отправления, Число мест
        // Определить get, set методы для этих свойств.
        // Создать класс с main методом, в котором будет объявлен объект класса Bus.
        // Вывести все данные (значения полей) объекта в консоль.
    
        public class Task1
        {
            private static void Main(string[] args)
            {
                Bus bus = new Bus("Minsk", 4, "9:30", 40);
                Console.WriteLine(bus);
            }
        }
    }
}