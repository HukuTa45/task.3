using System;

namespace task3
{
    public class Element
    {
        public int Value { get; set; }
        public Element Next { get; set; }
        public Element Previous { get; set; }
    }

    public class ElementCollection
    {
        private Element _first;
        private Element _last;

        public ElementCollection()
        {
            Count = 0;
        }

        public int Count { get; private set; }

        public Element GetElement(int index)
        {
            if (index > Count)
                throw new IndexOutOfRangeException();

            var current = _first;
            for (var i = 1; i < index; i++) current = current.Next;

            return current;
        }

        public void AddLast(int value)
        {
            if (Count == 0)
            {
                AddFirst(value);
                return;
            }

            var newEnd = new Element
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
            _first = new Element
            {
                Value = value,
                Next = null,
                Previous = null
            };
            _last = _first;

            Count++;
        }

        public Element DeleteElement(int index)
        {
            var element = GetElement(index);
            if (element == null)
                throw new IndexOutOfRangeException();

            if (element.Previous != null)
                element.Previous.Next = element.Next;
            else
                _first = element.Next;

            if (element.Next != null)
                element.Next.Previous = element.Previous;
            else
                _last = element.Previous;
            element.Next = null;
            element.Previous = null;
            Count--;

            return element;
        }
    }
}