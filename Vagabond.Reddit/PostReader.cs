using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Vagabond.Reddit
{
    public class PostReader
    {
        private const string SubReditUrl = "http://reddit.com/r/{0}.json";

        public IEnumerable<Post> GetPosts(string subRedit)
        {
            var client = new WebClient();
            var response = client.DownloadString(
                string.Format(
                    SubReditUrl,
                    subRedit));
            var json = JObject.Parse(response);
            return json["data"]["children"].Select(p => p.ToObject<Post>());
        }
    }
}
