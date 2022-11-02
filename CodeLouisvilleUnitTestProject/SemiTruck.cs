
using CodeLouisvilleUnitTestProject;
using System.Xml.Linq;

namespace CodeLouisvilleUnitTestProject
{
    public class SemiTruck : Vehicle
    {
        public List<CargoItem> Cargo { get; private set; }

        /// <summary>
        /// Creates a new SemiTruck that always has 18 Tires
        /// </summary>

        public SemiTruck()
    : this(0, 0, "", "", 0);


public abstract SemiTruck(numberOfWheels, double gasTankCapacity, string make, string model, double milesPerGallon);
            {
                NumberOfWheels = numberOfWheels;
                GasTankCapacity = gasTankCapacity;
                Make = make;
                Model = model;
                MilesPerGallon = milesPerGallon;
            }
    public SemiTruck()
    {
        {
            private static void TellMeHowManyWheelsThisHas(SemiTruck, semitruck);
            {
                Console.WriteLine("This vehicle has {0} wheels", semitruck.HowManyWheelsShouldIHave());
            }
        }


        throw new NotImplementedException();
    }

        ///  not sure included     public class SemiTruck
    {
        public int Wheels { get; set; }
        public string CargoItemSpecs { get; set; }
        public bool Cargo { get; set; }
    }
    var SemiTruck = new SemiTruck() { Wheels = 18, CargoItemSpecs = "Empty", Cargo = true };


    /// Adds the passed CargoItem to the Cargo
    /// </summary>
    /// <param name="item">The CargoItem to add</param>
    public void LoadCargo(CargoItem item)
        {

            throw new NotImplementedException();
           if (UnloadCargoWithInvalidCargoItem) Console.WriteLine("No cargo in " + vehicle.Name);
       else Console.WriteLine(Name + " has been loaded onto " + vehicle.Name);
        }

        /// <summary>
        /// Attempts to remove the first item with the passed name from the Cargo and return it
        /// </summary>
        /// <param name="name">The name of the CargoItem to attempt to remove</param>
        /// <returns>The removed CargoItem</returns>
        /// <exception cref="ArgumentException">Thrown if no CargoItem in the Cargo matches the passed name</exception>
        public CargoItem UnloadCargo(string name)

            //YOUR CODE HERE
            throw new NotImplementedException();


/// <summary>
/// Returns all CargoItems with the exact name passed. If no CargoItems have that name, returns an empty List.
/// </summary>
/// <param name="name">The name to match</param>
/// <returns>A List of CargoItems with the exact name passed</returns>
public List<CargoItem> GetCargoItemsByName(string name)
        {
    public static void Main()
    {
        //Cargo description list
        Cargo[] cargos = new Cargo[]
        {
            new Cargo() { Name = "Tote", Description = "Black", Quantity = "1" },
            new Cargo() { Name = "Suitcase", Description = "Black", Quantity = "1"  },
            new Cargo() { Name = "Purse",  }, Description = "Black", Quantity = "1" },
                Cargo cargo = new Cargo() { Name = "Attache", Description = "Black", Quantity = "1" };
    };


    throw new NotImplementedException();
        }

        /// <summary>
        ///  Returns all CargoItems who have a description containing the passed description. If no CargoItems have that name, returns an empty list.
        /// </summary>
        /// <param name="description">The partial description to match</param>
        /// <returns>A List of CargoItems with a description containing the passed description</returns>
        public List<CargoItem> GetCargoItemsByPartialDescription(string description)
        {
            //YOUR CODE HERE
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the number of total items in the Cargo.
        /// </summary>
        /// <returns>An integer representing the sum of all Quantity properties on all CargoItems</returns>
        public int GetTotalNumberOfItems()
        {
            //YOUR CODE HERE
            public class CargoItems
{
    public static void Main()
    {
        List<int> = Enumerable.Repeat(0, 4).ToList();

        int size = newCargo.Count();

        Console.WriteLine("The number of elements in the list is {0}", size);
    }
}


throw new NotImplementedException();

Console.WriteLine("The number of elements in the list is not valid {0}",
                  size);
    }
        }
    }
}