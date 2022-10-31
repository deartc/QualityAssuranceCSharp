using Google.Protobuf.WellKnownTypes;
using System.Xml.Linq;

namespace CodeLouisvilleUnitTestProject 
{
    public class CargoItem
    {
        [Fact]
        public void UnloadCargoWithInvalidCargoItem()
        {
            //arrange

            //act
            if (UnloadCargoWithInvalidCargoItem) return "<NO CARGO>";
            else return name;
        }

    }
//assert
throw private new NotImplementedException();
            if (UnloadCargoWithInvalidCargoItem) Console.WriteLine("No cargo in " + vehicle.Name);
            else Console.WriteLine(Name + " has been loaded onto " + vehicle.Name);

        }


//Verify that attempting to unload a CargoItem that does not
//appear in the Cargo throws a System.ArgumentException