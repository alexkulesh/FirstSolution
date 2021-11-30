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
            string num = n.ToString();
            string t = "";
            
            for (int i = 0; i <= num.Length - 1; i++)
            {
                t += num[i];
                Console.WriteLine(t);
            }
        }
    }
}