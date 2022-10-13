using System;
namespace DictionaryDS;

public partial class Dictionary<TKey, TValue>
{
    public void Add(TKey key, TValue value)
    {
        if (_capacity == _count)
        {
            GrowSize();
        }
        Array[_count] = new KeyValuePair<TKey, TValue>(key, value);
        _count++;
    }

    public void GrowSize()
    {
        _capacity *= 2;
        KeyValuePair<TKey, TValue>[] newArray = new KeyValuePair<TKey, TValue>[_capacity];

        for (int i = 0; i < _count; i++)
        {
            newArray[i] = Array[i];
        }

        Array = newArray;
    }

    public bool ContainsKey(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (Array[i].Key.Equals(key))
            {
                return true;
            }
        }
        return false;
    }

    public bool ContainsValue(TKey value)
    {
        for (int i = 0; i < _count; i++)
        {
            if (Array[i].Value.Equals(value))
            {
                return true;
            }
        }
        return false;
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        for (int i = 0; i < _count; i++)
        {
            if (Array[i].Key.Equals(key))
            {
                value = Array[i].Value;
                return true;
            }
        }
        value = default(TValue);
        return false;
    }

    public bool Remove(TKey key)
    {
        bool found = false;
        for (int i = 0; i < _count - 1; i++)
        {
            if (Array[i].Key.Equals(key))
            {
                found = true;
            }
            if (found)
            {
                Array[i] = Array[i + 1];
            }
        }
        if (found)
        {
            Array[_count - 1] = default(KeyValuePair<TKey, TValue>);
            _count--;
            return true;   
        }
        return false;
    }

    public void Clear()
    {
        _count = 0;
        _capacity = 4;
        Array = new KeyValuePair<TKey, TValue>[_capacity];
    }
}
