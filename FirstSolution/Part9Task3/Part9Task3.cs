using System;

namespace Part9Task3
{
    
    // At a given text string, define the number of words. Each word is separated
    // from each other by a space.
    
    public class Task
    {
        private static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[]? words = text?.Trim().Split(' ');
            Console.WriteLine("The number of words in the text - " + words.Length);
        }
    }
}