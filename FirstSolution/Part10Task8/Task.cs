using System;

namespace Part10Task8
{   
    
    //Написать 6ой метод, который принимает 2 массива строковых значений,
    //объединяет их в один массив и возвращает его. Показать пример
    //использования метода, вызвав его из метода Main 
    
    public class Task
    {
        private static void Main(string[] args)
        {   
            string [] newArray = CreateNewArray(new string[]{"f","fddf", "alex", "kolya", "john"}, new string[]{"111", "222","333"});
            
            foreach (var i in newArray)
            {
                Console.Write(i + " ");
            }
        }
        
        private static string[] CreateNewArray(string[] array1, string[] array2)
        {
            string[] newArray = new string[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                newArray[i] = array1[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                newArray[i + array1.Length] = array2[i];
            }
            
            return newArray;
        }
    }
}