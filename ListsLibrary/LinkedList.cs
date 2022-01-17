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
            throw new NotImplementedException();
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
    }
}
