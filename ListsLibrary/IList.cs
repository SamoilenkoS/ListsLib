using System;
using System.Collections.Generic;

namespace ListsLibrary
{
    public interface IList<T> : IEnumerable<T> where T : IComparable<T>
    {
        void Add(T element);//to end
        void AddFront(T element);
        void AddByIndex(int index, IEnumerable<T> items);
        int Count { get; }
        int Capacity { get; }
        T this[int index] { get; set; }
        IList<T> Initialize(IEnumerable<T> items);
    }
}
