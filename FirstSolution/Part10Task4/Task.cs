using System;

namespace Part10Task4
{
   
    // Write the 4th method, which takes age as a parameter and displays it
    // in the console "My name is <name> and I'm <again> years old"
    
    public class Task
    {
        private static void Main(string[] args)
        {
            PrintTextUsingNameAndAge("Ivan", 22);
        }
        
        private static void PrintTextUsingNameAndAge (string name, int age)
        {
            Console.WriteLine("My name is " + name + " and I'm " + age + " years old");
        }  
    }
}