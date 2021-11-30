using System;

namespace Task5P2
{
    
    // Выполнить задание двумя способами: с использованием оператора if и с использованием
    // условного оператора ?. Выполнить задания, минимизируя количество выполняемых операций
    // сравнения и присваивания.
    // 1. Даны действительные числа x, y, z. Поменять значения переменных так, чтобы x < y < z; 
    // 2. Даны вещественные x1, x2, x3, x4. Поменять значения переменных так, чтобы x1 < x3 < x2 < x4 

    public static class Task
    {
        private static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double num = 0;

            num = z;
            z = x > z ? z = x : z;
            x = x > num ? x = num : x;

            num = y;
            y = x > y ? y = x : y;
            x = x > num ? x = num : x;

            num = z;
            z = y > z ? z = y : z;
            y = y > num ? y = num : y;

            Console.WriteLine(x + " < " + y + " < " + z);

            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());

            num = x4;
            x4 = x1 > x4 ? x4 = x1 : x4;
            x1 = x1 > num ? x1 = num : x1;

            num = x2;
            x2 = x1 > x2 ? x2 = x1 : x2;
            x1 = x1 > num ? x1 = num : x1;

            num = x3;
            x3 = x1 > x3 ? x3 = x1 : x3;
            x1 = x1 > num ? x1 = num : x1;

            num = x4;
            x4 = x3 > x4 ? x4 = x3 : x4;
            x3 = x3 > num ? x3 = num : x3;

            num = x2;
            x2 = x3 > x2 ? x2 = x3 : x2;
            x3 = x3 > num ? x3 = num : x3;

            num = x4;
            x4 = x2 > x4 ? x4 = x2 : x4;
            x2 = x2 > num ? x2 = num : x2;

            Console.WriteLine(x1 + " < " + x3 + " < " + x2 + " < " + x4);
        }
    }
}