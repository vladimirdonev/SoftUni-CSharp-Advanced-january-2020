using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class tire
    {
        private double firsttirepressure { get; set; }
        private double secondtirepressure { get; set; }
        private double thirdtirepressure { get; set; }
        private double fourthtirepressure { get; set; }
        private int firsttireage { get; set; }
        private int secondtireage { get; set; }
        private int thirdtireage { get; set; }
        private int fourthtireage { get; set; }
        public double FirstTirePressure
        {
            get { return this.firsttirepressure; }
            set { this.firsttirepressure = value; }
        }
        public double SecondTirePressure
        {
            get { return this.secondtirepressure; }
            set { this.secondtirepressure = value; }
        }
        public double ThirdTirePressure
        {
            get { return this.thirdtirepressure; }
            set { this.thirdtirepressure = value; }
        }
        public double FourthTirePressure
        {
            get { return this.fourthtirepressure; }
            set { this.fourthtirepressure = value; }
        }
        public int FirstTireAge
        {
            get { return this.firsttireage; }
            set { this.firsttireage = value; }
        }
        public int SecondTireAge
        {
            get { return this.secondtireage; }
            set { this.secondtireage = value; }
        }
        public int ThirdTireAge
        {
            get { return this.thirdtireage; }
            set { this.thirdtireage = value; }
        }
        public int FourthTireAge
        {
            get { return this.fourthtireage; }
            set { this.fourthtireage = value; }
        }
        public tire(double first,int firstage,double second,int secondage,double third,int thirdage,double fourth,int fourthage)
        {
            FirstTirePressure = first;
            FirstTireAge = firstage;
            SecondTirePressure = second;
            SecondTireAge = secondage;
            ThirdTirePressure = third;
            ThirdTireAge = thirdage;
            FourthTirePressure = fourth;
            FourthTireAge = fourthage;
        }
    }
}
