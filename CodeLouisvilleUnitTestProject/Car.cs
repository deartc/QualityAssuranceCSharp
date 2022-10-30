using QualityAssuranceCSharp.CodeLouisvilleUnitTestProject;
using Vehicle;
using static MyApplication.CarDetail;
using static System.Net.Mime.MediaTypeNames;
using car = Vehicle.car;

namespace CodeLouisvilleUnitTestProject;
{
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
            GasTankCapacity = GasTankCapacity;



    
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
    private readonly string baseUrl = "https://vpic.nhtsa.dot.gov/api/ ";

    #endregion








    static void MyApplication.CarDetail(string[] args)
        {
            
            Vehicle car = new Vehicle { Make = "Honda", Model = "Civic" , Year = “2020”,  Tires = “4”, gasTankCapacity = “12, milesPerGallon  = "25" };
            //car.Make = "Honda";
            //car.Model = "Civic";
            //car.Year = “2020”
            //car.Tires = "4"
            
            
            {
                
            }



            Console.WriteLine(car.ToString());

    
        }
}
}

///passenger console

//passenger 
	

	using Car;
	using System.Text.Json;
	

	Console.WriteLine("This is passenger menu. Please choose from the following menu options:");
Console.WriteLine("1: Add an passenger");
Console.WriteLine("2: View all current passengers");
Console.WriteLine("3: Remove an passenger by name");
Console.WriteLine("4: Exit");


List<Passenger> passengers = new List<Passenger>();


var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};


var fileText = File.ReadAllText("passengers.json");
var deserialized = JsonSerializer.Deserialize<List<Passenger>>(fileText, options);
passengers.AddRange(deserialized);


string userInput = Console.ReadLine();


while (userInput != "4")
{
    if (userInput == "1")
    {
        passengers = Menu.AddPassenger(passengers);
    }
    else if (userInput == "2")
    {
        Menu.DisplayPassengers(passengers);
    }
    else if (userInput == "3")
    {
        Console.WriteLine("Enter the name of the passenger to remove");
        var name = Console.ReadLine();
        Menu.RemovePassenger(passengers, name);
    }
    else if (userInput == "4") //Exit
    {


    }
    Console.WriteLine("What next?");
    userInput = Console.ReadLine();
}


var json = JsonSerializer.Serialize(passengers);
File.WriteAllText("passengers.json", json);


Console.WriteLine("Please add or remove  passengers by  the following menu options:");
Console.WriteLine("1: Add a passenger");
Console.WriteLine("2: View all current passengers");
Console.WriteLine("3: Remove a passenger by name");
Console.WriteLine("Enter the name of the passenger to remove");


Console.WriteLine("4: Exit");
































// test
public void AddCar()
{
    //Arrange
    var vehicle = new car();
    var car = new car { Name = "Honda Civic" };

    //Act
    vehicle.Add(car);

    //Assert
    Assert.Shouldequal(vehicle.Count, 1);
}


public void AddCar()
{
    //Arrange
    var vehicle = new Vehicle();
    var car = new Car { Model = "Prius", Make = "Toyota" };

    //Act
    vehicles.cars.Add(car);

    //Assert
    Assert.ShouldEqual(vehicles.Count, 1);
}
























