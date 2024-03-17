using NUnit.Framework;
using Groups.Implementations;

namespace Groups.Tests 
{
    [TestFixture]
    public class SubjectEntityTests
    {
        [Test]
        public void AddTeacherToSubject_ShouldIncreaseTeacherCount()
        {
            var subject = new SubjectEntity("Math");
            var teacher = new TeacherEntity { Name = "Smith", Age = 35 };

            subject.AddTeacher(teacher);

            Assert.AreEqual(1, subject.Teachers.Count);
            Assert.IsTrue(subject.Teachers.Contains(teacher));
        }
    }
}