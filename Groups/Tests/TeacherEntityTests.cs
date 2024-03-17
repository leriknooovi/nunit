using NUnit.Framework;
using Groups.Implementations;

namespace Groups.Tests
{
    [TestFixture]
    public class TeacherEntityTests
    {
        [Test]
        public void CreateTeacher_ShouldInitializeNameAgeAndDepartment()
        {
            var teacher = new TeacherEntity { Name = "Brown", Age = 40, Department = "Science" };

            Assert.AreEqual("Brown", teacher.Name);
            Assert.AreEqual(40, teacher.Age);
            Assert.AreEqual("Science", teacher.Department);
        }
    }
}