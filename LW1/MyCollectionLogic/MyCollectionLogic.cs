using System;
using System.Collections.Generic;

namespace LW1.MyCollectionLogic;

public class MyCollectionLogic<T>
{
    private List<EventHandler<EventArgs>> _eventHandlers= new List<EventHandler<EventArgs>>();
    private Exception _exception;
    
   
    
}