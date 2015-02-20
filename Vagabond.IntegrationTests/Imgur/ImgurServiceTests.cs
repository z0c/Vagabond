using System;
using System.Linq;
using NUnit.Framework;
using Vagabond.Imgur;

namespace Vagabond.IntegrationTests.Imgur
{
    [TestFixture]
    public class ImgurServiceTests
    {
        [TestCase("zbMI6")]
        public void WhenGetAlbumImagesHasImages(string albumId)
        {
            var underTest = new ImgurService();

            var actual = underTest.GetAlbumImages(albumId);

            Assert.That(actual.Count(), Is.GreaterThan(0));

            foreach (var i in actual)
            {
                Console.WriteLine(i);
            }
        }
    }
}
