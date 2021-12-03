using System;

namespace Part9Task2
{
   
    // In the row array (list of surnames), define the longest surname.
    
    public class Task
    {
        private static void Main(string[] args)
        {
            string [] surnames = {"Кулеш", "Иванов", "Зинкевич", "Сидоров", "Будревич"};
            int longest = surnames[0].Length;
            int index = 0;
            
            for (int i = 1; i < surnames.Length; i++)
            {   
                if (longest < surnames[i].Length)
                {   
                    longest = surnames[i].Length;
                    index = i;
                }
            }
            
            Console.WriteLine("The longest surname - " + surnames[index]);
            
            if (index != surnames.Length - 1)
            {
                for (int i = index + 1; i < surnames.Length; i++)
                {
                    if (longest == surnames[i].Length)
                    {
                        Console.WriteLine("Another longest surname - " + surnames[i]);
                    }
                }
            }
        }
    }
}