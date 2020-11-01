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
	/// Interaction logic for PetWindow.xaml
	/// </summary>
	public partial class PetWindow : Window
	{
		BloggingMethods bM = new BloggingMethods();
		public PetWindow(int userId)
		{
			InitializeComponent();
			bM.SelectedUser = userId;
			PetList.ItemsSource = bM.RetrievePets(bM.SelectedUser);
		}

		private void HomeButtonClick(object sender, RoutedEventArgs e)
		{
			var homeWindow = new MainWindow();
			homeWindow.Show();
			this.Close();
		}

		private void NewPetButtonClick(object sender, RoutedEventArgs e)
		{
			if (PetName.Text != "")
			{
				bM.CreatePet(bM.SelectedUser, PetName.Text,PetSpecies.Text);
				PetName.Text = "";
				PetSpecies.Text = "";
				PetList.ItemsSource = bM.RetrievePets(bM.SelectedUser);
			}
			
		}

		private void DeletePetButtonClick(object sender, RoutedEventArgs e)
		{
			if (PetList.SelectedItem != null)
			{
				int selectedPetId = bM.RetrievePet(bM.SelectedUser, PetList.SelectedItem.ToString());
				bM.DeletePet(selectedPetId);
				PetList.ItemsSource = bM.RetrievePets(bM.SelectedUser);
				PetName.Text = "";
				PetSpecies.Text = "";
			}
			
		}

		private void UpdatePetButtonClick(object sender, RoutedEventArgs e)
		{
			if (PetList.SelectedItem != null && PetName.Text != "")
			{
				int selectedPetId = bM.RetrievePet(bM.SelectedUser, PetList.SelectedItem.ToString());
				bM.UpdatePet(selectedPetId, PetName.Text,PetSpecies.Text); ;
				PetName.Text = "";
				PetSpecies.Text = "";
				PetList.ItemsSource = bM.RetrievePets(bM.SelectedUser);
			}
		}

		private void PetList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (PetList.SelectedItem != null)
			{
				PetName.Text = PetList.SelectedItem.ToString();
				int selectedPetId = bM.RetrievePet(bM.SelectedUser, PetList.SelectedItem.ToString());
				PetSpecies.Text = bM.RetrievePetSpecies(selectedPetId);
			}
		}
	}
}
