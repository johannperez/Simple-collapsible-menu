using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CollapsibleMenu
{
	public partial class MenuPage : ContentPage
	{
		private MenuViewModel viewModel;

		public MenuPage()
		{
			InitializeComponent();
			viewModel = new MenuViewModel();
			BindingContext = viewModel;
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				viewModel.ItemSelected(e.SelectedItem as MenuItem);
				Menu.SelectedItem = null;
			}
		}
	}
}
