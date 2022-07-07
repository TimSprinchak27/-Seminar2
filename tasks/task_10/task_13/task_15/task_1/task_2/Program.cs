//Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причем X=0 и Y=0
// и выдает номер четверти плоскости в котрой находится эта плоскость 
// Задача 2. Напишите программу , которая по заданному номеру четверти, 
// показывает диапозон возможных координат точек . (задача 2)


namespace задача2
{
    class Program4
    {
            public static void Main (string[] args) 

        

            //Минимальное значение для типа данных int
            
            //int num = int.MinValue;
            
            //Максимальное значение для типа данных int

            //int num2 = int.MaxValue;
            
        {  
            try
            {
               int min = int.MinValue;
               int max = int.MaxValue; 

               Console.WriteLine("Введите номер четверти ");
               int num = Convert.ToInt32(Console.ReadLine ());  
                if (num == 1)
                {
                    Console.WriteLine($"Диапозон 1 четверти 0 < X < {max} и 0 < Y < {max}");

                }

                else if (num == 2) 
                {
                   Console.WriteLine($"Диапозон 2 четверти 0 < X < {min} и 0 < Y < {max}"); 
                }

                else if (num == 3) 
                {
                   Console.WriteLine($"Диапозон 3 четверти 0 < X < {min} и 0 < Y < {min}"); 
        
                }
                else if (num == 4) 
                {
                   Console.WriteLine($"Диапозон 3 четверти 0 < X < {max} и 0 < Y < {min}"); 
        
                }

                else
                {
                    Console.WriteLine("Диапозона не существует  ");
                }
            





            
              Console.ReadKey();
            }
            catch
            {
                   Console.WriteLine($"Введите нужное значение"); 

            }


            
    


            
        }
    }
}
