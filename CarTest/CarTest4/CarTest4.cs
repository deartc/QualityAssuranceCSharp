namespace CarTest4
{
    public class CarTest4
    {


        public void AddCar()
        {
            //Arrange
            var vehicle = new car();
            var car = new car { Name = "Honda Civic" };

            //Act
            vehicle.Add(car);

            //Assert
            Assert.Shouldequal(vehicle.Count, 1);
        }
    }
}




    //Car test =   It is a vehicle and  one car