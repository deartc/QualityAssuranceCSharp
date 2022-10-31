using System.Xml.Linq;

namespace CargoTest
{
    public class CargoTest1
    {
        
        {
            [Fact]
            public void CreateNewCargo()
            {
                //arrange & act
                var cargo = new Cargo();

                //assert
                Assert.NotNull(cargo);
            }
        }
    }



//	Verify that the Cargo property for the newly created SemiSemiTruck is a List of CargoItems which is empty, but not null


