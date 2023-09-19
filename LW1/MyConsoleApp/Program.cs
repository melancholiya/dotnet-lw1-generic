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
           var handler=new DequeEventHandler<int>(deque);

           deque.ElementAdded += (sender, eventArgs) =>
           {
               Console.WriteLine("Element added: {0}", eventArgs);
           };
           deque.CollectionCleared += (sender, eventArgs) =>
           {
               Console.WriteLine("Collection cleared");
           };
           deque.ElementRemoved += (sender, eventArgs) =>
           {
               Console.WriteLine("Element removed: {0}", eventArgs);
           };
           deque.AddedToBeginning += (sender, eventArgs) =>
           {
               Console.WriteLine("Element added to beginning: {0}", eventArgs);
           };
           deque.AddedToEnd += (sender, eventArgs) =>
           {
               Console.WriteLine("Element added to end: {0}", eventArgs);
           };
           
             
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