using System;

namespace Part8Task2P1
{
   
    // Напишите программу, которая считает сумму первых 10 натуральных чисел, используя цикл while.

    public class Task
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;

            while (i <= 10)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Сумма первых 10 натуральных чисел равна - " + sum);
        }
    }
}