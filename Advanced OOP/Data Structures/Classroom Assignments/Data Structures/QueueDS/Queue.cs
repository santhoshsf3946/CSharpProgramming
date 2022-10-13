using System;

namespace QueueDS
{
    public partial class Queue<Type>
    {
        private int _count;

        private int _head;

        private int _tail;

        private int _capacity;

        public Type[] Array { get; set; }

        public int Count { get { return _count; } }


        public Queue()
        {
            _count = 0;
            _head = 0;
            _tail = 0;
            _capacity = 4;
            Array = new Type[_capacity];
        }

        public Queue(int size)
        {
            _count = 0;
            _head = 0;
            _tail = 0;
            _capacity = size;
            Array = new Type[_capacity];
        }

        public void Enqueue(Type data)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }

            Array[_tail] = data;
            _tail++;
            _count++;
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

        public Type Dequeue()
        {
            Type value = default(Type);

            if (_head > _tail)
            {
                Console.WriteLine("Queue Empty");
            }
            else
            {
                value = Array[_head];
                _head++;
                _count--;
            }

            return value;
        }

        public Type Peak()
        {
            Type value = default(Type);

            if (_head > _tail)
            {
                Console.WriteLine("Queue Empty");
            }
            else
            {
                value = Array[_head];
            }

            return value;
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
    }
}
