using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CollapsibleMenu
{
	public partial class MenuPage : ContentPage
	{
		private MenuViewModel viewModel;

		private MasterDetailPage masterDetailPage;

		public MenuPage(MasterDetailPage masterDetailPage)
		{
			InitializeComponent();
			this.masterDetailPage = masterDetailPage;

			viewModel = new MenuViewModel();
			viewModel.Navigate += (obj) =>
			{
				this.masterDetailPage.Detail = new NavigationPage(new DetailPage(obj));
				this.masterDetailPage.IsPresented = false;
			};
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
