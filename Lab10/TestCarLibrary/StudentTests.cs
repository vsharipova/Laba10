using CarLibrary;
namespace TestCarLibrary
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestConstructorWithParameters()
        {
            Student student = new Student("Олег", 20, 7);

            Assert.AreEqual("Олег", student.Name);
            Assert.AreEqual(20, student.Age);
            Assert.AreEqual(7, student.Gpa);
        }

        [TestMethod]
        public void TestConstructorNoParameters()
        {
            Student student = new Student();

            Assert.AreEqual("No Name", student.Name);
            Assert.AreEqual(0, student.Age);
            Assert.AreEqual(0, student.Gpa);
        }

        [TestMethod]
        public void TestOperatorInt()
        {
            Student student = new Student("Олег", 20, 7);

            int course = (int)student;
            Assert.AreEqual(3, course);
        }

        [TestMethod]
        public void TestOperatorIncrement()
        {
            Student student = new Student("Олег", 20, 7);
            student++;

            Assert.AreEqual(21, student.Age);
        }

        [TestMethod]
        public void TestImplicitConversionLowGpa()
        {
            Student student = new Student("Alice", 20, 2.5);
            bool result = student;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ExplicitConversion()
        {
            Student student = new Student("Алиса", 20, 3.8);
            int course = (int)student;
            Assert.AreEqual(3, course);
        }

        [TestMethod]
        public void IncrementAge_AgeIncremented()
        {
            Student student = new Student("Алиса", 19, 3.0);
            student++;

            Assert.AreEqual(20, student.Age);
        }

        [TestMethod]
        public void ModifyGpaBySubtraction()
        {
            Student student = new Student("Алиса", 21, 3.5);
            student = student - 1.5;

            Assert.AreEqual(2.0, student.Gpa);
        }

        [TestMethod]
        public void ModifyNameByModulus()
        {
            Student student = new Student("Алиса", 20, 3.5);
            student = student % "Алисия";

            Assert.AreEqual("Алисия", student.Name);
        }

        [TestMethod]
        public void Compare_StudentAGreaterThanStudentB()
        {
            Student studentA = new Student("Alice", 21, 4.0);
            Student studentB = new Student("Bob", 20, 3.5);
            bool result = studentA > studentB;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Compare_StudentAGreaterThanGpa()
        {
            Student studentA = new Student("Alice", 21, 4.0);
            bool result = studentA > 3.5;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CompareAgeStudent()
        {
            Student student1 = new Student();
            Student student2 = new Student();

            student1.Compare(student2);
            student2.Compare(student1);

            Student student3 = new Student("Иван", 21, 6);
            student1.Compare(student3);
            student3.Compare(student1);
        }


    }
}
