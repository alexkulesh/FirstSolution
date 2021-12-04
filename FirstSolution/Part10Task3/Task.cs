using System;

namespace Part10Task3
{
    
    // Write a third method that takes a name as a parameter and prints it to 
    // the console "My name is <name>". Call the method twice from the Main 
    // method with different parameters.
    
    public class Task
    {
        private static void Main(string[] args)
        {
            Text("Vasya");
            Text("Kolya");
        }

        private static void Text (string name)
        {
            Console.WriteLine("My name is " + name);
        }  
    }
}