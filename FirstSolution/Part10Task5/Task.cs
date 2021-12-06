using System;

namespace Part10Task5
{
    
    // Преобразовать 4ый метод, чтобы он отображал "year" или "years" в зависимости от
    // количества лет Вызвать 4ый метод с разными параметрами из метода Main

    public class Task
    {
        private static void Main(string[] args)
        {
            PrintTextDependingOnAge("Ilya", 22);
        }

        private static void PrintTextDependingOnAge(string name, int age)
        {
            if (age > 0)
            {
                if (age == 1)
                {
                    Console.WriteLine("My name is {0} and I'm {1} year old", name, age);
                }
                else
                {
                    Console.WriteLine("My name is {0} and I'm {1} years old", name, age);
                }
            }
            else
            {
                Console.WriteLine("Incorrect input data");
            }
        }
    }
}