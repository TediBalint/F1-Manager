using F1_Manager.Commands;
using F1_Manager.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace F1_Manager.Viewmodels
{
	public class CarViewModel: ViewModelBase
	{
		public string WelcomeMessage => "Car";
		public ICommand NavigateHomeCommand { get; }
		
		public CarViewModel(ISharedService sharedService) 
		{
			NavigateHomeCommand = new NavigateCommand<HomeViewModel>(sharedService, () => new HomeViewModel(sharedService)); 
		}
	}
}
