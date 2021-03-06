using System;
using System.Collections.Generic;
using System.Text;

namespace ListsLibrary
{
    public class Node<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
