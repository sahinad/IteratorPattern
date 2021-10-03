using System;

namespace IteratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var history = new BrowseHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            var iterator = history.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }

            Console.WriteLine(history.Pop());
        }
    }
}
