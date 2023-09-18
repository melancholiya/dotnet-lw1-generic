namespace LW1.MyCollection
{
    /// <summary>
    /// Represents a node in the deque.node 
    /// </summary>
    /// <typeparam name="T">Type of deque</typeparam>
    public class MyDequeNode<T>
    {
        public T Value { get; internal set; }
        public MyDequeNode<T> Previous { get; internal set; }
        public MyDequeNode<T> Next { get; internal set; }
        public MyDequeNode(T value)
        {
            Value = value;
        }

    }

}