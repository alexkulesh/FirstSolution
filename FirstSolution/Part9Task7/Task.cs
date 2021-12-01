using System;

namespace Part9Task7
{   
    
    // An array consisting of the following words: abraacadaabra, bellio, whiite
    // Create a new array using loops and conditional expressions
    // that will contain words in which two coming letters differ. If they are the same,
    // then leave only the 1st symbol
    // For example:
    // At the entry point we have the word "whiite". At the end we must get "white"
   
    public class Task
    {
        private static void Main(string[] args)
        {
            string[] array = {"abraacadaabra", "belLio", "whiite"};
            string[] newArray = new string [array.Length];

            for (int i = 0; i < array.Length; i++)
            {   
                string newWord = "";
                string word = array[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (j < array[i].Length - 1 && word[j] == word[j+1])
                    {   
                        j++;
                    }
                    var letter = word[j];
                    newWord += letter;
                }
                
                newArray[i] = newWord;
                Console.WriteLine(newArray[i]);
            }
        }
    }
}