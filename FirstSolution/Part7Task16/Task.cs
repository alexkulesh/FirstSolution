using System;

namespace Part7Task16
{
    
    //Используя тернарную операцию проверить, делится ли введенное с клавиатуры число на 8 без остатка.
    
    public static class Task
    {
        private static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            
            if (a >= 0)
            {
                string text = a % 8 == 0 ? "Делится без остатка" : "Делится c остатком";
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Введено значение ниже нуля");
            }
        }
    }
}