using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays;
public class DynamicArray<T>
{
    private T[] _array;
    private int _count;
    private int _capacity;

    public DynamicArray()
    {
        _capacity = 4; 
        _array = new T[_capacity];
        _count = 0;
    }

    public int Count => _count;
    public int Capacity => _capacity;

    public void Add(T item)
    {
        if (_count == _capacity)
        {
            Resize(_capacity * 2);
        }
        _array[_count++] = item;
    }

    public void Insert(int index, T item)
    {
        if (index < 0 || index > _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        if (_count == _capacity)
        {
            Resize(_capacity * 2);
        }

        for (int i = _count; i > index; i--)
        {
            _array[i] = _array[i - 1];
        }

        _array[index] = item;
        _count++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        for (int i = index; i < _count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        _count--;

        if (_count <= _capacity / 4)
        {
            Resize(_capacity / 2);
        }
    }

    public T Get(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        return _array[index];
    }

    private void Resize(int newCapacity)
    {
        T[] newArray = new T[newCapacity];
        for (int i = 0; i < _count; i++)
        {
            newArray[i] = _array[i];
        }
        _array = newArray;
        _capacity = newCapacity;
    }
}
