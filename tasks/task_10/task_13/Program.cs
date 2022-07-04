//Напишите программу, которая выводит третью цифру заданного числа, или сообщает что третьей цифры нет.
// 456-->5
// 782-->8
// 918-->1

namespace Task10
{
    class Program1
    {
        static void Main (string[] args )

        {

            Console.WriteLine("Введите число : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            string NumberТext = Convert.ToString(Number);
            if (NumberТext.Length > 2)
            {
                Console.WriteLine("Результат " + NumberТext [2]);
            }
            else
            {
                Console.WriteLine("Третья цифра отсутствует ");
            }

      
             
    


            }
        }
    
}
