using System;

namespace Part7Task11
{
    
    //Напишите консольную программу, пользователь вводит с клавиатуры число.
    //Программа проверяет и выводит на консоль результат ""Число четное"" либо
    //""Число нечетное"", либо ""Введено некорректное значение"".
    
    public class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num % 2 == 0 && num > 1)
            {
                Console.WriteLine("Число четное!");
            }
            else if (num % 2 != 0 && num > 1)
            {
                Console.WriteLine("Число нечетное!");
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
            }
        }
    }
}