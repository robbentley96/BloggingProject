using System;
using EFGetStarted;

namespace CodeFirstLab
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new BloggingContext())
			{
				//Create

				var newUser = new User { Name = "Martin Beard" };
				var newBlog = new Blog { Url = "www.spartaglobal.com", User = newUser };
				var newPost = new Post { Blog = newBlog, Content = "Hey Eng73" };

				db.Users.Add(newUser);
				db.Blogs.Add(newBlog);
				db.Posts.Add(newPost);
			}
		}
	}

	


}
