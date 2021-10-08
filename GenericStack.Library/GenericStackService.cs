using System;
using System.Collections.Generic;

namespace GenericStack.Library
{
    public class GenericStack<T>
    {
        private List<T> _elements = new List<T>();

        public void Push(T element)
        {
            if (EqualityComparer<T>.Default.Equals(element, default(T)))
            {
                throw new ArgumentNullException("Null cannot be pushed into the stack.");
            }
            else
            {
                _elements.Add(element);
            }
        }

        public T Pop()
        {
            if (_elements.Count == 0)
            {
                return default(T);
            }
            else
            {
                int lastElemIndex = _elements.Count - 1;
                T elem = _elements[lastElemIndex];
                _elements.RemoveAt(lastElemIndex);
                return elem;
            }

        }
    }
}
