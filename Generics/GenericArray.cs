namespace Generics;

public class GenericArray<T> //where T : class T can only be class
{
    private T[] _array;
    private int _size;

    public GenericArray(int size)
    {
        _size = size;
        _array = new T[size];
    }

    public void AddElement(int index, T element)
    {
        if (index < _size)
        {
            _array[index] = element;
        }
    }

    public T ElementAtIndex(int index)
    {
        if (index >= _size)
        {
            throw new IndexOutOfRangeException($"index is greater than {_size}");
        }

        return _array[index];
    }
}