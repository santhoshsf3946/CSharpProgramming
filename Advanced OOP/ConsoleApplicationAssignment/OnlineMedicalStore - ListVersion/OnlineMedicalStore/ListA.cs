using System;

namespace OnlineMedicalStore
{
    public partial class List<Type>
    {
        // Creating a function that appends an element at the end of the array
        public void Add(Type data)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            Array[_count] = data;
            _count++;
        }

        public void Insert(int index, Type data)
        {
            int newCount = _count;
            if (_count >= _capacity)
            {
                _capacity = _capacity * 2;
            }
            Type[] newArray = new Type[_capacity];

            int counter = 0;

            for (int i = 0; i <= newCount; i++)
            {
                if (index == i)
                {
                    newArray[i] = data;
                    _count++;
                }
                else
                {
                    newArray[i] = Array[counter];
                    counter++;
                }
            }
            counter = 0;
            Array = newArray;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _count - 1; i++)
            {
                Array[i] = Array[i + 1];
            }
            Array[_count - 1] = default(Type);
            _count--;
        }

        public void Remove(Type data)
        {
            bool value = false;
            for (int i = 0; i < _count - 1; i++)
            {
                if (Array[i].Equals(data))
                {
                    value = true;
                }
                if (value)
                {
                     Array[i] = Array[i + 1];
                }
            }
            Array[_count - 1] = default(Type);
            _count--;
        }
    }
}
