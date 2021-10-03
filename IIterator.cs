namespace IteratorPattern
{
    public interface IIterator
    {
        bool HasNext();

        string Current();

        void Next();
    }
}
