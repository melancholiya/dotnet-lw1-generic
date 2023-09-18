using System;
using System.Collections.Generic;
using LW1.MyCollection;

namespace LW1.MyConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var deque=new DoubleEndedQueue<int>();
            deque.AddLast(1);
             deque.AddLast(2);
             deque.AddLast(3);
             deque.Clear();
             
             //int []array=new int[deque.Count];
             //deque.CopyTo(array,1);

             /*foreach (var t in array)
             {
                 System.Console.WriteLine(t);
             }
             */
             


            /*foreach (var items in deque)
            {
                System.Console.WriteLine(items);
            }
            Console.WriteLine(deque.Contains(5));
            */

        }
    }
}