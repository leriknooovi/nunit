using NUnit.Framework;
using Groups.Implementations;

namespace Groups.Tests
{
    [TestFixture]
    public class StudentEntityTests
    {
        [Test]
        public void CreateStudent_ShouldInitializeNameAgeAndStudentID()
        {
            var student = new StudentEntity { Name = "Emma", Age = 22, StudentID = 123 };

            Assert.AreEqual("Emma", student.Name);
            Assert.AreEqual(22, student.Age);
            Assert.AreEqual(123, student.StudentID);
        }
    }
}
