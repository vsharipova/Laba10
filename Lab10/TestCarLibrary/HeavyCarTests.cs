using CarLibrary;
namespace TestCarLibrary
{
    [TestClass]
    public class HeavyCarTests
    {
        [TestMethod]
        public void HeavyCarConstructor()
        {
            HeavyCar heavyCar = new HeavyCar("Toyota", 2022, "Red", 25000, 200, 2);

            Assert.AreEqual("Toyota", heavyCar.Brand);
            Assert.AreEqual(2022, heavyCar.Year);
            Assert.AreEqual("Red", heavyCar.Color);
            Assert.AreEqual(25000, heavyCar.Cost);
            Assert.AreEqual(200, heavyCar.Clearance);
            Assert.AreEqual(2, heavyCar.Capacity);
        }

        [TestMethod]
        public void Equals_CompareWithEqualLightCar_ReturnsTrue()
        {
            HeavyCar heavyCar1 = new HeavyCar("Toyota", 2022, "Red", 25000, 200, 2);
            HeavyCar heavyCar2 = new HeavyCar("Toyota", 2022, "Red", 25000, 200, 2);

            bool result = heavyCar1.Equals(heavyCar2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToString_ReturnsProperStringRepresentation()
        {
            HeavyCar heavyCar = new HeavyCar("Toyota", 2022, "Red", 25000, 200, 2);
            string expectedOutput = "Модель = Toyota, Год выпуска = 2022, Цвет = Red, Стоимость = 25000, Дорожный просвет = 200, Грузоподъемность = 2";

            string result = heavyCar.ToString();

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void RandomInit_SetsRandomValuesWithinSpecifiedRanges()
        {
            HeavyCar heavyCar = new HeavyCar();

            heavyCar.RandomInit();

            Assert.IsNotNull(heavyCar.Capacity);
        }

        [TestMethod]
         public void TestShallowCopyMethod()
         {
            HeavyCar heavyCar = new HeavyCar();
            var shallowCopy = heavyCar.ShallowCopy();
            Assert.AreEqual(heavyCar.ToString(), shallowCopy.ToString());
         }

        [TestMethod]
        public void TestCloneMethod()
        {
            HeavyCar heavyCar = new HeavyCar();
            var clonedHeavyCar = (HeavyCar)heavyCar.Clone();
            Assert.AreEqual(heavyCar.ToString(), clonedHeavyCar.ToString());
        }

    }
}