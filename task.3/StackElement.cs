using System;

namespace task._3
{
    public class StackElement
    {
        public int Value { get; set; }
        public StackElement Next { get; set; }
        public StackElement Previous { get; set; }
    }

    public class StackElementCollection
    {
        private StackElement _last;

        public StackElementCollection()
        {
            Count = 0;
        }

        public int Count { get; private set; }

        public StackElement GetElement(int index)
        {
            if (index > Count)
                throw new IndexOutOfRangeException();

            return _last;
        }

        public void AddLast(int value)
        {
            if (Count == 0)
            {
                AddFirst(value);
                return;
            }

            var newEnd = new StackElement
            {
                Next = null,
                Previous = _last,
                Value = value
            };


            _last = newEnd;
            _last.Next = _last.Previous;

            Count++;
        }

        public void AddFirst(int value)
        {
            _last = new StackElement
            {
                Value = value,
                Next = null,
                Previous = null
            };

            Count++;
        }

        public StackElement DeleteElement(int index)
        {
            var element = GetElement(index);

            _last = _last.Next;
            Count--;

            return element;
        }
    }
}