using System;

namespace Part9Task5
{
    
    // In a given array of real numbers, find the
    // difference between the maximum and minimum number.
    
    public class Task
    {
        private static void Main(string[] args)
        {
            double[] array = {1.24, 3.72, 6.56, 4.33};
            double max = array[0];
            double min = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }

                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Difference between the maximum and minimum number equals - " + (float)(max - min));
        }
    }
}