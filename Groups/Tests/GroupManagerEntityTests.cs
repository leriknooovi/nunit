using NUnit.Framework;
using Groups.Implementations;

namespace Groups.Tests 
{
    [TestFixture]
    public class GroupManagerEntityTests
    {
        [Test]
        public void AddGroup_ShouldIncreaseGroupCount()
        {
            var groupManager = new GroupManagerEntity();
            var group = new GroupEntity("GroupA");

            groupManager.AddGroup(group);

            Assert.AreEqual(1, groupManager.Groups.Count);
            Assert.IsTrue(groupManager.Groups.Contains(group));
        }
    }
}