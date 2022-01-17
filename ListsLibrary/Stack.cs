using System;

namespace ListsLibrary
{
    public class Stack
    {
        private LinkedList<int> _list;

        public void Push(int element)
        {
            _list.AddFront(element);
        }

        public int Pop()
        {
            return _list[0];
        }

        public int Peek()
        {
            return 0;
            //return _list.RemoveFront();
        }
    }
}
