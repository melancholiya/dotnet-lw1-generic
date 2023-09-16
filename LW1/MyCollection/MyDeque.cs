using System.Collections;
using System.Collections.Generic;

namespace LW1.MyCollection;

public class DoubleEndedQueue<T>:IEnumerable<T>
{
    private int _size;
    private class MyEnumarator : IEnumerator<T>
    {
        private readonly LinkedList<T> _enumeratorImplementation;
        private int _index;
        private T _currentElement;
            
        public MyEnumarator(LinkedList<T>enumeratorImplementation)
        {
            _enumeratorImplementation = enumeratorImplementation;
            _index = -1;
            _currentElement = default(T);
        }

        public bool MoveNext()
        {
            _index++;
                
            return _enumeratorImplementation.MoveNext();
        }

        public void Reset()
        {
            _enumeratorImplementation.Reset();
        }

        public void Dispose()
        {
        }

        public T Current => _enumeratorImplementation.Current;
        object IEnumerator.Current => ((IEnumerator)_enumeratorImplementation).Current;
    }
    public IEnumerator<T> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
