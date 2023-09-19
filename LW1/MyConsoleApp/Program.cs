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
           
             deque.AddFirst(1);
             deque.AddFirst(2);
             deque.AddFirst(3);
             deque.AddLast(4);
             deque.AddLast(5);
             deque.AddLast(6);
             
            Console.WriteLine(deque.Contains(5));
            Console.WriteLine(deque.Contains(7));
            
            Console.WriteLine(deque.IndexOf(5));
            Console.WriteLine(deque.IndexOf(7));

            deque.Remove(1);
             
             deque.Clear();
             
             
             


            foreach (var items in deque)
            {
                System.Console.WriteLine(items);
            }
            

        }
    }
}