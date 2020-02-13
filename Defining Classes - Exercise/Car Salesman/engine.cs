
namespace DefiningClasses
{
    public class engine
    {
        private string model { get; set; }
        private string power { get; set; }
        private string displacement { get; set; }
        private string efficiency { get; set; }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Power
        {
            get { return this.power; }
            set { this.power = value; }
        }
        public string Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }
        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }
        public engine(string model,string power,string displacement,string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
    }
}
