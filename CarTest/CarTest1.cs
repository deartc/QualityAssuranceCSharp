using CodeLouisvilleUnitTestProject;
{
}
    namespace CodeLouisvilleUnitTestProject
    {
        public class CarTests
        {
            [Fact]
            public void CreateNewCar()
            {
            //arrange & act
            var car = new Car();
    
            //assert
            Assert.NotNull(car); 
            }
        }
}

