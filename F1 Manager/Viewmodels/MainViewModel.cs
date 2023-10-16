using F1_Manager.Stores;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace F1_Manager.Viewmodels
{
	
	public class MainViewModel : ViewModelBase
	{
		private readonly NavigationStore _navigationStore;

		
		public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

		public MainViewModel(NavigationStore navigationstore) 
		{
			_navigationStore = navigationstore;
			_navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

		}

		private void OnCurrentViewModelChanged()
		{
			OnPropertyChanged(nameof(CurrentViewModel));
		}

	}
}
