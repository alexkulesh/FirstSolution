using System;

namespace Part11Task2
{
    //Написать метод Sum() возвращающий сумму элементов массива.
    //Использовать перегрузку для работы с типами byte, int, double, float.

    public class Task
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Sum(new byte[] {1, 4, 3, 2}));
            Console.WriteLine(Sum(new int[] {10, 14, 23, 12}));
            Console.WriteLine(Sum(new double[] {1.6, 4.6, 2.3, 1.2}));
            Console.WriteLine(Sum(new float[] {1.1f, 7.4f, 5.3f, 2.2f}));
        }

        private static byte Sum(byte[] array)
        {
            byte sum = 0;

            foreach (var i in array)
            {
                sum += i;
            }

            return sum;
        }

        private static int Sum(int[] array)
        {
            int sum = 0;

            foreach (var i in array)
            {
                sum += i;
            }

            return sum;
        }

        private static double Sum(double[] array)
        {
            double sum = 0;

            foreach (var i in array)
            {
                sum += i;
            }

            return sum;
        }

        private static float Sum(float[] array)
        {
            float sum = 0;

            foreach (var i in array)
            {
                sum += i;
            }

            return sum;
        }
    }
}