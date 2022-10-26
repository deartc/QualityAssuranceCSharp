
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










//Test

class Car : Vehicle
{
    public override int HowManyTiresShouldIHave()
    {
        return 4;
    }

}































