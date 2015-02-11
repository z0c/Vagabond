using System;
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

        [TestCase("lowpoly")]
        public void WhenGetPostsThenPostHasDomain(string subRedit)
        {
            var underTest = new PostReader();

            var actual = underTest.GetPosts(subRedit);

            foreach (var p in actual)
            {
                Console.WriteLine(p.Domain);
                Assert.That(string.IsNullOrEmpty(p.Domain), Is.Not.True);
            }
        }

        [TestCase("lowpoly")]
        public void WhenGetPostsThenPostHasTitle(string subRedit)
        {
            var underTest = new PostReader();

            var actual = underTest.GetPosts(subRedit);

            foreach (var p in actual)
            {
                Console.WriteLine(p.Title);
                Assert.That(string.IsNullOrEmpty(p.Title), Is.Not.True);
            }
        }

        [TestCase("lowpoly")]
        public void WhenGetPostsThenPostHasScore(string subRedit)
        {
            var underTest = new PostReader();

            var actual = underTest.GetPosts(subRedit);

            foreach (var p in actual)
            {
                Console.WriteLine(p.Score);
                Assert.That(p.Score, Is.Not.True);
            }
        }

        [TestCase("lowpoly")]
        public void WhenGetPostsThenPostHasId(string subRedit)
        {
            var underTest = new PostReader();

            var actual = underTest.GetPosts(subRedit);

            foreach (var p in actual)
            {
                Console.WriteLine(p.Id);
                Assert.That(string.IsNullOrEmpty(p.Id), Is.Not.True);
            }
        }

        [TestCase("lowpoly")]
        public void WhenGetPostsThenPostHasUrl(string subRedit)
        {
            var underTest = new PostReader();

            var actual = underTest.GetPosts(subRedit);

            foreach (var p in actual)
            {
                Console.WriteLine(p.Url);
                Assert.That(string.IsNullOrEmpty(p.Url), Is.Not.True);
            }
        }

        [TestCase("lowpoly")]
        public void WhenGetPostsThenPostHasCreated(string subRedit)
        {
            var underTest = new PostReader();

            var actual = underTest.GetPosts(subRedit);

            foreach (var p in actual)
            {
                Console.WriteLine(p.CreatedDateTime);
                Assert.That(p.CreatedDateTime, Is.Not.Null);
            }
        }
    }
}
