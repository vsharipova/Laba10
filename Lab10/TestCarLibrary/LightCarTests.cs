using CarLibrary;
namespace TestCarLibrary
{
    [TestClass]
    public class LightCarTests
    {
        [TestMethod]
        public void LightCarConstructor()
        {
            LightCar lightCar = new LightCar("Toyota", 2022, "Red", 25000, 5, 5, 200);

            Assert.AreEqual("Toyota", lightCar.Brand);
            Assert.AreEqual(2022, lightCar.Year);
            Assert.AreEqual("Red", lightCar.Color);
            Assert.AreEqual(25000, lightCar.Cost);
            Assert.AreEqual(5, lightCar.Clearance);
            Assert.AreEqual(5, lightCar.CountPlaces);
            Assert.AreEqual(200, lightCar.MaxSpeed);
        }


        [TestMethod]
        public void Equals_CompareWithEqualLightCar_ReturnsTrue()
        {
            LightCar lightCar1 = new LightCar("Ford", 2023, "Blue", 30000, 7, 5, 180); 
            LightCar lightCar2 = new LightCar("Ford", 2023, "Blue", 30000, 7, 5, 180); 

            bool result = lightCar1.Equals(lightCar2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToString_ReturnsProperStringRepresentation()
        {
            LightCar lightCar = new LightCar("Tesla", 2024, "White", 40000, 8, 5, 220); 
            string expectedOutput = "Модель = Tesla, Год выпуска = 2024, Цвет = White, Стоимость = 40000, Дорожный просвет = 8, Кол-во мест = 5, Макс скорость = 220";

            string result = lightCar.ToString();

            Assert.AreEqual(expectedOutput, result);
        }

    }
}