using System;
using System.Collections.Generic;
using LW1.MyCollection;

namespace LW1.MyCollectionLogic;

public class DequeEventHandler<T> : IDequeEventHandler
{
    private readonly DoubleEndedQueue<T> _deque;
    
    public DequeEventHandler(DoubleEndedQueue<T>deque)
    {
        _deque = deque;
        
    }
    public void Subscriber()
    {
        _deque.ElementAdded += (sender, eventArgs) =>
        {
            Console.WriteLine("Element added: {0}", eventArgs);
            
        };
        _deque.CollectionCleared += (sender, eventArgs) =>
        {
            Console.WriteLine("Collection cleared");
        };
        _deque.ElementRemoved += (sender, eventArgs) =>
        {
            Console.WriteLine("Element removed: {0}", eventArgs);
        };
        _deque.AddedToBeginning += (sender, eventArgs) =>
        {
            Console.WriteLine("Element added to beginning: {0}", eventArgs);
        };
        _deque.AddedToEnd += (sender, eventArgs) =>
        {
            Console.WriteLine("Element added to end: {0}", eventArgs);
        };
    }
    
    


    
}