using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;
        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }
        public int Count { get; private set; }
        public int this[int index]
        {
            get
            {
                CheckIndex(index);
                return items[index];
            }
            set
            {
                CheckIndex(index);
                items[index] = value;
            }
        }
        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        public void Add(int element)
        {
            if(this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = element;
            this.Count++;
        }
        public int RemoveAt(int index)
        {
            CheckIndex(index);
            int element = items[index];
            items[index] = default(int);
            this.ShiftLeft(index);
            this.Count--;
            if(this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }
            return element;
        }
        public void Insert(int index,int item)
        {
            CheckIndex(index);
            this.Count++;
            if(this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.ShiftRight(index);
            this.items[index] = item;
        }
        public bool Contains(int Element)
        {
            bool exist = false;
            for (int i = 0; i < Count; i++)
            {
                if(this.items[i] == Element)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
        public void Swap(int Firstindex,int Secondindex)
        {
            CheckIndex(Firstindex);
            CheckIndex(Secondindex);
            int Firstelement = this.items[Firstindex];
            int Secondelement = this.items[Secondindex];
            this.items[Firstindex] = Secondelement;
            this.items[Secondindex] = Firstelement;
        }
        private  void CheckIndex(int index)
        {
            if(index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        private void ShiftLeft(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = items[i + 1];

            }
        }
        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = items[i];
            }
            this.items = copy;
        }
        private void ShiftRight(int index)
        {
            for (int i = Count; i < index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }
    }  
}
