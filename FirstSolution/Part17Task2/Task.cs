using System;

namespace Part17Task2
{   
    // 2. Реализовать статический класс для произведения математических операций.
    // Класс должен содержать статический метод который принимает в качестве
    // памаретров 2 числа и тип операции которую необходиной выполнить (перечисление). 
    // 2.1 Реализовать перечесление которое будет содержать возможные математические
    // операции (Сложение, вычитание, умножение, деление). По возможности использовать
    // обработку исключений. Числа вводить с клавиатуры
    
    public class Task
    {
        private static void Main(string[] args)
        {
            double inputNum1 = Convert.ToDouble(Console.ReadLine());
            double inputNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(MathOperations.MathOp(inputNum1, inputNum2, Operation.Addition));
            Console.WriteLine(MathOperations.MathOp(inputNum1, inputNum2, Operation.Subtraction));
            Console.WriteLine(MathOperations.MathOp(inputNum1, inputNum2, Operation.Multiplication));
            Console.WriteLine(MathOperations.MathOp(inputNum1, inputNum2, Operation.Division));
        }
    }
}