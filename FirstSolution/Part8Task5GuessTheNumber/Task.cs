using System;

namespace Part8Task5GuessTheNumber
{
    
    // Написать игру "Угадай число".
    // Программа случайно выбирает число в диапазоне 0-100.
    // Пользователь должен угадать это число.
    // После ввода варианта пользователя выводиться сообщение "больше" если выбранное
    // больше введенного пользователем."меньше" если выбранное число меньше введенного пользователем.
    // "правильно" если выбранное число совпало с введенным пользователем. Предусмотреть возможность
    // сыграть несколько раз без перезапуска программы. По желанию разработчика можно предусмотреть
    // вариант с ограничением количества попыток пользователя для угадывания числа.

    public class Task
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            Console.WriteLine(number);

            for (int i = 1; i <= 3; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
    
                if (input == number)
                {
                    Console.WriteLine("Правильно");
                    break;
                }
                else if (input < number)
                {
                    Console.WriteLine("Меньше");
                }
                else if (input > number)
                {
                    Console.WriteLine("Больше");
                }
                else
                {
                    Console.WriteLine("Некорректно введены данные");
                }
            }
        }
    }
}