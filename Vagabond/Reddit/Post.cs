using System;
using Newtonsoft.Json;
using Vagabond.JsonConverters;

namespace Vagabond.Reddit
{
    public class Post
    {
        public string Id { get; set; }
        public string Domain { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int Score { get; set; }
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime CreatedDateTime { get; set; }
        
        public bool IsImgurAlbum { get { return Url.StartsWith("http://imgur.com/a/"); } }
    }
}
