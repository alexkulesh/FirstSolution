using System;

namespace Part12Task1
{
    // Написать рекурсивный метод выводящий строку в обратном
    // порядке. Допускается применить более одного входящего параметра.

    public class Task
    {
        private static void Main(string[] args)
        {
            ReverseString("computer".Length, "computer");
        }

        private static string ReverseString(int length, string text)
        {
            if (length > 0)
            {
                string letter = text[length - 1].ToString();
                --length;
                Console.Write(letter);
                return ReverseString(length, text);
            }

            return text;
        }
    }
}