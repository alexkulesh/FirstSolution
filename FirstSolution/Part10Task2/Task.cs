using System;

namespace Part10Task2
{   
    
    // Написать 2 метода, первый выводит в консоль "My name is Vasya"
    // второй выводит в консоль "My name is Kolya"
    
    public class Task
    {
        private static void Main(string[] args)
        {
            printText1();
            printText2();
        }

        static void printText1()
        {
            Console.WriteLine("My name is Vasya");
        }
        
        static void printText2()
        {
            Console.WriteLine("My name is Kolya");
        }
    }
}