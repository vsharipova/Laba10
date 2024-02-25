using CarLibrary;
namespace CarLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        Car car;
        [TestMethod]
        public void TestMethod1()
        {
            car = new Car();
            car.Brand = "BMW";
            Assert.AreEqual("BMW", car.Brand);
        }
    }
}