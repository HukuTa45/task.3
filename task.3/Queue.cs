using System;


namespace task._3
{
    public class Queue
    {
        private Element _first;
        private Element _last;

        public Queue()
        {
            Count = 0;
        }

        public int Count { get; private set; }

        public Element Peek()
        {
            if (_first == null)
                throw new NullReferenceException();
            
            return _first;

        }

        public void Enqueue(int value)
        {
            if (Count == 0)
            {
                AddFirst(value);
                return;
            }

            var newEnd = new Element
            {
                Next = null,
                
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
               
            };
            _last = _first;

            Count++;
        }

        public Element Dequeue()
        {
            var element = _first;
            
            _first = _first.Next;
            Count--;

            return element;
        }
    }
}