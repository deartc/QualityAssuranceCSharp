using QualityAssuranceCSharp.CodeLouisvilleUnitTestProject;
using Vehicle;
using static MyApplication.CarDetail;
using static System.Net.Mime.MediaTypeNames;
using car = Vehicle.car;

namespace CodeLouisvilleUnitTestProject;

//The first with a GasTankCapacity of 0, an empty string for Make and Model, and a MilesPerGallon of 0. 


public class car
    {


        public string Make { get; set; }
        public string Model { get; set; }
        public decimal MilesPerGallon { get; set; }
        public decimal GasTankCapacity { get; set; }
        public double GasTankCapacity { get; init; }
        public double MilesPerGallon { get; set; }

    public car()
    {
        Make = "make";
        Model = "model";
        MilesPerGallon = 0.00M;
        GasTankCapacity = 0.00M;

        public car (string make, string model, decimal milesPerGallon, decimal gasTankCapacity)
            Make = make;
        Model = model;
        MilesPerGallon = milesPerGallon;
        GasTankCapacity = GasTankCapacity; }



    
 // double for GasTankCapacity MPG,string for Make, model.

    public double MilesPerGallon { get; set; }
    public double GasTankCapacity { get; init; }
    public int NumberOfTires { get; init; }
    public string GasLevel => $"{_gasRemaining / GasTankCapacity * 100}%";
    public double MilesRemaining => _gasRemaining * MilesPerGallon;
    public double Mileage => _mileage;


    public Car (int numberOfTires, double gasTankCapacity, string make, string model, double milesPerGallon)
    {
        NumberOfTires = numberOfTires;
        GasTankCapacity = gasTankCapacity;
        Make = make;
        Model = model;
        MilesPerGallon = milesPerGallon;
        Year = Year;

}

    #region Private Fields
    private double _gasRemaining;
    private double _mileage;
    private bool _hasFlatTire;
    #endregion




    static void MyApplication.CarDetail(string[] args)
        {

        Vehicle car = new Vehicle { Make = "Honda", Model = "Civic", Year = “2020”, Tires = “4”, gasTankCapacity = “12, milesPerGallon = "25" };
        //car.Make = "Honda";
        //car.Model = "Civic";
        //car.Year = “2020”
        //car.NumberOfTires = "4"


        {

        }

        Console.WriteLine(car.ToString());