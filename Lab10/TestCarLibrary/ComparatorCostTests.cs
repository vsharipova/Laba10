using CarLibrary;
namespace TestCarLibrary
{
    [TestClass]
    public class ComaratorCostTests
    {
        [TestMethod]
        public void Compare_FirstCarCostIsHigher()
        {
            Car car1 = new Car { Cost = 100 };
            Car car2 = new Car { Cost = 50 };
            ComparatorCost comparator = new ComparatorCost();

            int result = comparator.Compare(car1, car2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Compare_SecondCarCostIsHigher()
        {
            Car car1 = new Car { Cost = 50 };
            Car car2 = new Car { Cost = 100 };
            ComparatorCost comparator = new ComparatorCost();

            int result = comparator.Compare(car1, car2);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Compare_BothCarsCostAreEqual()
        {
            Car car1 = new Car { Cost = 75 };
            Car car2 = new Car { Cost = 75 };
            ComparatorCost comparator = new ComparatorCost();

            int result = comparator.Compare(car1, car2);

            Assert.AreEqual(0, result);
        }
    }
}