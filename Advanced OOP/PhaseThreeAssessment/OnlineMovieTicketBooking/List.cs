using System;

namespace OnlineMovieTicketBooking
{
    public partial class List<Type>
    {
        private int _count;

        private int _capacity;

        public int Count { get { return _count; } }
        
        public int Capacity { get { return _capacity; } }
        
        private Type[] Array { get; set; }
        
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

        public Type this[int i]
        {
            get { return Array[i]; }
            set { Array[i] = value; }
        }

        public void Add(Type item)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            Array[_count] = item;
            _count++;
        }

        public void GrowSize()
        {
            _capacity *= 2;

            Type[] newArray = new Type[_capacity];

            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i] = Array[i];
            }

            Array = newArray;
        }
    }
}
