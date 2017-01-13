using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CollapsibleMenu
{
	public class MenuViewModel : INotifyPropertyChanged
	{
		private List<MenuItem> menuItems = new List<MenuItem>();

		public ObservableCollection<MenuItem> VisibleMenuItems { get; set; } = new ObservableCollection<MenuItem>();

		public delegate void NavigateTo(string page);

		public event PropertyChangedEventHandler PropertyChanged;
		public event NavigateTo Navigate;

		public MenuViewModel()
		{
			menuItems.Add(new MenuItem() { Collapsed = true, Id = "1", InnerItem = false, Name = "Menu #1" });
			menuItems.Add(new MenuItem() { Collapsed = true, Id = "1.1", InnerItem = true, Name = "Menu #1.1" });
			menuItems.Add(new MenuItem() { Collapsed = true, Id = "1.2", InnerItem = true, Name = "Menu #1.2" });
			menuItems.Add(new MenuItem() { Collapsed = true, Id = "2", InnerItem = false, Name = "Menu #2" });
			menuItems.Add(new MenuItem() { Collapsed = true, Id = "2.1", InnerItem = true, Name = "Menu #2.1" });
			menuItems.Add(new MenuItem() { Collapsed = true, Id = "2.2", InnerItem = true, Name = "Menu #2.2" });
			menuItems.Add(new MenuItem() { Collapsed = true, Id = "3", InnerItem = false, Name = "Menu #3" });

			LoadVisibleItems();
		}

		internal void ItemSelected(MenuItem menuItem)
		{
			if (menuItem.InnerItem)
				Navigate?.Invoke(menuItem.Id);
			else
			{
				int addOrRemoveIndex = VisibleMenuItems.IndexOf(menuItem) + 1;
				int allItemsIndex = menuItems.IndexOf(menuItem);

				if (menuItem.Collapsed)
				{
					allItemsIndex++;
					while (allItemsIndex < menuItems.Count && menuItems[allItemsIndex].InnerItem)
					{
						VisibleMenuItems.Insert(addOrRemoveIndex, menuItems[allItemsIndex]);
						allItemsIndex++;
						addOrRemoveIndex++;
					}
				}
				else
				{
					allItemsIndex++;
					while (allItemsIndex < menuItems.Count && menuItems[allItemsIndex].InnerItem)
					{
						VisibleMenuItems.Remove(menuItems[allItemsIndex]);
						allItemsIndex++;
					}
				}

				menuItem.Collapsed = !menuItem.Collapsed;
			}
		}

		/// <summary>
		/// Loads Visibile Menu Items with all visible menu items
		/// </summary>
		void LoadVisibleItems()
		{
			var collapsed = false;

			foreach (var item in menuItems)
			{
				if (item.InnerItem)
				{
					if (!collapsed)
					{
						VisibleMenuItems.Add(item);
					}
				}
				else
				{
					collapsed = item.Collapsed;
					VisibleMenuItems.Add(item);
				}

			}
		}
	}
}
