using System;

namespace Part7Task2
{
    
    //Выполнить задание, выделяя цифры числа, хранящегося в переменной стандартного целого числового типа.
    //1. Определить число, полученное выписыванием в обратном порядке цифр четырехзначного натурального числа n.
    //2.  Дано четырехзначное натуральное n. Верно ли, что это число содержит ровно две цифры 7?
    // 3. Дано четырехзначное натуральное n. Верно ли, что сумма первых двух
    // цифр равна сумме двух оставшихся цифр числа?
    
    public static class Task
    {
        private static void Main(string[] args)
        {
            var a = Convert.ToInt16(Console.ReadLine());
            
            if (a == 4)
            {
                string text = a.ToString();
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    Console.Write(text[i]);
                }

                int num7 = 0;
                
                for (int i = 0; i <= text.Length - 1; i++)
                {
                    if (text[i] == '7')
                    {
                        num7 += 1;
                    }
                }

                if (num7 == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Это число содержит ровно две цифры 7");
                    Console.WriteLine("");
                }

                int sum1 = 0;
                int sum2 = 0;

                for (int i = 0; i <= text.Length - 1; i++)
                {
                    if (i <= 1)
                    {
                        sum1 += Convert.ToInt16(text[i]);
                    }
                    else
                    {
                        sum2 += Convert.ToInt16(text[i]);
                    }
                }

                string expr = sum1 == sum2
                    ? "сумма первых двух цифр равна сумме двух оставшихся цифр числа"
                    : "сумма первых двух цифр не равна сумме двух оставшихся цифр числа";
                
                Console.WriteLine(expr);
            }
            else
            {
                Console.WriteLine("Число не четырехзначное");
            }
        }
    }
}