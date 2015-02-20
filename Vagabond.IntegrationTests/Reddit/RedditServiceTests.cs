using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Vagabond.Reddit;

namespace Vagabond.IntegrationTests.Reddit
{
    [TestFixture]
    public class RedditServiceTests
    {
        [TestCase("lowpoly")]
        public void WhenGetPostsThenListOfPostsIsReturned(string subRedit)
        {
            var underTest = new RedditService();

            var actual = underTest.GetPosts(subRedit);

            Assert.That(actual, Is.InstanceOf<IEnumerable<Post>>());
        }

        [TestCase("lowpoly")]
        public void WhenGetPostsThenPostHasDomain(string subRedit)
        {
            var underTest = new RedditService();

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
            var underTest = new RedditService();

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
            var underTest = new RedditService();

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
            var underTest = new RedditService();

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
            var underTest = new RedditService();

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
            var underTest = new RedditService();

            var actual = underTest.GetPosts(subRedit);

            foreach (var p in actual)
            {
                Console.WriteLine(p.CreatedDateTime);
                Assert.That(p.CreatedDateTime, Is.Not.Null);
            }
        }

        [TestCase("gonewild")]
        public void WhenGetPostsHasImgurAlbum(string subRedit)
        {
            var underTest = new RedditService();

            var actual = underTest.GetImgurAlbumsOrderedByScore(subRedit).ToList();

            foreach (var p in actual)
            {
                Console.WriteLine(p.Score + ": " + p.Title + " -> " + p.Url);
                StringAssert.StartsWith("http://imgur.com/a/", p.Url);
            }

            Assert.That(actual.Count(), Is.GreaterThan(0));
        }
    }
}
