using System.Collections.Generic;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Blogging;");
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public User User { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
        public override string ToString()
        {
            return Url;
        }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }

    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; } = new List<Blog>();
        public List<Pet> Pets { get; set; } = new List<Pet>();
		public override string ToString()
		{
            return Name;
		}
	}

    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public User User { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
	

