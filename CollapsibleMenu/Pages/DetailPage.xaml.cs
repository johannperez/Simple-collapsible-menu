﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CollapsibleMenu
{
	public partial class DetailPage : ContentPage
	{
		public DetailPage()
		{
			InitializeComponent();
		}

		public DetailPage(String id)
		{
			InitializeComponent();
			IdLabel.Text = id;
		}
	}
}
