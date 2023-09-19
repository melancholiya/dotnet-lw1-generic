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
           //var handler=new DequeEventHandler<int>(deque);
           IDequeEventHandler handler=new DequeEventHandler<int>(deque);
           handler.Subscriber();
           
            deque.AddFirst(1);
             deque.AddFirst(2);
             deque.AddLast(3);
             deque.Clear();
             
             
             


            foreach (var items in deque)
            {
                System.Console.WriteLine(items);
            }
            //Console.WriteLine(deque.Contains(5));
            

        }
    }
}