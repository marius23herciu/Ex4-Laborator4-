using System;

namespace Ex4_Laborator4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 4
            //Scrieti o functie recursiva care va afisa in ordine elementele unui vector de
            //intregi
            int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = 0;
            AfisareVector(vector, n);
        }
        static void AfisareVector(int[] vector, int n)
        {
            if (n >= vector.Length)
            {
                return;
            }
            Console.Write(vector[n] + " ");
            AfisareVector(vector, n + 1);
        }
    }
}
