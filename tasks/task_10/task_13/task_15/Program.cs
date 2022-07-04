//Напишите программу, которая принимает на вход цифру обозначающая день недели, и проверяет явлется этот выходным.


namespace Task15
{
    class Program2
    {
        static void Main (string[] args )

        {

            Console.WriteLine("Введите цифру дня недели : ");
            int DayNumber = Convert.ToInt32(Console.ReadLine());
            void CheckingTheDayOfTheWeek (int DayNumber)
            {
                if (DayNumber == 6 || DayNumber == 7 ) 
                {
                    Console.WriteLine("(Этот день выходной)  ДА ");

                }
                else if (  DayNumber < 1 || DayNumber > 7)
                {
                   Console.WriteLine("Это не день недели");
 
                }
                else Console.WriteLine("Этот день не выходной Нет ");

            }

            CheckingTheDayOfTheWeek (DayNumber);



            
            

      
             
    


            }
        }
    
}