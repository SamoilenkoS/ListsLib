using ListsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            School s = School.Instance;
            School q = School.Instance;
            Student t = Student.Initialize("sad", "das", DateTime.Now.Subtract(TimeSpan.FromSeconds(1)));
            WeatherGenerator weatherObserver = new WeatherGenerator();
            using (weatherObserver.Subscribe(new WeatherObserver()))
            {
                weatherObserver.SimulateWeather();
            }
            //Entity entity = new Entity
            //{
            //    Id = Guid.NewGuid(),
            //    State = "New",
            //    CreationDate = DateTime.Now
            //};
            //Console.WriteLine($"{entity.Id}\t{entity.State}\t{entity.CreationDate}");

            //Entity another = entity.Clone() as Entity;
            //Console.WriteLine($"{another.Id}\t{another.State}\t{another.CreationDate}");

            //HashSet<int> elements = new HashSet<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    elements.Add(i);
            //}

            //elements.Add(5);
            //foreach (var el in elements)
            //{
            //    Console.WriteLine(el);
            //}


            //var result = students.Contains(new Student
            //    { FirstName = "Vasya", LastName = "Ivanovich" },
            //    new StudentSurnameEqualityComparer());
            //Console.WriteLine(result);
            //ChildForInterface obj1 = new ChildForInterface();
            //obj1.T();

            //IInterfaceA obj2 = new ChildForInterface();
            //obj2.T();

            IInterfaceB obj3 = new ChildForInterface();
            obj3.T();

            //    ListsLibrary.IList<int> list1
            //        = new ListsLibrary.LinkedList<int>();
            //    List<int> items = new List<int>();

            //    Dictionary<string, string> pairs = new Dictionary<string, string>();
            //    pairs.Add("1", "Hello");
            //    pairs.Add("2", "World!");
            //    pairs.Add("10", "Blabla");

            //    Console.WriteLine(pairs["10"]);
            //    foreach (var item in pairs)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    ListsLibrary.LinkedList<int> list =
            //        new ListsLibrary.LinkedList<int>();
            //    for (int i = 0; i < 10; i++)
            //    {
            //        list.AddFront(i);
            //    }

            //    foreach (var item in list)
            //    {
            //        Console.Write($"{item}\t");
            //    }
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
