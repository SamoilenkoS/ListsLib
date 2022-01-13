using ListsLibrary;
using System;
using System.Collections.Generic;

namespace ListsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(new[] { 1, 2, 3, 4, 5 });
            array.Add(new[] { 4, 5, 6, 7, 8, 9, 10 });

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }

            //for (int i = 0; i < ; i++)
            //{
            //    array[i] = i;
            //    Console.Write($"{array[i]}\t");
            //}

            //Resize(ref array);

            //Console.WriteLine();
            //foreach (var item in array)
            //{
            //    Console.Write($"{item}\t");
            //}
        }

        private static void Resize(ref int[] array)
        {
           
        }

        private static void Add(ref int[] array, ref int count, int element)
        {
            
        }
    }
}
