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
    if (succeeded) Console.WriteLine(Name + " has been loaded onto " + semiTruck.Name);
    else Console.WriteLine(Name + " NOT LOADED onto " + semiTruck.Name);
}
	}
	
	Console.WriteLine(semitruckToTest.Specs);
