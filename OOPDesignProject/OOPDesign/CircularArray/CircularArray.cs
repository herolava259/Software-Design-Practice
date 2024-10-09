

using System.Collections;

namespace OOPDesign.CircularArray;

public class CircularArray<T>
{
    private readonly int _capacity;

    private readonly T[] _array;

    private int _size;
    private int _head;

    public CircularArray(int capacity)
    {
        this._capacity = capacity;
        _head = -1;
        _array = new T[capacity];
        _size = 0;
    }


    public int Length
        => _array.Length;


    public void Add(T item)
    {
        _head = (_head + 1) % _capacity;

        _array[_head] = item;
        _size += 1;
        _size = _size > _capacity ? _capacity : _size;
    }

    
}
