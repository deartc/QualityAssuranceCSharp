using CodeLouisvilleUnitTestProject;
{
}
    namespace CodeLouisvilleUnitTestProjectTests
    {
        public class CarTests
        {
            [Fact]
            public void CreateNewCarTest()
            {
                //arrange & act
                var car = new Car()
    
            //assert
            Assert.NotNull(car);
            }
        }
}
   
