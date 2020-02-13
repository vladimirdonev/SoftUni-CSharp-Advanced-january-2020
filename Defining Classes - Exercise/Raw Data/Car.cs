using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model { get; set; }
        private engine engine { get; set; }
        private cargo cargo { get; set; }
        private tire tire { get; set; }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }
        public cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }
        public tire Tire
        {
            get { return this.tire; }
            set { this.tire = value; }
        }
        public Car(string model, engine engine, cargo cargo, tire tire)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tire = tire;
        }
    }
}
