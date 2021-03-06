﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Vagabond.Reddit
{
    public class RedditService
    {
        private const string SubReditUrl = "http://www.reddit.com/r/{0}.json";

        public IEnumerable<Post> GetPosts(string subRedit)
        {
            var client = new WebClient();
            var response = client.DownloadString(string.Format(SubReditUrl, subRedit));
            var json = JObject.Parse(response);
            return json["data"]["children"]
                   .Select(p => p["data"]
                   .ToObject<Post>());
        }

        public IEnumerable<Post> GetImgurAlbumsOrderedByScore(string subredit)
        {
            return GetPosts(subredit)
                   .Where(p => p.IsImgurAlbum)
                   .OrderByDescending(p => p.Score);
        }
    }
}
