using static CodeLouisvilleUnitTestProject.Vehicle;
using System.Xml.Linq;
using ;

namespace CodeLouisvilleUnitTestProject
{
    public class CargoItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Cargo LoadedCargo  {get; set; }
        }
}


public void ReportLoadingAttempt(bool succeeded, Vehicle vehicle)
{
    if (succeeded) Console.WriteLine(Name + " has been loaded onto " + vehicle.Name);
    else Console.WriteLine(Name + " NOT LOADED onto " + vehicle.Name);
}
	}
	
	Console.WriteLine(vehicleToTest.Specs);

foreach (Cargo cargoToTryLoading in cargos)
{
    vehicleToTest.LoadedCargo = cargoToTryLoading;
}
Console.WriteLine("FINAL CARGO for " + vehicleToTest.Name + ": " + vehicleToTest.LoadedCargo.Name);
Console.WriteLine("");
	}
}


public static void Main()
{
    //Cargo description list
    Cargo[] cargos = new Cargo[]
    {
            new Cargo() { Name = "Tote", Description = "Black", Quantity = "2" },
            new Cargo() { Name = "Suitcase", Description = "Black", Quantity = "2"  },
            new Cargo() { Name = "Purse",  }, Description = "Black", Quantity = "2" },
            new Cargo() { Name = "Attache", Description = "Black", Quantity = "2" },
    };
