using System;
using System.Collections.Generic;
using LW1.MyCollection;
using LW1.MyCollectionLogic;

namespace LW1.MyConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            var deque=new DoubleEndedQueue<int>();
           IDequeEventHandler handler=new DequeEventHandler<int>(deque);
           handler.Subscriber();
           
           IConsoleApp consoleApp=new ConsoleApp();
           consoleApp.CreateDequeWithElements();
           consoleApp.RemoveElements();
           consoleApp.Contains();
           consoleApp.CopyTo();
           Console.WriteLine("-------------------Clear-------------------");
           deque.Clear();
           //consoleApp.Clear();
           





















        }
        
    }
    
}