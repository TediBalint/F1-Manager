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
		public string ErsMessage { get; set; }
		public string WeightMessage { get; set; }
		public ICommand NavigateBackCommand { get; }
		public CreateEngineViewModel(ISharedService sharedService)
		{
			// may need onpropertyChanged for these
			double power = sharedService.createCarManager.thisEngine.GetPower();
			double maxPower = sharedService.createCarManager.thisEngine.GetMaxPower();

			double ersRecharge = sharedService.createCarManager.thisEngine.GetErsRecharge();
			double maxErsRecharge = sharedService.createCarManager.thisEngine.GetMaxErsRecharge();

			double fuelCons = sharedService.createCarManager.thisEngine.GetConsumption();
			double minFuelCons = sharedService.createCarManager.thisEngine.GetMinConsumption();

			double weight = sharedService.createCarManager.thisEngine.GetWeight();
			double minWeight = sharedService.createCarManager.thisEngine.GetMinWeight();

			PowerMessage = $"{power}/{maxPower}";
			FuelMessage = $"{fuelCons}/{minFuelCons}";
			ErsMessage = $"{ersRecharge}/{maxErsRecharge}";
			WeightMessage = $"{weight}/{minWeight}";

			
			NavigateBackCommand = new NavigateCommand<CreateCarViewModel>(sharedService, () => new CreateCarViewModel(sharedService));
		}
	}
}
