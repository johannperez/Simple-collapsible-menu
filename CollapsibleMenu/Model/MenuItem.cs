using System;
using System.ComponentModel;

namespace CollapsibleMenu
{
	public class MenuItem : INotifyPropertyChanged
	{
		private string icon;
		private string name;
		private bool collapsed;

		public event PropertyChangedEventHandler PropertyChanged;

		public string Id { get; set; }

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
			}
		}

		public string Icon
		{ 
			get
			{
				return icon;
			}
			set
			{
				icon = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icon"));
			}
		}

		public bool Collapsed
		{
			get
			{
				return collapsed;
			}
			set
			{
				collapsed = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Collapsed"));
			}
		}

		public bool InnerItem { get; set; }

	}
}
