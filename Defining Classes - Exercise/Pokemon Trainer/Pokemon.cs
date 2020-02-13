using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Pokemon
    {
        private string name { get; set; }
        private string element { get; set; }
        private int health { get; set; }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Element
        {
            get { return this.element; }
            set { this.element = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public Pokemon(string name,string element,int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
    }
}
