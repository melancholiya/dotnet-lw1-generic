using System;
using System.Collections.Generic;
using LW1.MyCollection;

namespace LW1.MyCollectionLogic;

public class DequeEventHandler<T>
{
    private readonly DoubleEndedQueue<T> _doubleEndedQueue;

    
    public DequeEventHandler(DoubleEndedQueue<T>doubleEndedQueue)
    {
        _doubleEndedQueue = doubleEndedQueue;
        
    }
    
    


    
}