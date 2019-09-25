using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = { '@', '-', '-', '*', '-', '+', '-', '-', '-', '-' };
            int kol=0;
            char c;
            int DogHealth = 100;
            Console.WriteLine("Начальный массив");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Start");
           
            // перемещаю собаку по массиву
            while (kol < 9)
            {
                //Console.Clear();
                Console.WriteLine("Нажми (1) чтобы сделать ход собакой");
                c = Char.Parse(Console.ReadLine());
                if (c == '1')
                {
                    if (DogHealth <= 0) { Console.WriteLine("Собака больше не может ходить!!! GAME OVER"); break; }
                    for (int i = 0; i < array.Length; i++)
                    {
                     // проверка элементов массива на бомбу и аптечку
                        array[kol] = '-';
                        if (array[kol + 1] =='*')
                           {
                            Console.WriteLine("БОМБА!!, но собака еще жива");
                            DogHealth -= 40;
                           }
                        if (array[kol + 1] == '+') 
                            {
                            Console.WriteLine("Наш Тузик востановил часть здоровья");
                            DogHealth +=40;
                            }
                        array[kol + 1] = '@';
                       // Вывод массива после изменений
                        Console.Write(array[i]); 
                      
                    }
                 }
                DogHealth -=10;
                kol++;
                Console.WriteLine($" Здоровье собаки= {DogHealth}");
           
            }
            Console.WriteLine($" Собака нагулялась:)");
        }
        
    }
}

        

