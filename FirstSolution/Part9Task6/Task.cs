using System;

namespace Part9Task6
{
    
    // A two-dimensional array of numbers is set (use random numbers generator).
    // Sort each odd string ascending, and each even - descending, then output
    // the value of the k-th column.
    
    public class Task
    {
        private static void Main(string[] args)
        {
            int[,] array = new int[5,5];
            Random random = new Random();
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;
            Console.WriteLine("Unsorted array");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i,j] = random.Next(0, 10);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = j + 1; k < columns; k++)
                    {
                        int sort;
                        if ((i + 1) % 2 == 0)
                        {
                            if (array[i, j] < array[i, k])
                            {
                                sort = array[i, j];
                                array[i, j] = array[i, k];
                                array[i, k] = sort;
                            }
                        }
                        
                        if ((i + 1) % 2 != 0)
                        {
                            if (array[i, j] > array[i, k])
                            {
                                sort = array[i, j];
                                array[i, j] = array[i, k];
                                array[i, k] = sort;
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine("Sorted array");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}