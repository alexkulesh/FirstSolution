using System;

namespace Part7Task4
{
    
    // Присвоить логической переменной значение логического выражения, истинного при выполнении
    // следующего условия и ложного в противном случае: 
    // 1.  год с порядковым номером y является високосным; 
    // 2.  целые числа x, y, z равны между собой; 
    // 3. только одно из целых чисел x, y, z положительно;
    
    public static class Task
    {
        private static void Main(string[] args)
        {
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            int z = Convert.ToInt16(Console.ReadLine());
            bool year = false;
            bool areEqual = false;
            bool isPositive = false;
            
            if (y % 4 == 0)
            {
                year = true;
            }
            
            Console.WriteLine("Год является високосным - " + year);

            if (x == y && x == z)
            {
                areEqual = true;
            }
            
            Console.WriteLine("числа x, y, z равны между собой - " + areEqual);
            
            if ((x > 0 && y < 0 && z < 0) || (x < 0 && y > 0 && z < 0) || (x < 0 && y > 0 && z < 0))
            {
                isPositive = true;
            }    
            
            Console.WriteLine("только одно из целых чисел x, y, z положительно - " + isPositive);
        }
    }
}