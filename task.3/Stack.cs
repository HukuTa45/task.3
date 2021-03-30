using task._3;

namespace task3
{
    public class Stack
    {
        private readonly StackElementCollection _stackElement;

        public Stack()
        {
            _stackElement = new StackElementCollection();
        }

        public int Count
        {
            get => _stackElement.Count;
            private set { }
        }

        public void Push(int value)
        {
            _stackElement.AddLast(value);
        }

        public int Pop()
        {
            return _stackElement.DeleteElement(Count).Value;
        }

        public int Peek()
        {
            return _stackElement.GetElement(Count).Value;
        }
    }
}