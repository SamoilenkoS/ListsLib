using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListsLibrary
{
    public class LinkedList<T> : IList<T> where T : IComparable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
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

        public LinkedList(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public void Add(T element)
        {
            if(_head != null)
            {
                _tail.Next = new Node<T> { Value = element };
                _tail = _tail.Next;
            }
            else
            {
                _head = new Node<T> { Value = element };
                _tail = _head;
            }

            ++_count;
        }

        public void AddFront(T element)
        {
            if(_head != null)
            {
                Node<T> newRoot = new Node<T>
                {
                    Value = element,
                    Next = _head
                };

                _head = newRoot;
            }
            else
            {
                _head = new Node<T> { Value = element };
            }

            ++_count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> temp = _head;
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

        public void AddByIndex(int index, IEnumerable<T> items)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentException();
            }

            if(items.Count() == 0)
            {
                return;
            }

            //Comment just for students: memory from listToInsert will be used in this list and there
            //isn't additional memory usage here
            LinkedList<T> listToInsert = Initialize(items) as LinkedList<T>;
            if(index > 0)
            {
                InsertLinkedListToBody(index, listToInsert);
            }
            else
            {
                InsertLinkedListToHead(listToInsert);
            }

            _count += listToInsert.Count;
         }

        private void InsertLinkedListToHead(LinkedList<T> listToInsert)
        {
            Node<T> tempNext = _head;
            _head = listToInsert._head;
            listToInsert._tail.Next = tempNext;
        }

        private void InsertLinkedListToBody(int index, LinkedList<T> listToInsert)
        {
            Node<T> nodeToStartInsertion = GetNode(index - 1);
            Node<T> tempNext = nodeToStartInsertion.Next;
            nodeToStartInsertion.Next = listToInsert._head;
            listToInsert._tail.Next = tempNext;
        }

        public IList<T> Initialize(IEnumerable<T> items)
        {
            return new LinkedList<T>(items);
        }

        private Node<T> GetNode(int index)
        {
            Node<T> temp = _head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }

            return temp;
        }
    }
}
