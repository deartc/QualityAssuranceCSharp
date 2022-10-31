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
        set { name = value; }
}

//assert
throw new NotImplementedException();
            if (UnloadCargoWithInvalidCargoItem) Console.WriteLine("No cargo in " + vehicle.Name);
            else Console.WriteLine(Name + " has been loaded onto " + vehicle.Name);


            t
        }





//Verify that attempting to unload a CargoItem that does not
//appear in the Cargo throws a System.ArgumentException