using System;

namespace task._3
{
    public class Stack
    {
        private Element _last;

        
        public Stack()
        {
            Count = 0;
            MaxCount = 3;
        }
        public int MaxCount { get; set; }
        public int Count { get; private set; }

        public Element Peek()
        {
            if (_last == null)
                throw new NullReferenceException();

            return _last;
        }

        public void Push(int value)
        {
            if (Count == 0)
            {
                AddFirst(value);
                return;
            }

            var newEnd = new Element
            {
                Next = _last,
                
                Value = value
            };


            _last = newEnd;

            Count++;
            
            
        }

        public void AddFirst(int value)
        {
            _last = new Element
            {
                Value = value,
                Next = null,
                
            };

            Count++;
        }

        public Element Pop()
        {
            var element = _last;

            _last = _last.Next;
            Count--;

            return element;
        }
    }
}