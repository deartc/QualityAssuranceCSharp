
namespace CodeLouisvilleUnitTestProject
{
    class Car : Vehicle
    {
        public Car()
        {
        }

        static void Main(string[] args)
        {
            Car Honda = new Car("Civic", "Black", 1994);
            Car Toyota = new Car("Prius", "Blue", 2005);

            Console.WriteLine(Honda.model);
            Console.WriteLine(Toyota.model);



        }
    }
}



























