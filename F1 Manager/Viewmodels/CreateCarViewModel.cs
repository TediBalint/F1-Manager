using F1_Manager.Commands;
using F1_Manager.Stores;
using F1_Manager.Views.CreateCarViews;
using F1_Manager.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using F1_Manager.Viewmodels.CreateCarViewModels;

namespace F1_Manager.Viewmodels
{
	public class CreateCarViewModel : ViewModelBase
	{
		public string WelcomeMessage => "Car";
		public ICommand NavigateHomeCommand { get; }
		public ICommand NavigateEngineCommand { get; }

		public CreateCarViewModel(NavigationStore navigationStore)
		{
			NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
			NavigateEngineCommand = new NavigateCommand<CreateEngineViewModel>(navigationStore, () => new CreateEngineViewModel(navigationStore));
		}
	}
}
