using System.Collections.Generic;
using NUnit.Framework;
using Vagabond.ImageTwist;

namespace Vagabond.IntegrationTests.ImageTwist
{
    [TestFixture]
    public class ImageTwistServiceTests
    {
        [Test]
        public void GetFoldersReturnsListOfFolders()
        {
            var underTest = new ImageTwistService();

            var actual = underTest.GetFolders();

            Assert.That(actual, Is.InstanceOf<IEnumerable<string>>());
        }

        [TestCase("test")]
        public void UploadFolderCreatesNewFolder(string name)
        {
            var underTest = new ImageTwistService();

            underTest.CreateFolder(name);
        }
    }
}
