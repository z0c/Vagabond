using System.Configuration;

namespace Vagabond.Configuration
{
    public static class Imgur
    {
        public static string ClientId { get { return ConfigurationManager.AppSettings["Vagabond.Imgur.ClientId"]; } }
        public static string ClientSecret { get { return ConfigurationManager.AppSettings["Vagabond.Imgur.ClientSecret"]; } }
    }
}
