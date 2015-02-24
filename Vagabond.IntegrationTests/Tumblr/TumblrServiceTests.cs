using NUnit.Framework;
using Vagabond.Tumblr;

namespace Vagabond.IntegrationTests.Tumblr
{
    [TestFixture]
    public class TumblrServiceTests
    {
        [Test]
        public void SubmitPostReturnsOk()
        {
            var underTest = new TumblrService();

            underTest.SubmitPost("title", "body");
        }
    }
}
