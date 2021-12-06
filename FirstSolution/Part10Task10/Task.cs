using System;

namespace Part10Task10
{   
    
    // Преобразовать 7ой метод, чтобы он не только выводил в консоль сообщение,
    // но и возвращал номер попытки, на которой ставка сработала. Написать
    // 9ый метод, который взаимодействует с 7ым и 8ым. Метод принимает неограниченное
    // количество строковых параметров, каждая строка в формате "Vasya - 3"
    // (где Vasya - имя, 3 - ставка) Далее для каждого игрока поочередно вызывается
    // 7ой метод. В итоге нужно вывести имя игрока, который победил
    // (угадал число с наименьшего кол-ва попыток), и номер его попытки,
    // например "Vasya wins with beste result 3" (где 3 - это номер попытки)
    // Итоговое сообщение в консоли должно выглядить примерно так:
    // Vasya guessed the result on try #4 Kolya guessed the result on try #6
    // Petya guessed the result on try #1 Petya wins with best result 1
    
    public class Task
    {
       private static void Main(string[] args)
       {
           GuessWinner("Vasya - 0", "Kolya - 6", "Alex - 2", "John - 11");
       }
        
       private static int GuessNumber(string name, int stake)
       {    
           int attempt = 0;
           bool result = false;
           
           if (stake > 1 && stake < 11)
           {
               for (attempt = 1; result == false; attempt++)
               {
                   result = CreateRandomNumber(stake);
                   if (result == true)
                   {
                       break;
                   }
               }
               
               Console.WriteLine(name + " guessed the result on try №" + attempt);
               return attempt;
           }
           
           return 0;
       }

       private static bool CreateRandomNumber(int num)
       {
           bool result = false;
           Random random = new();
           int randomNum = random.Next(1, 10);
            
           if (num == randomNum)
           {
               result = true;
           }
           
           return result;
       }

       private static void GuessWinner(params string[] names)
       {
           int[] arrayOfAttemptsNum = new int[names.Length];
           string name = names[0];

           for (int i = 0; i < names.Length; i++)
           {
               string[] nameAndStake = names[i].Split(" - ");
               nameAndStake[0] = nameAndStake[0].Trim();
               name = nameAndStake[0];
               int stake = Convert.ToInt32(nameAndStake[1].Trim());
               
               if (stake >= 1 & stake <= 10)
               {
                   arrayOfAttemptsNum[i] = GuessNumber(name, stake);
               }
               else
               {   
                   Console.WriteLine("Someone put wrong number on the stake");
               }
           }
           
           int minAttempts = arrayOfAttemptsNum[0];
           int indexOfName = 0;

           for (int i = 1; i < arrayOfAttemptsNum.Length; i++)
           {
               if (minAttempts == 0 & arrayOfAttemptsNum[i] >= 1 & arrayOfAttemptsNum[i] <= 10)
               {
                   minAttempts = arrayOfAttemptsNum[i];
                   indexOfName = i;
               }

               if (minAttempts > arrayOfAttemptsNum[i] & arrayOfAttemptsNum[i] <= 10 &
                   arrayOfAttemptsNum[i] >= 1)
               {
                   minAttempts = arrayOfAttemptsNum[i];
                   indexOfName = i;
               }
           }

           for (int i = 0; i < names.Length; i++)
           {
               string[] nameAndStake = names[i].Split(" - ");
               nameAndStake[0] = nameAndStake[0].Trim();
               
               if (indexOfName == i)
               {
                   name = nameAndStake[0];
               }
           }
           
           Console.WriteLine("{0} wins with best result {1}", name, minAttempts);
       }
    }
}