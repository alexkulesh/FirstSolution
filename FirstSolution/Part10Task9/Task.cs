using System;

namespace Part10Task9
{
    // Написать 7ой и 8ой методы, которые взаимодествуют между собой.
    // 8ой метод принимает целочисленное значение. Далее генерирует
    // свое рандомное значение от 1 до 10, сравнивает со входным
    // параметром и возвращает результат сравнения. 7ой метод принимает
    // в кач-ве параметра имя игрока и его ставку от 1 до 10. Если значение
    // не от 1 до 10, выводит в консоль сообщение об ошибке и не
    // вызывает 8ой метод. Далее вызывает 8ой метод до тех пор, пока числа
    // не совпадут, считает количество попыток и выводит в консоль сообщение
    // вида: "Petya guessed the result on try #7" (петя угадал результат с 7ой попытки)

    public class Task
    {
        private static void Main(string[] args)
        {
            GuessNumber("Kolya", 5);
        }

        private static void GuessNumber(string name, int stake)
        {
            bool result = false;
            
            if (stake > 1 && stake < 11)
            {
                int attempt;
                
                for (attempt = 1; result == false; attempt++)
                {
                    result = CreateRandomNumber(stake);
                    
                    if (result == true)
                    {
                        break;
                    }
                }

                Console.WriteLine(name + " guessed the result on try №" + attempt);
            }
            else
            {
                Console.WriteLine("You put wrong number on stake");
            }
        }

        private static bool CreateRandomNumber(int num)
        {
            bool result = false;
            Random random = new Random();
            int randomNum = random.Next(1, 10);

            if (num == randomNum)
            {
                result = true;
            }
            else if (num > randomNum)
            {
                result = false;
            }
            else if (num < randomNum)
            {
                result = false;
            }

            return result;
        }
    }
}