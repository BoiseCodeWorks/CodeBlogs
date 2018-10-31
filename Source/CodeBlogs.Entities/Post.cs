using System;
using System.Collections.Generic;

namespace CodeBlogs.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
