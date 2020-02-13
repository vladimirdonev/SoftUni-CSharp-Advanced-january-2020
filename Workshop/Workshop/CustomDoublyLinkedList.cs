using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class CustomDoublyLinkedList<T>
    {
        private class ListNode
        {
            public T Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
            public ListNode(T value)
            {
                this.Value = value;
            }
        }
        private ListNode head { get; set; }
        private ListNode tail { get; set; }
        public int Count { get; private set; }
        public void AddFirst(T element)
        {
            var NewHead = new ListNode(element);
            if (this.Count == 0)
            {
                
                this.head = NewHead;
                this.tail = NewHead;
            }
            else
            {

                NewHead.NextNode = this.head;
                this.head.PreviousNode = NewHead;
                this.head = NewHead;
                
            }
            this.Count++;
        }
        public void AddLast(T element)
        {
            var NewHead = new ListNode(element);
            if(Count == 0)
            {
                this.head = NewHead;
                this.tail = NewHead;
            }
            else
            {
                NewHead.PreviousNode = this.tail;
                this.tail.NextNode = NewHead;
                this.tail = NewHead;
            }
            this.Count++;
        }
        public T  RemoveFirst()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            var firstelement = this.head.Value;
            this.head = this.head.NextNode;
            if(this.head != null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }
            this.Count++;
            return firstelement;
        }
        public T RemoveLast()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            var lastelement = this.tail.Value;
            this.tail = this.tail.PreviousNode;
            if(this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.tail = null;
            }
            return lastelement;
        }
        public void ForEach(Action<T> action)
        {
            var currentnode = this.head;
            while(currentnode != null)
            {
                action(currentnode.Value);
                currentnode = currentnode.NextNode;
            }
        }
        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            int counter = 0;
            var currentnode = this.head;
            while(currentnode != null)
            {
                arr[counter] = currentnode.Value;
                currentnode = currentnode.NextNode;
                counter++;
            }
            return arr;
        }
    }
}
