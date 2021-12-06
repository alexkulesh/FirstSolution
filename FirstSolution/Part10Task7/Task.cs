using System;

namespace Part10Task7
{   
    
    // Написать 5ый метод, который будет принимать неопределенное число имен,
    // и строго одно значение в качестве возраста. Метод должен выводить в
    // консоль сообщение вида: "We are kolya, vasya and petya. And we are 50 years old"
    
    public class Task
    {
       private static void Main(string[] args)
       {
           PrintTextUsingSeveralNames( 40, new string[]{"Alex", "Howard", "John"});
       }

       private static void PrintTextUsingSeveralNames(int age, string[]? name)
       {
           if (name != null && name.Length >= 3)
           {
               Console.WriteLine("We are " + name[0] + ", " + name[1] + " and " + name[2] + ". And we are " + age +
                                 " years old");
           }
           else
           {
               Console.WriteLine("You should have entered at least 3 parameters");
           }
       }
    }
}