using CodeBlogs.Data;
using CodeBlogs.Entities;
using System;
using System.Threading.Tasks;

namespace CodeBlogs.Business
{
    public class BlogService
    {
        private readonly BlogContext _ctx;

        public BlogService(BlogContext ctx)
        {
            _ctx = ctx;
        }


        public Post CreatePost(Post postData)
        {
            _ctx.Posts.Add(postData);
            try
            {
                var result = _ctx.SaveChangesAsync().Result;
                return postData;
            }
            catch (Exception e)
            {
                //private log e
                Console.Write(e.Message);
                throw new Exception("No Go");
            }
        }

    }
}
