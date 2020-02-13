using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person<T> : IComparable<T>
    {
        private string name { get; set; }
        private int age { get; set; }
        private string town { get; set; }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Town
        {
            get { return this.town; }
            set { this.town = value; }
        }
        public Person(string name,int age,string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;

        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
