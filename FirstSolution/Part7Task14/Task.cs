using System;

namespace Part7Task14
{
    
    // Пользователь вводит с клавиатуры любую строку (предложение).
    // Проверить и вывести на консоль результат, содержит ли строка подстроку ""тест"".
    
    public class Task
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(str.Contains("тест"));
        }
    }
}