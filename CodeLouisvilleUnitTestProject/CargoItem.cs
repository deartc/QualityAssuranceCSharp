using static CodeLouisvilleUnitTestProject.SemiTruck;
using System.Xml.Linq;
using System.Linq;
using System.Runtime.Remoting.Messaging;

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


//	LoadCargo: Verify the method correctly adds the passed object to the Cargo.


public void ReportLoadingAttempt(bool succeeded, SemiTruck SemiTruck)
{
    if (succeeded) Console.WriteLine(Name + " has been loaded onto " + vehicle.Name);
    else Console.WriteLine(Name + " NOT LOADED onto " + vehicle.Name);
}
	}
	
	Console.WriteLine(semitruckToTest.Specs);


public class SemiTruckTests
{

    //Verify that the SemiTruck constructor creates a new SemiTruck
    //object which is also a Vehicle and has 18 wheels. Verify that the
    //Cargo property for the newly created SemiTruck is a List of
    //CargoItems which is empty, but not null.
    [Fact]
    public void NewSemiTruckIsAVehicleAndHas18TiresAndEmptyCargoTest()
    {
        //arrange
        throw new NotImplementedException();
        //act

        //assert

    }

    //Verify that adding a CargoItem using LoadCargo does successfully add
    //that CargoItem to the Cargo. Confirm both the existence of the new
    //CargoItem in the Cargo and also that the count of Cargo increased to 1.
    [Fact]
    public void LoadCargoTest()
    {
        //arrange
        throw new NotImplementedException();
        //act

        //assert

    }

    //Verify that unloading a  cargo item that is in the Cargo does
    //remove it from the Cargo and return the matching CargoItem
    [Fact]
    public void UnloadCargoWithValidCargoTest()
    {
        //arrange
        throw new NotImplementedException();
        //act

        //assert

    }

    //Verify that attempting to unload a CargoItem that does not
    //appear in the Cargo throws a System.ArgumentException
    [Fact]
    public void UnloadCargoWithInvalidCargoTest()
    {
        //arrange
        throw new NotImplementedException();
        //act

        //assert

    }

    //Verify that getting cargo items by name returns all items
    //in Cargo with that name.
    [Fact]
    public void GetCargoItemsByNameWithValidName()
    {
        //arrange
        throw new NotImplementedException();
        //act

        //assert

    }

    //Verify that searching the Carto list for an item that does not
    //exist returns an empty list
    [Fact]
    public void GetCargoItemsByNameWithInvalidName()
    {
        //arrange
        throw new NotImplementedException();
        //act

        //assert

    }

    //Verify that searching the Cargo list by description for an item
    //that does exist returns all matched items that contain that description.
    [Fact]
    public void GetCargoItemsByPartialDescriptionWithValidDescription()
    {
        //arrange
        throw new NotImplementedException();
        //act

        //assert

    }

    //Verify that searching the Carto list by description for an item
    //that does not exist returns an empty list
    [Fact]
    public void GetCargoItemsByPartialDescriptionWithInvalidDescription()
    {
        //arrange
        throw new NotImplementedException();
        //act

        //assert

    }

    //Verify that the method returns the sum of all quantities of all
    //items in the Cargo
    [Fact]
    public void GetTotalNumberOfItemsReturnsSumOfAllQuantities()
    {
        //arrange
        throw new NotImplementedException();
        //act

        //assert

    }
}
}






//	LoadCargo: Verify the method correctly adds the passed object to the Cargo.

foreach (Cargo cargoToTryLoading in cargos)
{
    semiTruckToTest.LoadedCargo = cargoToTryLoading;
}
Console.WriteLine("FINAL CARGO for " + semitruckToTest.Name + ": " + semiTruckToTest.LoadedCargo.Name);
Console.WriteLine("");
	}
}


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




//number of Cargo items 







//GetTotalNumberOfItems: Verify that the method returns the sum of all quantities of all items in the Cargo List. 
public class CargoItems
{
    public static void Main()
    {
        List<int>  = Enumerable.Repeat(0, 4).ToList();

        int size = newCargo.Count();

        Console.WriteLine("The number of elements in the list is {0}", size);
    }
}





//UnloadCargo Positive Test: Verify that unloading a cargo item that is in the Cargo does remove it from the Cargo and return the matching CargoItem.
//UnloadCargo Negative Test: Verify that attempting to unload a CargoItem that does not appear in the Cargo throws a System.ArgumentException.
//GetCargoItemsByName Positive Test: Verify that searching the Cargo list by name for an item that does exist returns all matched items with exactly that name. 
//GetCargoItemsByName Negative Test: Verify that searching the Cargo list by name for an item that does not exist returns an empty list.
//GetCargoItemsByPartialDescription Positive Test: Verify that searching the Cargo list by description for an item that does exist returns all matched items that contain that Description.
//GetCargoItemsByPartialDescription Negative Test: Verify that searching the Cargo list by description for an item that does not exist returns an empty list.

//

Console.WriteLine("No cargo in " + Cargo.Name);
Console.WriteLine
    
    
    (CargoItem.Name + " has been loaded onto " + Cargo.Name);
Console.WriteLine(Cargo.Name + " NOT LOADED onto " + Cargo.Name);