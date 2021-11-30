using System;

namespace Part7Task13
{
    
    //Напишите консольную программу, пользователь вводит с клавиатуры поочередно
    //три числа a, b, c. Проверить: выполняется ли неравенство a < b < c;
    //выполняется ли неравенство b > a > c.
    
    public class Task
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < b && b < c)
            {
                Console.WriteLine("Неравенство a < b < c выполняется");
            }
            else if (b > a && a > c)
            {
                Console.WriteLine("Неравенство b > a > c выполняется");
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
            }
        }
    }
}