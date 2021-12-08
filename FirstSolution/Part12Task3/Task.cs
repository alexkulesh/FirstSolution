using System;

namespace Part12Task3
{
    // Дано слово, состоящее только из строчных латинских букв.
    // Проверьте, является ли это слово палиндромом. Выведите YES или NO.
    // При решении этой задачи нельзя пользоваться циклами

    public class Task
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(IsWordAPalindrome("ABBA"));
        }

        private static string IsWordAPalindrome(string word)
        {
            if (word.Length == 0)
            {
                return "You haven't entered a single word. There is nothing to check";
            }
            
            if (word.Length > 2 & word[0] == word[word.Length - 1])
            {
                word = word.Substring(1, word.Length - 2);
                return IsWordAPalindrome(word);
            }
            
            if (word.Length <= 2 & word[0] == word[word.Length - 1])
            {
                return "Yes";
            }

            return "NO";
        }
    }
}