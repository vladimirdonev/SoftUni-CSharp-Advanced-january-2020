using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIteratorr
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list { get; set; }
        private int currentindex = 0;
        public ListyIterator(List<T> array)
        {
            this.list = array;
        }
        public bool Move()
        {
            bool canmove = this.HasNext();
            if(canmove == true)
            {
                currentindex++;
                return canmove;
            }
            return false;
        }
        public bool HasNext()
        {
            if(currentindex + 1 >= this.list.Count)
            {
                return false;
            }
            return true;
        }
        public void Print()
        {
            if(this.list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
                
            }
            else
            {
                Console.WriteLine(list[currentindex]);
            }
        }
        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ",list));
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
