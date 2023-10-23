using F1_Manager.Car.EngineModules;
using F1_Manager.Commands;
using F1_Manager.Managers;
using F1_Manager.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace F1_Manager.Viewmodels.CreateCarViewModels
{
	public class CreateEngineViewModel : ViewModelBase
	{
		public string PowerMessage { get; set; }
		public string FuelMessage { get; set; }
		public string EnergyMessage { get; set; }
		public string WeightMessage { get; set; }
		public ICommand NavigateBackCommand { get; }
		public CreateEngineViewModel(NavigationStore navigationStore)
		{
			
			NavigateBackCommand = new NavigateCommand<CreateCarViewModel>(navigationStore, () => new CreateCarViewModel(navigationStore));
		}
	}
}
