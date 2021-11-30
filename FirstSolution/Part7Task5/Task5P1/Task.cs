using System;

namespace Task5P1
{   
    
    // Выполнить задание двумя способами: с использованием оператора if и с использованием условного оператора ?. Выполнить задания, минимизируя количество выполняемых операций сравнения и присваивания.
    // 1. Даны действительные числа x, y, z. Поменять значения переменных так, чтобы x < y < z; 
    // 2. Даны вещественные x1, x2, x3, x4. Поменять значения переменных так, чтобы x1 < x3 < x2 < x4 

    public static class Task
    {
        private static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double num;
            if (x > z)
            {
                num = z;
                z = x;
                x = num;
            }

            if (x > y)
            {
                num = y;
                y = x;
                x = num;
            }

            if (y > z)
            {
                num = z;
                z = y;
                y = num;
            }

            Console.WriteLine(x + " < " + y + " < " + z);

            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());

            if (x1 > x4)
            {
                num = x4;
                x4 = x1;
                x1 = num;
            }

            if (x1 > x2)
            {
                num = x2;
                x2 = x1;
                x1 = num;
            }

            if (x1 > x3)
            {
                num = x3;
                x3 = x1;
                x1 = num;
            }

            if (x3 > x4)
            {
                num = x4;
                x4 = x3;
                x3 = num;
            }

            if (x3 > x2)
            {
                num = x2;
                x2 = x3;
                x3 = num;
            }

            if (x2 > x4)
            {
                num = x4;
                x4 = x2;
                x2 = num;
            }

            Console.WriteLine(x1 + " < " + x3 + " < " + x2 + " < " + x4);
        }
    }
}