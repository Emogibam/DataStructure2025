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

    /// <summary>
    /// adding Item to Array
    /// </summary>
    /// <param name="item"></param>
    public void Add(T item)
    {
        if (_count == _capacity)
        {
            Resize(_capacity * 2);
        }
        _array[_count++] = item;
    }

    /// <summary>
    /// Insert an Item in an Array
    /// </summary>
    /// <param name="index"></param>
    /// <param name="item"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
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

    /// <summary>
    /// Removing Item at the Index
    /// </summary>
    /// <param name="index"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
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

    /// <summary>
    /// Getting an Item at an Index
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public T Get(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        return _array[index];
    }

    /// <summary>
    /// Resizing the array to meet Items added
    /// </summary>
    /// <param name="newCapacity"></param>
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
