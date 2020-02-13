using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model { get; set; }
        private double fuelamount { get; set; }
        private double fuelconsumptionperkilometer { get; set; }
        private double travelleddistance { get; set; }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double FuelAmount
        {
            get { return this.fuelamount; }
            set { this.fuelamount = value; }
        }
        public double FuelConsumptionPerKilometer
        {
            get { return this.fuelconsumptionperkilometer; }
            set { this.fuelconsumptionperkilometer = value; }
        }
        public double TravelledDistance
        {
            get { return this.travelleddistance; }
            set { this.travelleddistance = value; }
        }
        public Car(string carmodel,double fuelamount,double fuelfor1km)
        {
            this.Model = carmodel;
            this.FuelAmount = fuelamount;
            this.FuelConsumptionPerKilometer = fuelfor1km;
            this.TravelledDistance = 0;
        }
        public void Drive(double distance)
        {
            if (this.FuelAmount < distance * this.fuelconsumptionperkilometer)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= distance * this.FuelConsumptionPerKilometer;
                this.TravelledDistance += distance;
            }
        }
    }
}
