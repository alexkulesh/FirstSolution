using System;

namespace Part9Task4
{
    
    // A one-dimensional array of integers is set. Form two arrays
    // sorted by increasing numbers, that are containing even and odd numbers.
    
    public class Task
    {
        private static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10,11,13};
            int evenArrayLength = 0;
            int oddArrayLength = 0;
            int evenElement = 0;
            int oddElement = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {   
                    evenArrayLength++;
                }
                
                if (array[i] % 2 != 0)
                {   
                    oddArrayLength++;
                }
            }
            
            int[] evenArray = new int[evenArrayLength];
            int[] oddArray = new int[oddArrayLength];
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenArray[evenElement] = array[i];
                    evenElement++;
                }
                if (array[i] % 2 != 0)
                {
                    oddArray[oddElement] = array[i];
                    oddElement++;
                }
            }
            
            Console.WriteLine("Even numbers array");
            
            foreach (var t in evenArray)
            {
                Console.Write(t + " ");
            }
            
            Console.WriteLine("\nOdd numbers array" );
            
            foreach (var t in oddArray)
            {
                Console.Write(t + " ");
            }
        }
    }
}