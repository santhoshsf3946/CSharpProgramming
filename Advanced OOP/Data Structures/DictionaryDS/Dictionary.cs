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
            int index = 0;
            bool found =  LinearSearch(data, out index);

            if (found)
            {
                return Array[i].Value;
            }
            else
            {
                Console.WriteLine("\nInvalid Key");
            }
            return default(TValue);
        }
        set 
        {  
            int index = 0;
            bool found =  LinearSearch(data, out index);
            
            if (found)
            {
                Array[index].Value = value;
            }
            else
            {
                Console.WriteLine("\nInvalid Key");
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
        if (size == 0)
        {
            _capacity = 3;
        }
        else
        {
            _capacity = size;
        }
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
