using System;

namespace Part7Task15
{
    
    //Пользователь вводит с консоли строку, которая может принимать 2 значения: 'ru' либо 'en'.
    //Если она имеет значение 'ru', то вывести на консоль слово ""Брест"", а если имеет
    //значение 'en' – то ""Brest"".  Решите задачу через if, через switch-case (должно быть 2 решения).
    //Обработайте ситуацию, когда введенное значение не равно 'ru' либо 'en'.
    
    public static class Task
    {
        private static void Main(string[] args)
        {
            var locale = Console.ReadLine();
            
            if (locale != null && locale.Contains("ru"))
            {
                Console.WriteLine("Брест");
            }
            else if (locale != null && locale.Contains("en"))
            {
                Console.WriteLine("Brest");
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
            }
        }
    }
}