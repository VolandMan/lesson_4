using System;

namespace Month
{
    class Program
    {
        static void Main(string[] args)
        {
         string[] Month = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
           string[] NumDay = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" }; 
            //int KolDay = 0;
            int j;
            string UserIn;
               
            Console.WriteLine("Введите название месяца");
            UserIn = Console.ReadLine();

            for (int i = 0; i < Month.Length; i++)
            {
               
                if (UserIn == Month[i])

                    {
                    Month[i] = NumDay[i];
                    
                    if (Convert.ToInt32(NumDay[i]) % 2 == 0)
                    {
                        Console.WriteLine($"Количество дней 30");
                    }else 
                        Console.WriteLine($"Количество дней 31");
                }

            }
        }

        
    }
}
