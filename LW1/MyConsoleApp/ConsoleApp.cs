using System;
using LW1.MyCollection;

namespace LW1.MyConsoleApp;

public class ConsoleApp:IConsoleApp
{
   private readonly DoubleEndedQueue<int> _deque;

   public ConsoleApp()
   {
      _deque=new DoubleEndedQueue<int>();
   }
   
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

   public void IndexOf()
   {
      Console.WriteLine("-------------------IndexOf-------------------");
      Console.WriteLine(_deque.IndexOf(5));
      Console.WriteLine(_deque.IndexOf(7));
   }

   public void CopyTo()
   {
      Console.WriteLine("-------------------CopyTo-------------------");
      var array=new int[_deque.Count];
      _deque.CopyTo(array,0);
      PrintDeque();
   }

   public void Insert()
   {
      Console.WriteLine("-------------------Insert-------------------");
      _deque.Insert(2, 7);
      _deque.Insert(4, 8);
      PrintDeque();
   }

   public void RemoveAt()
   {
      Console.WriteLine("-------------------RemoveAt-------------------");
      _deque.RemoveAt(2);
      _deque.RemoveAt(4);
      PrintDeque();
   }

   public void Clear()
   {
      Console.WriteLine("-------------------Clear-------------------");
      _deque.Clear();
   }
}
