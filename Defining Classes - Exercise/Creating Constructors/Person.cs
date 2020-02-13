using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name { get; set; }
        private int age { get; set; }
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
        public  Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age)
        {
            Name = "No name";
            Age = age;
        }
        public Person(int age,string name)
        {
            Name = name;
            Age = age;
        }
    }
}
