using System;
namespace OnlineMedicalStore;

public partial class List<Type>
{
    private Type[] Array { get; set; }

    private int _count;

    private int _capacity;

    public int Count { get{ return _count; } }

    public int Capacity { get{ return _capacity; } }

    public Type this[int i]  // Indexer
    {
        get { return Array[i]; }
        set { Array[i] = value; }
    }

    // creating constructor of the class that initializes values
    public List()
    {
        _count = 0;
        _capacity = 4;
        Array = new Type[_capacity];
    }

    public List(int size)
    {
        _count = 0;
        _capacity = size;
        Array = new Type[_capacity];
    }

    public void GrowSize()
    {
        _capacity = _capacity * 2;

        Type[] newArray = new Type[_capacity];

        for (int i = 0; i < Array.Length; i++)
        {
            newArray[i] = Array[i];
        }

        Array = newArray;
    }
}
