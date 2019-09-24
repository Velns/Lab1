﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.Data_user_cars
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class Data_user_cars { }
#else

	public class Data_user_cars : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public Data_user_cars()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/Lab1_ppp.Screens;component/SampleData/Data_user_cars/Data_user_cars.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private ItemCollection _Collection = new ItemCollection();

		public ItemCollection Collection
		{
			get
			{
				return this._Collection;
			}
		}
	}

	public class Item : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Number = string.Empty;

		public string Number
		{
			get
			{
				return this._Number;
			}

			set
			{
				if (this._Number != value)
				{
					this._Number = value;
					this.OnPropertyChanged("Number");
				}
			}
		}

		private double _Price = 0;

		public double Price
		{
			get
			{
				return this._Price;
			}

			set
			{
				if (this._Price != value)
				{
					this._Price = value;
					this.OnPropertyChanged("Price");
				}
			}
		}

		private string _Model = string.Empty;

		public string Model
		{
			get
			{
				return this._Model;
			}

			set
			{
				if (this._Model != value)
				{
					this._Model = value;
					this.OnPropertyChanged("Model");
				}
			}
		}

		private string _Color = string.Empty;

		public string Color
		{
			get
			{
				return this._Color;
			}

			set
			{
				if (this._Color != value)
				{
					this._Color = value;
					this.OnPropertyChanged("Color");
				}
			}
		}
	}

	public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
	{ 
	}
#endif
}
