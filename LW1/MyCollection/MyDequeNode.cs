namespace LW1.MyCollection
{
    /// <summary>
    /// Element of deque
    /// </summary>
    /// <typeparam name="T">Type of deque</typeparam>
    public class MyDequeNode<T>
    {
        public MyDequeNode(T value)
        {
            Value = value;
        }

        public T Value { get; internal set; }
        public MyDequeNode<T> Previous { get; internal set; }
        public MyDequeNode<T> Next { get; internal set; }
    }

}