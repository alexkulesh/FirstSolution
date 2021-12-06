using System;

namespace Part10Task6
{
   
    // Преобразовать 4ый метод, чтобы он ничего не возвращал,
    // если years == 0 (используя оператор return)
    
    public class Task
    {
        private static void Main(string[] args)
        {
            PrintTextDependingOnAge("Ilya", 0);
        }

        private static string PrintTextDependingOnAge(string name, int age)
        {
            if (age > 0)
            {
                if (age == 1)
                {
                    return String.Format("My name is {0} and I'm {1} year old", name, age);
                }
                else
                {
                    return String.Format("My name is {0} and I'm {1} years old", name, age);
                }
            } 
            else if (age == 0)
            {
                return "";
            }
            else
            {
                return "Incorrect input data";
            }
        }  
    }   
}