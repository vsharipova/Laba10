using CarLibrary;
namespace TestCarLibrary
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Car car = new Car();
            car.Brand = "BMW";
            Assert.AreEqual("BMW", car. Brand);
        }

        [TestMethod]
        public void Car_Initialization()
        {
            Car car = new Car("Toyota", 2020, "Red", 35000, 150);

            Assert.AreEqual("Toyota", car.Brand);
            Assert.AreEqual(2020, car.Year);
            Assert.AreEqual("Red", car.Color);
            Assert.AreEqual(35000, car.Cost);
            Assert.AreEqual(150, car.Clearance);
        }

        [TestMethod]
        public void TestDefaultConstructor()
        {
            Car car = new Car();
            Assert.IsNotNull(car);
        }

        [TestMethod]
        public void CompareToCompareWithOtherCar()
        {
            Car car1 = new Car("Toyota", 2022, "Red", 25000, 5);
            Car car2 = new Car("Toyota", 2022, "Red", 25000, 5);

            Assert.AreEqual(car1, car2);
        }
        [TestMethod]
        public void CompareToCompareWithSameCar()
        {
            Car car1 = new Car("Toyota", 2022, "Red", 25000, 5);
            Car car2 = new Car("Toyota", 2022, "Red", 25000, 5);
            int result = car1.CompareTo(car2);
            Assert.AreEqual(0, result);
        }
    }
}