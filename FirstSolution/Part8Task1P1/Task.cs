using System;

namespace Part8Task1P1
{
    
    //Выведите столбец чисел от 1 до 50, используя цикл while.

    public class Task
    {
        static void Main(string[] args)
        {
            int i = 1;
            
            while (i <= 50)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}