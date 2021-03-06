using System;

namespace Part15Task2
{
    // Полную структуру классов и их взаимосвязь продумать самостоятельно.
    // Исходные данные база (массив) из n машин задать непосредственно в коде (захардкодить).
    // Создать базовый класс Auto с методами позволяющим вывести на экран информацию о транспортном средстве,
    // а также определить грузоподъемность транспортного средства.
    // Создать производные классы: 
    // Легковая_машина (марка, номер, скорость, грузоподъемность),
    // Мотоцикл (марка, номер, скорость, грузоподъемность, наличие коляски, при этом если коляска отсутствует,
    // то грузоподъемность равна 0), Грузовик (марка, номер, скорость, грузоподъемность, наличие прицепа, при
    // этом если есть прицеп, то грузоподъемность увеличивается в два раза) со своими методами вывода информации
    // на экран, и определения грузоподъемности. Создать базу (массив) из n машин, вывести полную информацию
    // из базы на экран, а также организовать поиск машин, удовлетворяющих требованиям грузоподъемности. 
    
    public class Task2
    {
        private static void Main(string[] args)
        {
            Auto[] autos = {new Car("Ford", "4433", 180, 500, 4), new Motorcycle("BMW", "1111", 210, 100, false), new Truck("MAN", "5533", 120, 10500, true)};

            for (int i = 0; i < autos.Length; i++)
            {
                autos[i].printInfo();
            }
            
            int desiredCapacity = 5000;
            Console.WriteLine($"List of autos that fits your desirable carrying capacity - {desiredCapacity}");
            
            for (int i = 0; i < autos.Length; i++)
            {
                if (desiredCapacity < autos[i].CarryingCapacity)
                {
                    autos[i].printInfo();
                }   
            }
        }
    }
}