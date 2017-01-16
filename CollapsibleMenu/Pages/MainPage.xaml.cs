using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CollapsibleMenu
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
			this.Detail = new NavigationPage(new DetailPage());
			this.Master = new MenuPage(this);
		}
	}
}
