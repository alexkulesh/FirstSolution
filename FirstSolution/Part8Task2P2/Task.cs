using System;

namespace Part8Task2P2
{
    
    // Напишите программу, которая считает сумму первых 10 натуральных чисел, используя цикл for.
    
    public class Task
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            for (int i = 1; i <= 10; i++)
            { 
                sum += i;
            }
            
            Console.WriteLine("Сумма первых 10 натуральных чисел равна - " + sum);
        }
    }
}