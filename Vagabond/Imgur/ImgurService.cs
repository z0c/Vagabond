using System.Collections.Generic;
using System.Linq;

namespace Vagabond.Imgur
{
    public class ImgurService
    {
        public IEnumerable<string> GetAlbumImages(string albumId)
        {
            var auth = new ImgurNet.Authentication.ClientAuthentication("somecrap", true);
            var i = new ImgurNet.Imgur(auth);
            var a = new ImgurNet.ApiEndpoints.AlbumEndpoint(i);
            var r = a.GetAllImagesFromAlbumAsync(albumId).Result;
            return r.Data.Select(image => image.Link);
        }
    }
}
