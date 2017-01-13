using System;
using Xamarin.Forms;

namespace CollapsibleMenu
{
	public class MenuItemCellTemplateSelector:Xamarin.Forms.DataTemplateSelector
	{
		private readonly DataTemplate CollapsibleMenuItemTemplate;
		private readonly DataTemplate InnerMenuItemTemplate;

		public MenuItemCellTemplateSelector()
		{
			CollapsibleMenuItemTemplate = new DataTemplate(typeof(CollapsibleMenuItem));
			InnerMenuItemTemplate = new DataTemplate(typeof(InnerMenuItem));
		}

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			MenuItem menuItem = item as MenuItem;
			if (menuItem.InnerItem)
				return InnerMenuItemTemplate;
			else
				return CollapsibleMenuItemTemplate;
		}
	}
}
