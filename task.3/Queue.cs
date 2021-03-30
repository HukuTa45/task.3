namespace task3
{
    public class Queue
    {
        private readonly QueueElementCollection _queueElement;

        public Queue()
        {
            _queueElement = new QueueElementCollection();
        }

        public int Count
        {
            get => _queueElement.Count;
            private set { }
        }

        public void Enqueue(int value)
        {
            _queueElement.AddLast(value);
        }

        public int Dequeue()
        {
            return _queueElement.DeleteElement(0).Value;
        }

        public int Peek()
        {
            return _queueElement.GetElement(0).Value;
        }
    }
}