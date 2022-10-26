using CodeLouisvilleUnitTestProject;
using System.Reflection;

namespace using CodeLouisvilleUnitTestProject;

public class Car : Vehicle
{  
    {
        #region Public Properties
        public string Make { get; }
        public string Model { get; }
        public double MilesPerGallon { get; set; }
        public double GasTankCapacity { get; init; }
        public int NumberOfTires { get; init; }
        public int Year { get; set; }
    }
}
#region Private Fields
private double _gasRemaining;
private double _mileage;
private bool _hasFlatTire;
#endregion




public Car (int numberOfTires, double gasTankCapacity, string make, string model, double milesPerGallon, int year)
{
    NumberOfTires = numberOfTires;
    GasTankCapacity = gasTankCapacity;
    Make = make;
    Model = model;
    MilesPerGallon = milesPerGallon;
    Year = year
}


{
    class Car
    {
        static void Main(string[] args)
        {


        Car = new car { Make = "Honda", Model = "Civic" Year = “2020” };

            Car = new car  { Make = "Toyota", Model = "Prius" Year = “2020” };

            Vehicle car = new Vehicle { Make = "Sabaru", Model = "Civic" Year = “2020” };
            //vehicle.Make = "Honda";
            //vehicle.Model = "Civic";
            //vehicle.Year = “2020”

            
            {




        }
    }
}










//Test

class Car : Vehicle
{
    public override int HowManyTiresShouldIHave()
    {
        return 4;
    }

}































