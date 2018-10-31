using CodeBlogs.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CodeBlogs.Data
{
    public class BlogContext : DbContext
    {

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                Data Source=(localdb)\mssqllocaldb;
                Initial Catalog=CodeBlog;
                Integrated Security=True");
        }

    }
}
