using System.Collections.Generic;
using NUnit.Framework;

namespace Vagabond.Reddit.IntegrationTests
{
    [TestFixture]
    public class PostReaderTests
    {
        [TestCase("lowpoly")]
        public void WhenGetPostsThenListOfPostsIsReturned(string subRedit)
        {
            var underTest = new PostReader();

            var actual = underTest.GetPosts(subRedit);

            Assert.That(actual, Is.InstanceOf<IEnumerable<Post>>());
        }
    }
}
