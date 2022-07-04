//Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа.
// 456-->5
// 782-->8
// 918-->1

namespace Task10
{
    class Program
    {
        static void Main (string[] args )

        {

            Console.WriteLine("Введите трехзначное число : ");
            int ТрехзначноеЧисло = Convert.ToInt32(Console.ReadLine());
            string stringNumber = Convert.ToString(ТрехзначноеЧисло);
            
            Console.WriteLine("Результат " + stringNumber [1]);

            
             
            




            }
        }
    
}

