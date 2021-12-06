using System;

namespace Part10Task2
{   
    
    // Написать 2 метода, первый выводит в консоль "My name is Vasya"
    // второй выводит в консоль "My name is Kolya"
    
    public class Task
    {
        private static void Main(string[] args)
        {
            PrintTextUsingNameVasya();
            PrintTextUsingNameKolya();
        }

        static void PrintTextUsingNameVasya()
        {
            Console.WriteLine("My name is Vasya");
        }
        
        static void PrintTextUsingNameKolya()
        {
            Console.WriteLine("My name is Kolya");
        }
    }
}