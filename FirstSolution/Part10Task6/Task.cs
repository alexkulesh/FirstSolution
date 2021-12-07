using System;

namespace Part10Task6
{
   
    // Преобразовать 4ый метод, чтобы он ничего не возвращал,
    // если years == 0 (используя оператор return)
    
    public class Task
    {
        private static void Main(string[] args)
        {
            PrintTextDependingOnAge("Ilya", 13);
        }

        private static void PrintTextDependingOnAge(string name, int age)
        {
            if (age == 0)
            {
                return;
            }

            if (age > 0)
            { 
                if (age == 1)
                {
                    Console.WriteLine($"My name is {name} and I'm {age} year old");
                }
                else
                {
                    Console.WriteLine($"My name is {name} and I'm {age} years old");
                }
            }
            else
            {   
                Console.WriteLine("Incorrect input data");
            }
        }  
    }   
}