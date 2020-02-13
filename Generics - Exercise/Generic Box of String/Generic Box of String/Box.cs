using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofString
{
    public class Box <T> 
        where T : IComparable
    {
        private  T value { get; }
        public Box(T String)
        {
            this.value = String;
        }
        public  List<Box<T>> SwapNames(List<Box<T>> boxes, int firstelement, int secondelement)
        {
            var element = boxes[firstelement];
            var second = boxes[secondelement];
            boxes[firstelement] = second;
            boxes[secondelement] = element;
            return boxes;
        }
        public  int Count(List<Box<T>>  boxes,T element)
        {
            int count = default(int);
            foreach (var item in boxes)
            {
                if (item.value.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            return $"{this.value.GetType()}: {value}";
        }
    }
}
