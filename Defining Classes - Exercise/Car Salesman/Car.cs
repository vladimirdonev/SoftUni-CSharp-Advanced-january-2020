namespace DefiningClasses
{
    public class Car
    {
        private string model { get; set; }
        private engine engine { get; set; }
        private string weight { get; set; }
        private string color { get; set; }
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
        public string Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public Car(string model,engine enginemodel,string weight,string color)
        {
            Model = model;
            this.Engine = enginemodel;
            Weight = weight;
            Color = color;
        }
        //public override string ToString()
        //{
        //   return $"{Model}:" +
        //      $"{Environment.NewLine}" +
        //    $"Power: {Engine.Model}" +
        //  $"{Environment.NewLine} " +
        //$"Displacement: {Engine.Displacement}" +
        //$"{Environment.NewLine}   " +
        //$"Efficiency: {Engine.Efficiency}" +
        //$"{Environment.NewLine}" +
        //$"Weight: {Weight} " +
        //$"{Environment.NewLine}" +
        //$"Color: {Color}"; 

    //}
}
}
