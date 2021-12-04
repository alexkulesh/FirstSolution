using System;

namespace Part10Task12
{   
    
    // Написать 10ый метод, который будет принимать время в качестве
    // параметра и возвращать разные строки в зависимости от времени
    // "good night" - c 22.00 до 05.00 "good morning" - c 05.00 до 12.00
    // "good afternoon" - c 12.00 до 18.00 "goood evening" - c18.00
    // до 22.00 в решении использовать несколько return операторов
    
    public class Task
    {
       private static void Main(string[] args)
       {
           DateTime dateTime = DateTime.Now;
           Console.WriteLine(Method10(dateTime));
       }

       static string Method10(DateTime dateTime)
       {
           if (dateTime.Hour >= 22 && dateTime.Hour <= 5)
           {
               return "good night";
           }
           
           if (dateTime.Hour >= 5 && dateTime.Hour < 12)
           {
               return "good morning";
           }
           
           if (dateTime.Hour >= 12 && dateTime.Hour < 18)
           {
               return "good afternoon";
           }
           
           if (dateTime.Hour >= 18 && dateTime.Hour < 22)
           {
               return "good evening";
           }
           
           else
           {
               return "You put wrong data";
           }
       }
    }
}