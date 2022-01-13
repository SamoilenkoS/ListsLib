using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListsLibrary
{
    public class ArrayList : IEnumerable<int>
    {
        private const int DefaultSize = 4;
        private const double Increment = 1.33;
        private int _currentCount;
        private int[] _array;

        private int DefaultNewSize => (int)(_array.Length * Increment);
        public int Count => _currentCount;
        public int Capacity => _array.Length;


        public ArrayList()
        {
            _array = new int[DefaultSize];
        }

        public ArrayList(int capacity)
        {
            _array = new int[capacity];
        }

        public ArrayList(int[] array)
        {
            _array = new int[(int)(array.Length * Increment)];
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }

            _currentCount = array.Length;
        }

        public void Add(int element)
        {
            if (Count == Capacity)
            {
                Resize(DefaultNewSize);
            }

            _array[_currentCount++] = element;
        }

        public void Add(int[] array)
        {
            var newSize = Count + array.Length;
            if (newSize >= Capacity)
            {
                Resize(newSize);
            }

            for (int i = Count, j = 0; i < newSize; i++, j++)
            {
                _array[i] = array[j];
            }

            _currentCount = newSize;
        }

        public void AddFront(int element)
        {
            if (Count == Capacity)
            {
                Resize(DefaultNewSize);
            }

            for (int i = Count - 1; i >= 0; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[0] = element;
            ++_currentCount;
        }

        private void Resize(int newSize)
        {
            int[] arrayNew = new int[newSize];
            for (int i = 0; i < _array.Length; i++)
            {
                arrayNew[i] = _array[i];
            }

            _array = arrayNew;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
