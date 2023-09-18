using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;

namespace LW1.MyCollection;

public class DoubleEndedQueue<T>: ICollection<T>
{
    private MyDequeNode<T> _head;

    private MyDequeNode<T> _tail;

    public DoubleEndedQueue() { }

    public DoubleEndedQueue(IEnumerable<T>collection)
    {
        if (collection is null)
        {
            throw new ArgumentNullException(nameof(collection));
        }

        foreach (var item in collection)
        {
            AddLast(item);
        }
    }

    public event EventHandler CollectionCleared;
    public event EventHandler CollectionAdded;
    public event EventHandler CollectionRemoved;

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

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
            _tail.Next = newNode;
            newNode.Previous = _tail;
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

public T RemoveLast()
{
    if(Count==0)
        throw new InvalidOperationException("Deque is empty.");
    var item = _tail.Value;
    if (Count == 1)
    {
        _head = null;
        _tail = null;
    }
    else
    {
        _tail = _tail.Previous;
        _tail.Next = null;
    }
    Count--;
    return item;
    
}


private void AddItems(T value)
{
    if (_head == null)
    {
        AddFirst(value);
    } 
    AddLast(value);
}
public void Add(T item)
{
    AddItems(item);
}

public void Clear()
{
    var current= _head;
    while (current!=null)
    {
        current = current.Next;
    }
    _head = null;
    Count= 0;
    
    //CollectionCleared!.Invoke(this,EventArgs.Empty);
    Console.WriteLine("Collection cleared");
}

public bool Contains(T item)
{
    MyDequeNode<T>current = _head;
    while (current!=null)
    {
        if (current.Value.Equals(item))
        {
            return true;
        }
        current = current.Next;
    }
    return false;
}

public void CopyTo(T[] array, int arrayIndex)
{
    if (array is null)
    {
        throw new ArgumentNullException(nameof(array));
    }

    if (arrayIndex < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(arrayIndex), "Index must be non-negative");
    }

    if (array.Length - arrayIndex < Count)
    {
        throw new ArgumentException("The number of elements in the source deque is " +
                                    "greater than the available space from arrayIndex to the " +
                                    "end of the destination array.");
    }

    MyDequeNode<T>current = _head;
    while (current!=null)
    {
        array[arrayIndex++] = current.Value;
        current = current.Next;
    }
}


private class MyEnumerator : IEnumerator<T>
        {
            private readonly DoubleEndedQueue<T> _doubleEndedQueue;
            private MyDequeNode<T> _node;
            private T _currentElement;
            public T Current => _currentElement;
            object IEnumerator.Current => _currentElement;    
            
            public MyEnumerator(DoubleEndedQueue<T>doubleEndedQueue)
            {
                _doubleEndedQueue = doubleEndedQueue;
                _currentElement = default(T);
                _node = doubleEndedQueue._head;
            }

            public bool MoveNext()
            {
                if (_node == null &&_node!=_doubleEndedQueue._tail)
                {
                    return false;
                }
                _currentElement = _node!.Value;
                _node = _node.Next;
                if (_node == _doubleEndedQueue._head)
                {
                    _node = null;
                }

                return true;
            }
            
            public void Reset()
            {
                _currentElement = default(T);
            }

            public void Dispose()
            { 
            }
            

    }
    public IEnumerator<T> GetEnumerator()
    {
        return new MyEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
