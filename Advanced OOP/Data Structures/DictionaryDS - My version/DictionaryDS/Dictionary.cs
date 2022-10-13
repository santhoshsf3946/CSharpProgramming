using System;
namespace DictionaryDS;

public partial class Dictionary<TKey, TValue>
{
    private int _count;

    private int _capacity;

    private KeyValuePair<TKey, TValue>[] Array { get; set; }

    public int Count { get{ return _count; } }

    public int Capacity { get{ return _capacity; } }


    public TValue this[TKey data]
    {
        get 
        { 
            for (int i = 0; i < _count; i++)
            {
                if (Array[i].Key.Equals(data))
                {
                    return Array[i].Value;
                }
            }
            return default(TValue);
        }
        set 
        {  
            for (int i = 0; i < _count; i++)
            {
                if (Array[i].Key.Equals(data))
                {
                    Array[i].Value = value;
                }
            }
        }
    }


    public Dictionary()
    {
        _count = 0;
        _capacity = 4;
        Array = new KeyValuePair<TKey, TValue>[_capacity];
    }

    public Dictionary(int size)
    {
        _count = 0;
        _capacity = size;
        Array = new KeyValuePair<TKey, TValue>[_capacity];
    }
}

public class KeyValuePair<TKey, TValue>
{
        
    public TKey Key { get; set; }

    public TValue Value { get; set; }

    public KeyValuePair(TKey key, TValue value) 
    {
        Key = key;
        Value = value;
    }
}
