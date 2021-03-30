using System;

namespace task3
{
    public class QueueElement
    {
        public int Value { get; set; }
        public QueueElement Next { get; set; }
        public QueueElement Previous { get; set; }
    }

    public class QueueElementCollection
    {
        private QueueElement _first;
        private QueueElement _last;

        public QueueElementCollection()
        {
            Count = 0;
        }

        public int Count { get; private set; }

        public QueueElement GetElement(int index)
        {
            if (index > Count)
                throw new IndexOutOfRangeException();
            
            return _first;

        }

        public void AddLast(int value)
        {
            if (Count == 0)
            {
                AddFirst(value);
                return;
            }

            var newEnd = new QueueElement
            {
                Next = null,
                Previous = _last,
                Value = value
            };

            _last.Next = newEnd;
            _last = newEnd;

            Count++;
        }

        public void AddFirst(int value)
        {
            _first = new QueueElement
            {
                Value = value,
                Next = null,
                Previous = null
            };
            _last = _first;

            Count++;
        }

        public QueueElement DeleteElement(int index)
        {
            var element = GetElement(index);
            
            _first = _first.Next;
            Count--;

            return element;
        }
    }
}