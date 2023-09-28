using System;
using LW1.MyCollection;

namespace LW1.MyConsoleApp;

public class ConsoleApp:IConsoleApp
{
   private readonly DoubleEndedQueue<int> _deque = new();

   private void PrintDeque()
   {
      foreach (var item in _deque)
      {
         Console.WriteLine(item);
      }
   }

   public void CreateDequeWithElements()
   {
      Console.WriteLine("-------------------Create deque-------------------");
      _deque.AddFirst(1);
      _deque.AddFirst(2);
      _deque.AddFirst(3);
      _deque.AddLast(4);
      _deque.AddLast(5);
      _deque.AddLast(6);
      PrintDeque();
   }
   public void RemoveElements()
   {
      Console.WriteLine("-------------------Remove-------------------");
      _deque.RemoveFirst();
      _deque.RemoveLast();
      PrintDeque();
   }

   public void Contains()
   {
      Console.WriteLine("-------------------Contains-------------------");
      Console.WriteLine(_deque.Contains(5));
      Console.WriteLine(_deque.Contains(7));
   }

   public void CopyTo()
   {
      Console.WriteLine("-------------------CopyTo-------------------");
      var array=new int[_deque.Count];
      _deque.CopyTo(array,0);
      PrintDeque();
   }

   public void Clear()
   {
      Console.WriteLine("-------------------Clear-------------------");
      _deque.Clear();
   }
}
