using NUnit.Framework;
using Groups.Implementations;

namespace Groups.Tests 
{
    public class GroupEntityTests
    {
        [Test]
        public void AddStudentToGroup_ShouldIncreaseStudentCount()
        {
            var group = new GroupEntity("GroupA");
            var student = new StudentEntity { Name = "John", Age = 20 };

            group.AddStudent(student);

            Assert.AreEqual(1, group.Students.Count);
            Assert.IsTrue(group.Students.Contains(student));
        }
    }
}