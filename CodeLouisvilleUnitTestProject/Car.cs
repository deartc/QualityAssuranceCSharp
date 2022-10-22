using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;



namespace
Vehicle
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int GasTankCapacity { get; set; }
        public double GasLevel { get; set; }
        public double MilesPerGallon { get; set; }
        public double Odometer { get; set; } = 0;
        public double MilesRemaining { get; set; }





        public Car(string make, string model, int GasTankCapacity, double milesPerGallon)
        {
            Make = make;
            Model = model;
            GasTankCapacity = gasTankCapacity;

            GasLevel = gasLevel;
            MilesPerGallon = milesPerGallon;

        }
    }
}

























              


