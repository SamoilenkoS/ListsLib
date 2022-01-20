using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListsLibrary
{
    public class LinkedList<T> : IList<T> where T : IComparable<T>
    {
        private Node<T> _root;
        private int _count;

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return GetNode(index).Value;
            }
            set
            {
                if (index < 0 || index > Count)
                {
                    throw new IndexOutOfRangeException();
                }

                GetNode(index).Value = value;
            }
        }

        public int Count => _count;

        public int Capacity => _count;

        public LinkedList()
        {
        }

        public LinkedList(T element)
        {
            Add(element);
        }

        public LinkedList(IEnumerable<T> elements)
        {
            foreach (var item in elements)
            {
                Add(item);
            }
        }

        public void Reverse()
        {
            LinkedList<T> temp = new LinkedList<T>();
            while(_root != null)
            {
                temp.AddFront(_root.Value);
                _root = _root.Next;
            }

            _root = temp._root;
        }

        public void Sort(bool ascending = true)
        {
            Node<T> left = GetNode(0);
            for (int i = 0; i < Count - 1; i++)
            {
                Node<T> right = GetNode(i + 1);
                for (int j = i + 1; j < Count; j++)
                {
                    if(left.Value.CompareTo(right.Value) == 1)
                    {
                        SwapValues(ref left, ref right);
                    }

                    right = right.Next;
                }

                left = left.Next;
            }
        }

        private void SwapValues(ref Node<T> a, ref Node<T> b)
        {
            T temp = a.Value;
            a.Value = b.Value;
            b.Value = temp;
        }

        public void Add(T element)
        {
            if(_root != null)
            {
                GetNode(Count - 1)
                    .Next = new Node<T>
                    {
                        Value = element
                    };
            }
            else
            {
                _root = new Node<T> { Value = element };
            }

            ++_count;
        }

        public void AddFront(T element)
        {
            if(_root != null)
            {
                Node<T> newRoot = new Node<T>
                {
                    Value = element,
                    Next = _root
                };

                _root = newRoot;
            }
            else
            {
                _root = new Node<T> { Value = element };
            }

            ++_count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> temp = _root;
            for (int i = 0; i < Count; i++)
            {
                yield return temp.Value;
                temp = temp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private Node<T> GetNode(int index)
        {
            Node<T> temp = _root;
            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }

            return temp;
        }

        public IList<T> CreateInstance(IEnumerable<T> items)
        {
            return new LinkedList<T>(items);
        }

        //public T[] ToArray()
        //{
        //    T[] result = new T[Count];
        //    Node<T> temp = _root;
        //    int i = 0;
        //    while(temp != null)
        //    {
        //        result[i++] = temp.Value;
        //        temp = temp.Next;
        //    }

        //    return result;
        //}
    }
}
