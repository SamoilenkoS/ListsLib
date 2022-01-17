using ListsLibrary;
using System;

namespace ListsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list =
                new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.AddFront(i);
            }

            foreach (var item in list)
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
