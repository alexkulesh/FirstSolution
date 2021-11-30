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
            int i = 0;
            string num = n.ToString();
            string t = "";
            
            while (i <= num.Length - 1)
            {
                t += num[i];
                Console.WriteLine(t);
                i++;
            }
        }
    }
}