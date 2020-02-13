using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class cargo
    {
        private int cargoWeight { get; set; }
        private string cargoType { get; set; }
        public int CargoWeight
        {
            get { return this.cargoWeight; }
            set { this.cargoWeight = value; }
        }
        public string CargoType
        {
            get { return this.cargoType; }
            set { this.cargoType = value; }
        }
        public cargo(int cargoweight,string cargotype)
        {
            CargoWeight = cargoweight;
            CargoType = cargotype;
        }
    }
}
