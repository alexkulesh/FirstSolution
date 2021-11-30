using System;

namespace Part7Task12
{
    
    // Пользователь вводит номер месяца (от 1 до 12). Вывести на консоль время года.
    
    public class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num >= 1 && num <= 13)
            {
                if (num == 12 || num <= 2)
                {
                    Console.WriteLine("На дворе зима");
                }
                else if (num >= 3 && num <= 5)
                {
                    Console.WriteLine("На дворе весна");
                }
                else if (num >= 6 && num <= 8)
                {
                    Console.WriteLine("На дворе лето");
                }
                else if (num >= 9 && num <= 11)
                {
                    Console.WriteLine("На дворе осень");
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
            }
        }
    }
}