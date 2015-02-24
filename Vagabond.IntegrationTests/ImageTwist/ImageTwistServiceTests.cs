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

        [TestCase("test", "http://test.com")]
        public void UploadImagesToFolder(string folderName, string imageUrl)
        {
            var underTest = new ImageTwistService();

            underTest.UploadUrlsToFolder(folderName, new List<string> { imageUrl });
        }
    }
}
