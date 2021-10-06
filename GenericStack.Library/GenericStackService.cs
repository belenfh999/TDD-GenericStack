using System;

namespace GenericStack.Library
{
    public class GenericStack<T>
    {
        private T _element;

        public void Push(T element)
        {
            _element = element;
        }

        public T Pop()
        {
            return _element;
        }
    }
}
