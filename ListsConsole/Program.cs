using ListsLibrary;
using System;
using System.Collections.Generic;

namespace ListsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ListsLibrary.IList<int> list1
                = new ListsLibrary.LinkedList<int>();

            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("1", "Hello");
            pairs.Add("2", "World!");
            pairs.Add("10", "Blabla");

            Console.WriteLine(pairs["10"]);
            foreach (var item in pairs)
            {
                Console.WriteLine(item);
            }

            ListsLibrary.LinkedList<int> list =
                new ListsLibrary.LinkedList<int>();
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
