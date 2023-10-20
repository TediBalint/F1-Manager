using F1_Manager.Managers;
using F1_Manager.Stores;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace F1_Manager.Viewmodels
{
	
	public class MainViewModel : ViewModelBase
	{
		private readonly NavigationStore _navigationStore;

		public CreateCarManager createCarManager;
		public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

		public MainViewModel(NavigationStore navigationstore) 
		{
			_navigationStore = navigationstore;
			_navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;	
		}

		private void OnCurrentViewModelChanged()
		{
			OnPropertyChanged(nameof(CurrentViewModel));
			if (_navigationStore.CurrentViewModel.GetType() == typeof(PlayViewModel))
			{
				createCarManager = new CreateCarManager();
				Debug.WriteLine("Created Car manager");
			}
		}	
	}
}
