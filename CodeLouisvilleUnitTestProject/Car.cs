
namespace using CodeLouisvilleUnitTestProject;

public class Car : Vehicle

{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car (int numberOfTires, double gasTankCapacity, string make, string model, double milesPerGallon)
    {
        NumberOfTires = numberOfTires;
        GasTankCapacity = gasTankCapacity;
        Make = make;
        Model = model;
        MilesPerGallon = milesPerGallon;
    
}


        static void Main(string[] args)
        {
            
            Vehicle car = new Vehicle { Make = "Honda", Model = "Civic" Year = “2020” };
            //vehicle.Make = "Honda";
            //vehicle.Model = "Civic";
            //vehicle.Year = “2020”

            for (int i = 0; i < 4; i++)
            {
                car.AddTire(Tire);
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

Console.WriteLine("Please enter your mpg");
var Mpg = Console.ReadLine();

Console.WriteLine("Please enter your gtc");
var Gtc = Console.ReadLine();




Console.WriteLine("Please enter how many passengers you want to add or remove");
var passenger = Console.ReadLine();



Console.WriteLine("Please enter your assembly day");
var AssemblydayInput = Console.ReadLine();

DateTime assemblyday;



while (!DateTime.TryParse(AssemblydayInput, out assemblyday))
{
    Console.WriteLine("Invalid , no data is available for years before 1995");
    AssemblydayInput = Console.ReadLine();
}



var Car = new Car
{
    Name = name,
    Assemblyday = assemblyday,
    Mpg = decimal.Parse(Mpg),
    Gtc = decimal.Parse(Gtc),
    Model = model,
    Passenger = passenger,


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



Console.WriteLine("No cargo in " + Car.Name);
Console.WriteLine(Car.Name + " has been loaded onto " + Car.Name);
Console.WriteLine(Car.Name + " NOT LOADED onto " + Car.Name);




















//Test

class Car : Vehicle
{
    public override int HowManyTiresShouldIHave()
    {
        return 4;
    }

}































