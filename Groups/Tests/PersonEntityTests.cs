namespace Groups.Tests
{
    [TestFixture]
    public class PersonEntityTests
    {
        [Test]
        public void CreatePerson_ShouldInitializeNameAndAge()
        {
            var person = new PersonEntity { Name = "Alice", Age = 25 };

            Assert.AreEqual("Alice", person.Name);
            Assert.AreEqual(25, person.Age);
        }
    }
}