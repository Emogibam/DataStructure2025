using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    public class CustomArray<T> : IEnumerable<T>
    {
        private T[] _array;
        private int _size;

        public int Length => _size;

        // Constructor to initialize the array with a specific capacity
        public CustomArray(int capacity)
        {
            _array = new T[capacity];
            _size = 0;
        }

        // Add an element to the array
        public void Add(T item)
        {
            if (_size == _array.Length)
            {
                Resize(_array.Length * 2); // Double the size of the array
            }
            _array[_size++] = item;
        }

        // Resize the internal array
        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            Array.Copy(_array, newArray, _size);
            _array = newArray;
        }

        // Get an element by index
        public T Get(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            return _array[index];
        }

        // Set an element at a specific index
        public void Set(int index, T value)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            _array[index] = value;
        }

        // Remove an element by index
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }

            for (int i = index; i < _size - 1; i++)
            {
                _array[i] = _array[i + 1];
            }
            _size--;
        }

        // Check if the array contains a specific element
        public bool Contains(T item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        // Clear the array
        public void Clear()
        {
            _size = 0;
        }

        // Print all elements in the array
        public void Print()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }

        // Implementing GetEnumerator for IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _size; i++)
            {
                yield return _array[i];
            }
        }

        // Non-generic GetEnumerator required for ICollection
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
