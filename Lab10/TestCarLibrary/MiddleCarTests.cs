using CarLibrary;
namespace TestCarLibrary
{
    [TestClass]
    public class MiddleCarTests
    {
        [TestMethod]
        public void MiddleCarConstructor()
        {
            MiddleCar middleCar = new MiddleCar("Toyota", 2022, "Red", 25000, 5, true, "������");

            Assert.AreEqual("Toyota", middleCar.Brand);
            Assert.AreEqual(2022, middleCar.Year);
            Assert.AreEqual("Red", middleCar.Color);
            Assert.AreEqual(25000, middleCar.Cost);
            Assert.AreEqual(5, middleCar.Clearance);
            Assert.AreEqual(true, middleCar.FourWheelDrive);
            Assert.AreEqual("������", middleCar.OffRoadType);
        }

        [TestMethod]
        public void Equals_CompareWithEqualLightCar_ReturnsTrue()
        {
            MiddleCar middleCar1 = new MiddleCar("Toyota", 2022, "Red", 25000, 5, true, "������");
            MiddleCar middleCar2 = new MiddleCar("Toyota", 2022, "Red", 25000, 5, true, "������");

            bool result = middleCar1.Equals(middleCar2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToString_ReturnsProperStringRepresentation()
        {
            MiddleCar middleCar = new MiddleCar("Toyota", 2022, "Red", 25000, 5, true, "������"); ;
            string expectedOutput = "������ = Toyota, ��� ������� = 2022, ���� = Red, ��������� = 25000, �������� ������� = 5, ������ ������ = True, ��� ���������� = ������";

            string result = middleCar.ToString();

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void RandomInit_SetsRandomValuesWithinSpecifiedRanges()
        {
            MiddleCar middleCar = new MiddleCar();

            middleCar.RandomInit();

            Assert.IsNotNull(middleCar.FourWheelDrive);
            Assert.IsFalse(string.IsNullOrEmpty(middleCar.OffRoadType));
        }

        
    }
}