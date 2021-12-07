using System;

namespace Part11Task1
{
    // Написать метод Max() или Min() находящий в массиве максимальное или
    // минимальное число и возвращающий его. Использовать перегрузку для
    // работы с типами byte, int, double, float.

    public class Task
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Max(new byte[] {1, 4, 3, 2}));
            Console.WriteLine(Max(new int[] {10, 14, 23, 12}));
            Console.WriteLine(Max(new double[] {1.6, 4.6, 2.3, 1.2}));
            Console.WriteLine(Max(new float[] {1.1f, 7.4f, 5.3f, 2.2f}));
        }

        private static byte Max(byte[] array)
        {
            byte max = array[0];

            foreach (var i in array)
            {
                if (max < i)
                {
                    max = i;
                }
            }

            return max;
        }

        private static int Max(int[] array)
        {
            int max = array[0];

            foreach (var i in array)
            {
                if (max < i)
                {
                    max = i;
                }
            }

            return max;
        }

        private static double Max(double[] array)
        {
            double max = array[0];

            foreach (var i in array)
            {
                if (max < i)
                {
                    max = i;
                }
            }

            return max;
        }

        private static float Max(float[] array)
        {
            float max = array[0];

            foreach (var i in array)
            {
                if (max < i)
                {
                    max = i;
                }
            }

            return max;
        }
    }
}