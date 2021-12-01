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
            int n = 1000;
            int i = 0;

            for (int j = 0; n >= 50; j++)
            {
                n /= 2;
                i++;
            }
            
            Console.WriteLine("Результат равен - " + n);
            Console.WriteLine("Количество итераций равна - " + i);
        }
    }
}