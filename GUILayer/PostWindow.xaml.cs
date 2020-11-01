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
	/// Interaction logic for PostWindow.xaml
	/// </summary>
	public partial class PostWindow : Window
	{
		BloggingMethods bM = new BloggingMethods();
		public PostWindow(int blogId)
		{
			InitializeComponent();
			bM.SelectedBlog = blogId;
			PostList.ItemsSource = bM.RetrievePosts(bM.SelectedBlog);
		}

		private void HomeButtonClick(object sender, RoutedEventArgs e)
		{
			var homeWindow = new MainWindow();
			homeWindow.Show();
			this.Close();
		}

		private void NewPostButtonClick(object sender, RoutedEventArgs e)
		{
			if (PostTitle.Text != "")
			{
				bM.CreatePost(bM.SelectedBlog, PostTitle.Text);
				PostTitle.Text = "";
				PostList.ItemsSource = bM.RetrievePosts(bM.SelectedBlog);
			}
			
		}

		private void DeletePostButtonClick(object sender, RoutedEventArgs e)
		{
			if (PostList.SelectedItem != null)
			{
				int selectedPostId = bM.RetrievePost(bM.SelectedBlog, PostList.SelectedItem.ToString());
				bM.DeletePost(selectedPostId);
				PostList.ItemsSource = bM.RetrievePosts(bM.SelectedBlog);
				PostTitle.Text = "";
				PostContent.Text = "";
			}
			
		}

		private void UpdatePostButtonClick(object sender, RoutedEventArgs e)
		{
			if (PostList.SelectedItem != null && PostTitle.Text != "")
			{
				int selectedPostId = bM.RetrievePost(bM.SelectedBlog, PostList.SelectedItem.ToString());
				bM.UpdatePost(selectedPostId, PostTitle.Text, PostContent.Text); ;
				PostTitle.Text = "";
				PostContent.Text = "";
				PostList.ItemsSource = bM.RetrievePosts(bM.SelectedBlog);
			}
		}

		private void PostList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (PostList.SelectedItem != null)
			{
				PostTitle.Text = PostList.SelectedItem.ToString();
				int selectedPostId = bM.RetrievePost(bM.SelectedBlog, PostList.SelectedItem.ToString());
				PostContent.Text = bM.RetrievePostContent(selectedPostId);
			}
		}
	}
}
