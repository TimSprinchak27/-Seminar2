//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

namespace Task19
{
    class Program
    {
         static void Main (string[] args ) 

        {

            Console.WriteLine("Введите пятизначное число: ");
            string? number = Console.ReadLine();

            
            if (number [0] == number [3] || number [1] == number [4])
            {
                Console.WriteLine($"Число: {number} - является палиндромом ");
            }

             else Console.WriteLine($"Число: {number} - не является палиндромом ");

            if (number.Length == 5);
            
             else  Console.WriteLine("Введите корректное число");
            
              
             


            }
        }
    
}



