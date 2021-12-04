using System;

namespace Part10Task13
{

    // Написать метод, который принимает неогранниченное количество
    // строк и неограниченно количество чисел Метод должен выводить
    // в консоль сообщение "number of string and int values is not equal",
    // если количество разное Если количество одинаковое, метод должен
    // выводить в консоль попарно 1ую строку с 1ым числом, 2ую строку
    // со 2ым числом в формате "<string>=<int>", например: a = 555 b =12 r = 111111
    
    public class Task
    {
        private static void Main(string[] args)
        {
            Method10(new []{"ggg","ttt","jjj"}, new []{111, 222, 333});
        }

        private static void Method10(string[] strings,  int[] numbers)
        {
            if (strings == null) throw new ArgumentNullException(nameof(strings));
            
            if (strings.Length > numbers.Length || strings.Length < numbers.Length)
            {
                Console.WriteLine("number of string and int values is not equal");
            }

            if (strings.Length == numbers.Length)
            {
                for (int i = 0; i < strings.Length; i++)
                {
                    Console.WriteLine(strings[i] + " = " + numbers[i] + " ");
                }
            }
        }
    }
}