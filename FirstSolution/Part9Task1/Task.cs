using System;

namespace Part9Task1
{
    // Enter the desired length line from the keyboard and calculate
    // the percentage of the character entries in the string.
    
    public static class Task
    {
        private static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            if (text != null && text.Length > 0)
            {   
                Console.WriteLine("Enter the character");
                char symbol = Convert.ToChar(Console.ReadLine());
                double num = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == symbol)
                    {
                        num++;
                    }
                }
                
                double percent = (num / text.Length) * 100;
                Console.WriteLine(percent);
            }
            else
            {
                throw new NullReferenceException("Empty text");
            }
        }
    }
}