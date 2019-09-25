using System;

namespace CopyMass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Num = new Random();
            int n = 4;
            int k = 12;
            int[] mass = new int[n];
            int[] mass2 = new int[k+n];

            for ( int i = 0; i < mass.Length; i++)
            {
                mass[i] = Num.Next(30,100);
                Console.Write(mass[i]  + " ");
            }
            Console.WriteLine();
            for (int j = 0; j < mass2.Length; j++)
            {
                mass2[j] = Num.Next(1,20); ;
                Console.Write(mass2[j] + " ");
            }
            Console.WriteLine();
            Array.Copy(mass ,0, mass2,6, mass .Length);

            for (int j = 0; j < mass2.Length; j++)
            {
                Console.Write(mass2[j] + " ");
            }


        } 
        
    }
}
