using CarLibrary;
namespace TestCarLibrary
{
    [TestClass]
    public class IdNumberTests
    {
        [TestMethod]
        public void IdNumberConstructor()
        {
            int number = 42;

            IdNumber idNumber = new IdNumber(number);

            Assert.AreEqual(number, idNumber.Number);
        }

        [TestMethod]
        public void IdNumberEquals()
        {
            IdNumber idNumber1 = new IdNumber(100);
            IdNumber idNumber2 = new IdNumber(100);

            bool result = idNumber1.Equals(idNumber2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IdNumberToString()
        {
            IdNumber idNumber = new IdNumber(123);

            string result = idNumber.ToString();

            Assert.AreEqual("123", result);
        }
    }
}