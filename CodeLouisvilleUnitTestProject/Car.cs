
namespace using CodeLouisvilleUnitTestProject;

public class Car : Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    }
}

namespace QualityAssuranceCSharp.CodeLouisvilleUnitTestProject
{
    class Car
    {
        static void Main(string[] args)
        {
            Tire tire = new Tire { Name = "Goodyear", Model = "Fx100", };

            Console.WriteLine("Created a wheel {0}, model {1}", Tire.Name, Tire.Model,);

            Vehicle car = new Vehicle { Make = "Honda", Model = "Civic" Year = “2020” };
            //vehicle.Make = "Honda";
            //vehicle.Model = "Civic";
            //vehicle.Year = “2020”

            for (int i = 0; i < 4; i++)
            {
                car.AddTire(Tire);
            }

            Console.WriteLine("Created a vehicle {0}, model {1}", car.Make, car.Model);

            Console.WriteLine(car.ToString());

            Console.ReadKey();
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































