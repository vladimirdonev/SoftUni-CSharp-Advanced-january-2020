using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T firstElement { get; }
        private T secondelement { get; }
        public EqualityScale(T first,T second)
        {
            this.firstElement = first;
            this.secondelement = second;
        }
        public bool AreEqual()
        {
            bool result = this.firstElement.Equals(this.secondelement);
            return result;
        }
    }
}
