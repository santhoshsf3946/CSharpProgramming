using System;

namespace ArrayListDS
{
    public partial class ArrayList
    {
        public void Add(dynamic data)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            Array[_count++] = data;
        }

        public void GrowSize()
        {
            _capacity *= 2;

            dynamic[] newArray = new dynamic[_capacity];
            
            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i] = Array[i];
            }

            Array = newArray;
        }

        public void Insert(int index, dynamic data)
        {
            if (_count == _capacity)
            {
                _capacity *= 2;
            }

            dynamic[] newArray = new dynamic[_capacity];

            int counter = 0;

            for (int i = 0; i <= _capacity; i++)
            {
                if (index == i)
                {
                    newArray[i] = data;
                }
                else
                {
                    newArray[i] = Array[counter++];
                }
            }
            counter = 0;
            Array = newArray;
            _count++;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _count - 1; i++)
            {
                Array[i] = Array[i + 1];
            }
            Array[_count - 1] = default(Object);
            _count--;
        }

        public void Remove(Object data)
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
            Array[_count - 1] = default(Object);
            _count--;
        }

        public int IndexOf(dynamic data)
        {
            for (int i = 0; i < _count; i++)
            {
                if (Array[i].Equals(data))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
