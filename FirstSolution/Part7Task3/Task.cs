using System;

namespace Part7Task3
{   
    
    // Выполнить задание, выделяя цифры числа, хранящегося в переменной стандартного
    // вещественного числового типа
    // 1. Определить, есть ли среди первых пяти цифр дробной части заданного
    // положительного вещественного числа, цифра 0.
    // 2. Определить, есть ли среди первых четырех цифр дробной части заданного
    // положительного вещественного числа, цифра 9.
    // 3. Определить, равна ли первая цифра дробной части заданного
    // положительного вещественного числа четвертой цифре.

    public static class Task
    {
        private static void Main(string[] args)
        {
            double num = Convert.ToDouble(Console.ReadLine());

            if (num > 0)
            {
                int rest = num.ToString().Substring(num.ToString().IndexOf(',') + 1).Length;

                if (rest <= 5)
                {
                    string rest0 = num.ToString().Substring(num.ToString().IndexOf(',') + 1, 4);
                    if (rest0.Contains('0'))
                        Console.WriteLine("Дробная часть содержит 0");
                }

                if (rest <= 4)
                {
                    string rest9 = num.ToString().Substring(num.ToString().IndexOf(',') + 1, 3);
                    if (rest9.Contains('9'))
                        Console.WriteLine("Дробная часть содержит 9");
                }

                string restEq = num.ToString().Substring(num.ToString().IndexOf(',') + 1);

                if (restEq[0] == restEq[3])
                {
                    Console.WriteLine("первая цифра дробной части заданного положительного " +
                                      "вещественного числа равна четвертой цифре");
                }
            }
        }
    }
}