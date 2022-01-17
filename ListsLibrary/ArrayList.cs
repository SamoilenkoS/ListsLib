using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ListsLibrary
{
    public class ArrayList<T>
        : IList<T>,
            IEquatable<IList<T>> where T : IComparable<T>
    {
        private const int DefaultSize = 4;
        private const double Increment = 1.33;
        private int _currentCount;
        private T[] _array;

        private int DefaultNewSize => (int)(_array.Length * Increment);
        public int Count => _currentCount;
        public int Capacity => _array.Length;

        public T this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public ArrayList()
        {
            _array = new T[DefaultSize];
        }

        public ArrayList(int capacity)
        {
            _array = new T[capacity];
        }

        public ArrayList(T[] array)
        {
            _array = new T[(int)(array.Length * Increment)];
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }

            _currentCount = array.Length;
        }

        public void Add(T element)
        {
            if (Count == Capacity)
            {
                Resize(DefaultNewSize);
            }

            _array[_currentCount++] = element;
        }

        //public void Add(IList<T> array)
        //{
        //    var newSize = Count + array.Count;
        //    if (newSize >= Capacity)
        //    {
        //        Resize(newSize);
        //    }

        //    for (int i = Count, j = 0; i < newSize; i++, j++)
        //    {
        //        _array[i] = array[j];
        //    }

        //    _currentCount = newSize;
        //}

        public void AddFront(T element)
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
            T[] arrayNew = new T[newSize];
            for (int i = 0; i < _array.Length; i++)
            {
                arrayNew[i] = _array[i];
            }

            _array = arrayNew;
        }

        public IEnumerator<T> GetEnumerator()
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

        public override bool Equals(object obj)
        {
            return Equals(obj as IList);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals([AllowNull] IList<T> list)
        {
            bool result = true;
            if (list != null && list.Count == Count)
            {
                for (int i = 0; i < Count; ++i)
                {
                    if (this[i].CompareTo(list[i]) != 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
