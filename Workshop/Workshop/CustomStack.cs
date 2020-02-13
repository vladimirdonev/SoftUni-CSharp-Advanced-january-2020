using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class CustomStack <T>
    {
        private T[] items;
        private const int InitialCapacity = 4;
        public int Count { get; private set; }
        public CustomStack()
        {
            this.Count = 0;
            this.items = new T[InitialCapacity];
        }
        public void Push(T Element)
        {
           if(this.Count == this.items.Length)
           {
                var newitems = new T[this.items.Length * 2];
                for (int i = 0; i < this.items.Length; i++)
                {
                    newitems[i] = items[i];
                }
                this.items = newitems;
           }
            this.items[this.Count] = Element;
            Count++;
        }
        public T Pop()
        {
            Checkeforelement();
            T number = items[this.Count - 1];
            items[this.Count - 1] = default(T);
            Count--;
            return number;
        }

        private void Checkeforelement()
        {
            if (this.items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
        }

        public T Peek()
        {
            Checkeforelement();
            T number = items[Count - 1];
            return number;
        }
        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.items[i]);
            }
        }
    }
}
