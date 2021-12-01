using System;

namespace Part8Task4P2
{
    
    // Пользователь вводит число. Выведите n строк, добавляя следующее
    // натуральное число на каждой строке. Используйте цикл for
    
    public class Task
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            string t = "";
            
            for (int i = 1; i <= n; i++)
            {
                t += i;
                Console.WriteLine(t);
            }
        }
    }
}