using System;

namespace Part8Task3P2
{
   
    // Дано число n=1000. Делите его на 2 столько раз, пока результат
    // деления не станет меньше 50. Какое число получится? Посчитайте
    // количество итераций, необходимых для этого (итерация - это проход цикла).
    // Используйте цикл for.

    public class Task
    {
        static void Main(string[] args)
        {
            int number = 1000;
            int i = 0;

            for (int j = 0; number >= 50; j++)
            {
                number /= 2;
                i++;
            }

            Console.WriteLine("Количество итераций равна - " + i);
        }
    }
}