using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Part18Task0
{
    public class Task
    {
        private static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            
            if (list == null) throw new ArgumentNullException(nameof(list));
            try
            {
                string s = (string) list[18];
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ArgumentOutOfRangeException");
            }

            Dictionary<string, int> dictionary = new()
            {
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9},
                {"ten", 10},
            };

            foreach (var i in dictionary)
            {
                Console.WriteLine(i);
            }

            string? text = Convert.ToString(Console.ReadLine());
            string?[] newText = text.Split(" ");
            var query = newText.Distinct();

            foreach (var i in query)
            {
                Console.Write(i);
            }
        }
    }
}