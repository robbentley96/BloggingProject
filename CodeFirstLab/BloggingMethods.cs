using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using EFGetStarted;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstLab
{
	public class BloggingMethods
	{
		public int SelectedUser { get; set; }
		public int SelectedBlog { get; set; }
		public int SelectedPet { get; set; }
		public int SelectedPost { get; set; }


		

		//User------------------------------------------

		//			Create

		public void CreateUser(string userName)
		{
			using (var db = new BloggingContext())
			{
				var newUser = new User() { Name = userName };
				db.Users.Add(newUser);
				db.SaveChanges();
			}
		}

		//			Read


		public List<User> RetrieveUsers()
		{
			using (var db = new BloggingContext())
			{
				List<User> userList = db.Users.ToList();
				return userList;
			}
		}

		public int RetrieveUser(string userName)
		{
			using (var db = new BloggingContext())
			{
				var selectedUser = db.Users.Where(u => u.Name == userName).FirstOrDefault();
				return selectedUser.UserId;
			}
		}

		//			Update

		public void UpdateUser(int userId, string userName)
		{
			using (var db = new BloggingContext())
			{
				var selectedUser = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
				selectedUser.Name = userName;
				db.SaveChanges();
			}
		}

		//			Delete

		public void DeleteUser(int userId)
		{
			using (var db = new BloggingContext())
			{
				var blogsToDelete = RetrieveBlogs(userId);
				foreach (var blog in blogsToDelete)
				{
					DeleteBlog(blog.BlogId);
				}
				var petsToDelete = RetrievePets(userId);
				foreach (var pet in petsToDelete)
				{
					DeletePet(pet.PetId);
				}
				var selectedUser = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
				db.Users.Remove(selectedUser);
				db.SaveChanges();
			}
		}

		//Blog-------------------------------------------

		//			Create

		public void CreateBlog(int userId, string blogUrl)
		{
			using (var db = new BloggingContext())
			{
				var selectedUser = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
				Blog newBlog = new Blog()
				{
					User = selectedUser,
					Url = blogUrl
				};
				db.Blogs.Add(newBlog);
				db.SaveChanges();
			}
		}

		//			Read

		public List<Blog> RetrieveBlogs(int userId)
		{
			using (var db = new BloggingContext())
			{
				List<Blog> blogs = db.Blogs.Include(u => u.User).Where(u => u.User.UserId == userId).ToList();
				
				return blogs;
			}
		}

		public int RetrieveBlog(int userId, string url)
		{
			using (var db = new BloggingContext())
			{
				var selectedBlog = db.Blogs.Include(u => u.User).Where(b => b.Url == url && b.User.UserId == userId).FirstOrDefault();
				return selectedBlog.BlogId;
			}
		}

		//			Update

		public void UpdateBlog(int blogId, string blogUrl)
		{
			using (var db = new BloggingContext())
			{
				var selectedBlog = db.Blogs.Where(b => b.BlogId == blogId).FirstOrDefault();
				selectedBlog.Url = blogUrl;
				db.SaveChanges();
			}
		}

		//			Delete

		public void DeleteBlog(int blogId)
		{
			using (var db = new BloggingContext())
			{
				var postsToDelete = RetrievePosts(blogId);
				foreach (var post in postsToDelete)
				{
					DeletePost(post.PostId);
				}
				var selectedBlog = db.Blogs.Where(b => b.BlogId == blogId).FirstOrDefault();
				db.Blogs.Remove(selectedBlog);
				db.SaveChanges();
			}
		}

		//Post------------------------------------------

		//			Create

		public void CreatePost(int blogId, string postName)
		{
			using (var db = new BloggingContext())
			{
				var selectedBlog = db.Blogs.Where(b => b.BlogId == blogId).FirstOrDefault();
				Post newPost = new Post()
				{
					Blog = selectedBlog,
					Title = postName
				};
				db.Posts.Add(newPost);
				db.SaveChanges();
			}
		}

		//			Read

		public List<Post> RetrievePosts(int blogId)
		{
			using (var db = new BloggingContext())
			{
				var posts = db.Posts.Include(b => b.Blog).Where(b => b.Blog.BlogId == blogId);
				return posts.ToList();
			}
		}

		public int RetrievePost(int blogId, string title)
		{
			using (var db = new BloggingContext())
			{
				var selectedPost = db.Posts.Include(b => b.Blog).Where(p => p.Title == title && p.Blog.BlogId == blogId).FirstOrDefault();
				return selectedPost.PostId;
			}
		}

		public string RetrievePostContent(int postId)
		{
			using (var db = new BloggingContext())
			{
				var content = db.Posts.Where(p => p.PostId == postId).FirstOrDefault().Content;
				return content;
			}
		}

		//			Update

		public void UpdatePost(int postId, string postName, string postContent)
		{
			using (var db = new BloggingContext())
			{
				var selectedPost = db.Posts.Where(p => p.PostId == postId).FirstOrDefault();
				selectedPost.Title = postName;
				selectedPost.Content = postContent;
				db.SaveChanges();
			}
		}

		//			Delete

		public void DeletePost(int postId)
		{
			using (var db = new BloggingContext())
			{
				var selectedPost = db.Posts.Where(p => p.PostId == postId).FirstOrDefault();
				db.Posts.Remove(selectedPost);
				db.SaveChanges();
			}
		}

		//Pet--------------------------------------------

		//			Create

		public void CreatePet(int userId, string petName, string species)
		{
			using (var db = new BloggingContext())
			{
				var selectedUser = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
				Pet newPet = new Pet()
				{
					User = selectedUser,
					Name = petName,
					Species = species
				};
				db.Pets.Add(newPet);
				db.SaveChanges();
			}
		}

		//			Read

		public List<Pet> RetrievePets(int userId)
		{
			using (var db = new BloggingContext())
			{
				var pets = db.Pets.Include(u => u.User).Where(u => u.User.UserId == userId);
				return pets.ToList();
			}
		}

		public int RetrievePet(int userId, string name)
		{
			using (var db = new BloggingContext())
			{
				var selectedPet = db.Pets.Include(u => u.User).Where(p => p.Name == name && p.User.UserId == userId).FirstOrDefault();
				return selectedPet.PetId;
			}
		}

		public string RetrievePetSpecies(int petId)
		{
			using (var db = new BloggingContext())
			{
				var species = db.Pets.Where(p => p.PetId == petId).FirstOrDefault().Species;
				return species;
			}
		}


		//			Update

		public void UpdatePet(int petId, string petName, string petSpecies)
		{
			using (var db = new BloggingContext())
			{
				var selectedPet = db.Pets.Where(p => p.PetId == petId).FirstOrDefault();
				selectedPet.Name = petName;
				selectedPet.Species = petSpecies;
				db.SaveChanges();
			}
		}

		//			Delete

		public void DeletePet(int petId)
		{
			using (var db = new BloggingContext())
			{
				var selectedPet = db.Pets.Where(p => p.PetId == petId).FirstOrDefault();
				db.Pets.Remove(selectedPet);
				db.SaveChanges();
			}
		}
	}	
}
