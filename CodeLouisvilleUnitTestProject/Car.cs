
namespace using CodeLouisvilleUnitTestProject;
using System;

public class Car : Vehicle

{
    //The first with a GasTankCapacity of 0, an empty string for Make and Model, and a MilesPerGallon of 0. 
    public string Make { get; set; }
    public string Model { get; set; }
    
    public double GasTankCapacity { get; init; }
    public double MilesPerGallon { get; set; }





    // needed
     for you.Create it yourself and implement it as follows:
1.	Car inherits from Vehicle.
2.	Car has a private field of type HttpClient to be used to call a public external API.
1.	HttpClient documentation can be found here.
3.	Car has a public integer property NumberOfPassengers with a public get accessor but a private set.

        
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
    public int Year { get; set; }
}








    public double MilesPerGallon { get; set; }
    public double GasTankCapacity { get; init; }
    public int NumberOfTires { get; init; }
    public string GasLevel => $"{_gasRemaining / GasTankCapacity * 100}%";
    public double MilesRemaining => _gasRemaining * MilesPerGallon;
    public double Mileage => _mileage;
#endregion


    #region Private Fields
    private double _gasRemaining;
    private double _mileage;
    private bool _hasFlatTire;
    #endregion








    static void Main(string[] args)
        {
            
            Vehicle car = new Vehicle { Make = "Honda", Model = "Civic" Year = “2020” };
            //vehicle.Make = "Honda";
            //vehicle.Model = "Civic";
            //vehicle.Year = “2020”

            
            {
                
            }



            Console.WriteLine(car.ToString());

    
        }
    }
}


Console.WriteLine("Car Statistics");

Console.WriteLine("Please enter your make");
var name = Console.ReadLine();

Console.WriteLine("Please enter your model");
var model = Console.ReadLine();











while (!DateTime.TryParse(AssemblyyearInput, out assemblyyear))
{
    Console.WriteLine("Invalid , no data is available for years before 1995");
    AssemblyyearInput = Console.ReadLine();
}






};



Console.WriteLine($"this is your car statistics: {Car.Make} " +
    $"Your model is {Car.Model} " + $"Your mpg is {Car.MilesPerGallon} " + $"Your passengers is {Car.Passenger}" +
    $"and your assemblyday is {Car.Assemblyday.ToShortDateString()}.");


Console.WriteLine("Please add or remove  passengers by  the following menu options:");
Console.WriteLine("1: Add a passenger");
Console.WriteLine("2: View all current passengers");
Console.WriteLine("3: Remove a passenger by name");
Console.WriteLine("Enter the name of the passenger to remove");


Console.WriteLine("4: Exit");

Console.WriteLine("Testing for gas and flat tires!");

Console.WriteLine("Cannot drive, out of gas.”.\r\n");


Console.WriteLine("Cannot drive due to flat tire");
























//Test

class Car : Vehicle
{
    public override int HowManyTiresShouldIHave()
    {
        return 4;
    }

}






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
























