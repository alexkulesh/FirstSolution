using System;

namespace Part8Task4P1
{
    
    // Пользователь вводит число. Выведите n строк, добавляя следующее
    // натуральное число на каждой строке. Используйте цикл while
    
    public class Task
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            string t = "";
            
            while (i <= n)
            {
                t += i;
                Console.WriteLine(t);
                i++;
            }
        }
    }
}