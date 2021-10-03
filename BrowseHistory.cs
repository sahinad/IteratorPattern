namespace IteratorPattern
{
    public class BrowseHistory
    {
        private readonly string[] urls = new string[10];
        private int count;

        public void Push(string url)
        {
            urls[count++] = url;
        }

        public string Pop()
        {
            return urls[--count];
        }

        public IIterator CreateIterator()
        {
            return new ArrayIterator(this);
        }

        public class ArrayIterator : IIterator
        {
            private readonly BrowseHistory history;
            private int index;

            public ArrayIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public string Current()
            {
                return history.urls[index];
            }

            public bool HasNext()
            {
                return index < history.count;
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
