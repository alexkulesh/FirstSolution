using System;

namespace Part12Task2
{
    
    // Необходимо написать рекурсивный метод, который принимает один параметр (целое число).
    // Результат вызова данной функции должен вернуть все значения предшествующих цифр перед
    // передаваемым числом
    // Например:
    // Цифра 5 была передана в данную функцию.
    // На выходе мы должны получить: 12345
    
    public class Task
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ReturnNums(5));
        }

        private static string ReturnNums(int num)
        {
            if (num == 1)
            {
                return "1";
            }
            
            return ReturnNums(num - 1) + " " + num;
        }
    }
}