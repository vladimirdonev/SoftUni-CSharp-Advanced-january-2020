using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;
        public int Count { get; private set; }
        public Box()
        {
            this.list = new List<T>();
        }
        public void Add(T element)
        {
            this.list.Add(element);
            this.Count++;
        }
        public T Remove()
        {
            T element = this.list[this.Count - 1];
                this.list.RemoveAt(Count - 1);
            this.Count--;
            return element;
        }
    }
}
