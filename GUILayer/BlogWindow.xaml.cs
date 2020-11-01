using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CodeFirstLab;

namespace GUILayer
{
	/// <summary>
	/// Interaction logic for BlogWindow.xaml
	/// </summary>
	public partial class BlogWindow : Window
	{

		BloggingMethods bM = new BloggingMethods();
		public BlogWindow(int userId)
		{
			InitializeComponent();
			bM.SelectedUser = userId;
			BlogList.ItemsSource = bM.RetrieveBlogs(bM.SelectedUser);
		}

		private void HomeButtonClick(object sender, RoutedEventArgs e)
		{
			var homeWindow = new MainWindow();
			homeWindow.Show();
			this.Close();
		}

		private void NewBlogButtonClick(object sender, RoutedEventArgs e)
		{
			if (BlogUrl.Text != "")
			{
				bM.CreateBlog(bM.SelectedUser, BlogUrl.Text);
				BlogUrl.Text = "";
				BlogList.ItemsSource = bM.RetrieveBlogs(bM.SelectedUser);
			}
			
		}

		private void DeleteBlogButtonClick(object sender, RoutedEventArgs e)
		{
			if (BlogList.SelectedItem != null)
			{
				int selectedBlogId = bM.RetrieveBlog(bM.SelectedUser, BlogList.SelectedItem.ToString());
				bM.DeleteBlog(selectedBlogId);
				BlogList.ItemsSource = bM.RetrieveBlogs(bM.SelectedUser);
				BlogUrl.Text = "";
			}
			
		}

		private void UpdateBlogButtonClick(object sender, RoutedEventArgs e)
		{
			if (BlogList.SelectedItem != null && BlogUrl.Text != "")
			{
				int selectedBlogId = bM.RetrieveBlog(bM.SelectedUser, BlogList.SelectedItem.ToString());
				bM.UpdateBlog(selectedBlogId, BlogUrl.Text); ;
				BlogUrl.Text = "";
				BlogList.ItemsSource = bM.RetrieveBlogs(bM.SelectedUser);
			}
			
		}

		private void ViewPostsButtonClick(object sender, RoutedEventArgs e)
		{
			if (BlogList.SelectedItem != null)
			{
				int selectedBlogId = bM.RetrieveBlog(bM.SelectedUser, BlogList.SelectedItem.ToString());
				var postsWindow = new PostWindow(selectedBlogId);
				postsWindow.Show();
				this.Close();
			}
			
		}

		private void BlogList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (BlogList.SelectedItem != null)
			{
				BlogUrl.Text = BlogList.SelectedItem.ToString();
			}
		}
	}
}
