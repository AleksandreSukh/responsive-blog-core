using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEngine.Models
{
    public class PostPreviewModel
    {
        public string PostTitle { get; set; }
        public string PostSubtitle { get; set; }
        public string PostMeta { get; set; }
    }

    public class PostModel : PostPreviewModel
    {
        public string PostBody { get; set; }
    }

    /// <summary>
    /// Fake data repository for testing purposes
    /// </summary>
    public static class DataRepository
    {
        static readonly List<PostModel> posts = new List<PostModel>();

        static DataRepository()
        {
            posts.Add(new PostModel()
            {
                PostTitle = "ცისფერი მთები",
                PostSubtitle = "ანუ დაუჯერებელი ამბავი",
                PostMeta = "Posted by somebody",
                PostBody = "ეს ამბავი დიდი ხნის წინ მოხდა. ლორემ იპსუმ დოლორ.."
            });
            posts.Add(new PostModel()
            {
                PostTitle = "კაპიტანი ტახმაგიდო",
                PostSubtitle = "ანუ დაუჯერებელი ამბავი",
                PostMeta = "Posted by somebody",
                PostBody = "ეს ამბავი დიდი ხნის წინ მოხდა. ლორემ იპსუმ დოლორ.."
            });
        }

        public static IQueryable<PostModel> GetAllPosts()
        {
            return posts.AsQueryable();
        }
    }
}
