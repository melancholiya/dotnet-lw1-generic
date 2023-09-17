using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LW1.MyCollection;

public class DoubleEndedQueue<T>:IEnumerable<T>
{
    private MyDequeNode<T> _head;

    private MyDequeNode<T> _tail;
    
    /// <summary>
    /// Gets the number of elements contained in the deque
    /// </summary>
    public int Count { get; private set; }
    /// <summary>
    /// Gets a value indicating whether the deque is read-only
    /// </summary>
    public bool IsReadOnly => false;
/// <summary>
/// Adds an item to the front of the deque
/// </summary>
    public void AddFirst(T item)
    {
        MyDequeNode<T> newNode = new MyDequeNode<T>(item);
        if (Count == 0)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
        }

        Count++;
    }
/// <summary>
/// Adds an item to the end of the deque
/// </summary>
    public void AddLast(T item)
    {
        MyDequeNode<T> newNode = new MyDequeNode<T>(item);
        if (Count == 0)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Previous = _tail;
            _tail.Next = newNode;
            _tail = newNode;
        }

        Count++;
    }
/// <summary>
///  Removes and returns the item at the end of the deque
/// </summary>
/// <returns></returns>
public T RemoveFirst()
{
    if (Count == 0)
    {
        throw new InvalidOperationException("Deque is empty.");
    }

    T item = _head.Value;
    if (Count == 1)
    {
        _head = null;
        _tail = null;
    }
    else
    {
        _head=_head.Next;
        _head.Previous = null;
    }

    Count--;
    return item;
}

        private class MyEnumarator : IEnumerator<T>
        {
            private readonly DoubleEndedQueue<T> _doubleEndedQueue;
            private MyDequeNode<T> _node;
            private int _index;
            private T _currentElement;
            public T Current => _currentElement;
            object IEnumerator.Current => _currentElement;
            
            public MyEnumarator(DoubleEndedQueue<T>doubleEndedQueue)
            {
                _doubleEndedQueue = doubleEndedQueue;
                _currentElement = default(T);
                _node = doubleEndedQueue._head;
                _index = 0;
            }

            public bool MoveNext()
            {
                if (_node == null)
                {
                    _index = _doubleEndedQueue.Count + 1;
                    return false;
                }

                _index++;
                _currentElement = _node.Value;
                _node= _node.Next;
                if (_node == _doubleEndedQueue._head)
                {
                    _node= null;
                }

                return true;
            }

            public void Reset()
            {
                _currentElement = default(T);
                _node = _doubleEndedQueue._head;
                _index = 0;
            }

            public void Dispose()
            {
            }

    }
    public IEnumerator<T> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
