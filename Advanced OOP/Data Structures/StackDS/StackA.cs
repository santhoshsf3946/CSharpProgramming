using System;

namespace StackDS
{
    public partial class Stack<Type>
    {
        public void Push(Type data)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            Array[_count] = data;
            _count++;
        }

        public Type Pop()
        {
            Type value = default(Type);
            if (_count < 0)
            {
                Console.WriteLine("Empty Stack");
            }
            else
            {
                value = Array[_count - 1];
                _count--;
            }
            return value;
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

        public bool Contains(Type data)
        {
            bool value = false;

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i].Equals(data))
                {
                    value = true;
                }
            }

            return value;
        }

        public Type Peak()
        {
            Type value = default(Type);

            if (_count < 0)
            {
                Console.WriteLine("Empty Stack");
            }

            else
            {
                value = Array[_count - 1];
            }

            return value;
        }

        public void Clear()
        {
            _count = 0;
            _capacity = 4;
            Array = new Type[_capacity];
        }
    }
}
