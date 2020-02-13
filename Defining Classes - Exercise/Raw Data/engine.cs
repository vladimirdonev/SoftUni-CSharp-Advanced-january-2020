using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class engine
    {
        private int engineSpeed { get; set; }
        private int enginePower { get; set; }
        public int EngineSpeed
        {
            get { return this.engineSpeed; }
            set { this.engineSpeed = value; }
        }
        public int EnginePower
        {
            get { return this.enginePower; }
            set { this.enginePower = value; }
        }
        public engine(int enginespeed,int enginepower)
        {
            EngineSpeed = enginespeed;
            EnginePower = enginepower;
        }
    }
}
