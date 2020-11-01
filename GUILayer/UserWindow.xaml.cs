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
using Microsoft.IdentityModel.Protocols;
using CodeFirstLab;

namespace GUILayer
{
	/// <summary>
	/// Interaction logic for UserWindow.xaml
	/// </summary>
	/// 
	
	public partial class UserWindow : Window
	{
		BloggingMethods bM = new BloggingMethods();

		public UserWindow()
		{
			InitializeComponent();
			UserGrid.Visibility = Visibility.Visible;
			//BlogGrid.Visibility = Visibility.Hidden;
			UserList.ItemsSource = bM.RetrieveUsers();
		}

		private void HomeButtonClick(object sender, RoutedEventArgs e)
		{
			var homeWindow = new MainWindow();
			homeWindow.Show();
			this.Close();
		}

		private void NewUserButtonClick(object sender, RoutedEventArgs e)
		{
			if (UserName.Text != "")
			{
				bM.CreateUser(UserName.Text);
				UserName.Text = "";
				UserList.ItemsSource = bM.RetrieveUsers();
			}
			
		}

		private void DeleteUserButtonClick(object sender, RoutedEventArgs e)
		{
			if (UserList.SelectedItem != null)
			{
				int selectedUserId = bM.RetrieveUser(UserList.SelectedItem.ToString());
				bM.DeleteUser(selectedUserId);
				UserList.ItemsSource = bM.RetrieveUsers();
				UserName.Text = "";
			}
			
		}

		private void UserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (UserList.SelectedItem != null)
			{
				UserName.Text = UserList.SelectedItem.ToString();
			}
			
		}

		private void UpdateUserButtonClick(object sender, RoutedEventArgs e)
		{
			if (UserList.SelectedItem != null && UserName.Text != "")
			{
				int selectedUserId = bM.RetrieveUser(UserList.SelectedItem.ToString());
				bM.UpdateUser(selectedUserId, UserName.Text);
				UserName.Text = "";
				UserList.ItemsSource = bM.RetrieveUsers();
			}
			
		}

		private void ViewBlogsButtonClick(object sender, RoutedEventArgs e)
		{
			if (UserList.SelectedItem != null)
			{
				int selectedUserId = bM.RetrieveUser(UserList.SelectedItem.ToString());
				var blogWindow = new BlogWindow(selectedUserId);
				blogWindow.Show();
				this.Close();
			}
			

		}

		private void ViewPetsButtonClick(object sender, RoutedEventArgs e)
		{
			if (UserList.SelectedItem != null)
			{
				int selectedUserId = bM.RetrieveUser(UserList.SelectedItem.ToString());
				var petWindow = new PetWindow(selectedUserId);
				petWindow.Show();
				this.Close();
			}
			

		}
	}
}
