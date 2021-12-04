using System;

namespace Part10Task5
{
    
    // Преобразовать 4ый метод, чтобы он отображал "year" или "years" в зависимости от
    // количества лет Вызвать 4ый метод с разными параметрами из метода Main

    public class Task
    {
        private static void Main(string[] args)
        {
            Text("Ilya", 22);
        }

        private static void Text(string name, int age)
        {
            if (age > 0)
            {
                if (age == 1)
                {
                    Console.WriteLine("My name is " + name + " and I'm " + age + " year old");
                }
                else
                {
                    Console.WriteLine("My name is " + name + " and I'm " + age + " years old");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input data");
            }
        }
    }
}