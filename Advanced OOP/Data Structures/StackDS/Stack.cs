using System;

namespace StackDS
{
    public partial class Stack<Type>
    {
        private int _count;

        private int _capacity;

        private Type[] Array { get; set; }

        public int Count { get { return _count; } }

        public Stack()
        {
            _count = 0;
            _capacity = 4;
            Array = new Type[_capacity];
        }

        public Stack(int size)
        {
            _count = 0;
            _capacity = size;
            Array = new Type[_capacity];
        }
    }
}
